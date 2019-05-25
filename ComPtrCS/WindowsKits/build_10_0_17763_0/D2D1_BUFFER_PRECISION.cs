/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_BUFFER_PRECISION {
    UNKNOWN = 0x00000000,
    _8BPC_UNORM = 0x00000001,
    _8BPC_UNORM_SRGB = 0x00000002,
    _16BPC_UNORM = 0x00000003,
    _16BPC_FLOAT = 0x00000004,
    _32BPC_FLOAT = 0x00000005,
    FORCE_DWORD = -0x0000001,
}
}
