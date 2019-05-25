/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=6)]
public class IDWriteLocalizedStrings : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("08256209-099a-4b34-b86d-c22b110e7771");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteLocalizedStrings>.Value;
    public UInt32 GetCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetCountFunc(IntPtr self);
    public HRESULT FindLocaleName(
        /// localeName: (*(const WCHAR))
        ref Char localeName
        /// index: (*(UINT32))
        , ref UInt32 index
        /// exists: (*(BOOL))
        , IntPtr exists
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (FindLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindLocaleNameFunc));
        return callback(Self, ref localeName, ref index, exists);
    }
    delegate HRESULT FindLocaleNameFunc(IntPtr self, ref Char localeName, ref UInt32 index, IntPtr exists);
    public HRESULT GetLocaleNameLength(
        /// index: (UINT32)
        UInt32 index
        /// length: (*(UINT32))
        , ref UInt32 length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetLocaleNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameLengthFunc));
        return callback(Self, index, ref length);
    }
    delegate HRESULT GetLocaleNameLengthFunc(IntPtr self, UInt32 index, ref UInt32 length);
    public HRESULT GetLocaleName(
        /// index: (UINT32)
        UInt32 index
        /// localeName: (*(WCHAR))
        , ref Char localeName
        /// size: (UINT32)
        , UInt32 size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, index, ref localeName, size);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, UInt32 index, ref Char localeName, UInt32 size);
    public HRESULT GetStringLength(
        /// index: (UINT32)
        UInt32 index
        /// length: (*(UINT32))
        , ref UInt32 length
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetStringLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringLengthFunc));
        return callback(Self, index, ref length);
    }
    delegate HRESULT GetStringLengthFunc(IntPtr self, UInt32 index, ref UInt32 length);
    public HRESULT GetString(
        /// index: (UINT32)
        UInt32 index
        /// stringBuffer: (*(WCHAR))
        , ref Char stringBuffer
        /// size: (UINT32)
        , UInt32 size
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStringFunc));
        return callback(Self, index, ref stringBuffer, size);
    }
    delegate HRESULT GetStringFunc(IntPtr self, UInt32 index, ref Char stringBuffer, UInt32 size);
}
}
