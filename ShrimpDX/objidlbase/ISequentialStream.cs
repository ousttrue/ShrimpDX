// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ISequentialStream: IUnknown
    {
        static Guid s_uuid = new Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Read(
            IntPtr pv,
            uint cb,
            out uint pcbRead
        ){
            var fp = GetFunctionPointer(3);
            if(m_ReadFunc==null) m_ReadFunc = (ReadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFunc));
            
            return m_ReadFunc(m_ptr, pv, cb, out pcbRead);
        }
        delegate int ReadFunc(IntPtr self, IntPtr pv, uint cb, out uint pcbRead);
        ReadFunc m_ReadFunc;

        public virtual int Write(
            IntPtr pv,
            uint cb,
            out uint pcbWritten
        ){
            var fp = GetFunctionPointer(4);
            if(m_WriteFunc==null) m_WriteFunc = (WriteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteFunc));
            
            return m_WriteFunc(m_ptr, pv, cb, out pcbWritten);
        }
        delegate int WriteFunc(IntPtr self, IntPtr pv, uint cb, out uint pcbWritten);
        WriteFunc m_WriteFunc;

    }
}
