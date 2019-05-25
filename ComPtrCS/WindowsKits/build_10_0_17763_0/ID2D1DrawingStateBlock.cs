/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID2D1DrawingStateBlock: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("28506e39-ebf6-46a1-bb47-fd85565ab957");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1DrawingStateBlock>.Value;
    public void GetDescription(
        /// stateDescription: (*(D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void GetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    public void SetDescription(
        /// stateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
        callback(Self, ref stateDescription);
    }
    delegate void SetDescriptionFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    public void SetTextRenderingParams(
        /// textRenderingParams: (*(IDWriteRenderingParams))
        IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTextRenderingParamsFunc));
        callback(Self, textRenderingParams);
    }
    delegate void SetTextRenderingParamsFunc(IntPtr self, IntPtr textRenderingParams);
    public void GetTextRenderingParams(
        /// textRenderingParams: (*(*(IDWriteRenderingParams)))
        ref IntPtr textRenderingParams
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTextRenderingParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTextRenderingParamsFunc));
        callback(Self, ref textRenderingParams);
    }
    delegate void GetTextRenderingParamsFunc(IntPtr self, ref IntPtr textRenderingParams);
}
}
