/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=100)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_CONFIG{
    /// (GUID)
    public Guid guidConfigBitstreamEncryption;

    /// (GUID)
    public Guid guidConfigMBcontrolEncryption;

    /// (GUID)
    public Guid guidConfigResidDiffEncryption;

    /// (UINT)
    public UInt32 ConfigBitstreamRaw;

    /// (UINT)
    public UInt32 ConfigMBcontrolRasterOrder;

    /// (UINT)
    public UInt32 ConfigResidDiffHost;

    /// (UINT)
    public UInt32 ConfigSpatialResid8;

    /// (UINT)
    public UInt32 ConfigResid8Subtraction;

    /// (UINT)
    public UInt32 ConfigSpatialHost8or9Clipping;

    /// (UINT)
    public UInt32 ConfigSpatialResidInterleaved;

    /// (UINT)
    public UInt32 ConfigIntraResidUnsigned;

    /// (UINT)
    public UInt32 ConfigResidDiffAccelerator;

    /// (UINT)
    public UInt32 ConfigHostInverseScan;

    /// (UINT)
    public UInt32 ConfigSpecificIDCT;

    /// (UINT)
    public UInt32 Config4GroupedCoefs;

    /// (USHORT)
    public UInt16 ConfigMinRenderTargetBuffCount;

    /// (USHORT)
    public UInt16 ConfigDecoderSpecific;

}
}
