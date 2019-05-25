/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDXGIOutput1: IDXGIOutput {

    static /*readonly*/ Guid s_uuid = new Guid("00cddea8-939b-4b83-a340-a685226666cc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIOutput1>.Value;
    public HRESULT GetDisplayModeList1(
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
    delegate HRESULT GetDisplayModeList1Func(IntPtr self, DXGI_FORMAT EnumFormat, UInt32 Flags, ref UInt32 pNumModes, ref DXGI_MODE_DESC1 pDesc);
    public HRESULT FindClosestMatchingMode1(
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
    delegate HRESULT FindClosestMatchingMode1Func(IntPtr self, ref DXGI_MODE_DESC1 pModeToMatch, ref DXGI_MODE_DESC1 pClosestMatch, IntPtr pConcernedDevice);
    public HRESULT GetDisplaySurfaceData1(
        /// pDestination: (*(IDXGIResource))
        IntPtr pDestination
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetDisplaySurfaceData1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceData1Func));
        return callback(Self, pDestination);
    }
    delegate HRESULT GetDisplaySurfaceData1Func(IntPtr self, IntPtr pDestination);
    public HRESULT DuplicateOutput(
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
    delegate HRESULT DuplicateOutputFunc(IntPtr self, IntPtr pDevice, ref IntPtr ppOutputDuplication);
}
}
