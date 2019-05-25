/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BRUSH_PROPERTIES{
    /// (FLOAT)
    public Single opacity;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F transform;

}
}
