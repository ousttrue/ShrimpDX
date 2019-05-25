/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_PIXEL_FORMAT{
    /// (DXGI_FORMAT)
    public DXGI_FORMAT format;

    /// (D2D1_ALPHA_MODE)
    public D2D1_ALPHA_MODE alphaMode;

}
}
