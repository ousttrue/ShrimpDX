/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=40)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CONTENT_DESC{
    /// (D3D11_VIDEO_FRAME_FORMAT)
    public D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL InputFrameRate;

    /// (UINT)
    public UInt32 InputWidth;

    /// (UINT)
    public UInt32 InputHeight;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL OutputFrameRate;

    /// (UINT)
    public UInt32 OutputWidth;

    /// (UINT)
    public UInt32 OutputHeight;

    /// (D3D11_VIDEO_USAGE)
    public D3D11_VIDEO_USAGE Usage;

}
}
