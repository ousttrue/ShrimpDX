
    using System;
    using System.Runtime.InteropServices;
    using System.Numerics;

    namespace WindowsKits.build_10_0_17763_0 {

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

public class IDXGIObject : IUnknownImpl{

    static /*readonly*/ Guid s_uuid = new Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    public Int32 SetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref Name, DataSize, pData);
    }
    delegate Int32 SetPrivateDataFunc(IntPtr self, ref Guid Name, UInt32 DataSize, IntPtr pData);
    public Int32 SetPrivateDataInterface(
        /// Name: (&(const GUID))
        ref Guid Name
        /// pUnknown: (*(const IUnknown))
        , IntPtr pUnknown
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref Name, pUnknown);
    }
    delegate Int32 SetPrivateDataInterfaceFunc(IntPtr self, ref Guid Name, IntPtr pUnknown);
    public Int32 GetPrivateData(
        /// Name: (&(const GUID))
        ref Guid Name
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref Name, ref pDataSize, pData);
    }
    delegate Int32 GetPrivateDataFunc(IntPtr self, ref Guid Name, ref UInt32 pDataSize, IntPtr pData);
    public Int32 GetParent(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppParent: (*(*(void)))
        , ref IntPtr ppParent
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetParentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentFunc));
        return callback(Self, ref riid, ref ppParent);
    }
    delegate Int32 GetParentFunc(IntPtr self, ref Guid riid, ref IntPtr ppParent);
}

public class IDXGIDeviceSubObject: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public Int32 GetDevice(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppDevice: (*(*(void)))
        , ref IntPtr ppDevice
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
        return callback(Self, ref riid, ref ppDevice);
    }
    delegate Int32 GetDeviceFunc(IntPtr self, ref Guid riid, ref IntPtr ppDevice);
}

public class IDXGIResource: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    public Int32 GetSharedHandle(
        /// pSharedHandle: (*(HANDLE))
        ref IntPtr pSharedHandle
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSharedHandleFunc));
        return callback(Self, ref pSharedHandle);
    }
    delegate Int32 GetSharedHandleFunc(IntPtr self, ref IntPtr pSharedHandle);
    public Int32 GetUsage(
        /// pUsage: (*(DXGI_USAGE))
        ref DXGI_USAGE pUsage
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetUsageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUsageFunc));
        return callback(Self, ref pUsage);
    }
    delegate Int32 GetUsageFunc(IntPtr self, ref DXGI_USAGE pUsage);
    public Int32 SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
        return callback(Self, EvictionPriority);
    }
    delegate Int32 SetEvictionPriorityFunc(IntPtr self, UInt32 EvictionPriority);
    public Int32 GetEvictionPriority(
        /// pEvictionPriority: (*(UINT))
        ref UInt32 pEvictionPriority
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
        return callback(Self, ref pEvictionPriority);
    }
    delegate Int32 GetEvictionPriorityFunc(IntPtr self, ref UInt32 pEvictionPriority);
}

public class IDXGIKeyedMutex: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("9d8e1289-d7b3-465f-8126-250e349af85d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 AcquireSync(
        /// Key: (UINT64)
        UInt64 Key
        /// dwMilliseconds: (DWORD)
        , UInt32 dwMilliseconds
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (AcquireSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireSyncFunc));
        return callback(Self, Key, dwMilliseconds);
    }
    delegate Int32 AcquireSyncFunc(IntPtr self, UInt64 Key, UInt32 dwMilliseconds);
    public Int32 ReleaseSync(
        /// Key: (UINT64)
        UInt64 Key
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (ReleaseSyncFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseSyncFunc));
        return callback(Self, Key);
    }
    delegate Int32 ReleaseSyncFunc(IntPtr self, UInt64 Key);
}

public class IDXGISurface: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    public Int32 GetDesc(
        /// pDesc: (*(DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDescFunc(IntPtr self, ref DXGI_SURFACE_DESC pDesc);
    public Int32 Map(
        /// pLockedRect: (*(DXGI_MAPPED_RECT))
        ref DXGI_MAPPED_RECT pLockedRect
        /// MapFlags: (UINT)
        , UInt32 MapFlags
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, ref pLockedRect, MapFlags);
    }
    delegate Int32 MapFunc(IntPtr self, ref DXGI_MAPPED_RECT pLockedRect, UInt32 MapFlags);
    public Int32 Unmap(
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        return callback(Self);
    }
    delegate Int32 UnmapFunc(IntPtr self);
}

