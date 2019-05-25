/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (HANDLE)
    public IntPtr DeviceHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

}
}
