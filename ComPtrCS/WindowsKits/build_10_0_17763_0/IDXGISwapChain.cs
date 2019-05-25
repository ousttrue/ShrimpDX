/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=10)]
public class IDXGISwapChain: IDXGIDeviceSubObject {

    static /*readonly*/ Guid s_uuid = new Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGISwapChain>.Value;
    public HRESULT Present(
        /// SyncInterval: (UINT)
        UInt32 SyncInterval
        /// Flags: (UINT)
        , UInt32 Flags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (PresentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PresentFunc));
        return callback(Self, SyncInterval, Flags);
    }
    delegate HRESULT PresentFunc(IntPtr self, UInt32 SyncInterval, UInt32 Flags);
    public HRESULT GetBuffer(
        /// Buffer: (UINT)
        UInt32 Buffer
        /// riid: (&(const IID))
        , ref Guid riid
        /// ppSurface: (*(*(void)))
        , ref IntPtr ppSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
        return callback(Self, Buffer, ref riid, ref ppSurface);
    }
    delegate HRESULT GetBufferFunc(IntPtr self, UInt32 Buffer, ref Guid riid, ref IntPtr ppSurface);
    public HRESULT SetFullscreenState(
        /// Fullscreen: (BOOL)
        Int32 Fullscreen
        /// pTarget: (*(IDXGIOutput))
        , IntPtr pTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFullscreenStateFunc));
        return callback(Self, Fullscreen, pTarget);
    }
    delegate HRESULT SetFullscreenStateFunc(IntPtr self, Int32 Fullscreen, IntPtr pTarget);
    public HRESULT GetFullscreenState(
        /// pFullscreen: (*(BOOL))
        IntPtr pFullscreen
        /// ppTarget: (*(*(IDXGIOutput)))
        , ref IntPtr ppTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenStateFunc));
        return callback(Self, pFullscreen, ref ppTarget);
    }
    delegate HRESULT GetFullscreenStateFunc(IntPtr self, IntPtr pFullscreen, ref IntPtr ppTarget);
    public HRESULT GetDesc(
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        ref DXGI_SWAP_CHAIN_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_DESC pDesc);
    public HRESULT ResizeBuffers(
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
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (ResizeBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBuffersFunc));
        return callback(Self, BufferCount, Width, Height, NewFormat, SwapChainFlags);
    }
    delegate HRESULT ResizeBuffersFunc(IntPtr self, UInt32 BufferCount, UInt32 Width, UInt32 Height, DXGI_FORMAT NewFormat, UInt32 SwapChainFlags);
    public HRESULT ResizeTarget(
        /// pNewTargetParameters: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pNewTargetParameters
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (ResizeTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeTargetFunc));
        return callback(Self, ref pNewTargetParameters);
    }
    delegate HRESULT ResizeTargetFunc(IntPtr self, ref DXGI_MODE_DESC pNewTargetParameters);
    public HRESULT GetContainingOutput(
        /// ppOutput: (*(*(IDXGIOutput)))
        ref IntPtr ppOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetContainingOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainingOutputFunc));
        return callback(Self, ref ppOutput);
    }
    delegate HRESULT GetContainingOutputFunc(IntPtr self, ref IntPtr ppOutput);
    public HRESULT GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
        return callback(Self, ref pStats);
    }
    delegate HRESULT GetFrameStatisticsFunc(IntPtr self, ref DXGI_FRAME_STATISTICS pStats);
    public HRESULT GetLastPresentCount(
        /// pLastPresentCount: (*(UINT))
        ref UInt32 pLastPresentCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetLastPresentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastPresentCountFunc));
        return callback(Self, ref pLastPresentCount);
    }
    delegate HRESULT GetLastPresentCountFunc(IntPtr self, ref UInt32 pLastPresentCount);
}
}
