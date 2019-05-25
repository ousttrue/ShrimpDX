/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_UAV{
    /// (UINT)
    public UInt32 FirstElement;

    /// (UINT)
    public UInt32 NumElements;

    /// (UINT)
    public UInt32 Flags;

}
}
