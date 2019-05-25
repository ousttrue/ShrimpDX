/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11RasterizerState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11RasterizerState>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_RASTERIZER_DESC pDesc);
}
}
