/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=88)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_PIPELINE_STATISTICS{
    /// (UINT64)
    public UInt64 IAVertices;

    /// (UINT64)
    public UInt64 IAPrimitives;

    /// (UINT64)
    public UInt64 VSInvocations;

    /// (UINT64)
    public UInt64 GSInvocations;

    /// (UINT64)
    public UInt64 GSPrimitives;

    /// (UINT64)
    public UInt64 CInvocations;

    /// (UINT64)
    public UInt64 CPrimitives;

    /// (UINT64)
    public UInt64 PSInvocations;

    /// (UINT64)
    public UInt64 HSInvocations;

    /// (UINT64)
    public UInt64 DSInvocations;

    /// (UINT64)
    public UInt64 CSInvocations;

}
}
