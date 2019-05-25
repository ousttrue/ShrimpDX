/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_INPUT{
    /// (GUID)
    public Guid QueryType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

}
}
