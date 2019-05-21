
    using System;
    using System.Runtime.InteropServices;
    using System.Numerics;

    namespace WindowsKits.build_10_0_17763_0 {

public class IDXGIDisplayControl : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<IDXGIDisplayControl>.Value;
    public Int32 IsStereoEnabled(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsStereoEnabledFunc));
        return callback(Self);
    }
    delegate Int32 IsStereoEnabledFunc(IntPtr self);
    public void SetStereoEnabled(
        /// enabled: (BOOL)
        Int32 enabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStereoEnabledFunc));
        callback(Self, enabled);
    }
    delegate void SetStereoEnabledFunc(IntPtr self, Int32 enabled);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_MOVE_RECT{
    /// (POINT)
    public POINT SourcePoint;

    /// (RECT)
    public RECT DestinationRect;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_DESC{
    /// (DXGI_MODE_DESC)
    public DXGI_MODE_DESC ModeDesc;

    /// (DXGI_MODE_ROTATION)
    public DXGI_MODE_ROTATION Rotation;

    /// (BOOL)
    public Int32 DesktopImageInSystemMemory;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_POINTER_POSITION{
    /// (POINT)
    public POINT Position;

    /// (BOOL)
    public Int32 Visible;

}

public enum DXGI_OUTDUPL_POINTER_SHAPE_TYPE {
    MONOCHROME = 0x00000001,
    COLOR = 0x00000002,
    MASKED_COLOR = 0x00000004,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_POINTER_SHAPE_INFO{
    /// (UINT)
    public UInt32 Type;

    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 Pitch;

    /// (POINT)
    public POINT HotSpot;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_FRAME_INFO{
    /// (LARGE_INTEGER)
    public Int64 LastPresentTime;

    /// (LARGE_INTEGER)
    public Int64 LastMouseUpdateTime;

    /// (UINT)
    public UInt32 AccumulatedFrames;

    /// (BOOL)
    public Int32 RectsCoalesced;

    /// (BOOL)
    public Int32 ProtectedContentMaskedOut;

    /// (DXGI_OUTDUPL_POINTER_POSITION)
    public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;

    /// (UINT)
    public UInt32 TotalMetadataBufferSize;

    /// (UINT)
    public UInt32 PointerShapeBufferSize;

}

public class IDXGIOutputDuplication: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("191cfac3-a341-470d-b26e-a864f428319c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 8;
    int VTableIndexBase => VTableIndexBase<IDXGIOutputDuplication>.Value;
    public void GetDesc(
        /// pDesc: (*(DXGI_OUTDUPL_DESC))
        ref DXGI_OUTDUPL_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref DXGI_OUTDUPL_DESC pDesc);
    public Int32 AcquireNextFrame(
        /// TimeoutInMilliseconds: (UINT)
        UInt32 TimeoutInMilliseconds
        /// pFrameInfo: (*(DXGI_OUTDUPL_FRAME_INFO))
        , ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo
        /// ppDesktopResource: (*(*(IDXGIResource)))
        , ref IntPtr ppDesktopResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (AcquireNextFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireNextFrameFunc));
        return callback(Self, TimeoutInMilliseconds, ref pFrameInfo, ref ppDesktopResource);
    }
    delegate Int32 AcquireNextFrameFunc(IntPtr self, UInt32 TimeoutInMilliseconds, ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo, ref IntPtr ppDesktopResource);
    public Int32 GetFrameDirtyRects(
        /// DirtyRectsBufferSize: (UINT)
        UInt32 DirtyRectsBufferSize
        /// pDirtyRectsBuffer: (*(RECT))
        , ref RECT pDirtyRectsBuffer
        /// pDirtyRectsBufferSizeRequired: (*(UINT))
        , ref UInt32 pDirtyRectsBufferSizeRequired
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFrameDirtyRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameDirtyRectsFunc));
        return callback(Self, DirtyRectsBufferSize, ref pDirtyRectsBuffer, ref pDirtyRectsBufferSizeRequired);
    }
    delegate Int32 GetFrameDirtyRectsFunc(IntPtr self, UInt32 DirtyRectsBufferSize, ref RECT pDirtyRectsBuffer, ref UInt32 pDirtyRectsBufferSizeRequired);
    public Int32 GetFrameMoveRects(
        /// MoveRectsBufferSize: (UINT)
        UInt32 MoveRectsBufferSize
        /// pMoveRectBuffer: (*(DXGI_OUTDUPL_MOVE_RECT))
        , ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer
        /// pMoveRectsBufferSizeRequired: (*(UINT))
        , ref UInt32 pMoveRectsBufferSizeRequired
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFrameMoveRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameMoveRectsFunc));
        return callback(Self, MoveRectsBufferSize, ref pMoveRectBuffer, ref pMoveRectsBufferSizeRequired);
    }
    delegate Int32 GetFrameMoveRectsFunc(IntPtr self, UInt32 MoveRectsBufferSize, ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer, ref UInt32 pMoveRectsBufferSizeRequired);
    public Int32 GetFramePointerShape(
        /// PointerShapeBufferSize: (UINT)
        UInt32 PointerShapeBufferSize
        /// pPointerShapeBuffer: (*(void))
        , IntPtr pPointerShapeBuffer
        /// pPointerShapeBufferSizeRequired: (*(UINT))
        , ref UInt32 pPointerShapeBufferSizeRequired
        /// pPointerShapeInfo: (*(DXGI_OUTDUPL_POINTER_SHAPE_INFO))
        , ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetFramePointerShapeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFramePointerShapeFunc));
        return callback(Self, PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired, ref pPointerShapeInfo);
    }
    delegate Int32 GetFramePointerShapeFunc(IntPtr self, UInt32 PointerShapeBufferSize, IntPtr pPointerShapeBuffer, ref UInt32 pPointerShapeBufferSizeRequired, ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);
    public Int32 MapDesktopSurface(
        /// pLockedRect: (*(DXGI_MAPPED_RECT))
        ref DXGI_MAPPED_RECT pLockedRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (MapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapDesktopSurfaceFunc));
        return callback(Self, ref pLockedRect);
    }
    delegate Int32 MapDesktopSurfaceFunc(IntPtr self, ref DXGI_MAPPED_RECT pLockedRect);
    public Int32 UnMapDesktopSurface(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (UnMapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnMapDesktopSurfaceFunc));
        return callback(Self);
    }
    delegate Int32 UnMapDesktopSurfaceFunc(IntPtr self);
    public Int32 ReleaseFrame(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (ReleaseFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFrameFunc));
        return callback(Self);
    }
    delegate Int32 ReleaseFrameFunc(IntPtr self);
}

