/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_RUN{
    /// (*(IDWriteFontFace))
    public IntPtr fontFace;

    /// (FLOAT)
    public Single fontEmSize;

    /// (UINT32)
    public UInt32 glyphCount;

    /// (*(const UINT16))
    public IntPtr glyphIndices;

    /// (*(const FLOAT))
    public IntPtr glyphAdvances;

    /// (*(const DWRITE_GLYPH_OFFSET))
    public IntPtr glyphOffsets;

    /// (BOOL)
    public Int32 isSideways;

    /// (UINT32)
    public UInt32 bidiLevel;

}
}
