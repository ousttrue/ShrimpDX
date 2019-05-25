/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_OVERHANG_METRICS{
    /// (FLOAT)
    public Single left;

    /// (FLOAT)
    public Single top;

    /// (FLOAT)
    public Single right;

    /// (FLOAT)
    public Single bottom;

}
}
