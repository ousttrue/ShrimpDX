/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_INLINE_OBJECT_METRICS{
    /// (FLOAT)
    public Single width;

    /// (FLOAT)
    public Single height;

    /// (FLOAT)
    public Single baseline;

    /// (BOOL)
    public Int32 supportsSideways;

}
}
