/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=264)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BLEND_DESC{
    /// (BOOL)
    public Int32 AlphaToCoverageEnable;

    /// (BOOL)
    public Int32 IndependentBlendEnable;

    /// (D3D11_RENDER_TARGET_BLEND_DESC)[8]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public D3D11_RENDER_TARGET_BLEND_DESC[] RenderTarget;

}
}
