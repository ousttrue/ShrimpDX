/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11RenderTargetView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("dfdba067-0b8d-4865-875b-d7b4516cc164");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11RenderTargetView>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_RENDER_TARGET_VIEW_DESC))
        ref D3D11_RENDER_TARGET_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_RENDER_TARGET_VIEW_DESC pDesc);
}
}
