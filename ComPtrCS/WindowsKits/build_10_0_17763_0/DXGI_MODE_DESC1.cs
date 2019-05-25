/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=32)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MODE_DESC1{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL RefreshRate;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (DXGI_MODE_SCANLINE_ORDER)
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

    /// (DXGI_MODE_SCALING)
    public DXGI_MODE_SCALING Scaling;

    /// (BOOL)
    public Int32 Stereo;

}
}
