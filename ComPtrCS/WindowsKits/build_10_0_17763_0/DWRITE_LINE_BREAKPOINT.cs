/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=1)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_LINE_BREAKPOINT{
    /// (UINT8)
    public Byte breakConditionBefore;

    /// (UINT8)
    public Byte breakConditionAfter;

    /// (UINT8)
    public Byte isWhitespace;

    /// (UINT8)
    public Byte isSoftHyphen;

    /// (UINT8)
    public Byte padding;

}
}
