/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_MATRIX{
    /// (FLOAT)
    public Single m11;

    /// (FLOAT)
    public Single m12;

    /// (FLOAT)
    public Single m21;

    /// (FLOAT)
    public Single m22;

    /// (FLOAT)
    public Single dx;

    /// (FLOAT)
    public Single dy;

}
}
