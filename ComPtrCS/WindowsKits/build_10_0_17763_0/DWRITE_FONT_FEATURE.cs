/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_FONT_FEATURE{
    /// (DWRITE_FONT_FEATURE_TAG)
    public DWRITE_FONT_FEATURE_TAG nameTag;

    /// (UINT32)
    public UInt32 parameter;

}
}
