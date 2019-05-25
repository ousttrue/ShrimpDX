/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_OUTPUT{
    /// (D3D11_OMAC)
    public D3D11_OMAC omac;

    /// (GUID)
    public Guid ConfigureType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

    /// (HRESULT)
    public HRESULT ReturnCode;

}
}
