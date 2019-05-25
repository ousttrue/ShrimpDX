/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D_MIN_PRECISION {
    DEFAULT = 0x00000000,
    FLOAT_16 = 0x00000001,
    FLOAT_2_8 = 0x00000002,
    RESERVED = 0x00000003,
    SINT_16 = 0x00000004,
    UINT_16 = 0x00000005,
    ANY_16 = 0x000000f0,
    ANY_10 = 0x000000f1,
}
}
