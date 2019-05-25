/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct _D3D11_AES_CTR_IV{
    /// (UINT64)
    public UInt64 IV;

    /// (UINT64)
    public UInt64 Count;

}
}
