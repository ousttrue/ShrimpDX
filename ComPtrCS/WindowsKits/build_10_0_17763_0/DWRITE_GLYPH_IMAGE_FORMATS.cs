/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum DWRITE_GLYPH_IMAGE_FORMATS {
    NONE = 0x00000000,
    TRUETYPE = 0x00000001,
    CFF = 0x00000002,
    COLR = 0x00000004,
    SVG = 0x00000008,
    PNG = 0x00000010,
    JPEG = 0x00000020,
    TIFF = 0x00000040,
    PREMULTIPLIED_B8G8R8A8 = 0x00000080,
}
}
