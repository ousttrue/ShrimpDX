/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_COMPOSITE_MODE {
    SOURCE_OVER = 0x00000000,
    DESTINATION_OVER = 0x00000001,
    SOURCE_IN = 0x00000002,
    DESTINATION_IN = 0x00000003,
    SOURCE_OUT = 0x00000004,
    DESTINATION_OUT = 0x00000005,
    SOURCE_ATOP = 0x00000006,
    DESTINATION_ATOP = 0x00000007,
    XOR = 0x00000008,
    PLUS = 0x00000009,
    SOURCE_COPY = 0x0000000a,
    BOUNDED_SOURCE_COPY = 0x0000000b,
    MASK_INVERT = 0x0000000c,
    FORCE_DWORD = -0x0000001,
}
}
