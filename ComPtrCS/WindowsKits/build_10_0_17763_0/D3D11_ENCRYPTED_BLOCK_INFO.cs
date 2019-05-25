/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_ENCRYPTED_BLOCK_INFO{
    /// (UINT)
    public UInt32 NumEncryptedBytesAtBeginning;

    /// (UINT)
    public UInt32 NumBytesInSkipPattern;

    /// (UINT)
    public UInt32 NumBytesInEncryptPattern;

}
}