public enum DXGI_ALPHA_MODE {
    UNSPECIFIED = 0x00000000,
    PREMULTIPLIED = 0x00000001,
    STRAIGHT = 0x00000002,
    IGNORE = 0x00000003,
    FORCE_DWORD = -0x0000001,
}

public class IDXGISurface2: IDXGISurface1 {

    static /*readonly*/ Guid s_uuid = new Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<IDXGISurface2>.Value;
    public Int32 GetResource(
        /// riid: (&(const IID))
        ref Guid riid
        /// ppParentResource: (*(*(void)))
        , ref IntPtr ppParentResource
        /// pSubresourceIndex: (*(UINT))
        , ref UInt32 pSubresourceIndex
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
        return callback(Self, ref riid, ref ppParentResource, ref pSubresourceIndex);
    }
    delegate Int32 GetResourceFunc(IntPtr self, ref Guid riid, ref IntPtr ppParentResource, ref UInt32 pSubresourceIndex);
}

public class IDXGIResource1: IDXGIResource {

    static /*readonly*/ Guid s_uuid = new Guid("30961379-4609-4a41-998e-54fe567ee0c1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    int VTableIndexBase => VTableIndexBase<IDXGIResource1>.Value;
    public Int32 CreateSubresourceSurface(
        /// index: (UINT)
        UInt32 index
        /// ppSurface: (*(*(IDXGISurface2)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateSubresourceSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSubresourceSurfaceFunc));
        return callback(Self, index, ref ppSurface);
    }
    delegate Int32 CreateSubresourceSurfaceFunc(IntPtr self, UInt32 index, ref IntPtr ppSurface);
    public Int32 CreateSharedHandle(
        /// pAttributes: (*(const SECURITY_ATTRIBUTES))
        ref SECURITY_ATTRIBUTES pAttributes
        /// dwAccess: (DWORD)
        , UInt32 dwAccess
        /// lpName: (LPCWSTR)
        , IntPtr lpName
        /// pHandle: (*(HANDLE))
        , ref IntPtr pHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSharedHandleFunc));
        return callback(Self, ref pAttributes, dwAccess, lpName, ref pHandle);
    }
    delegate Int32 CreateSharedHandleFunc(IntPtr self, ref SECURITY_ATTRIBUTES pAttributes, UInt32 dwAccess, IntPtr lpName, ref IntPtr pHandle);
}

