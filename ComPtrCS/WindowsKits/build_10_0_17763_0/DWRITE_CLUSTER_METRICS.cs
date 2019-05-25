/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_CLUSTER_METRICS{
    /// (FLOAT)
    public Single width;

    /// (UINT16)
    public UInt16 length;

    /// (UINT16)
    public UInt16 canWrapLineAfter;

    /// (UINT16)
    public UInt16 isWhitespace;

    /// (UINT16)
    public UInt16 isNewline;

    /// (UINT16)
    public UInt16 isSoftHyphen;

    /// (UINT16)
    public UInt16 isRightToLeft;

    /// (UINT16)
    public UInt16 padding;

}
}
