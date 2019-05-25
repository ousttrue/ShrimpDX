/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID3D11VideoDecoder: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoDecoder>.Value;
    public HRESULT GetCreationParameters(
        /// pVideoDesc: (*(D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetCreationParametersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationParametersFunc));
        return callback(Self, ref pVideoDesc, ref pConfig);
    }
    delegate HRESULT GetCreationParametersFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pVideoDesc, ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    public HRESULT GetDriverHandle(
        /// pDriverHandle: (*(HANDLE))
        ref IntPtr pDriverHandle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDriverHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDriverHandleFunc));
        return callback(Self, ref pDriverHandle);
    }
    delegate HRESULT GetDriverHandleFunc(IntPtr self, ref IntPtr pDriverHandle);
}
}