public class IDXGISurface1: IDXGISurface {

    static /*readonly*/ Guid s_uuid = new Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 GetDC(
        /// Discard: (BOOL)
        Int32 Discard
        /// phdc: (*(HDC))
        , ref IntPtr phdc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
        return callback(Self, Discard, ref phdc);
    }
    delegate Int32 GetDCFunc(IntPtr self, Int32 Discard, ref IntPtr phdc);
    public Int32 ReleaseDC(
        /// pDirtyRect: (*(RECT))
        ref RECT pDirtyRect
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
        return callback(Self, ref pDirtyRect);
    }
    delegate Int32 ReleaseDCFunc(IntPtr self, ref RECT pDirtyRect);
}

public class IDXGIAdapter: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    public Int32 EnumOutputs(
        /// Output: (UINT)
        UInt32 Output
        /// ppOutput: (*(*(IDXGIOutput)))
        , ref IntPtr ppOutput
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (EnumOutputsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumOutputsFunc));
        return callback(Self, Output, ref ppOutput);
    }
    delegate Int32 EnumOutputsFunc(IntPtr self, UInt32 Output, ref IntPtr ppOutput);
    public Int32 GetDesc(
        /// pDesc: (*(DXGI_ADAPTER_DESC))
        ref DXGI_ADAPTER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDescFunc(IntPtr self, ref DXGI_ADAPTER_DESC pDesc);
    public Int32 CheckInterfaceSupport(
        /// InterfaceName: (&(const GUID))
        ref Guid InterfaceName
        /// pUMDVersion: (*(LARGE_INTEGER))
        , IntPtr pUMDVersion
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (CheckInterfaceSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckInterfaceSupportFunc));
        return callback(Self, ref InterfaceName, pUMDVersion);
    }
    delegate Int32 CheckInterfaceSupportFunc(IntPtr self, ref Guid InterfaceName, IntPtr pUMDVersion);
}

public class IDXGIOutput: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 12;
    public Int32 GetDesc(
        /// pDesc: (*(DXGI_OUTPUT_DESC))
        ref DXGI_OUTPUT_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDescFunc(IntPtr self, ref DXGI_OUTPUT_DESC pDesc);
    public Int32 GetDisplayModeList(
        /// EnumFormat: (DXGI_FORMAT)
        DXGI_FORMAT EnumFormat
        /// Flags: (UINT)
        , UInt32 Flags
        /// pNumModes: (*(UINT))
        , ref UInt32 pNumModes
        /// pDesc: (*(DXGI_MODE_DESC))
        , ref DXGI_MODE_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetDisplayModeListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayModeListFunc));
        return callback(Self, EnumFormat, Flags, ref pNumModes, ref pDesc);
    }
    delegate Int32 GetDisplayModeListFunc(IntPtr self, DXGI_FORMAT EnumFormat, UInt32 Flags, ref UInt32 pNumModes, ref DXGI_MODE_DESC pDesc);
    public Int32 FindClosestMatchingMode(
        /// pModeToMatch: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pModeToMatch
        /// pClosestMatch: (*(DXGI_MODE_DESC))
        , ref DXGI_MODE_DESC pClosestMatch
        /// pConcernedDevice: (*(IUnknown))
        , IntPtr pConcernedDevice
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (FindClosestMatchingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindClosestMatchingModeFunc));
        return callback(Self, ref pModeToMatch, ref pClosestMatch, pConcernedDevice);
    }
    delegate Int32 FindClosestMatchingModeFunc(IntPtr self, ref DXGI_MODE_DESC pModeToMatch, ref DXGI_MODE_DESC pClosestMatch, IntPtr pConcernedDevice);
    public Int32 WaitForVBlank(
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (WaitForVBlankFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WaitForVBlankFunc));
        return callback(Self);
    }
    delegate Int32 WaitForVBlankFunc(IntPtr self);
    public Int32 TakeOwnership(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// Exclusive: (BOOL)
        , Int32 Exclusive
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (TakeOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TakeOwnershipFunc));
        return callback(Self, pDevice, Exclusive);
    }
    delegate Int32 TakeOwnershipFunc(IntPtr self, IntPtr pDevice, Int32 Exclusive);
    public void ReleaseOwnership(
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (ReleaseOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseOwnershipFunc));
        callback(Self);
    }
    delegate void ReleaseOwnershipFunc(IntPtr self);
    public Int32 GetGammaControlCapabilities(
        /// pGammaCaps: (*(DXGI_GAMMA_CONTROL_CAPABILITIES))
        ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (GetGammaControlCapabilitiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlCapabilitiesFunc));
        return callback(Self, ref pGammaCaps);
    }
    delegate Int32 GetGammaControlCapabilitiesFunc(IntPtr self, ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
    public Int32 SetGammaControl(
        /// pArray: (*(const DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (SetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGammaControlFunc));
        return callback(Self, ref pArray);
    }
    delegate Int32 SetGammaControlFunc(IntPtr self, ref DXGI_GAMMA_CONTROL pArray);
    public Int32 GetGammaControl(
        /// pArray: (*(DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (GetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlFunc));
        return callback(Self, ref pArray);
    }
    delegate Int32 GetGammaControlFunc(IntPtr self, ref DXGI_GAMMA_CONTROL pArray);
    public Int32 SetDisplaySurface(
        /// pScanoutSurface: (*(IDXGISurface))
        IntPtr pScanoutSurface
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (SetDisplaySurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDisplaySurfaceFunc));
        return callback(Self, pScanoutSurface);
    }
    delegate Int32 SetDisplaySurfaceFunc(IntPtr self, IntPtr pScanoutSurface);
    public Int32 GetDisplaySurfaceData(
        /// pDestination: (*(IDXGISurface))
        IntPtr pDestination
    )
    {
        var fp = GetFunctionPointer(10);
        var callback = (GetDisplaySurfaceDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceDataFunc));
        return callback(Self, pDestination);
    }
    delegate Int32 GetDisplaySurfaceDataFunc(IntPtr self, IntPtr pDestination);
    public Int32 GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    )
    {
        var fp = GetFunctionPointer(11);
        var callback = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
        return callback(Self, ref pStats);
    }
    delegate Int32 GetFrameStatisticsFunc(IntPtr self, ref DXGI_FRAME_STATISTICS pStats);
}

