/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=2)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SHAPING_TEXT_PROPERTIES{
    /// (UINT16)
    public UInt16 isShapedAlone;

    /// (UINT16)
    public UInt16 reserved1;

    /// (UINT16)
    public UInt16 canBreakShapingAfter;

    /// (UINT16)
    public UInt16 reserved;

}
}
