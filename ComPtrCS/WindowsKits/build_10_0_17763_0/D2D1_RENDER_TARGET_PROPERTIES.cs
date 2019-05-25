/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_RENDER_TARGET_PROPERTIES{
    /// (D2D1_RENDER_TARGET_TYPE)
    public D2D1_RENDER_TARGET_TYPE type;

    /// (D2D1_PIXEL_FORMAT)
    public D2D1_PIXEL_FORMAT pixelFormat;

    /// (FLOAT)
    public Single dpiX;

    /// (FLOAT)
    public Single dpiY;

    /// (D2D1_RENDER_TARGET_USAGE)
    public D2D1_RENDER_TARGET_USAGE usage;

    /// (D2D1_FEATURE_LEVEL)
    public D2D1_FEATURE_LEVEL minLevel;

}
}
