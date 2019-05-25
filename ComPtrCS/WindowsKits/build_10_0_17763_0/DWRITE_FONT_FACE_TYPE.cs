/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DWRITE_FONT_FACE_TYPE {
    CFF = 0x00000000,
    TRUETYPE = 0x00000001,
    OPENTYPE_COLLECTION = 0x00000002,
    TYPE1 = 0x00000003,
    VECTOR = 0x00000004,
    BITMAP = 0x00000005,
    UNKNOWN = 0x00000006,
    RAW_CFF = 0x00000007,
    TRUETYPE_COLLECTION = 0x00000002,
}
}
