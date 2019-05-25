/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=56)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (D3D11_AUTHENTICATED_PROTECTION_FLAGS)
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags;

}
}
