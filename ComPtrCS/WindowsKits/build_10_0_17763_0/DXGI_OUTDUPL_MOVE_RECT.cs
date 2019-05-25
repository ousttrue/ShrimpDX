/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_MOVE_RECT{
    /// (POINT)
    public POINT SourcePoint;

    /// (RECT)
    public RECT DestinationRect;

}
}
