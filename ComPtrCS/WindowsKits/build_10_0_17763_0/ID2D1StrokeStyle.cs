/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=9)]
public class ID2D1StrokeStyle: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd9069d-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1StrokeStyle>.Value;
    public D2D1_CAP_STYLE GetStartCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetStartCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStartCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetStartCapFunc(IntPtr self);
    public D2D1_CAP_STYLE GetEndCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetEndCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEndCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetEndCapFunc(IntPtr self);
    public D2D1_CAP_STYLE GetDashCap(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetDashCapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashCapFunc));
        return callback(Self);
    }
    delegate D2D1_CAP_STYLE GetDashCapFunc(IntPtr self);
    public Single GetMiterLimit(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetMiterLimitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMiterLimitFunc));
        return callback(Self);
    }
    delegate Single GetMiterLimitFunc(IntPtr self);
    public D2D1_LINE_JOIN GetLineJoin(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetLineJoinFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLineJoinFunc));
        return callback(Self);
    }
    delegate D2D1_LINE_JOIN GetLineJoinFunc(IntPtr self);
    public Single GetDashOffset(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetDashOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashOffsetFunc));
        return callback(Self);
    }
    delegate Single GetDashOffsetFunc(IntPtr self);
    public D2D1_DASH_STYLE GetDashStyle(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetDashStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashStyleFunc));
        return callback(Self);
    }
    delegate D2D1_DASH_STYLE GetDashStyleFunc(IntPtr self);
    public UInt32 GetDashesCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetDashesCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashesCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetDashesCountFunc(IntPtr self);
    public void GetDashes(
        /// dashes: (*(FLOAT))
        ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetDashesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDashesFunc));
        callback(Self, ref dashes, dashesCount);
    }
    delegate void GetDashesFunc(IntPtr self, ref Single dashes, UInt32 dashesCount);
}
}
