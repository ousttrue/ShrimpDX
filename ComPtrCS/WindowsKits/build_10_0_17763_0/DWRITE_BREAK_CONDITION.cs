/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DWRITE_BREAK_CONDITION {
    NEUTRAL = 0x00000000,
    CAN_BREAK = 0x00000001,
    MAY_NOT_BREAK = 0x00000002,
    MUST_BREAK = 0x00000003,
}
}
