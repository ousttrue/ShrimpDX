/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_SCRIPT_ANALYSIS{
    /// (UINT16)
    public UInt16 script;

    /// (DWRITE_SCRIPT_SHAPES)
    public DWRITE_SCRIPT_SHAPES shapes;

}
}
