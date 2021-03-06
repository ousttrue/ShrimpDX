// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICEnumMetadataItem: IUnknown
    {
        static Guid s_uuid = new Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Next(
            uint celt,
            out tagPROPVARIANT rgeltSchema,
            out tagPROPVARIANT rgeltId,
            out tagPROPVARIANT rgeltValue,
            out uint pceltFetched
        ){
            var fp = GetFunctionPointer(3);
            if(m_NextFunc==null) m_NextFunc = (NextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NextFunc));
            
            return m_NextFunc(m_ptr, celt, out rgeltSchema, out rgeltId, out rgeltValue, out pceltFetched);
        }
        delegate int NextFunc(IntPtr self, uint celt, out tagPROPVARIANT rgeltSchema, out tagPROPVARIANT rgeltId, out tagPROPVARIANT rgeltValue, out uint pceltFetched);
        NextFunc m_NextFunc;

        public virtual int Skip(
            uint celt
        ){
            var fp = GetFunctionPointer(4);
            if(m_SkipFunc==null) m_SkipFunc = (SkipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SkipFunc));
            
            return m_SkipFunc(m_ptr, celt);
        }
        delegate int SkipFunc(IntPtr self, uint celt);
        SkipFunc m_SkipFunc;

        public virtual int Reset(
        ){
            var fp = GetFunctionPointer(5);
            if(m_ResetFunc==null) m_ResetFunc = (ResetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResetFunc));
            
            return m_ResetFunc(m_ptr);
        }
        delegate int ResetFunc(IntPtr self);
        ResetFunc m_ResetFunc;

        public virtual int Clone(
            out IWICEnumMetadataItem ppIEnumMetadataItem
        ){
            var fp = GetFunctionPointer(6);
            if(m_CloneFunc==null) m_CloneFunc = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            ppIEnumMetadataItem = new IWICEnumMetadataItem();
            return m_CloneFunc(m_ptr, out ppIEnumMetadataItem.PtrForNew);
        }
        delegate int CloneFunc(IntPtr self, out IntPtr ppIEnumMetadataItem);
        CloneFunc m_CloneFunc;

    }
}
