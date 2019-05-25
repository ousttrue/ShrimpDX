/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class IDXGIFactory: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIFactory>.Value;
    public HRESULT EnumAdapters(
        /// Adapter: (UINT)
        UInt32 Adapter
        /// ppAdapter: (*(*(IDXGIAdapter)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (EnumAdaptersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdaptersFunc));
        return callback(Self, Adapter, ref ppAdapter);
    }
    delegate HRESULT EnumAdaptersFunc(IntPtr self, UInt32 Adapter, ref IntPtr ppAdapter);
    public HRESULT MakeWindowAssociation(
        /// WindowHandle: (HWND)
        IntPtr WindowHandle
        /// Flags: (UINT)
        , UInt32 Flags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (MakeWindowAssociationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MakeWindowAssociationFunc));
        return callback(Self, WindowHandle, Flags);
    }
    delegate HRESULT MakeWindowAssociationFunc(IntPtr self, IntPtr WindowHandle, UInt32 Flags);
    public HRESULT GetWindowAssociation(
        /// pWindowHandle: (*(HWND))
        ref IntPtr pWindowHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetWindowAssociationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWindowAssociationFunc));
        return callback(Self, ref pWindowHandle);
    }
    delegate HRESULT GetWindowAssociationFunc(IntPtr self, ref IntPtr pWindowHandle);
    public HRESULT CreateSwapChain(
        /// pDevice: (*(IUnknown))
        IntPtr pDevice
        /// pDesc: (*(DXGI_SWAP_CHAIN_DESC))
        , ref DXGI_SWAP_CHAIN_DESC pDesc
        /// ppSwapChain: (*(*(IDXGISwapChain)))
        , ref IntPtr ppSwapChain
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateSwapChainFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainFunc));
        return callback(Self, pDevice, ref pDesc, ref ppSwapChain);
    }
    delegate HRESULT CreateSwapChainFunc(IntPtr self, IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC pDesc, ref IntPtr ppSwapChain);
    public HRESULT CreateSoftwareAdapter(
        /// Module: (HMODULE)
        IntPtr Module
        /// ppAdapter: (*(*(IDXGIAdapter)))
        , ref IntPtr ppAdapter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateSoftwareAdapterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSoftwareAdapterFunc));
        return callback(Self, Module, ref ppAdapter);
    }
    delegate HRESULT CreateSoftwareAdapterFunc(IntPtr self, IntPtr Module, ref IntPtr ppAdapter);
}
}
