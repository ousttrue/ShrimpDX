/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=17)]
public class ID3D11VideoDevice : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoDevice>.Value;
    public HRESULT CreateVideoDecoder(
        /// pVideoDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc
        /// pConfig: (*(const D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
        /// ppDecoder: (*(*(ID3D11VideoDecoder)))
        , ref IntPtr ppDecoder
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateVideoDecoderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoDecoderFunc));
        return callback(Self, ref pVideoDesc, ref pConfig, ref ppDecoder);
    }
    delegate HRESULT CreateVideoDecoderFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pVideoDesc, ref D3D11_VIDEO_DECODER_CONFIG pConfig, ref IntPtr ppDecoder);
    public HRESULT CreateVideoProcessor(
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        IntPtr pEnum
        /// RateConversionIndex: (UINT)
        , UInt32 RateConversionIndex
        /// ppVideoProcessor: (*(*(ID3D11VideoProcessor)))
        , ref IntPtr ppVideoProcessor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateVideoProcessorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorFunc));
        return callback(Self, pEnum, RateConversionIndex, ref ppVideoProcessor);
    }
    delegate HRESULT CreateVideoProcessorFunc(IntPtr self, IntPtr pEnum, UInt32 RateConversionIndex, ref IntPtr ppVideoProcessor);
    public HRESULT CreateAuthenticatedChannel(
        /// ChannelType: (D3D11_AUTHENTICATED_CHANNEL_TYPE)
        D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType
        /// ppAuthenticatedChannel: (*(*(ID3D11AuthenticatedChannel)))
        , ref IntPtr ppAuthenticatedChannel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateAuthenticatedChannelFunc));
        return callback(Self, ChannelType, ref ppAuthenticatedChannel);
    }
    delegate HRESULT CreateAuthenticatedChannelFunc(IntPtr self, D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ref IntPtr ppAuthenticatedChannel);
    public HRESULT CreateCryptoSession(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// pKeyExchangeType: (*(const GUID))
        , ref Guid pKeyExchangeType
        /// ppCryptoSession: (*(*(ID3D11CryptoSession)))
        , ref IntPtr ppCryptoSession
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateCryptoSessionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCryptoSessionFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, ref ppCryptoSession);
    }
    delegate HRESULT CreateCryptoSessionFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref IntPtr ppCryptoSession);
    public HRESULT CreateVideoDecoderOutputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        , ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc
        /// ppVDOVView: (*(*(ID3D11VideoDecoderOutputView)))
        , ref IntPtr ppVDOVView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateVideoDecoderOutputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoDecoderOutputViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppVDOVView);
    }
    delegate HRESULT CreateVideoDecoderOutputViewFunc(IntPtr self, IntPtr pResource, ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, ref IntPtr ppVDOVView);
    public HRESULT CreateVideoProcessorInputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        , IntPtr pEnum
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC))
        , ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc
        /// ppVPIView: (*(*(ID3D11VideoProcessorInputView)))
        , ref IntPtr ppVPIView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateVideoProcessorInputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorInputViewFunc));
        return callback(Self, pResource, pEnum, ref pDesc, ref ppVPIView);
    }
    delegate HRESULT CreateVideoProcessorInputViewFunc(IntPtr self, IntPtr pResource, IntPtr pEnum, ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, ref IntPtr ppVPIView);
    public HRESULT CreateVideoProcessorOutputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        , IntPtr pEnum
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        , ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc
        /// ppVPOView: (*(*(ID3D11VideoProcessorOutputView)))
        , ref IntPtr ppVPOView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateVideoProcessorOutputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorOutputViewFunc));
        return callback(Self, pResource, pEnum, ref pDesc, ref ppVPOView);
    }
    delegate HRESULT CreateVideoProcessorOutputViewFunc(IntPtr self, IntPtr pResource, IntPtr pEnum, ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, ref IntPtr ppVPOView);
    public HRESULT CreateVideoProcessorEnumerator(
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc
        /// ppEnum: (*(*(ID3D11VideoProcessorEnumerator)))
        , ref IntPtr ppEnum
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreateVideoProcessorEnumeratorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorEnumeratorFunc));
        return callback(Self, ref pDesc, ref ppEnum);
    }
    delegate HRESULT CreateVideoProcessorEnumeratorFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, ref IntPtr ppEnum);
    public UInt32 GetVideoDecoderProfileCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetVideoDecoderProfileCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderProfileCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetVideoDecoderProfileCountFunc(IntPtr self);
    public HRESULT GetVideoDecoderProfile(
        /// Index: (UINT)
        UInt32 Index
        /// pDecoderProfile: (*(GUID))
        , ref Guid pDecoderProfile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetVideoDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderProfileFunc));
        return callback(Self, Index, ref pDecoderProfile);
    }
    delegate HRESULT GetVideoDecoderProfileFunc(IntPtr self, UInt32 Index, ref Guid pDecoderProfile);
    public HRESULT CheckVideoDecoderFormat(
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
        /// pSupported: (*(BOOL))
        , IntPtr pSupported
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CheckVideoDecoderFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckVideoDecoderFormatFunc));
        return callback(Self, ref pDecoderProfile, Format, pSupported);
    }
    delegate HRESULT CheckVideoDecoderFormatFunc(IntPtr self, ref Guid pDecoderProfile, DXGI_FORMAT Format, IntPtr pSupported);
    public HRESULT GetVideoDecoderConfigCount(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc
        /// pCount: (*(UINT))
        , ref UInt32 pCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (GetVideoDecoderConfigCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderConfigCountFunc));
        return callback(Self, ref pDesc, ref pCount);
    }
    delegate HRESULT GetVideoDecoderConfigCountFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pDesc, ref UInt32 pCount);
    public HRESULT GetVideoDecoderConfig(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc
        /// Index: (UINT)
        , UInt32 Index
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (GetVideoDecoderConfigFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderConfigFunc));
        return callback(Self, ref pDesc, Index, ref pConfig);
    }
    delegate HRESULT GetVideoDecoderConfigFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pDesc, UInt32 Index, ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    public HRESULT GetContentProtectionCaps(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// pCaps: (*(D3D11_VIDEO_CONTENT_PROTECTION_CAPS))
        , ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (GetContentProtectionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContentProtectionCapsFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, ref pCaps);
    }
    delegate HRESULT GetContentProtectionCapsFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
    public HRESULT CheckCryptoKeyExchange(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// Index: (UINT)
        , UInt32 Index
        /// pKeyExchangeType: (*(GUID))
        , ref Guid pKeyExchangeType
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (CheckCryptoKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCryptoKeyExchangeFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, Index, ref pKeyExchangeType);
    }
    delegate HRESULT CheckCryptoKeyExchangeFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, UInt32 Index, ref Guid pKeyExchangeType);
    public HRESULT SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate HRESULT SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public HRESULT SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate HRESULT SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
}
}
