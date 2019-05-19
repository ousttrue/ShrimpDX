
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0 {

public struct DXGI_USAGE{
    public /* (UINT) */UInt32 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_FRAME_STATISTICS{
    /* (UINT) */UInt32 PresentCount;
    /* (UINT) */UInt32 PresentRefreshCount;
    /* (UINT) */UInt32 SyncRefreshCount;
    /* (LARGE_INTEGER) */Int64 SyncQPCTime;
    /* (LARGE_INTEGER) */Int64 SyncGPUTime;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MAPPED_RECT{
    /* (INT) */Int32 Pitch;
    /* (*(BYTE)) */IntPtr pBits;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC{
    /* (WCHAR)[128] */[MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]public string Description;
    /* (UINT) */UInt32 VendorId;
    /* (UINT) */UInt32 DeviceId;
    /* (UINT) */UInt32 SubSysId;
    /* (UINT) */UInt32 Revision;
    /* (SIZE_T) */UIntPtr DedicatedVideoMemory;
    /* (SIZE_T) */UIntPtr DedicatedSystemMemory;
    /* (SIZE_T) */UIntPtr SharedSystemMemory;
    /* (LUID) */Guid AdapterLuid;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTPUT_DESC{
    /* (WCHAR)[32] */[MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)]public string DeviceName;
    /* (RECT) */RECT DesktopCoordinates;
    /* (BOOL) */Int32 AttachedToDesktop;
    /* (DXGI_MODE_ROTATION) */DXGI_MODE_ROTATION Rotation;
    /* (HMONITOR) */IntPtr Monitor;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SHARED_RESOURCE{
    /* (HANDLE) */IntPtr Handle;
}

public enum DXGI_RESIDENCY {
    FULLY_RESIDENT = 0x00000001,
    RESIDENT_IN_SHARED_MEMORY = 0x00000002,
    EVICTED_TO_DISK = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SURFACE_DESC{
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 Height;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (DXGI_SAMPLE_DESC) */DXGI_SAMPLE_DESC SampleDesc;
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
    /* (DXGI_MODE_DESC) */DXGI_MODE_DESC BufferDesc;
    /* (DXGI_SAMPLE_DESC) */DXGI_SAMPLE_DESC SampleDesc;
    /* (DXGI_USAGE) */DXGI_USAGE BufferUsage;
    /* (UINT) */UInt32 BufferCount;
    /* (HWND) */IntPtr OutputWindow;
    /* (BOOL) */Int32 Windowed;
    /* (DXGI_SWAP_EFFECT) */DXGI_SWAP_EFFECT SwapEffect;
    /* (UINT) */UInt32 Flags;
}

[ComImport, Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IDXGIObject{
    /* (HRESULT) */Int32 SetPrivateData(/* (&(const GUID)) */ref Guid Name, /* (UINT) */UInt32 DataSize, /* (*(const void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateDataInterface(/* (&(const GUID)) */ref Guid Name, /* (*(const IUnknown)) */IntPtr pUnknown);
    /* (HRESULT) */Int32 GetPrivateData(/* (&(const GUID)) */ref Guid Name, /* (*(UINT)) */ref UInt32 pDataSize, /* (*(void)) */IntPtr pData);
    /* (HRESULT) */Int32 GetParent(/* (&(const IID)) */ref Guid riid, /* (*(*(void))) */ref IntPtr ppParent);
}

[ComImport, Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
public interface IDXGIDeviceSubObject: IDXGIObject {
    /* (HRESULT) */Int32 GetDevice(/* (&(const IID)) */ref Guid riid, /* (*(*(void))) */ref IntPtr ppDevice);
}

[ComImport, Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
public interface IDXGIResource: IDXGIDeviceSubObject {
    /* (HRESULT) */Int32 GetSharedHandle(/* (*(HANDLE)) */ref IntPtr pSharedHandle);
    /* (HRESULT) */Int32 GetUsage(/* (*(DXGI_USAGE)) */ref DXGI_USAGE pUsage);
    /* (HRESULT) */Int32 SetEvictionPriority(/* (UINT) */UInt32 EvictionPriority);
    /* (HRESULT) */Int32 GetEvictionPriority(/* (*(UINT)) */ref UInt32 pEvictionPriority);
}

[ComImport, Guid("9d8e1289-d7b3-465f-8126-250e349af85d")]
public interface IDXGIKeyedMutex: IDXGIDeviceSubObject {
    /* (HRESULT) */Int32 AcquireSync(/* (UINT64) */UInt64 Key, /* (DWORD) */UInt32 dwMilliseconds);
    /* (HRESULT) */Int32 ReleaseSync(/* (UINT64) */UInt64 Key);
}

[ComImport, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
public interface IDXGISurface: IDXGIDeviceSubObject {
    /* (HRESULT) */Int32 GetDesc(/* (*(DXGI_SURFACE_DESC)) */ref DXGI_SURFACE_DESC pDesc);
    /* (HRESULT) */Int32 Map(/* (*(DXGI_MAPPED_RECT)) */ref DXGI_MAPPED_RECT pLockedRect, /* (UINT) */UInt32 MapFlags);
    /* (HRESULT) */Int32 Unmap();
}

[ComImport, Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86")]
public interface IDXGISurface1: IDXGISurface {
    /* (HRESULT) */Int32 GetDC(/* (BOOL) */Int32 Discard, /* (*(HDC)) */ref IntPtr phdc);
    /* (HRESULT) */Int32 ReleaseDC(/* (*(RECT)) */ref RECT pDirtyRect);
}

[ComImport, Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
public interface IDXGIAdapter: IDXGIObject {
    /* (HRESULT) */Int32 EnumOutputs(/* (UINT) */UInt32 Output, /* (*(*(IDXGIOutput))) */ref IDXGIOutput ppOutput);
    /* (HRESULT) */Int32 GetDesc(/* (*(DXGI_ADAPTER_DESC)) */ref DXGI_ADAPTER_DESC pDesc);
    /* (HRESULT) */Int32 CheckInterfaceSupport(/* (&(const GUID)) */ref Guid InterfaceName, /* (*(LARGE_INTEGER)) */ref Int64 pUMDVersion);
}

[ComImport, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
public interface IDXGIOutput: IDXGIObject {
    /* (HRESULT) */Int32 GetDesc(/* (*(DXGI_OUTPUT_DESC)) */ref DXGI_OUTPUT_DESC pDesc);
    /* (HRESULT) */Int32 GetDisplayModeList(/* (DXGI_FORMAT) */DXGI_FORMAT EnumFormat, /* (UINT) */UInt32 Flags, /* (*(UINT)) */ref UInt32 pNumModes, /* (*(DXGI_MODE_DESC)) */ref DXGI_MODE_DESC pDesc);
    /* (HRESULT) */Int32 FindClosestMatchingMode(/* (*(const DXGI_MODE_DESC)) */ref DXGI_MODE_DESC pModeToMatch, /* (*(DXGI_MODE_DESC)) */ref DXGI_MODE_DESC pClosestMatch, /* (*(IUnknown)) */IntPtr pConcernedDevice);
    /* (HRESULT) */Int32 WaitForVBlank();
    /* (HRESULT) */Int32 TakeOwnership(/* (*(IUnknown)) */IntPtr pDevice, /* (BOOL) */Int32 Exclusive);
    /* (void) */void ReleaseOwnership();
    /* (HRESULT) */Int32 GetGammaControlCapabilities(/* (*(DXGI_GAMMA_CONTROL_CAPABILITIES)) */ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
    /* (HRESULT) */Int32 SetGammaControl(/* (*(const DXGI_GAMMA_CONTROL)) */ref DXGI_GAMMA_CONTROL pArray);
    /* (HRESULT) */Int32 GetGammaControl(/* (*(DXGI_GAMMA_CONTROL)) */ref DXGI_GAMMA_CONTROL pArray);
    /* (HRESULT) */Int32 SetDisplaySurface(/* (*(IDXGISurface)) */IDXGISurface pScanoutSurface);
    /* (HRESULT) */Int32 GetDisplaySurfaceData(/* (*(IDXGISurface)) */IDXGISurface pDestination);
    /* (HRESULT) */Int32 GetFrameStatistics(/* (*(DXGI_FRAME_STATISTICS)) */ref DXGI_FRAME_STATISTICS pStats);
}

[ComImport, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public interface IDXGISwapChain: IDXGIDeviceSubObject {
    /* (HRESULT) */Int32 Present(/* (UINT) */UInt32 SyncInterval, /* (UINT) */UInt32 Flags);
    /* (HRESULT) */Int32 GetBuffer(/* (UINT) */UInt32 Buffer, /* (&(const IID)) */ref Guid riid, /* (*(*(void))) */ref IntPtr ppSurface);
    /* (HRESULT) */Int32 SetFullscreenState(/* (BOOL) */Int32 Fullscreen, /* (*(IDXGIOutput)) */IDXGIOutput pTarget);
    /* (HRESULT) */Int32 GetFullscreenState(/* (*(BOOL)) */ref Int32 pFullscreen, /* (*(*(IDXGIOutput))) */ref IDXGIOutput ppTarget);
    /* (HRESULT) */Int32 GetDesc(/* (*(DXGI_SWAP_CHAIN_DESC)) */ref DXGI_SWAP_CHAIN_DESC pDesc);
    /* (HRESULT) */Int32 ResizeBuffers(/* (UINT) */UInt32 BufferCount, /* (UINT) */UInt32 Width, /* (UINT) */UInt32 Height, /* (DXGI_FORMAT) */DXGI_FORMAT NewFormat, /* (UINT) */UInt32 SwapChainFlags);
    /* (HRESULT) */Int32 ResizeTarget(/* (*(const DXGI_MODE_DESC)) */ref DXGI_MODE_DESC pNewTargetParameters);
    /* (HRESULT) */Int32 GetContainingOutput(/* (*(*(IDXGIOutput))) */ref IDXGIOutput ppOutput);
    /* (HRESULT) */Int32 GetFrameStatistics(/* (*(DXGI_FRAME_STATISTICS)) */ref DXGI_FRAME_STATISTICS pStats);
    /* (HRESULT) */Int32 GetLastPresentCount(/* (*(UINT)) */ref UInt32 pLastPresentCount);
}

[ComImport, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public interface IDXGIFactory: IDXGIObject {
    /* (HRESULT) */Int32 EnumAdapters(/* (UINT) */UInt32 Adapter, /* (*(*(IDXGIAdapter))) */ref IDXGIAdapter ppAdapter);
    /* (HRESULT) */Int32 MakeWindowAssociation(/* (HWND) */IntPtr WindowHandle, /* (UINT) */UInt32 Flags);
    /* (HRESULT) */Int32 GetWindowAssociation(/* (*(HWND)) */ref IntPtr pWindowHandle);
    /* (HRESULT) */Int32 CreateSwapChain(/* (*(IUnknown)) */IntPtr pDevice, /* (*(DXGI_SWAP_CHAIN_DESC)) */ref DXGI_SWAP_CHAIN_DESC pDesc, /* (*(*(IDXGISwapChain))) */ref IDXGISwapChain ppSwapChain);
    /* (HRESULT) */Int32 CreateSoftwareAdapter(/* (HMODULE) */IntPtr Module, /* (*(*(IDXGIAdapter))) */ref IDXGIAdapter ppAdapter);
}

[ComImport, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
public interface IDXGIDevice: IDXGIObject {
    /* (HRESULT) */Int32 GetAdapter(/* (*(*(IDXGIAdapter))) */ref IDXGIAdapter pAdapter);
    /* (HRESULT) */Int32 CreateSurface(/* (*(const DXGI_SURFACE_DESC)) */ref DXGI_SURFACE_DESC pDesc, /* (UINT) */UInt32 NumSurfaces, /* (DXGI_USAGE) */DXGI_USAGE Usage, /* (*(const DXGI_SHARED_RESOURCE)) */ref DXGI_SHARED_RESOURCE pSharedResource, /* (*(*(IDXGISurface))) */ref IDXGISurface ppSurface);
    /* (HRESULT) */Int32 QueryResourceResidency(/* (*(const *(IUnknown))) */IntPtr ppResources, /* (*(DXGI_RESIDENCY)) */ref DXGI_RESIDENCY pResidencyStatus, /* (UINT) */UInt32 NumResources);
    /* (HRESULT) */Int32 SetGPUThreadPriority(/* (INT) */Int32 Priority);
    /* (HRESULT) */Int32 GetGPUThreadPriority(/* (*(INT)) */ref Int32 pPriority);
}

public enum DXGI_ADAPTER_FLAG {
    NONE = 0x00000000,
    REMOTE = 0x00000001,
    SOFTWARE = 0x00000002,
    FORCE_DWORD = -0x0000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC1{
    /* (WCHAR)[128] */[MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)]public string Description;
    /* (UINT) */UInt32 VendorId;
    /* (UINT) */UInt32 DeviceId;
    /* (UINT) */UInt32 SubSysId;
    /* (UINT) */UInt32 Revision;
    /* (SIZE_T) */UIntPtr DedicatedVideoMemory;
    /* (SIZE_T) */UIntPtr DedicatedSystemMemory;
    /* (SIZE_T) */UIntPtr SharedSystemMemory;
    /* (LUID) */Guid AdapterLuid;
    /* (UINT) */UInt32 Flags;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_DISPLAY_COLOR_SPACE{
    /* (FLOAT)[8][2] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=8 * 2)]public Single[] PrimaryCoordinates;
    /* (FLOAT)[16][2] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=16 * 2)]public Single[] WhitePoints;
}

[ComImport, Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
public interface IDXGIFactory1: IDXGIFactory {
    /* (HRESULT) */Int32 EnumAdapters1(/* (UINT) */UInt32 Adapter, /* (*(*(IDXGIAdapter1))) */ref IDXGIAdapter1 ppAdapter);
    /* (BOOL) */Int32 IsCurrent();
}

[ComImport, Guid("29038f61-3839-4626-91fd-086879011a05")]
public interface IDXGIAdapter1: IDXGIAdapter {
    /* (HRESULT) */Int32 GetDesc1(/* (*(DXGI_ADAPTER_DESC1)) */ref DXGI_ADAPTER_DESC1 pDesc);
}

[ComImport, Guid("77db970f-6276-48ba-ba28-070143b4392c")]
public interface IDXGIDevice1: IDXGIDevice {
    /* (HRESULT) */Int32 SetMaximumFrameLatency(/* (UINT) */UInt32 MaxLatency);
    /* (HRESULT) */Int32 GetMaximumFrameLatency(/* (*(UINT)) */ref UInt32 pMaxLatency);
}

public static class dxgi{
[DllImport("DXGI.dll")]
public static extern /* (HRESULT) */Int32 CreateDXGIFactory(/* (&(const IID)) */ref Guid riid, /* (*(*(void))) */ref IntPtr ppFactory);

[DllImport("DXGI.dll")]
public static extern /* (HRESULT) */Int32 CreateDXGIFactory1(/* (&(const IID)) */ref Guid riid, /* (*(*(void))) */ref IntPtr ppFactory);

}
}
