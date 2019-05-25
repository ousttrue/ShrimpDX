/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=36)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TEXT_METRICS{
    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single widthIncludingTrailingWhitespace;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single layoutWidth;

    /// (FLOAT)
    public Single layoutHeight;

    /// (UINT32)
    public UInt32 maxBidiReorderingDepth;

    /// (UINT32)
    public UInt32 lineCount;

}
}
