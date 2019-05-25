/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=312)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC1{
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

}
}
