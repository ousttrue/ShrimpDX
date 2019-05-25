/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS2{
    /// (BOOL)
    public Int32 PSSpecifiedStencilRefSupported;

    /// (BOOL)
    public Int32 TypedUAVLoadAdditionalFormats;

    /// (BOOL)
    public Int32 ROVsSupported;

    /// (D3D11_CONSERVATIVE_RASTERIZATION_TIER)
    public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

    /// (D3D11_TILED_RESOURCES_TIER)
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

    /// (BOOL)
    public Int32 MapOnDefaultTextures;

    /// (BOOL)
    public Int32 StandardSwizzle;

    /// (BOOL)
    public Int32 UnifiedMemoryArchitecture;

}
}
