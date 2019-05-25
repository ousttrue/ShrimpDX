/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_ARC_SEGMENT{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point;

    /// (D2D1_SIZE_F)
    public D2D_SIZE_F size;

    /// (FLOAT)
    public Single rotationAngle;

    /// (D2D1_SWEEP_DIRECTION)
    public D2D1_SWEEP_DIRECTION sweepDirection;

    /// (D2D1_ARC_SIZE)
    public D2D1_ARC_SIZE arcSize;

}
}
