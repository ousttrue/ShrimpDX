/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_HWND_RENDER_TARGET_PROPERTIES{
    /// (HWND)
    public IntPtr hwnd;

    /// (D2D1_SIZE_U)
    public D2D_SIZE_U pixelSize;

    /// (D2D1_PRESENT_OPTIONS)
    public D2D1_PRESENT_OPTIONS presentOptions;

}
}
