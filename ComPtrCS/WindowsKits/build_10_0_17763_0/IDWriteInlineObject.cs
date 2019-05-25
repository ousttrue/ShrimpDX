/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDWriteInlineObject : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("8339fde3-106f-47ab-8373-1c6295eb10b3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteInlineObject>.Value;
    public HRESULT Draw(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// renderer: (*(IDWriteTextRenderer))
        , IntPtr renderer
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
        return callback(Self, clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }
    delegate HRESULT DrawFunc(IntPtr self, IntPtr clientDrawingContext, IntPtr renderer, Single originX, Single originY, Int32 isSideways, Int32 isRightToLeft, IntPtr clientDrawingEffect);
    public HRESULT GetMetrics(
        /// metrics: (*(DWRITE_INLINE_OBJECT_METRICS))
        ref DWRITE_INLINE_OBJECT_METRICS metrics
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMetricsFunc));
        return callback(Self, ref metrics);
    }
    delegate HRESULT GetMetricsFunc(IntPtr self, ref DWRITE_INLINE_OBJECT_METRICS metrics);
    public HRESULT GetOverhangMetrics(
        /// overhangs: (*(DWRITE_OVERHANG_METRICS))
        ref DWRITE_OVERHANG_METRICS overhangs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetOverhangMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOverhangMetricsFunc));
        return callback(Self, ref overhangs);
    }
    delegate HRESULT GetOverhangMetricsFunc(IntPtr self, ref DWRITE_OVERHANG_METRICS overhangs);
    public HRESULT GetBreakConditions(
        /// breakConditionBefore: (*(DWRITE_BREAK_CONDITION))
        ref DWRITE_BREAK_CONDITION breakConditionBefore
        /// breakConditionAfter: (*(DWRITE_BREAK_CONDITION))
        , ref DWRITE_BREAK_CONDITION breakConditionAfter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetBreakConditionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBreakConditionsFunc));
        return callback(Self, ref breakConditionBefore, ref breakConditionAfter);
    }
    delegate HRESULT GetBreakConditionsFunc(IntPtr self, ref DWRITE_BREAK_CONDITION breakConditionBefore, ref DWRITE_BREAK_CONDITION breakConditionAfter);
}
}
