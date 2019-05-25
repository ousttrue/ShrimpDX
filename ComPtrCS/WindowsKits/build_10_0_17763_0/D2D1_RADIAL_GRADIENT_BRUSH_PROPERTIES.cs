/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F center;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F gradientOriginOffset;

    /// (FLOAT)
    public Single radiusX;

    /// (FLOAT)
    public Single radiusY;

}
}