public class IDXGISwapChain: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 10;
    public Int32 Present(
        /// SyncInterval: (UINT)
        UInt32 SyncInterval
        /// Flags: (UINT)
        , UInt32 Flags
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (PresentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PresentFunc));
        return callback(Self, SyncInterval, Flags);
    }
    delegate Int32 PresentFunc(IntPtr self, UInt32 SyncInterval, UInt32 Flags);
    public Int32 GetBuffer(
        /// Buffer: (UINT)
        UInt32 Buffer
        /// riid: (&(const IID))
        , ref Guid riid
        /// ppSurface: (*(*(void)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
        return callback(Self, Buffer, ref riid, ref ppSurface);
    }
    delegate Int32 GetBufferFunc(IntPtr self, UInt32 Buffer, ref Guid riid, ref IntPtr ppSurface);
    public Int32 SetFullscreenState(
        /// Fullscreen: (BOOL)
        Int32 Fullscreen
        /// pTarget: (*(IDXGIOutput))
        , IntPtr pTarget
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (SetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFullscreenStateFunc));
        return callback(Self, Fullscreen, pTarget);
    }
    delegate Int32 SetFullscreenStateFunc(IntPtr self, Int32 Fullscreen, IntPtr pTarget);
    public Int32 GetFullscreenState(
        /// pFullscreen: (*(BOOL))
        IntPtr pFullscreen
        /// ppTarget: (*(*(IDXGIOutput)))
        , ref IntPtr ppTarget
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenStateFunc));
        return callback(Self, pFullscreen, ref ppTarget);
    }
    delegate Int32 GetFullscreenStateFunc(IntPtr self, IntPtr pFullscreen, ref IntPtr ppTarget);
    public Int32 GetDesc(
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        ref DXGI_SWAP_CHAIN_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_DESC pDesc);
    public Int32 ResizeBuffers(
        /// BufferCount: (UINT)
        UInt32 BufferCount
        /// Width: (UINT)
        , UInt32 Width
        /// Height: (UINT)
        , UInt32 Height
        /// NewFormat: (DXGI_FORMAT)
        , DXGI_FORMAT NewFormat
        /// SwapChainFlags: (UINT)
        , UInt32 SwapChainFlags
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (ResizeBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBuffersFunc));
        return callback(Self, BufferCount, Width, Height, NewFormat, SwapChainFlags);
    }
    delegate Int32 ResizeBuffersFunc(IntPtr self, UInt32 BufferCount, UInt32 Width, UInt32 Height, DXGI_FORMAT NewFormat, UInt32 SwapChainFlags);
    public Int32 ResizeTarget(
        /// pNewTargetParameters: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pNewTargetParameters
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (ResizeTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeTargetFunc));
        return callback(Self, ref pNewTargetParameters);
    }
    delegate Int32 ResizeTargetFunc(IntPtr self, ref DXGI_MODE_DESC pNewTargetParameters);
    public Int32 GetContainingOutput(
        /// ppOutput: (*(*(IDXGIOutput)))
        ref IntPtr ppOutput
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (GetContainingOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainingOutputFunc));
        return callback(Self, ref ppOutput);
    }
    delegate Int32 GetContainingOutputFunc(IntPtr self, ref IntPtr ppOutput);
    public Int32 GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
        return callback(Self, ref pStats);
    }
    delegate Int32 GetFrameStatisticsFunc(IntPtr self, ref DXGI_FRAME_STATISTICS pStats);
    public Int32 GetLastPresentCount(
        /// pLastPresentCount: (*(UINT))
        ref UInt32 pLastPresentCount
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (GetLastPresentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastPresentCountFunc));
        return callback(Self, ref pLastPresentCount);
    }
    delegate Int32 GetLastPresentCountFunc(IntPtr self, ref UInt32 pLastPresentCount);
}

