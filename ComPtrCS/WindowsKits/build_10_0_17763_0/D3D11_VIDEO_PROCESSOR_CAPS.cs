/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=36)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CAPS{
    /// (UINT)
    public UInt32 DeviceCaps;

    /// (UINT)
    public UInt32 FeatureCaps;

    /// (UINT)
    public UInt32 FilterCaps;

    /// (UINT)
    public UInt32 InputFormatCaps;

    /// (UINT)
    public UInt32 AutoStreamCaps;

    /// (UINT)
    public UInt32 StereoCaps;

    /// (UINT)
    public UInt32 RateConversionCapsCount;

    /// (UINT)
    public UInt32 MaxInputStreams;

    /// (UINT)
    public UInt32 MaxStreamStates;

}
}
