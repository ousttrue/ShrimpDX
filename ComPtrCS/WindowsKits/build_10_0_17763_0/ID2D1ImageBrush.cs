/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=10)]
public class ID2D1ImageBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1ImageBrush>.Value;
    public void SetImage(
        /// image: (*(ID2D1Image))
        IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetImageFunc));
        callback(Self, image);
    }
    delegate void SetImageFunc(IntPtr self, IntPtr image);
    public void SetExtendModeX(
        /// extendModeX: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeXFunc));
        callback(Self, extendModeX);
    }
    delegate void SetExtendModeXFunc(IntPtr self, D2D1_EXTEND_MODE extendModeX);
    public void SetExtendModeY(
        /// extendModeY: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeYFunc));
        callback(Self, extendModeY);
    }
    delegate void SetExtendModeYFunc(IntPtr self, D2D1_EXTEND_MODE extendModeY);
    public void SetInterpolationMode(
        /// interpolationMode: (D2D1_INTERPOLATION_MODE)
        D2D1_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationModeFunc));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationModeFunc(IntPtr self, D2D1_INTERPOLATION_MODE interpolationMode);
    public void SetSourceRectangle(
        /// sourceRectangle: (*(const D2D1_RECT_F))
        ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (SetSourceRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSourceRectangleFunc));
        callback(Self, ref sourceRectangle);
    }
    delegate void SetSourceRectangleFunc(IntPtr self, ref D2D_RECT_F sourceRectangle);
    public void GetImage(
        /// image: (*(*(ID2D1Image)))
        ref IntPtr image
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetImageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImageFunc));
        callback(Self, ref image);
    }
    delegate void GetImageFunc(IntPtr self, ref IntPtr image);
    public D2D1_EXTEND_MODE GetExtendModeX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeXFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeXFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendModeY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeYFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeYFunc(IntPtr self);
    public D2D1_INTERPOLATION_MODE GetInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_INTERPOLATION_MODE GetInterpolationModeFunc(IntPtr self);
    public void GetSourceRectangle(
        /// sourceRectangle: (*(D2D1_RECT_F))
        ref D2D_RECT_F sourceRectangle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetSourceRectangleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceRectangleFunc));
        callback(Self, ref sourceRectangle);
    }
    delegate void GetSourceRectangleFunc(IntPtr self, ref D2D_RECT_F sourceRectangle);
}
}
