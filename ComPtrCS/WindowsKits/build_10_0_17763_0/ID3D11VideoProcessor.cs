/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3D11VideoProcessor: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoProcessor>.Value;
    public void GetContentDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetContentDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContentDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetContentDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc);
    public void GetRateConversionCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetRateConversionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRateConversionCapsFunc));
        callback(Self, ref pCaps);
    }
    delegate void GetRateConversionCapsFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
}
}
