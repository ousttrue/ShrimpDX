/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D_INTERPOLATION_MODE {
    UNDEFINED = 0x00000000,
    CONSTANT = 0x00000001,
    LINEAR = 0x00000002,
    LINEAR_CENTROID = 0x00000003,
    LINEAR_NOPERSPECTIVE = 0x00000004,
    LINEAR_NOPERSPECTIVE_CENTROID = 0x00000005,
    LINEAR_SAMPLE = 0x00000006,
    LINEAR_NOPERSPECTIVE_SAMPLE = 0x00000007,
}
}
