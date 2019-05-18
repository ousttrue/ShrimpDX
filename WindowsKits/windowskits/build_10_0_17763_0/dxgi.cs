
using System;
using System.Runtime.InteropServices;
using WindowsKits;

namespace WindowsKits.build_10_0_17763_0
{

    public struct DXGI_USAGE
    {
        public UInt32 Value;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_FRAME_STATISTICS
    {
        public UInt32 PresentCount;
        public UInt32 PresentRefreshCount;
        public UInt32 SyncRefreshCount;
        public Int64 SyncQPCTime;
        public Int64 SyncGPUTime;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_MAPPED_RECT
    {
        public Int32 Pitch;
        public /* Byte * */IntPtr pBits;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_ADAPTER_DESC
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Description;
        public UInt32 VendorId;
        public UInt32 DeviceId;
        public UInt32 SubSysId;
        public UInt32 Revision;
        public UIntPtr DedicatedVideoMemory;
        public UIntPtr DedicatedSystemMemory;
        public UIntPtr SharedSystemMemory;
        public Guid AdapterLuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_OUTPUT_DESC
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public RECT DesktopCoordinates;
        public Int32 AttachedToDesktop;
        public DXGI_MODE_ROTATION Rotation;
        public IntPtr Monitor;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_SHARED_RESOURCE
    {
        public IntPtr Handle;
    }

    public enum DXGI_RESIDENCY
    {
        FULLY_RESIDENT = 0x00000001,
        RESIDENT_IN_SHARED_MEMORY = 0x00000002,
        EVICTED_TO_DISK = 0x00000003,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_SURFACE_DESC
    {
        public UInt32 Width;
        public UInt32 Height;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
    }

    public enum DXGI_SWAP_EFFECT
    {
        DISCARD = 0x00000000,
        SEQUENTIAL = 0x00000001,
        FLIP_SEQUENTIAL = 0x00000003,
        FLIP_DISCARD = 0x00000004,
    }

    public enum DXGI_SWAP_CHAIN_FLAG
    {
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

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_SWAP_CHAIN_DESC
    {
        public DXGI_MODE_DESC BufferDesc;
        public DXGI_SAMPLE_DESC SampleDesc;
        public DXGI_USAGE BufferUsage;
        public UInt32 BufferCount;
        public IntPtr OutputWindow;
        public Int32 Windowed;
        public DXGI_SWAP_EFFECT SwapEffect;
        public UInt32 Flags;
    }

    [ComImport, Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIObject
    {
        Int32 SetPrivateData(ref Guid Name, UInt32 DataSize, IntPtr pData);
        Int32 SetPrivateDataInterface(ref Guid Name, /* IUnknown* */IntPtr pUnknown);
        Int32 GetPrivateData(ref Guid Name, ref UInt32 pDataSize, IntPtr pData);
        Int32 GetParent(ref Guid riid, ref IntPtr ppParent);
    }

    [ComImport, Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
    public interface IDXGIDeviceSubObject : IDXGIObject
    {
        Int32 GetDevice(ref Guid riid, ref IntPtr ppDevice);
    }

    [ComImport, Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
    public interface IDXGIResource : IDXGIDeviceSubObject
    {
        Int32 GetSharedHandle(IntPtr pSharedHandle);
        Int32 GetUsage(ref DXGI_USAGE pUsage);
        Int32 SetEvictionPriority(UInt32 EvictionPriority);
        Int32 GetEvictionPriority(ref UInt32 pEvictionPriority);
    }

    [ComImport, Guid("9d8e1289-d7b3-465f-8126-250e349af85d")]
    public interface IDXGIKeyedMutex : IDXGIDeviceSubObject
    {
        Int32 AcquireSync(UInt64 Key, UInt32 dwMilliseconds);
        Int32 ReleaseSync(UInt64 Key);
    }

    [ComImport, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
    public interface IDXGISurface : IDXGIDeviceSubObject
    {
        Int32 GetDesc(ref DXGI_SURFACE_DESC pDesc);
        Int32 Map(ref DXGI_MAPPED_RECT pLockedRect, UInt32 MapFlags);
        Int32 Unmap();
    }

    [ComImport, Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86")]
    public interface IDXGISurface1 : IDXGISurface
    {
        Int32 GetDC(Int32 Discard, IntPtr phdc);
        Int32 ReleaseDC(ref RECT pDirtyRect);
    }

    [ComImport, Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
    public interface IDXGIAdapter : IDXGIObject
    {
        Int32 EnumOutputs(UInt32 Output, ref IDXGIOutput ppOutput);
        Int32 GetDesc(ref DXGI_ADAPTER_DESC pDesc);
        Int32 CheckInterfaceSupport(ref Guid InterfaceName, Int64 pUMDVersion);
    }

    [ComImport, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
    public interface IDXGIOutput : IDXGIObject
    {
        Int32 GetDesc(ref DXGI_OUTPUT_DESC pDesc);
        Int32 GetDisplayModeList(DXGI_FORMAT EnumFormat, UInt32 Flags, ref UInt32 pNumModes, ref DXGI_MODE_DESC pDesc);
        Int32 FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, ref DXGI_MODE_DESC pClosestMatch, /* IUnknown* */IntPtr pConcernedDevice);
        Int32 WaitForVBlank();
        Int32 TakeOwnership(/* IUnknown* */IntPtr pDevice, Int32 Exclusive);
        void ReleaseOwnership();
        Int32 GetGammaControlCapabilities(ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
        Int32 SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);
        Int32 GetGammaControl(ref DXGI_GAMMA_CONTROL pArray);
        Int32 SetDisplaySurface(IDXGISurface pScanoutSurface);
        Int32 GetDisplaySurfaceData(IDXGISurface pDestination);
        Int32 GetFrameStatistics(ref DXGI_FRAME_STATISTICS pStats);
    }

    [ComImport, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
    public interface IDXGISwapChain : IDXGIDeviceSubObject
    {
        Int32 Present(UInt32 SyncInterval, UInt32 Flags);
        Int32 GetBuffer(UInt32 Buffer, ref Guid riid, ref IntPtr ppSurface);
        Int32 SetFullscreenState(Int32 Fullscreen, IDXGIOutput pTarget);
        Int32 GetFullscreenState(Int32 pFullscreen, ref IDXGIOutput ppTarget);
        Int32 GetDesc(ref DXGI_SWAP_CHAIN_DESC pDesc);
        Int32 ResizeBuffers(UInt32 BufferCount, UInt32 Width, UInt32 Height, DXGI_FORMAT NewFormat, UInt32 SwapChainFlags);
        Int32 ResizeTarget(ref DXGI_MODE_DESC pNewTargetParameters);
        Int32 GetContainingOutput(ref IDXGIOutput ppOutput);
        Int32 GetFrameStatistics(ref DXGI_FRAME_STATISTICS pStats);
        Int32 GetLastPresentCount(ref UInt32 pLastPresentCount);
    }

    [ComImport, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
    public interface IDXGIFactory : IDXGIObject
    {
        Int32 EnumAdapters(UInt32 Adapter, ref IDXGIAdapter ppAdapter);
        Int32 MakeWindowAssociation(IntPtr WindowHandle, UInt32 Flags);
        Int32 GetWindowAssociation(IntPtr pWindowHandle);
        Int32 CreateSwapChain(/* IUnknown* */IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, ref IDXGISwapChain ppSwapChain);
        Int32 CreateSoftwareAdapter(IntPtr Module, ref IDXGIAdapter ppAdapter);
    }

    [ComImport, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
    public interface IDXGIDevice : IDXGIObject
    {
        Int32 GetAdapter(ref IDXGIAdapter pAdapter);
        Int32 CreateSurface(ref DXGI_SURFACE_DESC pDesc, UInt32 NumSurfaces, DXGI_USAGE Usage, ref DXGI_SHARED_RESOURCE pSharedResource, ref IDXGISurface ppSurface);
        Int32 QueryResourceResidency(/* IUnknown* */IntPtr ppResources, ref DXGI_RESIDENCY pResidencyStatus, UInt32 NumResources);
        Int32 SetGPUThreadPriority(Int32 Priority);
        Int32 GetGPUThreadPriority(Int32 pPriority);
    }

    public enum DXGI_ADAPTER_FLAG
    {
        NONE = 0x00000000,
        REMOTE = 0x00000001,
        SOFTWARE = 0x00000002,
        FORCE_DWORD = -0x0000001,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_ADAPTER_DESC1
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string Description;
        public UInt32 VendorId;
        public UInt32 DeviceId;
        public UInt32 SubSysId;
        public UInt32 Revision;
        public UIntPtr DedicatedVideoMemory;
        public UIntPtr DedicatedSystemMemory;
        public UIntPtr SharedSystemMemory;
        public Guid AdapterLuid;
        public UInt32 Flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_DISPLAY_COLOR_SPACE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public Single[] PrimaryCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Single[] WhitePoints;
    }

    [ComImport, Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
    public interface IDXGIFactory1 : IDXGIFactory
    {
        Int32 EnumAdapters1(UInt32 Adapter, ref IDXGIAdapter1 ppAdapter);
        Int32 IsCurrent();
    }

    [ComImport, Guid("29038f61-3839-4626-91fd-086879011a05")]
    public interface IDXGIAdapter1 : IDXGIAdapter
    {
        Int32 GetDesc1(ref DXGI_ADAPTER_DESC1 pDesc);
    }

    [ComImport, Guid("77db970f-6276-48ba-ba28-070143b4392c")]
    public interface IDXGIDevice1 : IDXGIDevice
    {
        Int32 SetMaximumFrameLatency(UInt32 MaxLatency);
        Int32 GetMaximumFrameLatency(ref UInt32 pMaxLatency);
    }

    public static class dxgi
    {
        [DllImport("DXGI.dll")]
        public static extern Int32 CreateDXGIFactory(ref Guid riid, ref IntPtr ppFactory);

        [DllImport("DXGI.dll")]
        public static extern Int32 CreateDXGIFactory1(ref Guid riid, ref IntPtr ppFactory);

    }
}
