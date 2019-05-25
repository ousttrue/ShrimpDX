/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=4116)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_GAMMA_CONTROL_CAPABILITIES{
    /// (BOOL)
    public Int32 ScaleAndOffsetSupported;

    /// (float)
    public float MaxConvertedValue;

    /// (float)
    public float MinConvertedValue;

    /// (UINT)
    public UInt32 NumGammaControlPoints;

    /// (float)[1025]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1025)]
    public float[] ControlPointPositions;

}
}
