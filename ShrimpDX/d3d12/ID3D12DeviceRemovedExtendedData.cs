// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12DeviceRemovedExtendedData: IUnknown
    {
        static Guid s_uuid = new Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetAutoBreadcrumbsOutput(
            out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput
        ){
            var fp = GetFunctionPointer(3);
            if(m_GetAutoBreadcrumbsOutputFunc==null) m_GetAutoBreadcrumbsOutputFunc = (GetAutoBreadcrumbsOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAutoBreadcrumbsOutputFunc));
            
            return m_GetAutoBreadcrumbsOutputFunc(m_ptr, out pOutput);
        }
        delegate int GetAutoBreadcrumbsOutputFunc(IntPtr self, out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
        GetAutoBreadcrumbsOutputFunc m_GetAutoBreadcrumbsOutputFunc;

        public virtual int GetPageFaultAllocationOutput(
            out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput
        ){
            var fp = GetFunctionPointer(4);
            if(m_GetPageFaultAllocationOutputFunc==null) m_GetPageFaultAllocationOutputFunc = (GetPageFaultAllocationOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPageFaultAllocationOutputFunc));
            
            return m_GetPageFaultAllocationOutputFunc(m_ptr, out pOutput);
        }
        delegate int GetPageFaultAllocationOutputFunc(IntPtr self, out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
        GetPageFaultAllocationOutputFunc m_GetPageFaultAllocationOutputFunc;

    }
}
