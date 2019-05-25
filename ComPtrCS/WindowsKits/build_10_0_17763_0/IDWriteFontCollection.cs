/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDWriteFontCollection : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteFontCollection>.Value;
    public UInt32 GetFontFamilyCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFontFamilyCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetFontFamilyCountFunc(IntPtr self);
    public HRESULT GetFontFamily(
        /// index: (UINT32)
        UInt32 index
        /// fontFamily: (*(*(IDWriteFontFamily)))
        , ref IntPtr fontFamily
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFontFamilyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFamilyFunc));
        return callback(Self, index, ref fontFamily);
    }
    delegate HRESULT GetFontFamilyFunc(IntPtr self, UInt32 index, ref IntPtr fontFamily);
    public HRESULT FindFamilyName(
        /// familyName: (*(const WCHAR))
        [MarshalAs(UnmanagedType.LPWStr)]string familyName
        /// index: (*(UINT32))
        , ref UInt32 index
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (FindFamilyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindFamilyNameFunc));
        return callback(Self, familyName, ref index, exists);
    }
    delegate HRESULT FindFamilyNameFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)]string familyName, ref UInt32 index, IntPtr exists);
    public HRESULT GetFontFromFontFace(
        /// fontFace: (*(IDWriteFontFace))
        IntPtr fontFace
        /// font: (*(*(IDWriteFont)))
        , ref IntPtr font
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetFontFromFontFaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFontFromFontFaceFunc));
        return callback(Self, fontFace, ref font);
    }
    delegate HRESULT GetFontFromFontFaceFunc(IntPtr self, IntPtr fontFace, ref IntPtr font);
}
}
