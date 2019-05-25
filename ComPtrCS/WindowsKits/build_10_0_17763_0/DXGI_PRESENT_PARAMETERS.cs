/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_PRESENT_PARAMETERS{
    /// (UINT)
    public UInt32 DirtyRectsCount;

    /// (*(RECT))
    public IntPtr pDirtyRects;

    /// (*(RECT))
    public IntPtr pScrollRect;

    /// (*(POINT))
    public IntPtr pScrollOffset;

}
}
