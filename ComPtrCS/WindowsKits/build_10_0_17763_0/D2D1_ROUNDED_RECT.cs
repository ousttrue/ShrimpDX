/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_ROUNDED_RECT{
    /// (D2D1_RECT_F)
    public D2D_RECT_F rect;

    /// (FLOAT)
    public Single radiusX;

    /// (FLOAT)
    public Single radiusY;

}
}
