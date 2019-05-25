/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDXGIResource: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIResource>.Value;
    public HRESULT GetSharedHandle(
        /// pSharedHandle: (*(HANDLE))
        ref IntPtr pSharedHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSharedHandleFunc));
        return callback(Self, ref pSharedHandle);
    }
    delegate HRESULT GetSharedHandleFunc(IntPtr self, ref IntPtr pSharedHandle);
    public HRESULT GetUsage(
        /// pUsage: (*(DXGI_USAGE))
        ref DXGI_USAGE pUsage
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetUsageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUsageFunc));
        return callback(Self, ref pUsage);
    }
    delegate HRESULT GetUsageFunc(IntPtr self, ref DXGI_USAGE pUsage);
    public HRESULT SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
        return callback(Self, EvictionPriority);
    }
    delegate HRESULT SetEvictionPriorityFunc(IntPtr self, UInt32 EvictionPriority);
    public HRESULT GetEvictionPriority(
        /// pEvictionPriority: (*(UINT))
        ref UInt32 pEvictionPriority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
        return callback(Self, ref pEvictionPriority);
    }
    delegate HRESULT GetEvictionPriorityFunc(IntPtr self, ref UInt32 pEvictionPriority);
}
}
