/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_RTV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstWSlice;

    /// (UINT)
    public UInt32 WSize;

}
}
