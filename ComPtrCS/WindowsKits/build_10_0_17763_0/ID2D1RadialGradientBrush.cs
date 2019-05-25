/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=9)]
public class ID2D1RadialGradientBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906ac-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1RadialGradientBrush>.Value;
    public void SetCenter(
        /// center: (D2D1_POINT_2F)
        D2D_POINT_2F center
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetCenterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCenterFunc));
        callback(Self, center);
    }
    delegate void SetCenterFunc(IntPtr self, D2D_POINT_2F center);
    public void SetGradientOriginOffset(
        /// gradientOriginOffset: (D2D1_POINT_2F)
        D2D_POINT_2F gradientOriginOffset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetGradientOriginOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGradientOriginOffsetFunc));
        callback(Self, gradientOriginOffset);
    }
    delegate void SetGradientOriginOffsetFunc(IntPtr self, D2D_POINT_2F gradientOriginOffset);
    public void SetRadiusX(
        /// radiusX: (FLOAT)
        Single radiusX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetRadiusXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRadiusXFunc));
        callback(Self, radiusX);
    }
    delegate void SetRadiusXFunc(IntPtr self, Single radiusX);
    public void SetRadiusY(
        /// radiusY: (FLOAT)
        Single radiusY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetRadiusYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRadiusYFunc));
        callback(Self, radiusY);
    }
    delegate void SetRadiusYFunc(IntPtr self, Single radiusY);
    public D2D_POINT_2F GetCenter(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetCenterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCenterFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetCenterFunc(IntPtr self);
    public D2D_POINT_2F GetGradientOriginOffset(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetGradientOriginOffsetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientOriginOffsetFunc));
        return callback(Self);
    }
    delegate D2D_POINT_2F GetGradientOriginOffsetFunc(IntPtr self);
    public Single GetRadiusX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetRadiusXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRadiusXFunc));
        return callback(Self);
    }
    delegate Single GetRadiusXFunc(IntPtr self);
    public Single GetRadiusY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetRadiusYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRadiusYFunc));
        return callback(Self);
    }
    delegate Single GetRadiusYFunc(IntPtr self);
    public void GetGradientStopCollection(
        /// gradientStopCollection: (*(*(ID2D1GradientStopCollection)))
        ref IntPtr gradientStopCollection
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetGradientStopCollectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCollectionFunc));
        callback(Self, ref gradientStopCollection);
    }
    delegate void GetGradientStopCollectionFunc(IntPtr self, ref IntPtr gradientStopCollection);
}
}
