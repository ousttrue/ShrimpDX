/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE{
    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL CustomRate;

    /// (UINT)
    public UInt32 OutputFrames;

    /// (BOOL)
    public Int32 InputInterlaced;

    /// (UINT)
    public UInt32 InputFramesOrFields;

}
}