public enum _DXGI_OFFER_RESOURCE_PRIORITY {
    DXGI_OFFER_RESOURCE_PRIORITY_LOW = 0x00000001,
    DXGI_OFFER_RESOURCE_PRIORITY_NORMAL = 0x00000002,
    DXGI_OFFER_RESOURCE_PRIORITY_HIGH = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OFFER_RESOURCE_PRIORITY{
    public _DXGI_OFFER_RESOURCE_PRIORITY Value;
}

public class IDXGIDevice2: IDXGIDevice1 {

    static /*readonly*/ Guid s_uuid = new Guid("05008617-fbfd-4051-a790-144884b4f6a9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    int VTableIndexBase => VTableIndexBase<IDXGIDevice2>.Value;
    public Int32 OfferResources(
        /// NumResources: (UINT)
        UInt32 NumResources
        /// ppResources: (*(const *(IDXGIResource)))
        , ref IntPtr ppResources
        /// Priority: (DXGI_OFFER_RESOURCE_PRIORITY)
        , DXGI_OFFER_RESOURCE_PRIORITY Priority
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (OfferResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OfferResourcesFunc));
        return callback(Self, NumResources, ref ppResources, Priority);
    }
    delegate Int32 OfferResourcesFunc(IntPtr self, UInt32 NumResources, ref IntPtr ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);
    public Int32 ReclaimResources(
        /// NumResources: (UINT)
        UInt32 NumResources
        /// ppResources: (*(const *(IDXGIResource)))
        , ref IntPtr ppResources
        /// pDiscarded: (*(BOOL))
        , IntPtr pDiscarded
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReclaimResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReclaimResourcesFunc));
        return callback(Self, NumResources, ref ppResources, pDiscarded);
    }
    delegate Int32 ReclaimResourcesFunc(IntPtr self, UInt32 NumResources, ref IntPtr ppResources, IntPtr pDiscarded);
    public Int32 EnqueueSetEvent(
        /// hEvent: (HANDLE)
        IntPtr hEvent
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (EnqueueSetEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnqueueSetEventFunc));
        return callback(Self, hEvent);
    }
    delegate Int32 EnqueueSetEventFunc(IntPtr self, IntPtr hEvent);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MODE_DESC1{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL RefreshRate;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (DXGI_MODE_SCANLINE_ORDER)
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

    /// (DXGI_MODE_SCALING)
    public DXGI_MODE_SCALING Scaling;

    /// (BOOL)
    public Int32 Stereo;

}

