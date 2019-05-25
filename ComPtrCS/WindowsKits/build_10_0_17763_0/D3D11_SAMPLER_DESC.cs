/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=52)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SAMPLER_DESC{
    /// (D3D11_FILTER)
    public D3D11_FILTER Filter;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressU;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressV;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressW;

    /// (FLOAT)
    public Single MipLODBias;

    /// (UINT)
    public UInt32 MaxAnisotropy;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC ComparisonFunc;

    /// (FLOAT)[4]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public Single[] BorderColor;

    /// (FLOAT)
    public Single MinLOD;

    /// (FLOAT)
    public Single MaxLOD;

}
}
