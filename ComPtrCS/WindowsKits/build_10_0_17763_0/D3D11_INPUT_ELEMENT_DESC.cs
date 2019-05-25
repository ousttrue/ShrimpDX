/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_INPUT_ELEMENT_DESC{
    /// (LPCSTR)
    public IntPtr SemanticName;

    /// (UINT)
    public UInt32 SemanticIndex;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (UINT)
    public UInt32 InputSlot;

    /// (UINT)
    public UInt32 AlignedByteOffset;

    /// (D3D11_INPUT_CLASSIFICATION)
    public D3D11_INPUT_CLASSIFICATION InputSlotClass;

    /// (UINT)
    public UInt32 InstanceDataStepRate;

}
}
