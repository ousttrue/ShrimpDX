/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_PRINT_CONTROL_PROPERTIES{
    /// (D2D1_PRINT_FONT_SUBSET_MODE)
    public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;

    /// (FLOAT)
    public Single rasterDPI;

    /// (D2D1_COLOR_SPACE)
    public D2D1_COLOR_SPACE colorSpace;

}
}
