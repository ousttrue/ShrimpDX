/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11Buffer: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("48570b85-d1ee-4fcd-a250-eb350722b037");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Buffer>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_BUFFER_DESC pDesc);
}
}
