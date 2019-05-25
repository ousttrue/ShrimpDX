/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DXGI_RESIDENCY {
    FULLY_RESIDENT = 0x00000001,
    RESIDENT_IN_SHARED_MEMORY = 0x00000002,
    EVICTED_TO_DISK = 0x00000003,
}
}
