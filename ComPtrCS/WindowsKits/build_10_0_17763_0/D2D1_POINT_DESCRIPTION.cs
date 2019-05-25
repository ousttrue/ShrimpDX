/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_POINT_DESCRIPTION{
    /// (D2D1_POINT_2F)
    public D2D_POINT_2F point;

    /// (D2D1_POINT_2F)
    public D2D_POINT_2F unitTangentVector;

    /// (UINT32)
    public UInt32 endSegment;

    /// (UINT32)
    public UInt32 endFigure;

    /// (FLOAT)
    public Single lengthToEndSegment;

}
}
