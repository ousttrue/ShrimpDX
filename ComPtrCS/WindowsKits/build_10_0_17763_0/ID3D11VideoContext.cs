/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=58)]
public class ID3D11VideoContext: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoContext>.Value;
    public HRESULT GetDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        , D3D11_VIDEO_DECODER_BUFFER_TYPE Type
        /// pBufferSize: (*(UINT))
        , ref UInt32 pBufferSize
        /// ppBuffer: (*(*(void)))
        , ref IntPtr ppBuffer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDecoderBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderBufferFunc));
        return callback(Self, pDecoder, Type, ref pBufferSize, ref ppBuffer);
    }
    delegate HRESULT GetDecoderBufferFunc(IntPtr self, IntPtr pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, ref UInt32 pBufferSize, ref IntPtr ppBuffer);
    public HRESULT ReleaseDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        , D3D11_VIDEO_DECODER_BUFFER_TYPE Type
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ReleaseDecoderBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDecoderBufferFunc));
        return callback(Self, pDecoder, Type);
    }
    delegate HRESULT ReleaseDecoderBufferFunc(IntPtr self, IntPtr pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
    public HRESULT DecoderBeginFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// pView: (*(ID3D11VideoDecoderOutputView))
        , IntPtr pView
        /// ContentKeySize: (UINT)
        , UInt32 ContentKeySize
        /// pContentKey: (*(const void))
        , IntPtr pContentKey
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (DecoderBeginFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderBeginFrameFunc));
        return callback(Self, pDecoder, pView, ContentKeySize, pContentKey);
    }
    delegate HRESULT DecoderBeginFrameFunc(IntPtr self, IntPtr pDecoder, IntPtr pView, UInt32 ContentKeySize, IntPtr pContentKey);
    public HRESULT DecoderEndFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (DecoderEndFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderEndFrameFunc));
        return callback(Self, pDecoder);
    }
    delegate HRESULT DecoderEndFrameFunc(IntPtr self, IntPtr pDecoder);
    public HRESULT SubmitDecoderBuffers(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// pBufferDesc: (*(const D3D11_VIDEO_DECODER_BUFFER_DESC))
        , ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SubmitDecoderBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SubmitDecoderBuffersFunc));
        return callback(Self, pDecoder, NumBuffers, ref pBufferDesc);
    }
    delegate HRESULT SubmitDecoderBuffersFunc(IntPtr self, IntPtr pDecoder, UInt32 NumBuffers, ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc);
    public APP_DEPRECATED_HRESULT DecoderExtension(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// pExtensionData: (*(const D3D11_VIDEO_DECODER_EXTENSION))
        , ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (DecoderExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderExtensionFunc));
        return callback(Self, pDecoder, ref pExtensionData);
    }
    delegate APP_DEPRECATED_HRESULT DecoderExtensionFunc(IntPtr self, IntPtr pDecoder, ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
    public void VideoProcessorSetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (VideoProcessorSetOutputTargetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputTargetRectFunc));
        callback(Self, pVideoProcessor, Enable, ref pRect);
    }
    delegate void VideoProcessorSetOutputTargetRectFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// YCbCr: (BOOL)
        , Int32 YCbCr
        /// pColor: (*(const D3D11_VIDEO_COLOR))
        , ref D3D11_VIDEO_COLOR pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (VideoProcessorSetOutputBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputBackgroundColorFunc));
        callback(Self, pVideoProcessor, YCbCr, ref pColor);
    }
    delegate void VideoProcessorSetOutputBackgroundColorFunc(IntPtr self, IntPtr pVideoProcessor, Int32 YCbCr, ref D3D11_VIDEO_COLOR pColor);
    public void VideoProcessorSetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (VideoProcessorSetOutputColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputColorSpaceFunc));
        callback(Self, pVideoProcessor, ref pColorSpace);
    }
    delegate void VideoProcessorSetOutputColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorSetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// AlphaFillMode: (D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE)
        , D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (VideoProcessorSetOutputAlphaFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputAlphaFillModeFunc));
        callback(Self, pVideoProcessor, AlphaFillMode, StreamIndex);
    }
    delegate void VideoProcessorSetOutputAlphaFillModeFunc(IntPtr self, IntPtr pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, UInt32 StreamIndex);
    public void VideoProcessorSetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
        /// Size: (SIZE)
        , SIZE Size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (VideoProcessorSetOutputConstrictionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputConstrictionFunc));
        callback(Self, pVideoProcessor, Enable, Size);
    }
    delegate void VideoProcessorSetOutputConstrictionFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable, SIZE Size);
    public void VideoProcessorSetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (VideoProcessorSetOutputStereoModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputStereoModeFunc));
        callback(Self, pVideoProcessor, Enable);
    }
    delegate void VideoProcessorSetOutputStereoModeFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable);
    public APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (VideoProcessorSetOutputExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputExtensionFunc));
        return callback(Self, pVideoProcessor, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtensionFunc(IntPtr self, IntPtr pVideoProcessor, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorGetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enabled: (*(BOOL))
        , IntPtr Enabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (VideoProcessorGetOutputTargetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputTargetRectFunc));
        callback(Self, pVideoProcessor, Enabled, ref pRect);
    }
    delegate void VideoProcessorGetOutputTargetRectFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr Enabled, ref RECT pRect);
    public void VideoProcessorGetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pYCbCr: (*(BOOL))
        , IntPtr pYCbCr
        /// pColor: (*(D3D11_VIDEO_COLOR))
        , ref D3D11_VIDEO_COLOR pColor
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (VideoProcessorGetOutputBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputBackgroundColorFunc));
        callback(Self, pVideoProcessor, pYCbCr, ref pColor);
    }
    delegate void VideoProcessorGetOutputBackgroundColorFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pYCbCr, ref D3D11_VIDEO_COLOR pColor);
    public void VideoProcessorGetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (VideoProcessorGetOutputColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputColorSpaceFunc));
        callback(Self, pVideoProcessor, ref pColorSpace);
    }
    delegate void VideoProcessorGetOutputColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorGetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pAlphaFillMode: (*(D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE))
        , ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode
        /// pStreamIndex: (*(UINT))
        , ref UInt32 pStreamIndex
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (VideoProcessorGetOutputAlphaFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputAlphaFillModeFunc));
        callback(Self, pVideoProcessor, ref pAlphaFillMode, ref pStreamIndex);
    }
    delegate void VideoProcessorGetOutputAlphaFillModeFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, ref UInt32 pStreamIndex);
    public void VideoProcessorGetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pSize: (*(SIZE))
        , ref SIZE pSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (VideoProcessorGetOutputConstrictionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputConstrictionFunc));
        callback(Self, pVideoProcessor, pEnabled, ref pSize);
    }
    delegate void VideoProcessorGetOutputConstrictionFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pEnabled, ref SIZE pSize);
    public void VideoProcessorGetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (VideoProcessorGetOutputStereoModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputStereoModeFunc));
        callback(Self, pVideoProcessor, pEnabled);
    }
    delegate void VideoProcessorGetOutputStereoModeFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pEnabled);
    public APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (VideoProcessorGetOutputExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputExtensionFunc));
        return callback(Self, pVideoProcessor, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtensionFunc(IntPtr self, IntPtr pVideoProcessor, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorSetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// FrameFormat: (D3D11_VIDEO_FRAME_FORMAT)
        , D3D11_VIDEO_FRAME_FORMAT FrameFormat
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (VideoProcessorSetStreamFrameFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamFrameFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, FrameFormat);
    }
    delegate void VideoProcessorSetStreamFrameFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat);
    public void VideoProcessorSetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (VideoProcessorSetStreamColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamColorSpaceFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pColorSpace);
    }
    delegate void VideoProcessorSetStreamColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorSetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// OutputRate: (D3D11_VIDEO_PROCESSOR_OUTPUT_RATE)
        , D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate
        /// RepeatFrame: (BOOL)
        , Int32 RepeatFrame
        /// pCustomRate: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pCustomRate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (VideoProcessorSetStreamOutputRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamOutputRateFunc));
        callback(Self, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, ref pCustomRate);
    }
    delegate void VideoProcessorSetStreamOutputRateFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, Int32 RepeatFrame, ref DXGI_RATIONAL pCustomRate);
    public void VideoProcessorSetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (VideoProcessorSetStreamSourceRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamSourceRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pRect);
    }
    delegate void VideoProcessorSetStreamSourceRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (VideoProcessorSetStreamDestRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamDestRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pRect);
    }
    delegate void VideoProcessorSetStreamDestRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Alpha: (FLOAT)
        , Single Alpha
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (VideoProcessorSetStreamAlphaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamAlphaFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Alpha);
    }
    delegate void VideoProcessorSetStreamAlphaFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, Single Alpha);
    public void VideoProcessorSetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Count: (UINT)
        , UInt32 Count
        /// pEntries: (*(const UINT))
        , ref UInt32 pEntries
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (VideoProcessorSetStreamPaletteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamPaletteFunc));
        callback(Self, pVideoProcessor, StreamIndex, Count, ref pEntries);
    }
    delegate void VideoProcessorSetStreamPaletteFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, UInt32 Count, ref UInt32 pEntries);
    public void VideoProcessorSetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pSourceAspectRatio: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pSourceAspectRatio
        /// pDestinationAspectRatio: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pDestinationAspectRatio
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (VideoProcessorSetStreamPixelAspectRatioFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamPixelAspectRatioFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pSourceAspectRatio, ref pDestinationAspectRatio);
    }
    delegate void VideoProcessorSetStreamPixelAspectRatioFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref DXGI_RATIONAL pSourceAspectRatio, ref DXGI_RATIONAL pDestinationAspectRatio);
    public void VideoProcessorSetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Lower: (FLOAT)
        , Single Lower
        /// Upper: (FLOAT)
        , Single Upper
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (VideoProcessorSetStreamLumaKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamLumaKeyFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }
    delegate void VideoProcessorSetStreamLumaKeyFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, Single Lower, Single Upper);
    public void VideoProcessorSetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Format: (D3D11_VIDEO_PROCESSOR_STEREO_FORMAT)
        , D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format
        /// LeftViewFrame0: (BOOL)
        , Int32 LeftViewFrame0
        /// BaseViewFrame0: (BOOL)
        , Int32 BaseViewFrame0
        /// FlipMode: (D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE)
        , D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode
        /// MonoOffset: (int)
        , int MonoOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (VideoProcessorSetStreamStereoFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamStereoFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }
    delegate void VideoProcessorSetStreamStereoFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, Int32 LeftViewFrame0, Int32 BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset);
    public void VideoProcessorSetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (VideoProcessorSetStreamAutoProcessingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamAutoProcessingModeFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable);
    }
    delegate void VideoProcessorSetStreamAutoProcessingModeFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable);
    public void VideoProcessorSetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        , D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// Enable: (BOOL)
        , Int32 Enable
        /// Level: (int)
        , int Level
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (VideoProcessorSetStreamFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamFilterFunc));
        callback(Self, pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }
    delegate void VideoProcessorSetStreamFilterFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, Int32 Enable, int Level);
    public APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (VideoProcessorSetStreamExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamExtensionFunc));
        return callback(Self, pVideoProcessor, StreamIndex, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtensionFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorGetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pFrameFormat: (*(D3D11_VIDEO_FRAME_FORMAT))
        , ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (VideoProcessorGetStreamFrameFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamFrameFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pFrameFormat);
    }
    delegate void VideoProcessorGetStreamFrameFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
    public void VideoProcessorGetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (VideoProcessorGetStreamColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamColorSpaceFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pColorSpace);
    }
    delegate void VideoProcessorGetStreamColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorGetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pOutputRate: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_RATE))
        , ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate
        /// pRepeatFrame: (*(BOOL))
        , IntPtr pRepeatFrame
        /// pCustomRate: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pCustomRate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 35);
        var callback = (VideoProcessorGetStreamOutputRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamOutputRateFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pOutputRate, pRepeatFrame, ref pCustomRate);
    }
    delegate void VideoProcessorGetStreamOutputRateFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, IntPtr pRepeatFrame, ref DXGI_RATIONAL pCustomRate);
    public void VideoProcessorGetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 36);
        var callback = (VideoProcessorGetStreamSourceRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamSourceRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pRect);
    }
    delegate void VideoProcessorGetStreamSourceRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref RECT pRect);
    public void VideoProcessorGetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 37);
        var callback = (VideoProcessorGetStreamDestRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamDestRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pRect);
    }
    delegate void VideoProcessorGetStreamDestRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref RECT pRect);
    public void VideoProcessorGetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pAlpha: (*(FLOAT))
        , ref Single pAlpha
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 38);
        var callback = (VideoProcessorGetStreamAlphaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamAlphaFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pAlpha);
    }
    delegate void VideoProcessorGetStreamAlphaFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref Single pAlpha);
    public void VideoProcessorGetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Count: (UINT)
        , UInt32 Count
        /// pEntries: (*(UINT))
        , ref UInt32 pEntries
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 39);
        var callback = (VideoProcessorGetStreamPaletteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamPaletteFunc));
        callback(Self, pVideoProcessor, StreamIndex, Count, ref pEntries);
    }
    delegate void VideoProcessorGetStreamPaletteFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, UInt32 Count, ref UInt32 pEntries);
    public void VideoProcessorGetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pSourceAspectRatio: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pSourceAspectRatio
        /// pDestinationAspectRatio: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pDestinationAspectRatio
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 40);
        var callback = (VideoProcessorGetStreamPixelAspectRatioFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamPixelAspectRatioFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pSourceAspectRatio, ref pDestinationAspectRatio);
    }
    delegate void VideoProcessorGetStreamPixelAspectRatioFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref DXGI_RATIONAL pSourceAspectRatio, ref DXGI_RATIONAL pDestinationAspectRatio);
    public void VideoProcessorGetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pLower: (*(FLOAT))
        , ref Single pLower
        /// pUpper: (*(FLOAT))
        , ref Single pUpper
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 41);
        var callback = (VideoProcessorGetStreamLumaKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamLumaKeyFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pLower, ref pUpper);
    }
    delegate void VideoProcessorGetStreamLumaKeyFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref Single pLower, ref Single pUpper);
    public void VideoProcessorGetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnable: (*(BOOL))
        , IntPtr pEnable
        /// pFormat: (*(D3D11_VIDEO_PROCESSOR_STEREO_FORMAT))
        , ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat
        /// pLeftViewFrame0: (*(BOOL))
        , IntPtr pLeftViewFrame0
        /// pBaseViewFrame0: (*(BOOL))
        , IntPtr pBaseViewFrame0
        /// pFlipMode: (*(D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE))
        , ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode
        /// MonoOffset: (*(int))
        , ref int MonoOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 42);
        var callback = (VideoProcessorGetStreamStereoFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamStereoFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
    }
    delegate void VideoProcessorGetStreamStereoFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnable, ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, IntPtr pLeftViewFrame0, IntPtr pBaseViewFrame0, ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, ref int MonoOffset);
    public void VideoProcessorGetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 43);
        var callback = (VideoProcessorGetStreamAutoProcessingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamAutoProcessingModeFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled);
    }
    delegate void VideoProcessorGetStreamAutoProcessingModeFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled);
    public void VideoProcessorGetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        , D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pLevel: (*(int))
        , ref int pLevel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 44);
        var callback = (VideoProcessorGetStreamFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamFilterFunc));
        callback(Self, pVideoProcessor, StreamIndex, Filter, pEnabled, ref pLevel);
    }
    delegate void VideoProcessorGetStreamFilterFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, IntPtr pEnabled, ref int pLevel);
    public APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 45);
        var callback = (VideoProcessorGetStreamExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamExtensionFunc));
        return callback(Self, pVideoProcessor, StreamIndex, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtensionFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public HRESULT VideoProcessorBlt(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pView: (*(ID3D11VideoProcessorOutputView))
        , IntPtr pView
        /// OutputFrame: (UINT)
        , UInt32 OutputFrame
        /// StreamCount: (UINT)
        , UInt32 StreamCount
        /// pStreams: (*(const D3D11_VIDEO_PROCESSOR_STREAM))
        , ref D3D11_VIDEO_PROCESSOR_STREAM pStreams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 46);
        var callback = (VideoProcessorBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorBltFunc));
        return callback(Self, pVideoProcessor, pView, OutputFrame, StreamCount, ref pStreams);
    }
    delegate HRESULT VideoProcessorBltFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pView, UInt32 OutputFrame, UInt32 StreamCount, ref D3D11_VIDEO_PROCESSOR_STREAM pStreams);
    public HRESULT NegotiateCryptoSessionKeyExchange(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 47);
        var callback = (NegotiateCryptoSessionKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NegotiateCryptoSessionKeyExchangeFunc));
        return callback(Self, pCryptoSession, DataSize, pData);
    }
    delegate HRESULT NegotiateCryptoSessionKeyExchangeFunc(IntPtr self, IntPtr pCryptoSession, UInt32 DataSize, IntPtr pData);
    public void EncryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// pSrcSurface: (*(ID3D11Texture2D))
        , IntPtr pSrcSurface
        /// pDstSurface: (*(ID3D11Texture2D))
        , IntPtr pDstSurface
        /// IVSize: (UINT)
        , UInt32 IVSize
        /// pIV: (*(void))
        , IntPtr pIV
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 48);
        var callback = (EncryptionBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EncryptionBltFunc));
        callback(Self, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }
    delegate void EncryptionBltFunc(IntPtr self, IntPtr pCryptoSession, IntPtr pSrcSurface, IntPtr pDstSurface, UInt32 IVSize, IntPtr pIV);
    public void DecryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// pSrcSurface: (*(ID3D11Texture2D))
        , IntPtr pSrcSurface
        /// pDstSurface: (*(ID3D11Texture2D))
        , IntPtr pDstSurface
        /// pEncryptedBlockInfo: (*(D3D11_ENCRYPTED_BLOCK_INFO))
        , ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo
        /// ContentKeySize: (UINT)
        , UInt32 ContentKeySize
        /// pContentKey: (*(const void))
        , IntPtr pContentKey
        /// IVSize: (UINT)
        , UInt32 IVSize
        /// pIV: (*(void))
        , IntPtr pIV
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 49);
        var callback = (DecryptionBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecryptionBltFunc));
        callback(Self, pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }
    delegate void DecryptionBltFunc(IntPtr self, IntPtr pCryptoSession, IntPtr pSrcSurface, IntPtr pDstSurface, ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo, UInt32 ContentKeySize, IntPtr pContentKey, UInt32 IVSize, IntPtr pIV);
    public void StartSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// RandomNumberSize: (UINT)
        , UInt32 RandomNumberSize
        /// pRandomNumber: (*(void))
        , IntPtr pRandomNumber
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 50);
        var callback = (StartSessionKeyRefreshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StartSessionKeyRefreshFunc));
        callback(Self, pCryptoSession, RandomNumberSize, pRandomNumber);
    }
    delegate void StartSessionKeyRefreshFunc(IntPtr self, IntPtr pCryptoSession, UInt32 RandomNumberSize, IntPtr pRandomNumber);
    public void FinishSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 51);
        var callback = (FinishSessionKeyRefreshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FinishSessionKeyRefreshFunc));
        callback(Self, pCryptoSession);
    }
    delegate void FinishSessionKeyRefreshFunc(IntPtr self, IntPtr pCryptoSession);
    public HRESULT GetEncryptionBltKey(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// KeySize: (UINT)
        , UInt32 KeySize
        /// pReadbackKey: (*(void))
        , IntPtr pReadbackKey
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 52);
        var callback = (GetEncryptionBltKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEncryptionBltKeyFunc));
        return callback(Self, pCryptoSession, KeySize, pReadbackKey);
    }
    delegate HRESULT GetEncryptionBltKeyFunc(IntPtr self, IntPtr pCryptoSession, UInt32 KeySize, IntPtr pReadbackKey);
    public HRESULT NegotiateAuthenticatedChannelKeyExchange(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 53);
        var callback = (NegotiateAuthenticatedChannelKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NegotiateAuthenticatedChannelKeyExchangeFunc));
        return callback(Self, pChannel, DataSize, pData);
    }
    delegate HRESULT NegotiateAuthenticatedChannelKeyExchangeFunc(IntPtr self, IntPtr pChannel, UInt32 DataSize, IntPtr pData);
    public HRESULT QueryAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// InputSize: (UINT)
        , UInt32 InputSize
        /// pInput: (*(const void))
        , IntPtr pInput
        /// OutputSize: (UINT)
        , UInt32 OutputSize
        /// pOutput: (*(void))
        , IntPtr pOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 54);
        var callback = (QueryAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryAuthenticatedChannelFunc));
        return callback(Self, pChannel, InputSize, pInput, OutputSize, pOutput);
    }
    delegate HRESULT QueryAuthenticatedChannelFunc(IntPtr self, IntPtr pChannel, UInt32 InputSize, IntPtr pInput, UInt32 OutputSize, IntPtr pOutput);
    public HRESULT ConfigureAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// InputSize: (UINT)
        , UInt32 InputSize
        /// pInput: (*(const void))
        , IntPtr pInput
        /// pOutput: (*(D3D11_AUTHENTICATED_CONFIGURE_OUTPUT))
        , ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 55);
        var callback = (ConfigureAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConfigureAuthenticatedChannelFunc));
        return callback(Self, pChannel, InputSize, pInput, ref pOutput);
    }
    delegate HRESULT ConfigureAuthenticatedChannelFunc(IntPtr self, IntPtr pChannel, UInt32 InputSize, IntPtr pInput, ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
    public void VideoProcessorSetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Rotation: (D3D11_VIDEO_PROCESSOR_ROTATION)
        , D3D11_VIDEO_PROCESSOR_ROTATION Rotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 56);
        var callback = (VideoProcessorSetStreamRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamRotationFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Rotation);
    }
    delegate void VideoProcessorSetStreamRotationFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
    public void VideoProcessorGetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnable: (*(BOOL))
        , IntPtr pEnable
        /// pRotation: (*(D3D11_VIDEO_PROCESSOR_ROTATION))
        , ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 57);
        var callback = (VideoProcessorGetStreamRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamRotationFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnable, ref pRotation);
    }
    delegate void VideoProcessorGetStreamRotationFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnable, ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
}
}
