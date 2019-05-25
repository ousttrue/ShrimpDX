/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=4)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE{
    /// (UINT)
    public UInt32 Usage;

    /// (UINT)
    public UInt32 RGB_Range;

    /// (UINT)
    public UInt32 YCbCr_Matrix;

    /// (UINT)
    public UInt32 YCbCr_xvYCC;

    /// (UINT)
    public UInt32 Nominal_Range;

    /// (UINT)
    public UInt32 Reserved;

}
}
