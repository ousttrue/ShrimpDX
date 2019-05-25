/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class ID2D1Brush: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906a8-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Brush>.Value;
    public void SetOpacity(
        /// opacity: (FLOAT)
        Single opacity
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetOpacityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetOpacityFunc));
        callback(Self, opacity);
    }
    delegate void SetOpacityFunc(IntPtr self, Single opacity);
    public void SetTransform(
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void SetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
    public Single GetOpacity(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetOpacityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOpacityFunc));
        return callback(Self);
    }
    delegate Single GetOpacityFunc(IntPtr self);
    public void GetTransform(
        /// transform: (*(D2D1_MATRIX_3X2_F))
        ref D2D_MATRIX_3X2_F transform
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTransformFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTransformFunc));
        callback(Self, ref transform);
    }
    delegate void GetTransformFunc(IntPtr self, ref D2D_MATRIX_3X2_F transform);
}
}
