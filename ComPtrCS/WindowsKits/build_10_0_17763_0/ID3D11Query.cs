/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11Query: ID3D11Asynchronous {

    static /*readonly*/ Guid s_uuid = new Guid("d6c00747-87b7-425e-b84d-44d108560afd");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Query>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_QUERY_DESC pDesc);
}
}
