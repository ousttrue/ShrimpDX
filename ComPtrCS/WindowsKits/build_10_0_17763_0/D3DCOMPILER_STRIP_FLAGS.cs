/// d3dcompiler.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public enum D3DCOMPILER_STRIP_FLAGS {
    D3DCOMPILER_STRIP_REFLECTION_DATA = 0x00000001,
    D3DCOMPILER_STRIP_DEBUG_INFO = 0x00000002,
    D3DCOMPILER_STRIP_TEST_BLOBS = 0x00000004,
    D3DCOMPILER_STRIP_PRIVATE_DATA = 0x00000008,
    D3DCOMPILER_STRIP_ROOT_SIGNATURE = 0x00000010,
    D3DCOMPILER_STRIP_FORCE_DWORD = 0x7fffffff,
}
}