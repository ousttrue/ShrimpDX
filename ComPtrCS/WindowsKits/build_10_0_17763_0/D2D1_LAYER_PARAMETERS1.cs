/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_LAYER_PARAMETERS1{
    /// (D2D1_RECT_F)
    public D2D_RECT_F contentBounds;

    /// (*(ID2D1Geometry))
    public IntPtr geometricMask;

    /// (D2D1_ANTIALIAS_MODE)
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;

    /// (D2D1_MATRIX_3X2_F)
    public D2D_MATRIX_3X2_F maskTransform;

    /// (FLOAT)
    public Single opacity;

    /// (*(ID2D1Brush))
    public IntPtr opacityBrush;

    /// (D2D1_LAYER_OPTIONS1)
    public D2D1_LAYER_OPTIONS1 layerOptions;

}
}
