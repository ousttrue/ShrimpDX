/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID2D1GradientStopCollection: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a7-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1GradientStopCollection>.Value;
    public UInt32 GetGradientStopCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetGradientStopCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetGradientStopCountFunc(IntPtr self);
    public void GetGradientStops(
        /// gradientStops: (*(D2D1_GRADIENT_STOP))
        ref D2D1_GRADIENT_STOP gradientStops
        /// gradientStopsCount: (UINT32)
        , UInt32 gradientStopsCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetGradientStopsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGradientStopsFunc));
        callback(Self, ref gradientStops, gradientStopsCount);
    }
    delegate void GetGradientStopsFunc(IntPtr self, ref D2D1_GRADIENT_STOP gradientStops, UInt32 gradientStopsCount);
    public D2D1_GAMMA GetColorInterpolationGamma(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetColorInterpolationGammaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorInterpolationGammaFunc));
        return callback(Self);
    }
    delegate D2D1_GAMMA GetColorInterpolationGammaFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetExtendModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeFunc(IntPtr self);
}
}