public enum DXGI_SCALING {
    STRETCH = 0x00000000,
    NONE = 0x00000001,
    ASPECT_RATIO_STRETCH = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SWAP_CHAIN_DESC1{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (BOOL)
    public Int32 Stereo;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (DXGI_USAGE)
    public DXGI_USAGE BufferUsage;

    /// (UINT)
    public UInt32 BufferCount;

    /// (DXGI_SCALING)
    public DXGI_SCALING Scaling;

    /// (DXGI_SWAP_EFFECT)
    public DXGI_SWAP_EFFECT SwapEffect;

    /// (DXGI_ALPHA_MODE)
    public DXGI_ALPHA_MODE AlphaMode;

    /// (UINT)
    public UInt32 Flags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_SWAP_CHAIN_FULLSCREEN_DESC{
    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL RefreshRate;

    /// (DXGI_MODE_SCANLINE_ORDER)
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

    /// (DXGI_MODE_SCALING)
    public DXGI_MODE_SCALING Scaling;

    /// (BOOL)
    public Int32 Windowed;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_PRESENT_PARAMETERS{
    /// (UINT)
    public UInt32 DirtyRectsCount;

    /// (*(RECT))
    public IntPtr pDirtyRects;

    /// (*(RECT))
    public IntPtr pScrollRect;

    /// (*(POINT))
    public IntPtr pScrollOffset;

}

public class IDXGISwapChain1: IDXGISwapChain {

    static /*readonly*/ Guid s_uuid = new Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 11;
    int VTableIndexBase => VTableIndexBase<IDXGISwapChain1>.Value;
    public Int32 GetDesc1(
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC1))
        ref DXGI_SWAP_CHAIN_DESC1 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDesc1Func(IntPtr self, ref DXGI_SWAP_CHAIN_DESC1 pDesc);
    public Int32 GetFullscreenDesc(
        /// pDesc: (*(DXGI_SWAP_CHAIN_FULLSCREEN_DESC))
        ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFullscreenDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetFullscreenDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
    public Int32 GetHwnd(
        /// pHwnd: (*(HWND))
        ref IntPtr pHwnd
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
        return callback(Self, ref pHwnd);
    }
    delegate Int32 GetHwndFunc(IntPtr self, ref IntPtr pHwnd);
    public Int32 GetCoreWindow(
        /// refiid: (&(const IID))
        ref Guid refiid
        /// ppUnk: (*(*(void)))
        , ref IntPtr ppUnk
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetCoreWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCoreWindowFunc));
        return callback(Self, ref refiid, ref ppUnk);
    }
    delegate Int32 GetCoreWindowFunc(IntPtr self, ref Guid refiid, ref IntPtr ppUnk);
    public Int32 Present1(
        /// SyncInterval: (UINT)
        UInt32 SyncInterval
        /// PresentFlags: (UINT)
        , UInt32 PresentFlags
        /// pPresentParameters: (*(const DXGI_PRESENT_PARAMETERS))
        , ref DXGI_PRESENT_PARAMETERS pPresentParameters
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (Present1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(Present1Func));
        return callback(Self, SyncInterval, PresentFlags, ref pPresentParameters);
    }
    delegate Int32 Present1Func(IntPtr self, UInt32 SyncInterval, UInt32 PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);
    public Int32 IsTemporaryMonoSupported(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (IsTemporaryMonoSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsTemporaryMonoSupportedFunc));
        return callback(Self);
    }
    delegate Int32 IsTemporaryMonoSupportedFunc(IntPtr self);
    public Int32 GetRestrictToOutput(
        /// ppRestrictToOutput: (*(*(IDXGIOutput)))
        ref IntPtr ppRestrictToOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetRestrictToOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRestrictToOutputFunc));
        return callback(Self, ref ppRestrictToOutput);
    }
    delegate Int32 GetRestrictToOutputFunc(IntPtr self, ref IntPtr ppRestrictToOutput);
    public Int32 SetBackgroundColor(
        /// pColor: (*(const DXGI_RGBA))
        ref DXGI_RGBA pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBackgroundColorFunc));
        return callback(Self, ref pColor);
    }
    delegate Int32 SetBackgroundColorFunc(IntPtr self, ref DXGI_RGBA pColor);
    public Int32 GetBackgroundColor(
        /// pColor: (*(DXGI_RGBA))
        ref DXGI_RGBA pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackgroundColorFunc));
        return callback(Self, ref pColor);
    }
    delegate Int32 GetBackgroundColorFunc(IntPtr self, ref DXGI_RGBA pColor);
    public Int32 SetRotation(
        /// Rotation: (DXGI_MODE_ROTATION)
        DXGI_MODE_ROTATION Rotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (SetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRotationFunc));
        return callback(Self, Rotation);
    }
    delegate Int32 SetRotationFunc(IntPtr self, DXGI_MODE_ROTATION Rotation);
    public Int32 GetRotation(
        /// pRotation: (*(DXGI_MODE_ROTATION))
        ref DXGI_MODE_ROTATION pRotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRotationFunc));
        return callback(Self, ref pRotation);
    }
    delegate Int32 GetRotationFunc(IntPtr self, ref DXGI_MODE_ROTATION pRotation);
}

