/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_INTERPOLATION_MODE {
    NEAREST_NEIGHBOR = 0x00000000,
    LINEAR = 0x00000001,
    CUBIC = 0x00000002,
    MULTI_SAMPLE_LINEAR = 0x00000003,
    ANISOTROPIC = 0x00000004,
    HIGH_QUALITY_CUBIC = 0x00000005,
    FORCE_DWORD = -0x0000001,
}
}
