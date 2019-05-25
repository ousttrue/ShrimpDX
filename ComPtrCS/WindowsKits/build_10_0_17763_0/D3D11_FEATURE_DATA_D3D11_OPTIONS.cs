/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=56)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS{
    /// (BOOL)
    public Int32 OutputMergerLogicOp;

    /// (BOOL)
    public Int32 UAVOnlyRenderingForcedSampleCount;

    /// (BOOL)
    public Int32 DiscardAPIsSeenByDriver;

    /// (BOOL)
    public Int32 FlagsForUpdateAndCopySeenByDriver;

    /// (BOOL)
    public Int32 ClearView;

    /// (BOOL)
    public Int32 CopyWithOverlap;

    /// (BOOL)
    public Int32 ConstantBufferPartialUpdate;

    /// (BOOL)
    public Int32 ConstantBufferOffsetting;

    /// (BOOL)
    public Int32 MapNoOverwriteOnDynamicConstantBuffer;

    /// (BOOL)
    public Int32 MapNoOverwriteOnDynamicBufferSRV;

    /// (BOOL)
    public Int32 MultisampleRTVWithForcedSampleCountOne;

    /// (BOOL)
    public Int32 SAD4ShaderInstructions;

    /// (BOOL)
    public Int32 ExtendedDoublesShaderInstructions;

    /// (BOOL)
    public Int32 ExtendedResourceSharing;

}
}
