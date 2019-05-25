/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=6)]
public class ID3D11VideoProcessorEnumerator: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("31627037-53ab-4200-9061-05faa9ab45f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11VideoProcessorEnumerator>.Value;
    public HRESULT GetVideoProcessorContentDesc(
        /// pContentDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetVideoProcessorContentDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorContentDescFunc));
        return callback(Self, ref pContentDesc);
    }
    delegate HRESULT GetVideoProcessorContentDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
    public HRESULT CheckVideoProcessorFormat(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// pFlags: (*(UINT))
        , ref UInt32 pFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CheckVideoProcessorFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckVideoProcessorFormatFunc));
        return callback(Self, Format, ref pFlags);
    }
    delegate HRESULT CheckVideoProcessorFormatFunc(IntPtr self, DXGI_FORMAT Format, ref UInt32 pFlags);
    public HRESULT GetVideoProcessorCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_CAPS))
        ref D3D11_VIDEO_PROCESSOR_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetVideoProcessorCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorCapsFunc));
        return callback(Self, ref pCaps);
    }
    delegate HRESULT GetVideoProcessorCapsFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CAPS pCaps);
    public HRESULT GetVideoProcessorRateConversionCaps(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        , ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetVideoProcessorRateConversionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorRateConversionCapsFunc));
        return callback(Self, TypeIndex, ref pCaps);
    }
    delegate HRESULT GetVideoProcessorRateConversionCapsFunc(IntPtr self, UInt32 TypeIndex, ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
    public HRESULT GetVideoProcessorCustomRate(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex
        /// CustomRateIndex: (UINT)
        , UInt32 CustomRateIndex
        /// pRate: (*(D3D11_VIDEO_PROCESSOR_CUSTOM_RATE))
        , ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetVideoProcessorCustomRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorCustomRateFunc));
        return callback(Self, TypeIndex, CustomRateIndex, ref pRate);
    }
    delegate HRESULT GetVideoProcessorCustomRateFunc(IntPtr self, UInt32 TypeIndex, UInt32 CustomRateIndex, ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
    public HRESULT GetVideoProcessorFilterRange(
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// pRange: (*(D3D11_VIDEO_PROCESSOR_FILTER_RANGE))
        , ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetVideoProcessorFilterRangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorFilterRangeFunc));
        return callback(Self, Filter, ref pRange);
    }
    delegate HRESULT GetVideoProcessorFilterRangeFunc(IntPtr self, D3D11_VIDEO_PROCESSOR_FILTER Filter, ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
}
}
