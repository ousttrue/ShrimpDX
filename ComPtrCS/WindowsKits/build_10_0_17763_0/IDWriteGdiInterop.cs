/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class IDWriteGdiInterop : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("1edd9491-9853-4299-898f-6432983b6f3a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteGdiInterop>.Value;
    public HRESULT CreateFontFromLOGFONT(
        /// logFont: (*(const LOGFONTW))
        ref LOGFONTW logFont
        /// font: (*(*(IDWriteFont)))
        , ref IntPtr font
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateFontFromLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFromLOGFONTFunc));
        return callback(Self, ref logFont, ref font);
    }
    delegate HRESULT CreateFontFromLOGFONTFunc(IntPtr self, ref LOGFONTW logFont, ref IntPtr font);
    public HRESULT ConvertFontToLOGFONT(
        /// font: (*(IDWriteFont))
        IntPtr font
        /// logFont: (*(LOGFONTW))
        , ref LOGFONTW logFont
        /// isSystemFont: (*(BOOL))
        , IntPtr isSystemFont
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (ConvertFontToLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConvertFontToLOGFONTFunc));
        return callback(Self, font, ref logFont, isSystemFont);
    }
    delegate HRESULT ConvertFontToLOGFONTFunc(IntPtr self, IntPtr font, ref LOGFONTW logFont, IntPtr isSystemFont);
    public HRESULT ConvertFontFaceToLOGFONT(
        /// font: (*(IDWriteFontFace))
        IntPtr font
        /// logFont: (*(LOGFONTW))
        , ref LOGFONTW logFont
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (ConvertFontFaceToLOGFONTFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConvertFontFaceToLOGFONTFunc));
        return callback(Self, font, ref logFont);
    }
    delegate HRESULT ConvertFontFaceToLOGFONTFunc(IntPtr self, IntPtr font, ref LOGFONTW logFont);
    public HRESULT CreateFontFaceFromHdc(
        /// hdc: (HDC)
        IntPtr hdc
        /// fontFace: (*(*(IDWriteFontFace)))
        , ref IntPtr fontFace
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateFontFaceFromHdcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFontFaceFromHdcFunc));
        return callback(Self, hdc, ref fontFace);
    }
    delegate HRESULT CreateFontFaceFromHdcFunc(IntPtr self, IntPtr hdc, ref IntPtr fontFace);
    public HRESULT CreateBitmapRenderTarget(
        /// hdc: (HDC)
        IntPtr hdc
        /// width: (UINT32)
        , UInt32 width
        /// height: (UINT32)
        , UInt32 height
        /// renderTarget: (*(*(IDWriteBitmapRenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateBitmapRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBitmapRenderTargetFunc));
        return callback(Self, hdc, width, height, ref renderTarget);
    }
    delegate HRESULT CreateBitmapRenderTargetFunc(IntPtr self, IntPtr hdc, UInt32 width, UInt32 height, ref IntPtr renderTarget);
}
}
