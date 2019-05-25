/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS{
    /// (UINT)
    public UInt32 Caps;

    /// (UINT)
    public UInt32 KeyExchangeTypeCount;

    /// (UINT)
    public UInt32 BlockAlignmentSize;

    /// (ULONGLONG)
    public UInt64 ProtectedMemorySize;

}
}
