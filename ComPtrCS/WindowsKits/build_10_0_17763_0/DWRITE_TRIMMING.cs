/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=12)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DWRITE_TRIMMING{
    /// (DWRITE_TRIMMING_GRANULARITY)
    public DWRITE_TRIMMING_GRANULARITY granularity;

    /// (UINT32)
    public UInt32 delimiter;

    /// (UINT32)
    public UInt32 delimiterCount;

}
}
