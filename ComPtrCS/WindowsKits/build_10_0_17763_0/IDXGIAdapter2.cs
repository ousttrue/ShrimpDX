/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class IDXGIAdapter2: IDXGIAdapter1 {

    static /*readonly*/ Guid s_uuid = new Guid("0aa1ae0a-fa0e-4b84-8644-e05ff8e5acb5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDXGIAdapter2>.Value;
    public HRESULT GetDesc2(
        /// pDesc: (*(DXGI_ADAPTER_DESC2))
        ref DXGI_ADAPTER_DESC2 pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDesc2Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc2Func));
        return callback(Self, ref pDesc);
    }
    delegate HRESULT GetDesc2Func(IntPtr self, ref DXGI_ADAPTER_DESC2 pDesc);
}
}
