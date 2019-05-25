/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12324)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_GAMMA_CONTROL{
    /// (DXGI_RGB)
    public DXGI_RGB Scale;

    /// (DXGI_RGB)
    public DXGI_RGB Offset;

    /// (DXGI_RGB)[1025]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1025)]
    public DXGI_RGB[] GammaCurve;

}
}
