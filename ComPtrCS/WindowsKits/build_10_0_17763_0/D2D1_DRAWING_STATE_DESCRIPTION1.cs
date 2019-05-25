/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=56)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_DRAWING_STATE_DESCRIPTION1{
    /// (D2D1_ANTIALIAS_MODE)
    public D2D1_ANTIALIAS_MODE antialiasMode;

    /// (D2D1_TEXT_ANTIALIAS_MODE)
    public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;

    /// (D2D1_TAG)
    public D2D1_TAG tag1;

    /// (D2D1_TAG)
    public D2D1_TAG tag2;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F transform;

    /// (D2D1_PRIMITIVE_BLEND)
    public D2D1_PRIMITIVE_BLEND primitiveBlend;

    /// (D2D1_UNIT_MODE)
    public D2D1_UNIT_MODE unitMode;

}
}
