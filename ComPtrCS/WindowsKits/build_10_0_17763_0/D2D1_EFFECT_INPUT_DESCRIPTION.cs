/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_EFFECT_INPUT_DESCRIPTION{
    /// (*(ID2D1Effect))
    public IntPtr effect;

    /// (UINT32)
    public UInt32 inputIndex;

    /// (D2D1_RECT_F)
    public D2D_RECT_F inputRectangle;

}
}
