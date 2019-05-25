/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=36)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_HIT_TEST_METRICS{
    /// (UINT32)
    public UInt32 textPosition;

    /// (UINT32)
    public UInt32 length;

    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single height;

    /// (UINT32)
    public UInt32 bidiLevel;

    /// (BOOL)
    public Int32 isText;

    /// (BOOL)
    public Int32 isTrimmed;

}
}
