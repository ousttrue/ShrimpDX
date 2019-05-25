/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=11)]
public class IDXGIFactory2: IDXGIFactory1 {

    static /*readonly*/ Guid s_uuid = new Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIFactory2>.Value;
    public Int32 IsWindowedStereoEnabled(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (IsWindowedStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsWindowedStereoEnabledFunc));
        return callback(Self);
    }
    delegate Int32 IsWindowedStereoEnabledFunc(IntPtr self);
    public HRESULT CreateSwapChainForHwnd(
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
    delegate HRESULT CreateSwapChainForHwndFunc(IntPtr self, IntPtr pDevice, IntPtr hWnd, ref DXGI_SWAP_CHAIN_DESC1 pDesc, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
    public HRESULT CreateSwapChainForCoreWindow(
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
    delegate HRESULT CreateSwapChainForCoreWindowFunc(IntPtr self, IntPtr pDevice, IntPtr pWindow, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
    public HRESULT GetSharedResourceAdapterLuid(
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
    delegate HRESULT GetSharedResourceAdapterLuidFunc(IntPtr self, IntPtr hResource, ref Guid pLuid);
    public HRESULT RegisterStereoStatusWindow(
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
    delegate HRESULT RegisterStereoStatusWindowFunc(IntPtr self, IntPtr WindowHandle, UInt32 wMsg, ref UInt32 pdwCookie);
    public HRESULT RegisterStereoStatusEvent(
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
    delegate HRESULT RegisterStereoStatusEventFunc(IntPtr self, IntPtr hEvent, ref UInt32 pdwCookie);
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
    public HRESULT RegisterOcclusionStatusWindow(
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
    delegate HRESULT RegisterOcclusionStatusWindowFunc(IntPtr self, IntPtr WindowHandle, UInt32 wMsg, ref UInt32 pdwCookie);
    public HRESULT RegisterOcclusionStatusEvent(
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
    delegate HRESULT RegisterOcclusionStatusEventFunc(IntPtr self, IntPtr hEvent, ref UInt32 pdwCookie);
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
    public HRESULT CreateSwapChainForComposition(
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
    delegate HRESULT CreateSwapChainForCompositionFunc(IntPtr self, IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
}
}
