/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11Texture2D: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Texture2D>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_TEXTURE2D_DESC pDesc);
}
}
