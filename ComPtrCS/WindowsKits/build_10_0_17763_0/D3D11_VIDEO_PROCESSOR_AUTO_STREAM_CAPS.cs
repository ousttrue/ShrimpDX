/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS {
    DENOISE = 0x00000001,
    DERINGING = 0x00000002,
    EDGE_ENHANCEMENT = 0x00000004,
    COLOR_CORRECTION = 0x00000008,
    FLESH_TONE_MAPPING = 0x00000010,
    IMAGE_STABILIZATION = 0x00000020,
    SUPER_RESOLUTION = 0x00000040,
    ANAMORPHIC_SCALING = 0x00000080,
}
}