public class IDXGIFactory2: IDXGIFactory1 {

    static /*readonly*/ Guid s_uuid = new Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 11;
    int VTableIndexBase => VTableIndexBase<IDXGIFactory2>.Value;
    public Int32 IsWindowedStereoEnabled(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsWindowedStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsWindowedStereoEnabledFunc));
        return callback(Self);
    }
    delegate Int32 IsWindowedStereoEnabledFunc(IntPtr self);
    public Int32 CreateSwapChainForHwnd(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// hWnd: (HWND)
        , IntPtr hWnd
        /// pDesc: (*(const DXGI_SWAP_CHAIN_DESC1))
        , ref DXGI_SWAP_CHAIN_DESC1 pDesc
        /// pFullscreenDesc: (*(const DXGI_SWAP_CHAIN_FULLSCREEN_DESC))
        , ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc
        /// pRestrictToOutput: (*(IDXGIOutput))
        , IntPtr pRestrictToOutput
        /// ppSwapChain: (*(*(IDXGISwapChain1)))
        , ref IntPtr ppSwapChain
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateSwapChainForHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForHwndFunc));
        return callback(Self, pDevice, hWnd, ref pDesc, ref pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }
    delegate Int32 CreateSwapChainForHwndFunc(IntPtr self, IntPtr pDevice, IntPtr hWnd, ref DXGI_SWAP_CHAIN_DESC1 pDesc, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
    public Int32 CreateSwapChainForCoreWindow(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// pWindow: (*(IUnknown))
        , IntPtr pWindow
        /// pDesc: (*(const DXGI_SWAP_CHAIN_DESC1))
        , ref DXGI_SWAP_CHAIN_DESC1 pDesc
        /// pRestrictToOutput: (*(IDXGIOutput))
        , IntPtr pRestrictToOutput
        /// ppSwapChain: (*(*(IDXGISwapChain1)))
        , ref IntPtr ppSwapChain
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateSwapChainForCoreWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForCoreWindowFunc));
        return callback(Self, pDevice, pWindow, ref pDesc, pRestrictToOutput, ref ppSwapChain);
    }
    delegate Int32 CreateSwapChainForCoreWindowFunc(IntPtr self, IntPtr pDevice, IntPtr pWindow, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
    public Int32 GetSharedResourceAdapterLuid(
        /// hResource: (HANDLE)
        IntPtr hResource
        /// pLuid: (*(LUID))
        , ref Guid pLuid
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetSharedResourceAdapterLuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSharedResourceAdapterLuidFunc));
        return callback(Self, hResource, ref pLuid);
    }
    delegate Int32 GetSharedResourceAdapterLuidFunc(IntPtr self, IntPtr hResource, ref Guid pLuid);
    public Int32 RegisterStereoStatusWindow(
        /// WindowHandle: (HWND)
        IntPtr WindowHandle
        /// wMsg: (UINT)
        , UInt32 wMsg
        /// pdwCookie: (*(DWORD))
        , ref UInt32 pdwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (RegisterStereoStatusWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterStereoStatusWindowFunc));
        return callback(Self, WindowHandle, wMsg, ref pdwCookie);
    }
    delegate Int32 RegisterStereoStatusWindowFunc(IntPtr self, IntPtr WindowHandle, UInt32 wMsg, ref UInt32 pdwCookie);
    public Int32 RegisterStereoStatusEvent(
        /// hEvent: (HANDLE)
        IntPtr hEvent
        /// pdwCookie: (*(DWORD))
        , ref UInt32 pdwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (RegisterStereoStatusEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterStereoStatusEventFunc));
        return callback(Self, hEvent, ref pdwCookie);
    }
    delegate Int32 RegisterStereoStatusEventFunc(IntPtr self, IntPtr hEvent, ref UInt32 pdwCookie);
    public void UnregisterStereoStatus(
        /// dwCookie: (DWORD)
        UInt32 dwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (UnregisterStereoStatusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterStereoStatusFunc));
        callback(Self, dwCookie);
    }
    delegate void UnregisterStereoStatusFunc(IntPtr self, UInt32 dwCookie);
    public Int32 RegisterOcclusionStatusWindow(
        /// WindowHandle: (HWND)
        IntPtr WindowHandle
        /// wMsg: (UINT)
        , UInt32 wMsg
        /// pdwCookie: (*(DWORD))
        , ref UInt32 pdwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (RegisterOcclusionStatusWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterOcclusionStatusWindowFunc));
        return callback(Self, WindowHandle, wMsg, ref pdwCookie);
    }
    delegate Int32 RegisterOcclusionStatusWindowFunc(IntPtr self, IntPtr WindowHandle, UInt32 wMsg, ref UInt32 pdwCookie);
    public Int32 RegisterOcclusionStatusEvent(
        /// hEvent: (HANDLE)
        IntPtr hEvent
        /// pdwCookie: (*(DWORD))
        , ref UInt32 pdwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (RegisterOcclusionStatusEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterOcclusionStatusEventFunc));
        return callback(Self, hEvent, ref pdwCookie);
    }
    delegate Int32 RegisterOcclusionStatusEventFunc(IntPtr self, IntPtr hEvent, ref UInt32 pdwCookie);
    public void UnregisterOcclusionStatus(
        /// dwCookie: (DWORD)
        UInt32 dwCookie
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (UnregisterOcclusionStatusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterOcclusionStatusFunc));
        callback(Self, dwCookie);
    }
    delegate void UnregisterOcclusionStatusFunc(IntPtr self, UInt32 dwCookie);
    public Int32 CreateSwapChainForComposition(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// pDesc: (*(const DXGI_SWAP_CHAIN_DESC1))
        , ref DXGI_SWAP_CHAIN_DESC1 pDesc
        /// pRestrictToOutput: (*(IDXGIOutput))
        , IntPtr pRestrictToOutput
        /// ppSwapChain: (*(*(IDXGISwapChain1)))
        , ref IntPtr ppSwapChain
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateSwapChainForCompositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForCompositionFunc));
        return callback(Self, pDevice, ref pDesc, pRestrictToOutput, ref ppSwapChain);
    }
    delegate Int32 CreateSwapChainForCompositionFunc(IntPtr self, IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
}

