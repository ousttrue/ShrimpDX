/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SO_DECLARATION_ENTRY{
    /// (UINT)
    public UInt32 Stream;

    /// (LPCSTR)
    public IntPtr SemanticName;

    /// (UINT)
    public UInt32 SemanticIndex;

    /// (BYTE)
    public Byte StartComponent;

    /// (BYTE)
    public Byte ComponentCount;

    /// (BYTE)
    public Byte OutputSlot;

}
}
