/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS{
    /// (UINT)
    public UInt32 VertexCountPerInstance;

    /// (UINT)
    public UInt32 InstanceCount;

    /// (UINT)
    public UInt32 StartVertexLocation;

    /// (UINT)
    public UInt32 StartInstanceLocation;

}
}
