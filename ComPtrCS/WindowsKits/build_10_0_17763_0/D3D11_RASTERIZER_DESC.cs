/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=40)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RASTERIZER_DESC{
    /// (D3D11_FILL_MODE)
    public D3D11_FILL_MODE FillMode;

    /// (D3D11_CULL_MODE)
    public D3D11_CULL_MODE CullMode;

    /// (BOOL)
    public Int32 FrontCounterClockwise;

    /// (INT)
    public Int32 DepthBias;

    /// (FLOAT)
    public Single DepthBiasClamp;

    /// (FLOAT)
    public Single SlopeScaledDepthBias;

    /// (BOOL)
    public Int32 DepthClipEnable;

    /// (BOOL)
    public Int32 ScissorEnable;

    /// (BOOL)
    public Int32 MultisampleEnable;

    /// (BOOL)
    public Int32 AntialiasedLineEnable;

}
}
