/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SUBRESOURCE_DATA{
    /// (*(const void))
    public IntPtr pSysMem;

    /// (UINT)
    public UInt32 SysMemPitch;

    /// (UINT)
    public UInt32 SysMemSlicePitch;

}
}
