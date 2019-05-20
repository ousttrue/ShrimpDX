
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0 {

public struct DXGI_USAGE{
    public UInt32 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_FRAME_STATISTICS{
    /// (UINT)
    public UInt32 PresentCount;

    /// (UINT)
    public UInt32 PresentRefreshCount;

    /// (UINT)
    public UInt32 SyncRefreshCount;

    /// (LARGE_INTEGER)
    public Int64 SyncQPCTime;

    /// (LARGE_INTEGER)
    public Int64 SyncGPUTime;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MAPPED_RECT{
    /// (INT)
    public Int32 Pitch;

    /// (*(BYTE))
    public IntPtr pBits;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC{
    /// (WCHAR)[128]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]
    public string Description;

    /// (UINT)
    public UInt32 VendorId;

    /// (UINT)
    public UInt32 DeviceId;

    /// (UINT)
    public UInt32 SubSysId;

    /// (UINT)
    public UInt32 Revision;

    /// (SIZE_T)
    public UIntPtr DedicatedVideoMemory;

    /// (SIZE_T)
    public UIntPtr DedicatedSystemMemory;

    /// (SIZE_T)
    public UIntPtr SharedSystemMemory;

    /// (LUID)
    public Guid AdapterLuid;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTPUT_DESC{
    /// (WCHAR)[32]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]
    public string DeviceName;

    /// (RECT)
    public RECT DesktopCoordinates;

    /// (BOOL)
    public Int32 AttachedToDesktop;

    /// (DXGI_MODE_ROTATION)
    public DXGI_MODE_ROTATION Rotation;

    /// (HMONITOR)
    public IntPtr Monitor;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SHARED_RESOURCE{
    /// (HANDLE)
    public IntPtr Handle;

}

public enum DXGI_RESIDENCY {
    FULLY_RESIDENT = 0x00000001,
    RESIDENT_IN_SHARED_MEMORY = 0x00000002,
    EVICTED_TO_DISK = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SURFACE_DESC{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

}

public enum DXGI_SWAP_EFFECT {
    DISCARD = 0x00000000,
    SEQUENTIAL = 0x00000001,
    FLIP_SEQUENTIAL = 0x00000003,
    FLIP_DISCARD = 0x00000004,
}

public enum DXGI_SWAP_CHAIN_FLAG {
    NONPREROTATED = 0x00000001,
    ALLOW_MODE_SWITCH = 0x00000002,
    GDI_COMPATIBLE = 0x00000004,
    RESTRICTED_CONTENT = 0x00000008,
    RESTRICT_SHARED_RESOURCE_DRIVER = 0x00000010,
    DISPLAY_ONLY = 0x00000020,
    FRAME_LATENCY_WAITABLE_OBJECT = 0x00000040,
    FOREGROUND_LAYER = 0x00000080,
    FULLSCREEN_VIDEO = 0x00000100,
    YUV_VIDEO = 0x00000200,
    HW_PROTECTED = 0x00000400,
    ALLOW_TEARING = 0x00000800,
    RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS = 0x00001000,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SWAP_CHAIN_DESC{
    /// (DXGI_MODE_DESC)
    public DXGI_MODE_DESC BufferDesc;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (DXGI_USAGE)
    public DXGI_USAGE BufferUsage;

    /// (UINT)
    public UInt32 BufferCount;

    /// (HWND)
    public IntPtr OutputWindow;

    /// (BOOL)
    public Int32 Windowed;

    /// (DXGI_SWAP_EFFECT)
    public DXGI_SWAP_EFFECT SwapEffect;

    /// (UINT)
    public UInt32 Flags;

}

[ComImport, Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDXGIObject{
    Int32 SetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(const void))
        IntPtr pData
    );
    Int32 SetPrivateDataInterface(
        /// Name: (&(const GUID))
        ref Guid Name,
        /// pUnknown: (*(const IUnknown))
        IntPtr pUnknown
    );
    Int32 GetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name,
        /// pDataSize: (*(UINT))
        ref UInt32 pDataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    Int32 GetParent(
        /// riid: (&(const IID))
        ref Guid riid,
        /// ppParent: (*(*(void)))
        ref IntPtr ppParent
    );
}

[ComImport, Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
public interface IDXGIDeviceSubObject: IDXGIObject {
    Int32 GetDevice(
        /// riid: (&(const IID))
        ref Guid riid,
        /// ppDevice: (*(*(void)))
        ref IntPtr ppDevice
    );
}

[ComImport, Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
public interface IDXGIResource: IDXGIDeviceSubObject {
    Int32 GetSharedHandle(
        /// pSharedHandle: (*(HANDLE))
        ref IntPtr pSharedHandle
    );
    Int32 GetUsage(
        /// pUsage: (*(DXGI_USAGE))
        ref DXGI_USAGE pUsage
    );
    Int32 SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    );
    Int32 GetEvictionPriority(
        /// pEvictionPriority: (*(UINT))
        ref UInt32 pEvictionPriority
    );
}

[ComImport, Guid("9d8e1289-d7b3-465f-8126-250e349af85d")]
public interface IDXGIKeyedMutex: IDXGIDeviceSubObject {
    Int32 AcquireSync(
        /// Key: (UINT64)
        UInt64 Key,
        /// dwMilliseconds: (DWORD)
        UInt32 dwMilliseconds
    );
    Int32 ReleaseSync(
        /// Key: (UINT64)
        UInt64 Key
    );
}

[ComImport, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
public interface IDXGISurface: IDXGIDeviceSubObject {
    Int32 GetDesc(
        /// pDesc: (*(DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc
    );
    Int32 Map(
        /// pLockedRect: (*(DXGI_MAPPED_RECT))
        ref DXGI_MAPPED_RECT pLockedRect,
        /// MapFlags: (UINT)
        UInt32 MapFlags
    );
    Int32 Unmap(
    );
}

[ComImport, Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86")]
public interface IDXGISurface1: IDXGISurface {
    Int32 GetDC(
        /// Discard: (BOOL)
        Int32 Discard,
        /// phdc: (*(HDC))
        ref IntPtr phdc
    );
    Int32 ReleaseDC(
        /// pDirtyRect: (*(RECT))
        ref RECT pDirtyRect
    );
}

[ComImport, Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
public interface IDXGIAdapter: IDXGIObject {
    Int32 EnumOutputs(
        /// Output: (UINT)
        UInt32 Output,
        /// ppOutput: (*(*(IDXGIOutput)))
        ref IDXGIOutput ppOutput
    );
    Int32 GetDesc(
        /// pDesc: (*(DXGI_ADAPTER_DESC))
        ref DXGI_ADAPTER_DESC pDesc
    );
    Int32 CheckInterfaceSupport(
        /// InterfaceName: (&(const GUID))
        ref Guid InterfaceName,
        /// pUMDVersion: (*(LARGE_INTEGER))
        ref Int64 pUMDVersion
    );
}

[ComImport, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
public interface IDXGIOutput: IDXGIObject {
    Int32 GetDesc(
        /// pDesc: (*(DXGI_OUTPUT_DESC))
        ref DXGI_OUTPUT_DESC pDesc
    );
    Int32 GetDisplayModeList(
        /// EnumFormat: (DXGI_FORMAT)
        DXGI_FORMAT EnumFormat,
        /// Flags: (UINT)
        UInt32 Flags,
        /// pNumModes: (*(UINT))
        ref UInt32 pNumModes,
        /// pDesc: (*(DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pDesc
    );
    Int32 FindClosestMatchingMode(
        /// pModeToMatch: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pModeToMatch,
        /// pClosestMatch: (*(DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pClosestMatch,
        /// pConcernedDevice: (*(IUnknown))
        IntPtr pConcernedDevice
    );
    Int32 WaitForVBlank(
    );
    Int32 TakeOwnership(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice,
        /// Exclusive: (BOOL)
        Int32 Exclusive
    );
    void ReleaseOwnership(
    );
    Int32 GetGammaControlCapabilities(
        /// pGammaCaps: (*(DXGI_GAMMA_CONTROL_CAPABILITIES))
        ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps
    );
    Int32 SetGammaControl(
        /// pArray: (*(const DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    );
    Int32 GetGammaControl(
        /// pArray: (*(DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    );
    Int32 SetDisplaySurface(
        /// pScanoutSurface: (*(IDXGISurface))
        IDXGISurface pScanoutSurface
    );
    Int32 GetDisplaySurfaceData(
        /// pDestination: (*(IDXGISurface))
        IDXGISurface pDestination
    );
    Int32 GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    );
}

[ComImport, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public interface IDXGISwapChain: IDXGIDeviceSubObject {
    Int32 Present(
        /// SyncInterval: (UINT)
        UInt32 SyncInterval,
        /// Flags: (UINT)
        UInt32 Flags
    );
    Int32 GetBuffer(
        /// Buffer: (UINT)
        UInt32 Buffer,
        /// riid: (&(const IID))
        ref Guid riid,
        /// ppSurface: (*(*(void)))
        ref IntPtr ppSurface
    );
    Int32 SetFullscreenState(
        /// Fullscreen: (BOOL)
        Int32 Fullscreen,
        /// pTarget: (*(IDXGIOutput))
        IDXGIOutput pTarget
    );
    Int32 GetFullscreenState(
        /// pFullscreen: (*(BOOL))
        ref Int32 pFullscreen,
        /// ppTarget: (*(*(IDXGIOutput)))
        ref IDXGIOutput ppTarget
    );
    Int32 GetDesc(
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        ref DXGI_SWAP_CHAIN_DESC pDesc
    );
    Int32 ResizeBuffers(
        /// BufferCount: (UINT)
        UInt32 BufferCount,
        /// Width: (UINT)
        UInt32 Width,
        /// Height: (UINT)
        UInt32 Height,
        /// NewFormat: (DXGI_FORMAT)
        DXGI_FORMAT NewFormat,
        /// SwapChainFlags: (UINT)
        UInt32 SwapChainFlags
    );
    Int32 ResizeTarget(
        /// pNewTargetParameters: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pNewTargetParameters
    );
    Int32 GetContainingOutput(
        /// ppOutput: (*(*(IDXGIOutput)))
        ref IDXGIOutput ppOutput
    );
    Int32 GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    );
    Int32 GetLastPresentCount(
        /// pLastPresentCount: (*(UINT))
        ref UInt32 pLastPresentCount
    );
}

[ComImport, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public interface IDXGIFactory: IDXGIObject {
    Int32 EnumAdapters(
        /// Adapter: (UINT)
        UInt32 Adapter,
        /// ppAdapter: (*(*(IDXGIAdapter)))
        ref IDXGIAdapter ppAdapter
    );
    Int32 MakeWindowAssociation(
        /// WindowHandle: (HWND)
        IntPtr WindowHandle,
        /// Flags: (UINT)
        UInt32 Flags
    );
    Int32 GetWindowAssociation(
        /// pWindowHandle: (*(HWND))
        ref IntPtr pWindowHandle
    );
    Int32 CreateSwapChain(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice,
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        ref DXGI_SWAP_CHAIN_DESC pDesc,
        /// ppSwapChain: (*(*(IDXGISwapChain)))
        ref IDXGISwapChain ppSwapChain
    );
    Int32 CreateSoftwareAdapter(
        /// Module: (HMODULE)
        IntPtr Module,
        /// ppAdapter: (*(*(IDXGIAdapter)))
        ref IDXGIAdapter ppAdapter
    );
}

[ComImport, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
public interface IDXGIDevice: IDXGIObject {
    Int32 GetAdapter(
        /// pAdapter: (*(*(IDXGIAdapter)))
        ref IDXGIAdapter pAdapter
    );
    Int32 CreateSurface(
        /// pDesc: (*(const DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc,
        /// NumSurfaces: (UINT)
        UInt32 NumSurfaces,
        /// Usage: (DXGI_USAGE)
        DXGI_USAGE Usage,
        /// pSharedResource: (*(const DXGI_SHARED_RESOURCE))
        ref DXGI_SHARED_RESOURCE pSharedResource,
        /// ppSurface: (*(*(IDXGISurface)))
        ref IDXGISurface ppSurface
    );
    Int32 QueryResourceResidency(
        /// ppResources: (*(const *(IUnknown)))
        IntPtr ppResources,
        /// pResidencyStatus: (*(DXGI_RESIDENCY))
        ref DXGI_RESIDENCY pResidencyStatus,
        /// NumResources: (UINT)
        UInt32 NumResources
    );
    Int32 SetGPUThreadPriority(
        /// Priority: (INT)
        Int32 Priority
    );
    Int32 GetGPUThreadPriority(
        /// pPriority: (*(INT))
        ref Int32 pPriority
    );
}

public enum DXGI_ADAPTER_FLAG {
    NONE = 0x00000000,
    REMOTE = 0x00000001,
    SOFTWARE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC1{
    /// (WCHAR)[128]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]
    public string Description;

    /// (UINT)
    public UInt32 VendorId;

    /// (UINT)
    public UInt32 DeviceId;

    /// (UINT)
    public UInt32 SubSysId;

    /// (UINT)
    public UInt32 Revision;

    /// (SIZE_T)
    public UIntPtr DedicatedVideoMemory;

    /// (SIZE_T)
    public UIntPtr DedicatedSystemMemory;

    /// (SIZE_T)
    public UIntPtr SharedSystemMemory;

    /// (LUID)
    public Guid AdapterLuid;

    /// (UINT)
    public UInt32 Flags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_DISPLAY_COLOR_SPACE{
    /// (FLOAT)[8][2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8 * 2)]
    public Single[] PrimaryCoordinates;

    /// (FLOAT)[16][2]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16 * 2)]
    public Single[] WhitePoints;

}

[ComImport, Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
public interface IDXGIFactory1: IDXGIFactory {
    Int32 EnumAdapters1(
        /// Adapter: (UINT)
        UInt32 Adapter,
        /// ppAdapter: (*(*(IDXGIAdapter1)))
        ref IDXGIAdapter1 ppAdapter
    );
    Int32 IsCurrent(
    );
}

[ComImport, Guid("29038f61-3839-4626-91fd-086879011a05")]
public interface IDXGIAdapter1: IDXGIAdapter {
    Int32 GetDesc1(
        /// pDesc: (*(DXGI_ADAPTER_DESC1))
        ref DXGI_ADAPTER_DESC1 pDesc
    );
}

[ComImport, Guid("77db970f-6276-48ba-ba28-070143b4392c")]
public interface IDXGIDevice1: IDXGIDevice {
    Int32 SetMaximumFrameLatency(
        /// MaxLatency: (UINT)
        UInt32 MaxLatency
    );
    Int32 GetMaximumFrameLatency(
        /// pMaxLatency: (*(UINT))
        ref UInt32 pMaxLatency
    );
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
public static extern Int32 CreateDXGIFactory(
    /// riid: (&(const IID))
    ref Guid riid,
    /// ppFactory: (*(*(void)))
    ref IntPtr ppFactory
);

[DllImport("DXGI.dll")]
public static extern Int32 CreateDXGIFactory1(
    /// riid: (&(const IID))
    ref Guid riid,
    /// ppFactory: (*(*(void)))
    ref IntPtr ppFactory
);

}
}
