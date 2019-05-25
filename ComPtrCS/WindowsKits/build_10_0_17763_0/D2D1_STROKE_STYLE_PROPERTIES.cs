/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_STROKE_STYLE_PROPERTIES{
    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE startCap;

    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE endCap;

    /// (D2D1_CAP_STYLE)
    public D2D1_CAP_STYLE dashCap;

    /// (D2D1_LINE_JOIN)
    public D2D1_LINE_JOIN lineJoin;

    /// (FLOAT)
    public Single miterLimit;

    /// (D2D1_DASH_STYLE)
    public D2D1_DASH_STYLE dashStyle;

    /// (FLOAT)
    public Single dashOffset;

}
}
