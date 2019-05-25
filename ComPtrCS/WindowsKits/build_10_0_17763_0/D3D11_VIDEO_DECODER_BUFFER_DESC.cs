/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_BUFFER_DESC{
    /// (D3D11_VIDEO_DECODER_BUFFER_TYPE)
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

    /// (UINT)
    public UInt32 BufferIndex;

    /// (UINT)
    public UInt32 DataOffset;

    /// (UINT)
    public UInt32 DataSize;

    /// (UINT)
    public UInt32 FirstMBaddress;

    /// (UINT)
    public UInt32 NumMBsInBuffer;

    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 Stride;

    /// (UINT)
    public UInt32 ReservedBits;

    /// (*(void))
    public IntPtr pIV;

    /// (UINT)
    public UInt32 IVSize;

    /// (BOOL)
    public Int32 PartialEncryption;

    /// (D3D11_ENCRYPTED_BLOCK_INFO)
    public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;

}
}
