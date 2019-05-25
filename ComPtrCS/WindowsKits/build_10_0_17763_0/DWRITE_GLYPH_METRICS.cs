/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=28)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_METRICS{
    /// (INT32)
    public Int32 leftSideBearing;

    /// (UINT32)
    public UInt32 advanceWidth;

    /// (INT32)
    public Int32 rightSideBearing;

    /// (INT32)
    public Int32 topSideBearing;

    /// (UINT32)
    public UInt32 advanceHeight;

    /// (INT32)
    public Int32 bottomSideBearing;

    /// (INT32)
    public Int32 verticalOriginY;

}
}
