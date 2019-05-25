/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=40)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_GLYPH_RUN_DESCRIPTION{
    /// (*(const WCHAR))
    public IntPtr localeName;

    /// (*(const WCHAR))
    public IntPtr str;

    /// (UINT32)
    public UInt32 stringLength;

    /// (*(const UINT16))
    public IntPtr clusterMap;

    /// (UINT32)
    public UInt32 textPosition;

}
}
