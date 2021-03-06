// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D10EffectShaderVariable: ID3D10EffectVariable
    {
        static Guid s_uuid = new Guid("80849279-c799-4797-8c33-0407a07d9e06");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetShaderDesc(
            uint ShaderIndex,
            out _D3D10_EFFECT_SHADER_DESC pDesc
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetShaderDescFunc==null) m_GetShaderDescFunc = (GetShaderDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetShaderDescFunc));
            
            return m_GetShaderDescFunc(m_ptr, ShaderIndex, out pDesc);
        }
        delegate int GetShaderDescFunc(IntPtr self, uint ShaderIndex, out _D3D10_EFFECT_SHADER_DESC pDesc);
        GetShaderDescFunc m_GetShaderDescFunc;

        public virtual int GetVertexShader(
            uint ShaderIndex,
            out ID3D10VertexShader ppVS
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetVertexShaderFunc==null) m_GetVertexShaderFunc = (GetVertexShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVertexShaderFunc));
            ppVS = new ID3D10VertexShader();
            return m_GetVertexShaderFunc(m_ptr, ShaderIndex, out ppVS.PtrForNew);
        }
        delegate int GetVertexShaderFunc(IntPtr self, uint ShaderIndex, out IntPtr ppVS);
        GetVertexShaderFunc m_GetVertexShaderFunc;

        public virtual int GetGeometryShader(
            uint ShaderIndex,
            out ID3D10GeometryShader ppGS
        ){
            var fp = GetFunctionPointer(27);
            if(m_GetGeometryShaderFunc==null) m_GetGeometryShaderFunc = (GetGeometryShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGeometryShaderFunc));
            ppGS = new ID3D10GeometryShader();
            return m_GetGeometryShaderFunc(m_ptr, ShaderIndex, out ppGS.PtrForNew);
        }
        delegate int GetGeometryShaderFunc(IntPtr self, uint ShaderIndex, out IntPtr ppGS);
        GetGeometryShaderFunc m_GetGeometryShaderFunc;

        public virtual int GetPixelShader(
            uint ShaderIndex,
            out ID3D10PixelShader ppPS
        ){
            var fp = GetFunctionPointer(28);
            if(m_GetPixelShaderFunc==null) m_GetPixelShaderFunc = (GetPixelShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelShaderFunc));
            ppPS = new ID3D10PixelShader();
            return m_GetPixelShaderFunc(m_ptr, ShaderIndex, out ppPS.PtrForNew);
        }
        delegate int GetPixelShaderFunc(IntPtr self, uint ShaderIndex, out IntPtr ppPS);
        GetPixelShaderFunc m_GetPixelShaderFunc;

        public virtual int GetInputSignatureElementDesc(
            uint ShaderIndex,
            uint Element,
            out _D3D10_SIGNATURE_PARAMETER_DESC pDesc
        ){
            var fp = GetFunctionPointer(29);
            if(m_GetInputSignatureElementDescFunc==null) m_GetInputSignatureElementDescFunc = (GetInputSignatureElementDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInputSignatureElementDescFunc));
            
            return m_GetInputSignatureElementDescFunc(m_ptr, ShaderIndex, Element, out pDesc);
        }
        delegate int GetInputSignatureElementDescFunc(IntPtr self, uint ShaderIndex, uint Element, out _D3D10_SIGNATURE_PARAMETER_DESC pDesc);
        GetInputSignatureElementDescFunc m_GetInputSignatureElementDescFunc;

        public virtual int GetOutputSignatureElementDesc(
            uint ShaderIndex,
            uint Element,
            out _D3D10_SIGNATURE_PARAMETER_DESC pDesc
        ){
            var fp = GetFunctionPointer(30);
            if(m_GetOutputSignatureElementDescFunc==null) m_GetOutputSignatureElementDescFunc = (GetOutputSignatureElementDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOutputSignatureElementDescFunc));
            
            return m_GetOutputSignatureElementDescFunc(m_ptr, ShaderIndex, Element, out pDesc);
        }
        delegate int GetOutputSignatureElementDescFunc(IntPtr self, uint ShaderIndex, uint Element, out _D3D10_SIGNATURE_PARAMETER_DESC pDesc);
        GetOutputSignatureElementDescFunc m_GetOutputSignatureElementDescFunc;

    }
}
