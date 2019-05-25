/// dxgicommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_RATIONAL{
    /// (UINT)
    public UInt32 Numerator;

    /// (UINT)
    public UInt32 Denominator;

}
}
