
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_USAGE{
    public UInt32 Value;
}

public static class dxgi{
public const int DXGI_CPU_ACCESS_NONE = unchecked((int)( 0 ));
public const int DXGI_CPU_ACCESS_DYNAMIC = unchecked((int)( 1 ));
public const int DXGI_CPU_ACCESS_READ_WRITE = unchecked((int)( 2 ));
public const int DXGI_CPU_ACCESS_SCRATCH = unchecked((int)( 3 ));
public const int DXGI_CPU_ACCESS_FIELD = unchecked((int)15);
public const int DXGI_USAGE_SHADER_INPUT = unchecked((int)0x00000010UL);
public const int DXGI_USAGE_RENDER_TARGET_OUTPUT = unchecked((int)0x00000020UL);
public const int DXGI_USAGE_BACK_BUFFER = unchecked((int)0x00000040UL);
public const int DXGI_USAGE_SHARED = unchecked((int)0x00000080UL);
public const int DXGI_USAGE_READ_ONLY = unchecked((int)0x00000100UL);
public const int DXGI_USAGE_DISCARD_ON_PRESENT = unchecked((int)0x00000200UL);
public const int DXGI_USAGE_UNORDERED_ACCESS = unchecked((int)0x00000400UL);
public const int DXGI_RESOURCE_PRIORITY_MINIMUM = unchecked((int)( 0x28000000 ));
public const int DXGI_RESOURCE_PRIORITY_LOW = unchecked((int)( 0x50000000 ));
public const int DXGI_RESOURCE_PRIORITY_NORMAL = unchecked((int)( 0x78000000 ));
public const int DXGI_RESOURCE_PRIORITY_HIGH = unchecked((int)( 0xa0000000 ));
public const int DXGI_RESOURCE_PRIORITY_MAXIMUM = unchecked((int)( 0xc8000000 ));
public const int DXGI_MAP_READ = unchecked((int)( 1UL ));
public const int DXGI_MAP_WRITE = unchecked((int)( 2UL ));
public const int DXGI_MAP_DISCARD = unchecked((int)( 4UL ));
public const int DXGI_ENUM_MODES_INTERLACED = unchecked((int)( 1UL ));
public const int DXGI_ENUM_MODES_SCALING = unchecked((int)( 2UL ));
public const int DXGI_MAX_SWAP_CHAIN_BUFFERS = unchecked((int)( 16 ));
public const int DXGI_PRESENT_TEST = unchecked((int)0x00000001UL);
public const int DXGI_PRESENT_DO_NOT_SEQUENCE = unchecked((int)0x00000002UL);
public const int DXGI_PRESENT_RESTART = unchecked((int)0x00000004UL);
public const int DXGI_PRESENT_DO_NOT_WAIT = unchecked((int)0x00000008UL);
public const int DXGI_PRESENT_STEREO_PREFER_RIGHT = unchecked((int)0x00000010UL);
public const int DXGI_PRESENT_STEREO_TEMPORARY_MONO = unchecked((int)0x00000020UL);
public const int DXGI_PRESENT_RESTRICT_TO_OUTPUT = unchecked((int)0x00000040UL);
public const int DXGI_PRESENT_USE_DURATION = unchecked((int)0x00000100UL);
public const int DXGI_PRESENT_ALLOW_TEARING = unchecked((int)0x00000200UL);
public const int DXGI_MWA_NO_WINDOW_CHANGES = unchecked((int)( 1 << 0 ));
public const int DXGI_MWA_NO_ALT_ENTER = unchecked((int)( 1 << 1 ));
public const int DXGI_MWA_NO_PRINT_SCREEN = unchecked((int)( 1 << 2 ));
public const int DXGI_MWA_VALID = unchecked((int)( 0x7 ));
[DllImport("DXGI.dll")]
public static extern HRESULT CreateDXGIFactory(
    /// riid: (&(const IID))
    ref Guid riid
    /// ppFactory: (*(*(void)))
    , ref IntPtr ppFactory
);

[DllImport("DXGI.dll")]
public static extern HRESULT CreateDXGIFactory1(
    /// riid: (&(const IID))
    ref Guid riid
    /// ppFactory: (*(*(void)))
    , ref IntPtr ppFactory
);

}
}
