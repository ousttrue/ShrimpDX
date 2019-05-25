/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RENDERING_CONTROLS{
    /// (D2D1_BUFFER_PRECISION)
    public D2D1_BUFFER_PRECISION bufferPrecision;

    /// (D2D1_SIZE_U)
    public D2D_SIZE_U tileSize;

}
}
