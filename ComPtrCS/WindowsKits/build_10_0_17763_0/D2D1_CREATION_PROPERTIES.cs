/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_CREATION_PROPERTIES{
    /// (D2D1_THREADING_MODE)
    public D2D1_THREADING_MODE threadingMode;

    /// (D2D1_DEBUG_LEVEL)
    public D2D1_DEBUG_LEVEL debugLevel;

    /// (D2D1_DEVICE_CONTEXT_OPTIONS)
    public D2D1_DEVICE_CONTEXT_OPTIONS options;

}
}
