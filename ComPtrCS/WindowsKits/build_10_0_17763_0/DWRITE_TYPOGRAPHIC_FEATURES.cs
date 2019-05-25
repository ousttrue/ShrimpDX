/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TYPOGRAPHIC_FEATURES{
    /// (*(DWRITE_FONT_FEATURE))
    public IntPtr features;

    /// (UINT32)
    public UInt32 featureCount;

}
}
