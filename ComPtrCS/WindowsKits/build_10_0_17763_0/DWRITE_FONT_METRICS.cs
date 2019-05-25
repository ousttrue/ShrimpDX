/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_FONT_METRICS{
    /// (UINT16)
    public UInt16 designUnitsPerEm;

    /// (UINT16)
    public UInt16 ascent;

    /// (UINT16)
    public UInt16 descent;

    /// (INT16)
    public Int16 lineGap;

    /// (UINT16)
    public UInt16 capHeight;

    /// (UINT16)
    public UInt16 xHeight;

    /// (INT16)
    public Int16 underlinePosition;

    /// (UINT16)
    public UInt16 underlineThickness;

    /// (INT16)
    public Int16 strikethroughPosition;

    /// (UINT16)
    public UInt16 strikethroughThickness;

}
}
