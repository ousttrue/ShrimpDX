/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11DepthStencilState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11DepthStencilState>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_DEPTH_STENCIL_DESC pDesc);
}
}
