/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE)
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;

    /// (HANDLE)
    public IntPtr ProcessHandle;

    /// (BOOL)
    public Int32 AllowAccess;

}
}
