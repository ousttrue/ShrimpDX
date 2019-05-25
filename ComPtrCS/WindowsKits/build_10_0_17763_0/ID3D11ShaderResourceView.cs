/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11ShaderResourceView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11ShaderResourceView>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_SHADER_RESOURCE_VIEW_DESC))
        ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
}
}
