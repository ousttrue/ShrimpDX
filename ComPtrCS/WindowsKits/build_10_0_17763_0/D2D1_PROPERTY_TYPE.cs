/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D2D1_PROPERTY_TYPE {
    UNKNOWN = 0x00000000,
    STRING = 0x00000001,
    BOOL = 0x00000002,
    UINT32 = 0x00000003,
    INT32 = 0x00000004,
    FLOAT = 0x00000005,
    VECTOR2 = 0x00000006,
    VECTOR3 = 0x00000007,
    VECTOR4 = 0x00000008,
    BLOB = 0x00000009,
    IUNKNOWN = 0x0000000a,
    ENUM = 0x0000000b,
    ARRAY = 0x0000000c,
    CLSID = 0x0000000d,
    MATRIX_3X2 = 0x0000000e,
    MATRIX_4X3 = 0x0000000f,
    MATRIX_4X4 = 0x00000010,
    MATRIX_5X4 = 0x00000011,
    COLOR_CONTEXT = 0x00000012,
    FORCE_DWORD = -0x0000001,
}
}
