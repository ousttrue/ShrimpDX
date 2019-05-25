/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11VideoProcessorOutputView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("a048285e-25a9-4527-bd93-d68b68c44254");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoProcessorOutputView>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc);
}
}
