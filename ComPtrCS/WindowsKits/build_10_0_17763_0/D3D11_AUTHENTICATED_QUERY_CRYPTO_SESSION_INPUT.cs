/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=40)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (HANDLE)
    public IntPtr DecoderHandle;

}
}
