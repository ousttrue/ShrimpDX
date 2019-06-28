using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ComPtrCS.Utilities
{

    public class D3D11Shader : IDisposable
    {
        ID3D10Blob m_vs_blob = new ID3D10Blob();
        ID3D11VertexShader m_vs = new ID3D11VertexShader();

        D3D11_INPUT_ELEMENT_DESC[] m_layout;
        public D3D11_INPUT_ELEMENT_DESC[] Layout => m_layout;

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

        static void Compile(string source, string name, string entryPoint, string target, uint flag1, uint flag2, ID3D10Blob dst)
        {
            var source_utf8 = Encoding.UTF8.GetBytes(source);
            var name_utf8 = Encoding.UTF8.GetBytes(name + "\0\0");
            var entryPoint_utf8 = Encoding.UTF8.GetBytes(entryPoint + "\0\0");
            var target_utf8 = Encoding.UTF8.GetBytes(target + "\0\0");

            Span<D3D_SHADER_MACRO> def = stackalloc D3D_SHADER_MACRO[]
            {
                new D3D_SHADER_MACRO
                {
                }
            };

            using (var error = new ID3D10Blob())
            using (var source_pin = PinPtr.Create(source_utf8))
            using (var name_pin = PinPtr.Create(name_utf8))
            using (var entryPoint_pin = PinPtr.Create(entryPoint_utf8))
            using (var target_pin = PinPtr.Create(target_utf8))
            {
                if (D3DCOMPILER.D3DCompile(
                    source_pin.Ptr, new UIntPtr((uint)source_utf8.Length),
                    name_pin.Ptr, ref MemoryMarshal.GetReference(def), new IntPtr(1),
                    entryPoint_pin.Ptr, target_pin.Ptr,
                    flag1, flag2,
                    ref dst.PtrForNew, ref error.PtrForNew
                ).Failed)
                {
                    var buffer = new Byte[error.GetBufferSize().ToUInt64()];
                    Marshal.Copy(error.GetBufferPointer(), buffer, 0, buffer.Length);
                    //var encoding = Encoding.GetEncoding(932);
                    var encoding = Encoding.UTF8;
                    var msg = encoding.GetString(buffer);
                    throw new Exception(msg);
                }
            }
        }

        public const string SampleShader = @"
struct VS_INPUT
{
    float4 Position   : POSITION;
    float4 Color      : COLOR;
};

struct VS_OUTPUT
{
    float4 Position   : SV_POSITION;
    float4 Color      : COLOR;
};

VS_OUTPUT vsMain( VS_INPUT In )
{
    VS_OUTPUT Output;
    Output.Position = In.Position;
    Output.Color    = In.Color;
    return Output;    
}

float4 psMain( VS_OUTPUT In ) : SV_TARGET
{
    return In.Color;
}
";

        static Byte[] position = Encoding.UTF8.GetBytes("POSITION");
        static Byte[] color = Encoding.UTF8.GetBytes("COLOR");

        static PinPtr<byte> position_pin;
        static PinPtr<byte> color_pin;

        public static D3D11Shader CreateSampleShader()
        {
            var shader = new D3D11Shader();
            position_pin = PinPtr.Create(position);
            color_pin = PinPtr.Create(color);
            {
                shader.m_layout = new D3D11_INPUT_ELEMENT_DESC[]
                {
                    new D3D11_INPUT_ELEMENT_DESC
                    {
                        SemanticName = position_pin.Ptr,
                        SemanticIndex = 0,
                        Format = DXGI_FORMAT.R32G32B32A32_FLOAT,
                        InputSlot = 0,
                        AlignedByteOffset = 0,
                        InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA,
                        InstanceDataStepRate = 0,
                    },
                    new D3D11_INPUT_ELEMENT_DESC
                    {
                        SemanticName = color_pin.Ptr,
                        SemanticIndex = 0,
                        Format = DXGI_FORMAT.R32G32B32A32_FLOAT,
                        InputSlot = 0,
                        AlignedByteOffset = unchecked((uint)D3D11.D3D11_APPEND_ALIGNED_ELEMENT),
                        InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA,
                        InstanceDataStepRate = 0,
                    }
                };
            }

            // compile. not depends on ID3D11Device
            Compile(SampleShader, "sample_vs", "vsMain", "vs_4_0", 0, 0, shader.m_vs_blob);
            Compile(SampleShader, "sample_ps", "psMain", "ps_4_0", 0, 0, shader.m_ps_blob);

            return shader;
        }

        public void Setup(ID3D11Device device, ID3D11DeviceContext context)
        {
            if (!m_inputLayout)
            {
                device.CreateVertexShader(m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), IntPtr.Zero, ref m_vs.PtrForNew);
                device.CreatePixelShader(m_ps_blob.GetBufferPointer(), m_ps_blob.GetBufferSize(), IntPtr.Zero, ref m_ps.PtrForNew);
                device.CreateInputLayout(ref MemoryMarshal.GetReference(Layout.AsSpan()), (uint)Layout.Length,
                    m_vs_blob.GetBufferPointer(), m_vs_blob.GetBufferSize(), ref m_inputLayout.PtrForNew).ThrowIfFailed();
            }

            // setup shader pipeline
            Span<IntPtr> classes = stackalloc IntPtr[] { };
            context.VSSetShader(m_vs.Ptr, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.PSSetShader(m_ps.Ptr, ref MemoryMarshal.GetReference(classes), (uint)classes.Length);
            context.IASetInputLayout(m_inputLayout.Ptr);
        }
    }
}