// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12ProtectedResourceSession: ID3D12ProtectedSession
    {
        static Guid s_uuid = new Guid("6cd696f4-f289-40cc-8091-5a6c0a099c3d");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc(
        ){
            var fp = GetFunctionPointer(10);
            if(m_GetDescFunc==null) m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            
            return m_GetDescFunc(m_ptr);
        }
        delegate D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDescFunc(IntPtr self);
        GetDescFunc m_GetDescFunc;

    }
}