public class IDXGIFactory: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    public Int32 EnumAdapters(
        /// Adapter: (UINT)
        UInt32 Adapter
        /// ppAdapter: (*(*(IDXGIAdapter)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (EnumAdaptersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdaptersFunc));
        return callback(Self, Adapter, ref ppAdapter);
    }
    delegate Int32 EnumAdaptersFunc(IntPtr self, UInt32 Adapter, ref IntPtr ppAdapter);
    public Int32 MakeWindowAssociation(
        /// WindowHandle: (HWND)
        IntPtr WindowHandle
        /// Flags: (UINT)
        , UInt32 Flags
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (MakeWindowAssociationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MakeWindowAssociationFunc));
        return callback(Self, WindowHandle, Flags);
    }
    delegate Int32 MakeWindowAssociationFunc(IntPtr self, IntPtr WindowHandle, UInt32 Flags);
    public Int32 GetWindowAssociation(
        /// pWindowHandle: (*(HWND))
        ref IntPtr pWindowHandle
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetWindowAssociationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWindowAssociationFunc));
        return callback(Self, ref pWindowHandle);
    }
    delegate Int32 GetWindowAssociationFunc(IntPtr self, ref IntPtr pWindowHandle);
    public Int32 CreateSwapChain(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        , ref DXGI_SWAP_CHAIN_DESC pDesc
        /// ppSwapChain: (*(*(IDXGISwapChain)))
        , ref IntPtr ppSwapChain
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (CreateSwapChainFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainFunc));
        return callback(Self, pDevice, ref pDesc, ref ppSwapChain);
    }
    delegate Int32 CreateSwapChainFunc(IntPtr self, IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, ref IntPtr ppSwapChain);
    public Int32 CreateSoftwareAdapter(
        /// Module: (HMODULE)
        IntPtr Module
        /// ppAdapter: (*(*(IDXGIAdapter)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (CreateSoftwareAdapterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSoftwareAdapterFunc));
        return callback(Self, Module, ref ppAdapter);
    }
    delegate Int32 CreateSoftwareAdapterFunc(IntPtr self, IntPtr Module, ref IntPtr ppAdapter);
}

