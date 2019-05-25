/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=52)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_DESC{
    /// (BOOL)
    public Int32 DepthEnable;

    /// (D3D11_DEPTH_WRITE_MASK)
    public D3D11_DEPTH_WRITE_MASK DepthWriteMask;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC DepthFunc;

    /// (BOOL)
    public Int32 StencilEnable;

    /// (UINT8)
    public Byte StencilReadMask;

    /// (UINT8)
    public Byte StencilWriteMask;

    /// (D3D11_DEPTH_STENCILOP_DESC)
    public D3D11_DEPTH_STENCILOP_DESC FrontFace;

    /// (D3D11_DEPTH_STENCILOP_DESC)
    public D3D11_DEPTH_STENCILOP_DESC BackFace;

}
}