public enum DXGI_GRAPHICS_PREEMPTION_GRANULARITY {
    DXGI_GRAPHICS_PREEMPTION_DMA_BUFFER_BOUNDARY = 0x00000000,
    DXGI_GRAPHICS_PREEMPTION_PRIMITIVE_BOUNDARY = 0x00000001,
    DXGI_GRAPHICS_PREEMPTION_TRIANGLE_BOUNDARY = 0x00000002,
    DXGI_GRAPHICS_PREEMPTION_PIXEL_BOUNDARY = 0x00000003,
    DXGI_GRAPHICS_PREEMPTION_INSTRUCTION_BOUNDARY = 0x00000004,
}

public enum DXGI_COMPUTE_PREEMPTION_GRANULARITY {
    DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY = 0x00000000,
    DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY = 0x00000001,
    DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY = 0x00000002,
    DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY = 0x00000003,
    DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY = 0x00000004,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_ADAPTER_DESC2{
    /// (WCHAR)[128]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]
    public Char[] Description;

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

    /// (DXGI_GRAPHICS_PREEMPTION_GRANULARITY)
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

    /// (DXGI_COMPUTE_PREEMPTION_GRANULARITY)
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;

}

public class IDXGIAdapter2: IDXGIAdapter1 {

    static /*readonly*/ Guid s_uuid = new Guid("0aa1ae0a-fa0e-4b84-8644-e05ff8e5acb5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    int VTableIndexBase => VTableIndexBase<IDXGIAdapter2>.Value;
    public Int32 GetDesc2(
        /// pDesc: (*(DXGI_ADAPTER_DESC2))
        ref DXGI_ADAPTER_DESC2 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDesc2Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc2Func));
        return callback(Self, ref pDesc);
    }
    delegate Int32 GetDesc2Func(IntPtr self, ref DXGI_ADAPTER_DESC2 pDesc);
}

