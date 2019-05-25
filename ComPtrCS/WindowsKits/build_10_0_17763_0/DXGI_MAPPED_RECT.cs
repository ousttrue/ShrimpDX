/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MAPPED_RECT{
    /// (INT)
    public Int32 Pitch;

    /// (*(BYTE))
    public IntPtr pBits;

}
}
