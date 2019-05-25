/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {


[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct __MIDL___MIDL_itf_d3d11_0000_0034_0001{
    public UInt32 ProtectionEnabled;
    public UInt32 OverlayOrFullscreenRequired;
    public UInt32 Reserved;
}
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_PROTECTION_FLAGS{
    public /* (struct __MIDL___MIDL_itf_d3d11_0000_0034_0001) */__MIDL___MIDL_itf_d3d11_0000_0034_0001 Flags;
    public /* (UINT) */UInt32 Value;
}
}
