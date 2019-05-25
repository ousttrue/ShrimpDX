/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=36)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_DESC{
    /// (DXGI_MODE_DESC)
    public DXGI_MODE_DESC ModeDesc;

    /// (DXGI_MODE_ROTATION)
    public DXGI_MODE_ROTATION Rotation;

    /// (BOOL)
    public Int32 DesktopImageInSystemMemory;

}
}
