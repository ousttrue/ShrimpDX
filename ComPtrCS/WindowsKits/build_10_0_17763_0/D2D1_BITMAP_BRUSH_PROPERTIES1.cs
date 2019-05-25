/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_BRUSH_PROPERTIES1{
    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeX;

    /// (D2D1_EXTEND_MODE)
    public D2D1_EXTEND_MODE extendModeY;

    /// (D2D1_INTERPOLATION_MODE)
    public D2D1_INTERPOLATION_MODE interpolationMode;

}
}
