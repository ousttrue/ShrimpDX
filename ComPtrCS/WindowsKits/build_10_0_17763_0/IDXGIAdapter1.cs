/// dxgi.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDXGIAdapter1: IDXGIAdapter {

    static /*readonly*/ Guid s_uuid = new Guid("29038f61-3839-4626-91fd-086879011a05");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIAdapter1>.Value;
    public HRESULT GetDesc1(
        /// pDesc: (*(DXGI_ADAPTER_DESC1))
        ref DXGI_ADAPTER_DESC1 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDesc1Func(IntPtr self, ref DXGI_ADAPTER_DESC1 pDesc);
}
}
