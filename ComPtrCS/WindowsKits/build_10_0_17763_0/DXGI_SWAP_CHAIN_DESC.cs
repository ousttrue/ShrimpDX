/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=72)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SWAP_CHAIN_DESC{
    /// (DXGI_MODE_DESC)
    public DXGI_MODE_DESC BufferDesc;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (DXGI_USAGE)
    public DXGI_USAGE BufferUsage;

    /// (UINT)
    public UInt32 BufferCount;

    /// (HWND)
    public IntPtr OutputWindow;

    /// (BOOL)
    public Int32 Windowed;

    /// (DXGI_SWAP_EFFECT)
    public DXGI_SWAP_EFFECT SwapEffect;

    /// (UINT)
    public UInt32 Flags;

}
}
