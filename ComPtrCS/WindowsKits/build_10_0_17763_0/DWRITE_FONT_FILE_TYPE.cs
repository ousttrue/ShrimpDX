/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DWRITE_FONT_FILE_TYPE {
    UNKNOWN = 0x00000000,
    CFF = 0x00000001,
    TRUETYPE = 0x00000002,
    OPENTYPE_COLLECTION = 0x00000003,
    TYPE1_PFM = 0x00000004,
    TYPE1_PFB = 0x00000005,
    VECTOR = 0x00000006,
    BITMAP = 0x00000007,
    TRUETYPE_COLLECTION = 0x00000003,
}
}
