/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DEPTH_STENCILOP_DESC{
    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilFailOp;

    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilDepthFailOp;

    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilPassOp;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC StencilFunc;

}
}
