/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIEWPORT{
    /// (FLOAT)
    public Single TopLeftX;

    /// (FLOAT)
    public Single TopLeftY;

    /// (FLOAT)
    public Single Width;

    /// (FLOAT)
    public Single Height;

    /// (FLOAT)
    public Single MinDepth;

    /// (FLOAT)
    public Single MaxDepth;

}
}
