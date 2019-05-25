/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_GEOMETRY_RELATION {
    UNKNOWN = 0x00000000,
    DISJOINT = 0x00000001,
    IS_CONTAINED = 0x00000002,
    CONTAINS = 0x00000003,
    OVERLAP = 0x00000004,
    FORCE_DWORD = -0x0000001,
}
}
