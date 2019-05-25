/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_RGB{
    /// (float)
    public float Red;

    /// (float)
    public float Green;

    /// (float)
    public float Blue;

}
}
