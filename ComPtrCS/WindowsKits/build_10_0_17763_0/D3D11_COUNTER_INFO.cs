/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_COUNTER_INFO{
    /// (D3D11_COUNTER)
    public D3D11_COUNTER LastDeviceDependentCounter;

    /// (UINT)
    public UInt32 NumSimultaneousCounters;

    /// (UINT8)
    public Byte NumDetectableParallelUnits;

}
}
