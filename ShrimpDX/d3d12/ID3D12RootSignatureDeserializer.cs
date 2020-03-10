// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12RootSignatureDeserializer: IUnknown
    {
        static Guid s_uuid = new Guid("34ab647b-3cc8-46ac-841b-c0965645c046");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual IntPtr GetRootSignatureDesc(
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetRootSignatureDescFunc==null) m_GetRootSignatureDescFunc = (GetRootSignatureDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRootSignatureDescFunc));
            
            return m_GetRootSignatureDescFunc(m_ptr);
        }
        delegate IntPtr GetRootSignatureDescFunc(IntPtr self);
        GetRootSignatureDescFunc m_GetRootSignatureDescFunc;

    }
}
