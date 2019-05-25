/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BOX{
    /// (UINT)
    public UInt32 left;

    /// (UINT)
    public UInt32 top;

    /// (UINT)
    public UInt32 front;

    /// (UINT)
    public UInt32 right;

    /// (UINT)
    public UInt32 bottom;

    /// (UINT)
    public UInt32 back;

}
}
