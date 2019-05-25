/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_GRADIENT_STOP{
    /// (FLOAT)
    public Single position;

    /// (D2D1_COLOR_F)
    public Vector4 color;

}
}
