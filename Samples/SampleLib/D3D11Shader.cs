using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ShrimpDX;

namespace SampleLib
{
    public enum Semantics
    {
        POSITION,
        COLOR,
    }

    public static class SemanticsExtensions
    {
        static Byte[] position = Encoding.UTF8.GetBytes("POSITION");
        static Byte[] color = Encoding.UTF8.GetBytes("COLOR");

        static PinPtr<byte> position_pin;
        static PinPtr<byte> color_pin;

        static SemanticsExtensions()
        {
            position_pin = PinPtr.Create(position);
            color_pin = PinPtr.Create(color);
        }

        public static IntPtr Pin(this Semantics semantic)
        {
            switch (semantic)
            {
                case Semantics.POSITION: return position_pin.Ptr;
                case Semantics.COLOR: return color_pin.Ptr;
            }

            throw new NotImplementedException();
        }
    }

    public struct VertexAttribute
    {
        public readonly Semantics Semantic;
        public readonly uint SemanticIndex;

        public readonly DXGI_FORMAT Format;

        public VertexAttribute(Semantics semantic, uint semanticIndex, DXGI_FORMAT format)
        {
            Semantic = semantic;
            SemanticIndex = semanticIndex;
            Format = format;
        }
    }


    public class D3D11Shader : IDisposable
    {
        ID3D10Blob m_vs_blob = new ID3D10Blob();
        ID3D11VertexShader m_vs = new ID3D11VertexShader();

        D3D11_INPUT_ELEMENT_DESC[] m_layout;
        public D3D11_INPUT_ELEMENT_DESC[] Layout => m_layout;

        VertexAttribute[] m_vertexAttributes;
        public VertexAttribute[] VertexAttributes => m_vertexAttributes;

        ID3D10Blob m_ps_blob = new ID3D10Blob();

        ID3D11PixelShader m_ps = new ID3D11PixelShader();

        ID3D11InputLayout m_inputLayout = new ID3D11InputLayout();

        public void Dispose()
        {
            m_inputLayout.Dispose();
            m_ps.Dispose();
            m_vs.Dispose();
            m_ps_blob.Dispose();
            m_vs_blob.Dispose();
        }

        static void Compile(string source, string name, string entryPoint, string target, uint flag1, uint flag2, out ID3D10Blob dst)
        {
            var source_utf8 = Encoding.UTF8.GetBytes(source);
            // var name_utf8 = Encoding.UTF8.GetBytes(name + "\0\0");
            var entryPoint_utf8 = Encoding.UTF8.GetBytes(entryPoint + "\0\0");
            var target_utf8 = Encoding.UTF8.GetBytes(target + "\0\0");

            var def = new D3D10_SHADER_MACRO[]
            {
                new D3D10_SHADER_MACRO
                {
                }
            };

            // using (var error = new ID3D10Blob())
            using (var source_pin = PinPtr.Create(source_utf8))
            // using (var name_pin = PinPtr.Create(name_utf8))
            using (var entryPoint_pin = PinPtr.Create(entryPoint_utf8))
            using (var target_pin = PinPtr.Create(target_utf8))
            {
                var hr = d3dcompiler.D3DCompile(
                    source_pin.Ptr,
                    (ulong)source.Length,
                    name,
                    ref def[0],
                    new IntPtr(1),
                    entryPoint,
                    target,
                    flag1,
                    flag2,
                    out dst,
                    out ID3D10Blob error
                );
                if (hr.Failed())
                {
                    using (error)
                    {
                        var buffer = new Byte[error.GetBufferSize()];
                        Marshal.Copy(error.GetBufferPointer(), buffer, 0, buffer.Length);
                        //var encoding = Encoding.GetEncoding(932);
                        var encoding = Encoding.UTF8;
                        var msg = encoding.GetString(buffer);
                        throw new Exception(msg);
                    }
                }
            }
        }

        public const string SampleShader = @"
struct VS_INPUT
{
    float4 Position   : POSITION;
    // float4 Color      : COLOR0;
};

struct VS_OUTPUT
{
    float4 Position   : SV_POSITION;
    // float4 Color      : COLOR0;
};

VS_OUTPUT vsMain( VS_INPUT In )
{
    VS_OUTPUT Output;
    Output.Position = In.Position;
    // Output.Color    = In.Color;
    return Output;    
}

float4 psMain( VS_OUTPUT In ) : SV_TARGET
{
    // return In.Color;
    return float4(1, 1, 1, 1);
}
";

        public static D3D11Shader CreateShader(string vs, string ps)
        {
            var shader = new D3D11Shader();
            {
                // compile. not depends on ID3D11Device
                Compile(vs, "vs", "vsMain", "vs_4_0", 0, 0, out shader.m_vs_blob);
                Compile(ps, "ps", "psMain", "ps_4_0", 0, 0, out shader.m_ps_blob);

                shader.m_vertexAttributes = new VertexAttribute[]
                {
                    new VertexAttribute(Semantics.POSITION, 0, DXGI_FORMAT._R32G32B32A32_FLOAT),
                    // new VertexAttribute(Semantics.COLOR, 0, DXGI_FORMAT._R8G8B8A8_UNORM),
                };

                shader.m_layout = new D3D11_INPUT_ELEMENT_DESC[shader.m_vertexAttributes.Length];

                {
                    for (int i = 0; i < shader.m_vertexAttributes.Length; ++i)
                    {
                        var va = shader.m_vertexAttributes[i];
                        shader.m_layout[i] = new D3D11_INPUT_ELEMENT_DESC
                        {
                            SemanticName = va.Semantic.ToString(),
                            SemanticIndex = va.SemanticIndex,
                            Format = va.Format,
                            // InputSlot = (uint)i,
                            InputSlot = 0,
                            // AlignedByteOffset = (i == 0) ? 0 : unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT),
                            AlignedByteOffset = 0,
                            InputSlotClass = D3D11_INPUT_CLASSIFICATION._VERTEX_DATA,
                            InstanceDataStepRate = 0,
                        };
                    }
                }

                return shader;
            }
        }

        public static D3D11Shader CreateSampleShader()
        {
            return CreateShader(SampleShader, SampleShader);
        }

        public void Setup(ID3D11Device device, ID3D11DeviceContext context)
        {
            if (!m_vertexAttributes.Any())
            {
                return;
            }

            if (!m_inputLayout)
            {
                var hr = device.CreateVertexShader(m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), null, out m_vs);
                hr.ThrowIfFailed();
                hr = device.CreatePixelShader(m_ps_blob.GetBufferPointer(), m_ps_blob.GetBufferSize(), null, out m_ps);
                hr.ThrowIfFailed();

                hr = device.CreateInputLayout(ref m_layout[0], (uint)m_layout.Length,
                            m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), out m_inputLayout);
                hr.ThrowIfFailed();
            }

            // setup shader pipeline
            Span<IntPtr> classes = stackalloc IntPtr[] { };
            context.VSSetShader(m_vs, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.PSSetShader(m_ps, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.IASetInputLayout(m_inputLayout);
        }
    }
}
