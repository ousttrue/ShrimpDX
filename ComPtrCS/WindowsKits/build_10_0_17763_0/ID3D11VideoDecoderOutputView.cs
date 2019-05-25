/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID3D11VideoDecoderOutputView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("c2931aea-2a85-4f20-860f-fba1fd256e18");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoDecoderOutputView>.Value;
    public void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
}
}
