/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_LINE_METRICS{
    /// (UINT32)
    public UInt32 length;

    /// (UINT32)
    public UInt32 trailingWhitespaceLength;

    /// (UINT32)
    public UInt32 newlineLength;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single baseline;

    /// (BOOL)
    public Int32 isTrimmed;

}
}
