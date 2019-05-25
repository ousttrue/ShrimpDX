/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RENDER_TARGET_BLEND_DESC{
    /// (BOOL)
    public Int32 BlendEnable;

    /// (D3D11_BLEND)
    public D3D11_BLEND SrcBlend;

    /// (D3D11_BLEND)
    public D3D11_BLEND DestBlend;

    /// (D3D11_BLEND_OP)
    public D3D11_BLEND_OP BlendOp;

    /// (D3D11_BLEND)
    public D3D11_BLEND SrcBlendAlpha;

    /// (D3D11_BLEND)
    public D3D11_BLEND DestBlendAlpha;

    /// (D3D11_BLEND_OP)
    public D3D11_BLEND_OP BlendOpAlpha;

    /// (UINT8)
    public Byte RenderTargetWriteMask;

}
}
