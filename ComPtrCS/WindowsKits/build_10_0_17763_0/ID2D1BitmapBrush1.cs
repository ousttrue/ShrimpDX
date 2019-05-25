/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=2)]
public class ID2D1BitmapBrush1: ID2D1BitmapBrush {

    static /*readonly*/ Guid s_uuid = new Guid("41343a53-e41a-49a2-91cd-21793bbb62e5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1BitmapBrush1>.Value;
    public void SetInterpolationMode1(
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        D2D1_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationMode1Func));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationMode1Func(IntPtr self, D2D1_INTERPOLATION_MODE interpolationMode);
    public D2D1_INTERPOLATION_MODE GetInterpolationMode1(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetInterpolationMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationMode1Func));
        return callback(Self);
    }
    delegate D2D1_INTERPOLATION_MODE GetInterpolationMode1Func(IntPtr self);
}
}
