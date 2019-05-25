/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class IDXGIDevice: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIDevice>.Value;
    public HRESULT GetAdapter(
        /// pAdapter: (*(*(IDXGIAdapter)))
        ref IntPtr pAdapter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetAdapterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAdapterFunc));
        return callback(Self, ref pAdapter);
    }
    delegate HRESULT GetAdapterFunc(IntPtr self, ref IntPtr pAdapter);
    public HRESULT CreateSurface(
        /// pDesc: (*(const DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc
        /// NumSurfaces: (UINT)
        , UInt32 NumSurfaces
        /// Usage: (DXGI_USAGE)
        , DXGI_USAGE Usage
        /// pSharedResource: (*(const DXGI_SHARED_RESOURCE))
        , ref DXGI_SHARED_RESOURCE pSharedResource
        /// ppSurface: (*(*(IDXGISurface)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSurfaceFunc));
        return callback(Self, ref pDesc, NumSurfaces, Usage, ref pSharedResource, ref ppSurface);
    }
    delegate HRESULT CreateSurfaceFunc(IntPtr self, ref DXGI_SURFACE_DESC pDesc, UInt32 NumSurfaces, DXGI_USAGE Usage, ref DXGI_SHARED_RESOURCE pSharedResource, ref IntPtr ppSurface);
    public HRESULT QueryResourceResidency(
        /// ppResources: (*(const *(IUnknown)))
        ref IntPtr ppResources
        /// pResidencyStatus: (*(DXGI_RESIDENCY))
        , ref DXGI_RESIDENCY pResidencyStatus
        /// NumResources: (UINT)
        , UInt32 NumResources
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (QueryResourceResidencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryResourceResidencyFunc));
        return callback(Self, ref ppResources, ref pResidencyStatus, NumResources);
    }
    delegate HRESULT QueryResourceResidencyFunc(IntPtr self, ref IntPtr ppResources, ref DXGI_RESIDENCY pResidencyStatus, UInt32 NumResources);
    public HRESULT SetGPUThreadPriority(
        /// Priority: (INT)
        Int32 Priority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGPUThreadPriorityFunc));
        return callback(Self, Priority);
    }
    delegate HRESULT SetGPUThreadPriorityFunc(IntPtr self, Int32 Priority);
    public HRESULT GetGPUThreadPriority(
        /// pPriority: (*(INT))
        IntPtr pPriority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGPUThreadPriorityFunc));
        return callback(Self, pPriority);
    }
    delegate HRESULT GetGPUThreadPriorityFunc(IntPtr self, IntPtr pPriority);
}
}
