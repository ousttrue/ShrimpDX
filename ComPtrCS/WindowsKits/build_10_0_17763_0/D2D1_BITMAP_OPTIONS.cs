/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_BITMAP_OPTIONS {
    NONE = 0x00000000,
    TARGET = 0x00000001,
    CANNOT_DRAW = 0x00000002,
    CPU_READ = 0x00000004,
    GDI_COMPATIBLE = 0x00000008,
    FORCE_DWORD = -0x0000001,
}
}