public class IDXGIOutput1: IDXGIOutput {

    static /*readonly*/ Guid s_uuid = new Guid("00cddea8-939b-4b83-a340-a685226666cc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    int VTableIndexBase => VTableIndexBase<IDXGIOutput1>.Value;
    public Int32 GetDisplayModeList1(
        /// EnumFormat: (DXGI_FORMAT)
        DXGI_FORMAT EnumFormat
        /// Flags: (UINT)
        , UInt32 Flags
        /// pNumModes: (*(UINT))
        , ref UInt32 pNumModes
        /// pDesc: (*(DXGI_MODE_DESC1))
        , ref DXGI_MODE_DESC1 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDisplayModeList1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayModeList1Func));
        return callback(Self, EnumFormat, Flags, ref pNumModes, ref pDesc);
    }
    delegate Int32 GetDisplayModeList1Func(IntPtr self, DXGI_FORMAT EnumFormat, UInt32 Flags, ref UInt32 pNumModes, ref DXGI_MODE_DESC1 pDesc);
    public Int32 FindClosestMatchingMode1(
        /// pModeToMatch: (*(const DXGI_MODE_DESC1))
        ref DXGI_MODE_DESC1 pModeToMatch
        /// pClosestMatch: (*(DXGI_MODE_DESC1))
        , ref DXGI_MODE_DESC1 pClosestMatch
        /// pConcernedDevice: (*(IUnknown))
        , IntPtr pConcernedDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (FindClosestMatchingMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindClosestMatchingMode1Func));
        return callback(Self, ref pModeToMatch, ref pClosestMatch, pConcernedDevice);
    }
    delegate Int32 FindClosestMatchingMode1Func(IntPtr self, ref DXGI_MODE_DESC1 pModeToMatch, ref DXGI_MODE_DESC1 pClosestMatch, IntPtr pConcernedDevice);
    public Int32 GetDisplaySurfaceData1(
        /// pDestination: (*(IDXGIResource))
        IntPtr pDestination
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetDisplaySurfaceData1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceData1Func));
        return callback(Self, pDestination);
    }
    delegate Int32 GetDisplaySurfaceData1Func(IntPtr self, IntPtr pDestination);
    public Int32 DuplicateOutput(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// ppOutputDuplication: (*(*(IDXGIOutputDuplication)))
        , ref IntPtr ppOutputDuplication
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (DuplicateOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DuplicateOutputFunc));
        return callback(Self, pDevice, ref ppOutputDuplication);
    }
    delegate Int32 DuplicateOutputFunc(IntPtr self, IntPtr pDevice, ref IntPtr ppOutputDuplication);
}

}
