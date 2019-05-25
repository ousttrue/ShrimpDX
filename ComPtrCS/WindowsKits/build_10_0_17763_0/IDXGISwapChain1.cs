/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=11)]
public class IDXGISwapChain1: IDXGISwapChain {

    static /*readonly*/ Guid s_uuid = new Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGISwapChain1>.Value;
    public HRESULT GetDesc1(
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC1))
        ref DXGI_SWAP_CHAIN_DESC1 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDesc1Func(IntPtr self, ref DXGI_SWAP_CHAIN_DESC1 pDesc);
    public HRESULT GetFullscreenDesc(
        /// pDesc: (*(DXGI_SWAP_CHAIN_FULLSCREEN_DESC))
        ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFullscreenDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetFullscreenDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
    public HRESULT GetHwnd(
        /// pHwnd: (*(HWND))
        ref IntPtr pHwnd
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
        return callback(Self, ref pHwnd);
    }
    delegate HRESULT GetHwndFunc(IntPtr self, ref IntPtr pHwnd);
    public HRESULT GetCoreWindow(
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
    delegate HRESULT GetCoreWindowFunc(IntPtr self, ref Guid refiid, ref IntPtr ppUnk);
    public HRESULT Present1(
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
    delegate HRESULT Present1Func(IntPtr self, UInt32 SyncInterval, UInt32 PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);
    public Int32 IsTemporaryMonoSupported(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (IsTemporaryMonoSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsTemporaryMonoSupportedFunc));
        return callback(Self);
    }
    delegate Int32 IsTemporaryMonoSupportedFunc(IntPtr self);
    public HRESULT GetRestrictToOutput(
        /// ppRestrictToOutput: (*(*(IDXGIOutput)))
        ref IntPtr ppRestrictToOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetRestrictToOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRestrictToOutputFunc));
        return callback(Self, ref ppRestrictToOutput);
    }
    delegate HRESULT GetRestrictToOutputFunc(IntPtr self, ref IntPtr ppRestrictToOutput);
    public HRESULT SetBackgroundColor(
        /// pColor: (*(const DXGI_RGBA))
        ref DXGI_RGBA pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBackgroundColorFunc));
        return callback(Self, ref pColor);
    }
    delegate HRESULT SetBackgroundColorFunc(IntPtr self, ref DXGI_RGBA pColor);
    public HRESULT GetBackgroundColor(
        /// pColor: (*(DXGI_RGBA))
        ref DXGI_RGBA pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackgroundColorFunc));
        return callback(Self, ref pColor);
    }
    delegate HRESULT GetBackgroundColorFunc(IntPtr self, ref DXGI_RGBA pColor);
    public HRESULT SetRotation(
        /// Rotation: (DXGI_MODE_ROTATION)
        DXGI_MODE_ROTATION Rotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (SetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRotationFunc));
        return callback(Self, Rotation);
    }
    delegate HRESULT SetRotationFunc(IntPtr self, DXGI_MODE_ROTATION Rotation);
    public HRESULT GetRotation(
        /// pRotation: (*(DXGI_MODE_ROTATION))
        ref DXGI_MODE_ROTATION pRotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRotationFunc));
        return callback(Self, ref pRotation);
    }
    delegate HRESULT GetRotationFunc(IntPtr self, ref DXGI_MODE_ROTATION pRotation);
}
}
