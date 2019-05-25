/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_EXTENSION{
    /// (UINT)
    public UInt32 Function;

    /// (*(void))
    public IntPtr pPrivateInputData;

    /// (UINT)
    public UInt32 PrivateInputDataSize;

    /// (*(void))
    public IntPtr pPrivateOutputData;

    /// (UINT)
    public UInt32 PrivateOutputDataSize;

    /// (UINT)
    public UInt32 ResourceCount;

    /// (*(*(ID3D11Resource)))
    public IntPtr ppResourceList;

}
}
