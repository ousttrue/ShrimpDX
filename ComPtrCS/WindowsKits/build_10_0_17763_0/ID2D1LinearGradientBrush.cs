/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1LinearGradientBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906ab-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1LinearGradientBrush>.Value;
    public void SetStartPoint(
        /// startPoint: (D2D1_POINT_2F)
        D2D_POINT_2F startPoint
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetStartPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStartPointFunc));
        callback(Self, startPoint);
    }
    delegate void SetStartPointFunc(IntPtr self, D2D_POINT_2F startPoint);
    public void SetEndPoint(
        /// endPoint: (D2D1_POINT_2F)
        D2D_POINT_2F endPoint
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetEndPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEndPointFunc));
        callback(Self, endPoint);
    }
    delegate void SetEndPointFunc(IntPtr self, D2D_POINT_2F endPoint);
    public D2D_POINT_2F GetStartPoint(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetStartPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStartPointFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetStartPointFunc(IntPtr self);
    public D2D_POINT_2F GetEndPoint(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetEndPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEndPointFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetEndPointFunc(IntPtr self);
    public void GetGradientStopCollection(
        /// gradientStopCollection: (*(*(ID2D1GradientStopCollection)))
        ref IntPtr gradientStopCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCollectionFunc));
        callback(Self, ref gradientStopCollection);
    }
    delegate void GetGradientStopCollectionFunc(IntPtr self, ref IntPtr gradientStopCollection);
}
}
