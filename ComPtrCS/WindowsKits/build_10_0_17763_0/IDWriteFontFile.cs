/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteFontFile : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteFontFile>.Value;
    public HRESULT GetReferenceKey(
        /// fontFileReferenceKey: (*(*(const void)))
        ref IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (*(UINT32))
        , ref UInt32 fontFileReferenceKeySize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetReferenceKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetReferenceKeyFunc));
        return callback(Self, ref fontFileReferenceKey, ref fontFileReferenceKeySize);
    }
    delegate HRESULT GetReferenceKeyFunc(IntPtr self, ref IntPtr fontFileReferenceKey, ref UInt32 fontFileReferenceKeySize);
    public HRESULT GetLoader(
        /// fontFileLoader: (*(*(IDWriteFontFileLoader)))
        ref IntPtr fontFileLoader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetLoaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLoaderFunc));
        return callback(Self, ref fontFileLoader);
    }
    delegate HRESULT GetLoaderFunc(IntPtr self, ref IntPtr fontFileLoader);
    public HRESULT Analyze(
        /// isSupportedFontType: (*(BOOL))
        IntPtr isSupportedFontType
        /// fontFileType: (*(DWRITE_FONT_FILE_TYPE))
        , ref DWRITE_FONT_FILE_TYPE fontFileType
        /// fontFaceType: (*(DWRITE_FONT_FACE_TYPE))
        , ref DWRITE_FONT_FACE_TYPE fontFaceType
        /// numberOfFaces: (*(UINT32))
        , ref UInt32 numberOfFaces
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (AnalyzeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AnalyzeFunc));
        return callback(Self, isSupportedFontType, ref fontFileType, ref fontFaceType, ref numberOfFaces);
    }
    delegate HRESULT AnalyzeFunc(IntPtr self, IntPtr isSupportedFontType, ref DWRITE_FONT_FILE_TYPE fontFileType, ref DWRITE_FONT_FACE_TYPE fontFaceType, ref UInt32 numberOfFaces);
}
}
