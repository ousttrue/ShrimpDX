// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Object: IUnknown
    {
        static Guid s_uuid = new Guid("c4fec28f-7966-4e95-9f94-f431cb56c3b8");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetPrivateData(
            ref Guid guid,
            out uint pDataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetPrivateDataFunc==null) m_GetPrivateDataFunc = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
            
            return m_GetPrivateDataFunc(m_ptr, ref guid, out pDataSize, pData);
        }
        delegate int GetPrivateDataFunc(IntPtr self, ref Guid guid, out uint pDataSize, IntPtr pData);
        GetPrivateDataFunc m_GetPrivateDataFunc;

        public virtual int SetPrivateData(
            ref Guid guid,
            uint DataSize,
            IntPtr pData
        ){
            var fp = GetFunctionPointer(4);
            if(m_SetPrivateDataFunc==null) m_SetPrivateDataFunc = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
            
            return m_SetPrivateDataFunc(m_ptr, ref guid, DataSize, pData);
        }
        delegate int SetPrivateDataFunc(IntPtr self, ref Guid guid, uint DataSize, IntPtr pData);
        SetPrivateDataFunc m_SetPrivateDataFunc;

        public virtual int SetPrivateDataInterface(
            ref Guid guid,
            IUnknown pData
        ){
            var fp = GetFunctionPointer(5);
            if(m_SetPrivateDataInterfaceFunc==null) m_SetPrivateDataInterfaceFunc = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
            
            return m_SetPrivateDataInterfaceFunc(m_ptr, ref guid, pData!=null ? pData.Ptr : IntPtr.Zero);
        }
        delegate int SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
        SetPrivateDataInterfaceFunc m_SetPrivateDataInterfaceFunc;

        public virtual int SetName(
            ref ushort Name
        ){
            var fp = GetFunctionPointer(6);
            if(m_SetNameFunc==null) m_SetNameFunc = (SetNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetNameFunc));
            
            return m_SetNameFunc(m_ptr, ref Name);
        }
        delegate int SetNameFunc(IntPtr self, ref ushort Name);
        SetNameFunc m_SetNameFunc;

    }
}
