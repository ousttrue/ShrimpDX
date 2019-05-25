/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT{
    /// (UINT)
    public UInt32 PixelShaderMinPrecision;

    /// (UINT)
    public UInt32 AllOtherShaderStagesMinPrecision;

}
}
