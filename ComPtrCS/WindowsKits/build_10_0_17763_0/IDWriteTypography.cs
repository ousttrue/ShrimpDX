/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteTypography : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("55f1112b-1dc2-4b3c-9541-f46894ed85b6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteTypography>.Value;
    public HRESULT AddFontFeature(
        /// fontFeature: (DWRITE_FONT_FEATURE)
        DWRITE_FONT_FEATURE fontFeature
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (AddFontFeatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddFontFeatureFunc));
        return callback(Self, fontFeature);
    }
    delegate HRESULT AddFontFeatureFunc(IntPtr self, DWRITE_FONT_FEATURE fontFeature);
    public UInt32 GetFontFeatureCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFontFeatureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFeatureCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontFeatureCountFunc(IntPtr self);
    public HRESULT GetFontFeature(
        /// fontFeatureIndex: (UINT32)
        UInt32 fontFeatureIndex
        /// fontFeature: (*(DWRITE_FONT_FEATURE))
        , ref DWRITE_FONT_FEATURE fontFeature
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetFontFeatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFeatureFunc));
        return callback(Self, fontFeatureIndex, ref fontFeature);
    }
    delegate HRESULT GetFontFeatureFunc(IntPtr self, UInt32 fontFeatureIndex, ref DWRITE_FONT_FEATURE fontFeature);
}
}
