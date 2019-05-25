/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=96)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTPUT_DESC{
    /// (WCHAR)[32]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]
    public string DeviceName;

    /// (RECT)
    public RECT DesktopCoordinates;

    /// (BOOL)
    public Int32 AttachedToDesktop;

    /// (DXGI_MODE_ROTATION)
    public DXGI_MODE_ROTATION Rotation;

    /// (HMONITOR)
    public IntPtr Monitor;

}
}
