/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_MAPPED_RECT{
    /// (UINT32)
    public UInt32 pitch;

    /// (*(BYTE))
    public IntPtr bits;

}
}
