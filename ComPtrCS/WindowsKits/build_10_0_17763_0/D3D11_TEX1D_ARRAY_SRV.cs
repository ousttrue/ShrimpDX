/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}
}
