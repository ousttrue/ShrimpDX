/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS1{
    /// (D3D11_TILED_RESOURCES_TIER)
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

    /// (BOOL)
    public Int32 MinMaxFiltering;

    /// (BOOL)
    public Int32 ClearViewAlsoSupportsDepthOnlyFormats;

    /// (BOOL)
    public Int32 MapOnDefaultBuffers;

}
}
