/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=12)]
public class IDXGIOutput: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIOutput>.Value;
    public HRESULT GetDesc(
        /// pDesc: (*(DXGI_OUTPUT_DESC))
        ref DXGI_OUTPUT_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDescFunc(IntPtr self, ref DXGI_OUTPUT_DESC pDesc);
    public HRESULT GetDisplayModeList(
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
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDisplayModeListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayModeListFunc));
        return callback(Self, EnumFormat, Flags, ref pNumModes, ref pDesc);
    }
    delegate HRESULT GetDisplayModeListFunc(IntPtr self, DXGI_FORMAT EnumFormat, UInt32 Flags, ref UInt32 pNumModes, ref DXGI_MODE_DESC pDesc);
    public HRESULT FindClosestMatchingMode(
        /// pModeToMatch: (*(const DXGI_MODE_DESC))
        ref DXGI_MODE_DESC pModeToMatch
        /// pClosestMatch: (*(DXGI_MODE_DESC))
        , ref DXGI_MODE_DESC pClosestMatch
        /// pConcernedDevice: (*(IUnknown))
        , IntPtr pConcernedDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (FindClosestMatchingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindClosestMatchingModeFunc));
        return callback(Self, ref pModeToMatch, ref pClosestMatch, pConcernedDevice);
    }
    delegate HRESULT FindClosestMatchingModeFunc(IntPtr self, ref DXGI_MODE_DESC pModeToMatch, ref DXGI_MODE_DESC pClosestMatch, IntPtr pConcernedDevice);
    public HRESULT WaitForVBlank(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (WaitForVBlankFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WaitForVBlankFunc));
        return callback(Self);
    }
    delegate HRESULT WaitForVBlankFunc(IntPtr self);
    public HRESULT TakeOwnership(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// Exclusive: (BOOL)
        , Int32 Exclusive
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (TakeOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TakeOwnershipFunc));
        return callback(Self, pDevice, Exclusive);
    }
    delegate HRESULT TakeOwnershipFunc(IntPtr self, IntPtr pDevice, Int32 Exclusive);
    public void ReleaseOwnership(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (ReleaseOwnershipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseOwnershipFunc));
        callback(Self);
    }
    delegate void ReleaseOwnershipFunc(IntPtr self);
    public HRESULT GetGammaControlCapabilities(
        /// pGammaCaps: (*(DXGI_GAMMA_CONTROL_CAPABILITIES))
        ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetGammaControlCapabilitiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlCapabilitiesFunc));
        return callback(Self, ref pGammaCaps);
    }
    delegate HRESULT GetGammaControlCapabilitiesFunc(IntPtr self, ref DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
    public HRESULT SetGammaControl(
        /// pArray: (*(const DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (SetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGammaControlFunc));
        return callback(Self, ref pArray);
    }
    delegate HRESULT SetGammaControlFunc(IntPtr self, ref DXGI_GAMMA_CONTROL pArray);
    public HRESULT GetGammaControl(
        /// pArray: (*(DXGI_GAMMA_CONTROL))
        ref DXGI_GAMMA_CONTROL pArray
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetGammaControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGammaControlFunc));
        return callback(Self, ref pArray);
    }
    delegate HRESULT GetGammaControlFunc(IntPtr self, ref DXGI_GAMMA_CONTROL pArray);
    public HRESULT SetDisplaySurface(
        /// pScanoutSurface: (*(IDXGISurface))
        IntPtr pScanoutSurface
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (SetDisplaySurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDisplaySurfaceFunc));
        return callback(Self, pScanoutSurface);
    }
    delegate HRESULT SetDisplaySurfaceFunc(IntPtr self, IntPtr pScanoutSurface);
    public HRESULT GetDisplaySurfaceData(
        /// pDestination: (*(IDXGISurface))
        IntPtr pDestination
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetDisplaySurfaceDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceDataFunc));
        return callback(Self, pDestination);
    }
    delegate HRESULT GetDisplaySurfaceDataFunc(IntPtr self, IntPtr pDestination);
    public HRESULT GetFrameStatistics(
        /// pStats: (*(DXGI_FRAME_STATISTICS))
        ref DXGI_FRAME_STATISTICS pStats
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
        return callback(Self, ref pStats);
    }
    delegate HRESULT GetFrameStatisticsFunc(IntPtr self, ref DXGI_FRAME_STATISTICS pStats);
}
}
