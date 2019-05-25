/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDXGIAdapter: IDXGIObject {

    static /*readonly*/ Guid s_uuid = new Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIAdapter>.Value;
    public HRESULT EnumOutputs(
        /// Output: (UINT)
        UInt32 Output
        /// ppOutput: (*(*(IDXGIOutput)))
        , ref IntPtr ppOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (EnumOutputsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumOutputsFunc));
        return callback(Self, Output, ref ppOutput);
    }
    delegate HRESULT EnumOutputsFunc(IntPtr self, UInt32 Output, ref IntPtr ppOutput);
    public HRESULT GetDesc(
        /// pDesc: (*(DXGI_ADAPTER_DESC))
        ref DXGI_ADAPTER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDescFunc(IntPtr self, ref DXGI_ADAPTER_DESC pDesc);
    public HRESULT CheckInterfaceSupport(
        /// InterfaceName: (&(const GUID))
        ref Guid InterfaceName
        /// pUMDVersion: (*(LARGE_INTEGER))
        , IntPtr pUMDVersion
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CheckInterfaceSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckInterfaceSupportFunc));
        return callback(Self, ref InterfaceName, pUMDVersion);
    }
    delegate HRESULT CheckInterfaceSupportFunc(IntPtr self, ref Guid InterfaceName, IntPtr pUMDVersion);
}
}
