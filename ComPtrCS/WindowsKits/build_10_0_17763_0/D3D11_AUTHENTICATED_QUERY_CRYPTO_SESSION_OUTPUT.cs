/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (HANDLE)
    public IntPtr DecoderHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (HANDLE)
    public IntPtr DeviceHandle;

}
}
