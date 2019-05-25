/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=64)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (D3D11_BUS_TYPE)
    public D3D11_BUS_TYPE BusType;

    /// (BOOL)
    public Int32 AccessibleInContiguousBlocks;

    /// (BOOL)
    public Int32 AccessibleInNonContiguousBlocks;

}
}
