/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS{
    /// (UINT)
    public UInt32 IndexCountPerInstance;

    /// (UINT)
    public UInt32 InstanceCount;

    /// (UINT)
    public UInt32 StartIndexLocation;

    /// (INT)
    public Int32 BaseVertexLocation;

    /// (UINT)
    public UInt32 StartInstanceLocation;

}
}
