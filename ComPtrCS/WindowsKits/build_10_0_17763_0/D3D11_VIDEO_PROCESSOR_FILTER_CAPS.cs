/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D11_VIDEO_PROCESSOR_FILTER_CAPS {
    BRIGHTNESS = 0x00000001,
    CONTRAST = 0x00000002,
    HUE = 0x00000004,
    SATURATION = 0x00000008,
    NOISE_REDUCTION = 0x00000010,
    EDGE_ENHANCEMENT = 0x00000020,
    ANAMORPHIC_SCALING = 0x00000040,
    STEREO_ADJUSTMENT = 0x00000080,
}
}
