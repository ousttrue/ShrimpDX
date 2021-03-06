// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICPixelFormatInfo2: IWICPixelFormatInfo
    {
        static Guid s_uuid = new Guid("a9db33a2-af5f-43c7-b679-74f5984b5aa4");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int SupportsTransparency(
            out int pfSupportsTransparency
        ){
            var fp = GetFunctionPointer(16);
            if(m_SupportsTransparencyFunc==null) m_SupportsTransparencyFunc = (SupportsTransparencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SupportsTransparencyFunc));
            
            return m_SupportsTransparencyFunc(m_ptr, out pfSupportsTransparency);
        }
        delegate int SupportsTransparencyFunc(IntPtr self, out int pfSupportsTransparency);
        SupportsTransparencyFunc m_SupportsTransparencyFunc;

        public virtual int GetNumericRepresentation(
            out WICPixelFormatNumericRepresentation pNumericRepresentation
        ){
            var fp = GetFunctionPointer(17);
            if(m_GetNumericRepresentationFunc==null) m_GetNumericRepresentationFunc = (GetNumericRepresentationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNumericRepresentationFunc));
            
            return m_GetNumericRepresentationFunc(m_ptr, out pNumericRepresentation);
        }
        delegate int GetNumericRepresentationFunc(IntPtr self, out WICPixelFormatNumericRepresentation pNumericRepresentation);
        GetNumericRepresentationFunc m_GetNumericRepresentationFunc;

    }
}
