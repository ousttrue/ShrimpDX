// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Resource1: ID3D12Resource
    {
        static Guid s_uuid = new Guid("9d5e227a-4430-4161-88b3-3eca6bb16e19");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetProtectedResourceSession(
            ref Guid riid,
            out IntPtr ppProtectedSession
        ){
            var fp = GetFunctionPointer(15);
            if(m_GetProtectedResourceSessionFunc==null) m_GetProtectedResourceSessionFunc = (GetProtectedResourceSessionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetProtectedResourceSessionFunc));
            
            return m_GetProtectedResourceSessionFunc(m_ptr, ref riid, out ppProtectedSession);
        }
        delegate int GetProtectedResourceSessionFunc(IntPtr self, ref Guid riid, out IntPtr ppProtectedSession);
        GetProtectedResourceSessionFunc m_GetProtectedResourceSessionFunc;

    }
}