public class IDXGIDevice: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    public Int32 GetAdapter(
        /// pAdapter: (*(*(IDXGIAdapter)))
        ref IntPtr pAdapter
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetAdapterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAdapterFunc));
        return callback(Self, ref pAdapter);
    }
    delegate Int32 GetAdapterFunc(IntPtr self, ref IntPtr pAdapter);
    public Int32 CreateSurface(
        /// pDesc: (*(const DXGI_SURFACE_DESC))
        ref DXGI_SURFACE_DESC pDesc
        /// NumSurfaces: (UINT)
        , UInt32 NumSurfaces
        /// Usage: (DXGI_USAGE)
        , DXGI_USAGE Usage
        /// pSharedResource: (*(const DXGI_SHARED_RESOURCE))
        , ref DXGI_SHARED_RESOURCE pSharedResource
        /// ppSurface: (*(*(IDXGISurface)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (CreateSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSurfaceFunc));
        return callback(Self, ref pDesc, NumSurfaces, Usage, ref pSharedResource, ref ppSurface);
    }
    delegate Int32 CreateSurfaceFunc(IntPtr self, ref DXGI_SURFACE_DESC pDesc, UInt32 NumSurfaces, DXGI_USAGE Usage, ref DXGI_SHARED_RESOURCE pSharedResource, ref IntPtr ppSurface);
    public Int32 QueryResourceResidency(
        /// ppResources: (*(const *(IUnknown)))
        ref IntPtr ppResources
        /// pResidencyStatus: (*(DXGI_RESIDENCY))
        , ref DXGI_RESIDENCY pResidencyStatus
        /// NumResources: (UINT)
        , UInt32 NumResources
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (QueryResourceResidencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryResourceResidencyFunc));
        return callback(Self, ref ppResources, ref pResidencyStatus, NumResources);
    }
    delegate Int32 QueryResourceResidencyFunc(IntPtr self, ref IntPtr ppResources, ref DXGI_RESIDENCY pResidencyStatus, UInt32 NumResources);
    public Int32 SetGPUThreadPriority(
        /// Priority: (INT)
        Int32 Priority
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (SetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGPUThreadPriorityFunc));
        return callback(Self, Priority);
    }
    delegate Int32 SetGPUThreadPriorityFunc(IntPtr self, Int32 Priority);
    public Int32 GetGPUThreadPriority(
        /// pPriority: (*(INT))
        IntPtr pPriority
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (GetGPUThreadPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGPUThreadPriorityFunc));
        return callback(Self, pPriority);
    }
    delegate Int32 GetGPUThreadPriorityFunc(IntPtr self, IntPtr pPriority);
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

public class IDXGIFactory1: IDXGIFactory {

    static /*readonly*/ Guid s_uuid = new Guid("770aae78-f26f-4dba-a829-253c83d1b387");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 EnumAdapters1(
        /// Adapter: (UINT)
        UInt32 Adapter
        /// ppAdapter: (*(*(IDXGIAdapter1)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (EnumAdapters1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdapters1Func));
        return callback(Self, Adapter, ref ppAdapter);
    }
    delegate Int32 EnumAdapters1Func(IntPtr self, UInt32 Adapter, ref IntPtr ppAdapter);
    public Int32 IsCurrent(
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (IsCurrentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsCurrentFunc));
        return callback(Self);
    }
    delegate Int32 IsCurrentFunc(IntPtr self);
}

public class IDXGIAdapter1: IDXGIAdapter {

    static /*readonly*/ Guid s_uuid = new Guid("29038f61-3839-4626-91fd-086879011a05");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public Int32 GetDesc1(
        /// pDesc: (*(DXGI_ADAPTER_DESC1))
        ref DXGI_ADAPTER_DESC1 pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDesc1Func(IntPtr self, ref DXGI_ADAPTER_DESC1 pDesc);
}

public class IDXGIDevice1: IDXGIDevice {

    static /*readonly*/ Guid s_uuid = new Guid("77db970f-6276-48ba-ba28-070143b4392c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 SetMaximumFrameLatency(
        /// MaxLatency: (UINT)
        UInt32 MaxLatency
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (SetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumFrameLatencyFunc));
        return callback(Self, MaxLatency);
    }
    delegate Int32 SetMaximumFrameLatencyFunc(IntPtr self, UInt32 MaxLatency);
    public Int32 GetMaximumFrameLatency(
        /// pMaxLatency: (*(UINT))
        ref UInt32 pMaxLatency
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumFrameLatencyFunc));
        return callback(Self, ref pMaxLatency);
    }
    delegate Int32 GetMaximumFrameLatencyFunc(IntPtr self, ref UInt32 pMaxLatency);
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
    ref Guid riid
    /// ppFactory: (*(*(void)))
    , ref IntPtr ppFactory
);

[DllImport("DXGI.dll")]
public static extern Int32 CreateDXGIFactory1(
    /// riid: (&(const IID))
    ref Guid riid
    /// ppFactory: (*(*(void)))
    , ref IntPtr ppFactory
);

}
}
