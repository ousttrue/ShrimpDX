/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TEXT_RANGE{
    /// (UINT32)
    public UInt32 startPosition;

    /// (UINT32)
    public UInt32 length;

}
}
