/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_STREAM{
    /// (BOOL)
    public Int32 Enable;

    /// (UINT)
    public UInt32 OutputIndex;

    /// (UINT)
    public UInt32 InputFrameOrField;

    /// (UINT)
    public UInt32 PastFrames;

    /// (UINT)
    public UInt32 FutureFrames;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppPastSurfaces;

    /// (*(ID3D11VideoProcessorInputView))
    public IntPtr pInputSurface;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfaces;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppPastSurfacesRight;

    /// (*(ID3D11VideoProcessorInputView))
    public IntPtr pInputSurfaceRight;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfacesRight;

}
}
