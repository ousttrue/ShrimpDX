/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D_RECT_U{
    /// (UINT32)
    public UInt32 left;

    /// (UINT32)
    public UInt32 top;

    /// (UINT32)
    public UInt32 right;

    /// (UINT32)
    public UInt32 bottom;

}
}
