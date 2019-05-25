using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace D3D11TriangleSample
{
    public class D3D11ShaderCompiled
    {
        ID3D10Blob m_blob = new ID3D10Blob();

        public static D3D11ShaderCompiled Compile(string source, string name, string entryPoint, string target, uint flag1, uint flag2)
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

            var compiled = new D3D11ShaderCompiled();

            using (var error = new ID3D10Blob())
            using (var source_pin = new PinPtr(source_utf8))
            using (var name_pin = new PinPtr(name_utf8))
            using (var entryPoint_pin = new PinPtr(entryPoint_utf8))
            using (var target_pin = new PinPtr(target_utf8))
            {
                if (D3DCOMPILER.D3DCompile(
                    source_pin.Ptr, new UIntPtr((uint)source_utf8.Length),
                    name_pin.Ptr, ref MemoryMarshal.GetReference(def), new IntPtr(1),
                    entryPoint_pin.Ptr, target_pin.Ptr,
                    flag1, flag2,
                    ref compiled.m_blob.PtrForNew, ref error.PtrForNew
                ).Succeeded)
                {
                    return compiled;
                }
                else
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
    }

    public class D3D11Shader
    {
        D3D11ShaderCompiled m_vs;
        D3D11ShaderCompiled m_ps;

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

        public static D3D11Shader CreateSampleShader()
        {
            var vs = D3D11ShaderCompiled.Compile(SampleShader, "sample_vs", "vsMain", "vs_4_0", 0, 0);
            var ps = D3D11ShaderCompiled.Compile(SampleShader, "sample_ps", "psMain", "ps_4_0", 0, 0);

            return new D3D11Shader
            {
                m_vs = vs,
                m_ps = ps,
            };
        }
    }
}