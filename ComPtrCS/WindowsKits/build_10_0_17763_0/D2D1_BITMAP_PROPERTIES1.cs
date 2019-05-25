/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_BITMAP_PROPERTIES1{
    /// (D2D1_PIXEL_FORMAT)
    public D2D1_PIXEL_FORMAT pixelFormat;

    /// (FLOAT)
    public Single dpiX;

    /// (FLOAT)
    public Single dpiY;

    /// (D2D1_BITMAP_OPTIONS)
    public D2D1_BITMAP_OPTIONS bitmapOptions;

    /// (*(ID2D1ColorContext))
    public IntPtr colorContext;

}
}
