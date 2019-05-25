/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class IDWriteTextAnalysisSource : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("688e1a58-5094-47c8-adc8-fbcea60ae92b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteTextAnalysisSource>.Value;
    public HRESULT GetTextAtPosition(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textString: (*(*(const WCHAR)))
        , ref IntPtr textString
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetTextAtPositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextAtPositionFunc));
        return callback(Self, textPosition, ref textString, ref textLength);
    }
    delegate HRESULT GetTextAtPositionFunc(IntPtr self, UInt32 textPosition, ref IntPtr textString, ref UInt32 textLength);
    public HRESULT GetTextBeforePosition(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textString: (*(*(const WCHAR)))
        , ref IntPtr textString
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetTextBeforePositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextBeforePositionFunc));
        return callback(Self, textPosition, ref textString, ref textLength);
    }
    delegate HRESULT GetTextBeforePositionFunc(IntPtr self, UInt32 textPosition, ref IntPtr textString, ref UInt32 textLength);
    public DWRITE_READING_DIRECTION GetParagraphReadingDirection(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetParagraphReadingDirectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParagraphReadingDirectionFunc));
        return callback(Self);
    }
    delegate DWRITE_READING_DIRECTION GetParagraphReadingDirectionFunc(IntPtr self);
    public HRESULT GetLocaleName(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
        /// localeName: (*(*(const WCHAR)))
        , ref IntPtr localeName
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetLocaleNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLocaleNameFunc));
        return callback(Self, textPosition, ref textLength, ref localeName);
    }
    delegate HRESULT GetLocaleNameFunc(IntPtr self, UInt32 textPosition, ref UInt32 textLength, ref IntPtr localeName);
    public HRESULT GetNumberSubstitution(
        /// textPosition: (UINT32)
        UInt32 textPosition
        /// textLength: (*(UINT32))
        , ref UInt32 textLength
        /// numberSubstitution: (*(*(IDWriteNumberSubstitution)))
        , ref IntPtr numberSubstitution
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetNumberSubstitutionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNumberSubstitutionFunc));
        return callback(Self, textPosition, ref textLength, ref numberSubstitution);
    }
    delegate HRESULT GetNumberSubstitutionFunc(IntPtr self, UInt32 textPosition, ref UInt32 textLength, ref IntPtr numberSubstitution);
}
}
