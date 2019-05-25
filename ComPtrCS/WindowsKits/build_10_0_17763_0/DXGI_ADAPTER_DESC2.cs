/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=320)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC2{
    /// (WCHAR)[128]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]
    public string Description;

    /// (UINT)
    public UInt32 VendorId;

    /// (UINT)
    public UInt32 DeviceId;

    /// (UINT)
    public UInt32 SubSysId;

    /// (UINT)
    public UInt32 Revision;

    /// (SIZE_T)
    public UIntPtr DedicatedVideoMemory;

    /// (SIZE_T)
    public UIntPtr DedicatedSystemMemory;

    /// (SIZE_T)
    public UIntPtr SharedSystemMemory;

    /// (LUID)
    public Guid AdapterLuid;

    /// (UINT)
    public UInt32 Flags;

    /// (DXGI_GRAPHICS_PREEMPTION_GRANULARITY)
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

    /// (DXGI_COMPUTE_PREEMPTION_GRANULARITY)
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;

}
}
