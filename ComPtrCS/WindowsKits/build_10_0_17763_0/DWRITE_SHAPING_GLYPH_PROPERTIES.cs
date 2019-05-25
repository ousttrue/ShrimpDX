/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=2)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SHAPING_GLYPH_PROPERTIES{
    /// (UINT16)
    public UInt16 justification;

    /// (UINT16)
    public UInt16 isClusterStart;

    /// (UINT16)
    public UInt16 isDiacritic;

    /// (UINT16)
    public UInt16 isZeroWidthSpace;

    /// (UINT16)
    public UInt16 reserved;

}
}
