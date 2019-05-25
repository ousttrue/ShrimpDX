/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=1)]
public class ID2D1StrokeStyle1: ID2D1StrokeStyle {

    static /*readonly*/ Guid s_uuid = new Guid("10a72a66-e91c-43f4-993f-ddf4b82b0b4a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1StrokeStyle1>.Value;
    public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetStrokeTransformTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStrokeTransformTypeFunc));
        return callback(Self);
    }
    delegate D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformTypeFunc(IntPtr self);
}
}
