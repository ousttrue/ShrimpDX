/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS{
    /// (UINT)
    public UInt32 PastFrames;

    /// (UINT)
    public UInt32 FutureFrames;

    /// (UINT)
    public UInt32 ProcessorCaps;

    /// (UINT)
    public UInt32 ITelecineCaps;

    /// (UINT)
    public UInt32 CustomRateCount;

}
}
