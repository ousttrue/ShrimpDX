/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=56)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (UINT)
    public UInt32 StartSequenceQuery;

    /// (UINT)
    public UInt32 StartSequenceConfigure;

}
}
