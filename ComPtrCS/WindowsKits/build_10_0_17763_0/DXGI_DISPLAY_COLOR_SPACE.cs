/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=192)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_DISPLAY_COLOR_SPACE{
    /// (FLOAT)[8][2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8 * 2)]
    public Single[] PrimaryCoordinates;

    /// (FLOAT)[16][2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16 * 2)]
    public Single[] WhitePoints;

}
}
