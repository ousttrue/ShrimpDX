/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_CLASS_INSTANCE_DESC{
    /// (UINT)
    public UInt32 InstanceId;

    /// (UINT)
    public UInt32 InstanceIndex;

    /// (UINT)
    public UInt32 TypeId;

    /// (UINT)
    public UInt32 ConstantBuffer;

    /// (UINT)
    public UInt32 BaseConstantBufferOffset;

    /// (UINT)
    public UInt32 BaseTexture;

    /// (UINT)
    public UInt32 BaseSampler;

    /// (BOOL)
    public Int32 Created;

}
}
