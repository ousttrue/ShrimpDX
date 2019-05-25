/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SWAP_CHAIN_DESC1{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (BOOL)
    public Int32 Stereo;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (DXGI_USAGE)
    public DXGI_USAGE BufferUsage;

    /// (UINT)
    public UInt32 BufferCount;

    /// (DXGI_SCALING)
    public DXGI_SCALING Scaling;

    /// (DXGI_SWAP_EFFECT)
    public DXGI_SWAP_EFFECT SwapEffect;

    /// (DXGI_ALPHA_MODE)
    public DXGI_ALPHA_MODE AlphaMode;

    /// (UINT)
    public UInt32 Flags;

}
}
