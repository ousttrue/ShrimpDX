// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIFactory3: IDXGIFactory2
    {
        static Guid s_uuid = new Guid("25483823-cd46-4c7d-86ca-47aa95b837bd");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetCreationFlags(
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetCreationFlagsFunc==null) m_GetCreationFlagsFunc = (GetCreationFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationFlagsFunc));
            
            return m_GetCreationFlagsFunc(m_ptr);
        }
        delegate uint GetCreationFlagsFunc(IntPtr self);
        GetCreationFlagsFunc m_GetCreationFlagsFunc;

    }
}
