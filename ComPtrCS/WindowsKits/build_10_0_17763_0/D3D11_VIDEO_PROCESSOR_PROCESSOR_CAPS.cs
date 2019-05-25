/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS {
    DEINTERLACE_BLEND = 0x00000001,
    DEINTERLACE_BOB = 0x00000002,
    DEINTERLACE_ADAPTIVE = 0x00000004,
    DEINTERLACE_MOTION_COMPENSATION = 0x00000008,
    INVERSE_TELECINE = 0x00000010,
    FRAME_RATE_CONVERSION = 0x00000020,
}
}
