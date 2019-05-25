/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_DESC{
    /// (UINT)
    public UInt32 ByteWidth;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

    /// (UINT)
    public UInt32 StructureByteStride;

}
}
