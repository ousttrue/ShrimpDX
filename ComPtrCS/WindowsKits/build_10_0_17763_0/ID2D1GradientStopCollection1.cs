/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=5)]
public class ID2D1GradientStopCollection1: ID2D1GradientStopCollection {

    static /*readonly*/ Guid s_uuid = new Guid("ae1572f4-5dd0-4777-998b-9279472ae63b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GradientStopCollection1>.Value;
    public void GetGradientStops1(
        /// gradientStops: (*(D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP gradientStops
        /// gradientStopsCount: (UINT32)
        , UInt32 gradientStopsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGradientStops1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStops1Func));
        callback(Self, ref gradientStops, gradientStopsCount);
    }
    delegate void GetGradientStops1Func(IntPtr self, ref D2D1_GRADIENT_STOP gradientStops, UInt32 gradientStopsCount);
    public D2D1_COLOR_SPACE GetPreInterpolationSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPreInterpolationSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPreInterpolationSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetPreInterpolationSpaceFunc(IntPtr self);
    public D2D1_COLOR_SPACE GetPostInterpolationSpace(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPostInterpolationSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPostInterpolationSpaceFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_SPACE GetPostInterpolationSpaceFunc(IntPtr self);
    public D2D1_BUFFER_PRECISION GetBufferPrecision(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetBufferPrecisionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferPrecisionFunc));
        return callback(Self);
    }
    delegate D2D1_BUFFER_PRECISION GetBufferPrecisionFunc(IntPtr self);
    public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetColorInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationModeFunc(IntPtr self);
}
}
