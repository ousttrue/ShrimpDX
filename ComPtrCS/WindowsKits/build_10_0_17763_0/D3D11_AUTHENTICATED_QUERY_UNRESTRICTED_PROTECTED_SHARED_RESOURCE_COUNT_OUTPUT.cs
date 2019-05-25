/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=56)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 UnrestrictedProtectedSharedResourceCount;

}
}
