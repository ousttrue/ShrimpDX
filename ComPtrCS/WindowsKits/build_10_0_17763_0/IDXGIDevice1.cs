/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class IDXGIDevice1: IDXGIDevice {

    static /*readonly*/ Guid s_uuid = new Guid("77db970f-6276-48ba-ba28-070143b4392c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIDevice1>.Value;
    public HRESULT SetMaximumFrameLatency(
        /// MaxLatency: (UINT)
        UInt32 MaxLatency
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumFrameLatencyFunc));
        return callback(Self, MaxLatency);
    }
    delegate HRESULT SetMaximumFrameLatencyFunc(IntPtr self, UInt32 MaxLatency);
    public HRESULT GetMaximumFrameLatency(
        /// pMaxLatency: (*(UINT))
        ref UInt32 pMaxLatency
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumFrameLatencyFunc));
        return callback(Self, ref pMaxLatency);
    }
    delegate HRESULT GetMaximumFrameLatencyFunc(IntPtr self, ref UInt32 pMaxLatency);
}
}
