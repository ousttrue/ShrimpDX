/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDXGIDevice2: IDXGIDevice1 {

    static /*readonly*/ Guid s_uuid = new Guid("05008617-fbfd-4051-a790-144884b4f6a9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIDevice2>.Value;
    public HRESULT OfferResources(
        /// NumResources: (UINT)
        UInt32 NumResources
        /// ppResources: (*(const *(IDXGIResource)))
        , ref IntPtr ppResources
        /// Priority: (DXGI_OFFER_RESOURCE_PRIORITY)
        , DXGI_OFFER_RESOURCE_PRIORITY Priority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OfferResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OfferResourcesFunc));
        return callback(Self, NumResources, ref ppResources, Priority);
    }
    delegate HRESULT OfferResourcesFunc(IntPtr self, UInt32 NumResources, ref IntPtr ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);
    public HRESULT ReclaimResources(
        /// NumResources: (UINT)
        UInt32 NumResources
        /// ppResources: (*(const *(IDXGIResource)))
        , ref IntPtr ppResources
        /// pDiscarded: (*(BOOL))
        , IntPtr pDiscarded
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReclaimResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReclaimResourcesFunc));
        return callback(Self, NumResources, ref ppResources, pDiscarded);
    }
    delegate HRESULT ReclaimResourcesFunc(IntPtr self, UInt32 NumResources, ref IntPtr ppResources, IntPtr pDiscarded);
    public HRESULT EnqueueSetEvent(
        /// hEvent: (HANDLE)
        IntPtr hEvent
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (EnqueueSetEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnqueueSetEventFunc));
        return callback(Self, hEvent);
    }
    delegate HRESULT EnqueueSetEventFunc(IntPtr self, IntPtr hEvent);
}
}
