/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=40)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_UNDERLINE{
    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single thickness;

    /// (FLOAT)
    public Single offset;

    /// (FLOAT)
    public Single runHeight;

    /// (DWRITE_READING_DIRECTION)
    public DWRITE_READING_DIRECTION readingDirection;

    /// (DWRITE_FLOW_DIRECTION)
    public DWRITE_FLOW_DIRECTION flowDirection;

    /// (*(const WCHAR))
    public IntPtr localeName;

    /// (DWRITE_MEASURING_MODE)
    public DWRITE_MEASURING_MODE measuringMode;

}
}
