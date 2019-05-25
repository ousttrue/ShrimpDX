/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_COMBINE_MODE {
    UNION = 0x00000000,
    INTERSECT = 0x00000001,
    XOR = 0x00000002,
    EXCLUDE = 0x00000003,
    FORCE_DWORD = -0x0000001,
}
}
