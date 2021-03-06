// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IDXGIDevice: IDXGIObject
    {
        static Guid s_uuid = new Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int GetAdapter(
            out IDXGIAdapter pAdapter
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetAdapterFunc==null) m_GetAdapterFunc = (GetAdapterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAdapterFunc));
            pAdapter = new IDXGIAdapter();
            return m_GetAdapterFunc(m_ptr, out pAdapter.PtrForNew);
        }
        delegate int GetAdapterFunc(IntPtr self, out IntPtr pAdapter);
        GetAdapterFunc m_GetAdapterFunc;

        public virtual int CreateSurface(
            ref DXGI_SURFACE_DESC pDesc,
            uint NumSurfaces,
            uint Usage,
            ref DXGI_SHARED_RESOURCE pSharedResource,
            out IDXGISurface ppSurface
        ){
            var fp = GetFunctionPointer(8);
            if(m_CreateSurfaceFunc==null) m_CreateSurfaceFunc = (CreateSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSurfaceFunc));
            ppSurface = new IDXGISurface();
            return m_CreateSurfaceFunc(m_ptr, ref pDesc, NumSurfaces, Usage, ref pSharedResource, out ppSurface.PtrForNew);
        }
        delegate int CreateSurfaceFunc(IntPtr self, ref DXGI_SURFACE_DESC pDesc, uint NumSurfaces, uint Usage, ref DXGI_SHARED_RESOURCE pSharedResource, out IntPtr ppSurface);
        CreateSurfaceFunc m_CreateSurfaceFunc;

        public virtual int QueryResourceResidency(
            ref IntPtr ppResources,
            out DXGI_RESIDENCY pResidencyStatus,
            uint NumResources
        ){
            var fp = GetFunctionPointer(9);
            if(m_QueryResourceResidencyFunc==null) m_QueryResourceResidencyFunc = (QueryResourceResidencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryResourceResidencyFunc));
            
            return m_QueryResourceResidencyFunc(m_ptr, ref ppResources, out pResidencyStatus, NumResources);
        }
        delegate int QueryResourceResidencyFunc(IntPtr self, ref IntPtr ppResources, out DXGI_RESIDENCY pResidencyStatus, uint NumResources);
        QueryResourceResidencyFunc m_QueryResourceResidencyFunc;

        public virtual int SetGPUThreadPriority(
            int Priority
        ){
            var fp = GetFunctionPointer(10);
            if(m_SetGPUThreadPriorityFunc==null) m_SetGPUThreadPriorityFunc = (SetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGPUThreadPriorityFunc));
            
            return m_SetGPUThreadPriorityFunc(m_ptr, Priority);
        }
        delegate int SetGPUThreadPriorityFunc(IntPtr self, int Priority);
        SetGPUThreadPriorityFunc m_SetGPUThreadPriorityFunc;

        public virtual int GetGPUThreadPriority(
            out int pPriority
        ){
            var fp = GetFunctionPointer(11);
            if(m_GetGPUThreadPriorityFunc==null) m_GetGPUThreadPriorityFunc = (GetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGPUThreadPriorityFunc));
            
            return m_GetGPUThreadPriorityFunc(m_ptr, out pPriority);
        }
        delegate int GetGPUThreadPriorityFunc(IntPtr self, out int pPriority);
        GetGPUThreadPriorityFunc m_GetGPUThreadPriorityFunc;

    }
}
