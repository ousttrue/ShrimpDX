/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_THREADING{
    /// (BOOL)
    public Int32 DriverConcurrentCreates;

    /// (BOOL)
    public Int32 DriverCommandLists;

}
}
