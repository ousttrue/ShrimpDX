/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=8)]
public class ID2D1BitmapBrush: ID2D1Brush {

    static /*readonly*/ Guid s_uuid = new Guid("2cd906aa-12e2-11dc-9fed-001143a055f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1BitmapBrush>.Value;
    public void SetExtendModeX(
        /// extendModeX: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeX
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (SetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeXFunc));
        callback(Self, extendModeX);
    }
    delegate void SetExtendModeXFunc(IntPtr self, D2D1_EXTEND_MODE extendModeX);
    public void SetExtendModeY(
        /// extendModeY: (D2D1_EXTEND_MODE)
        D2D1_EXTEND_MODE extendModeY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (SetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtendModeYFunc));
        callback(Self, extendModeY);
    }
    delegate void SetExtendModeYFunc(IntPtr self, D2D1_EXTEND_MODE extendModeY);
    public void SetInterpolationMode(
        /// interpolationMode: (D2D1_BITMAP_INTERPOLATION_MODE)
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (SetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetInterpolationModeFunc));
        callback(Self, interpolationMode);
    }
    delegate void SetInterpolationModeFunc(IntPtr self, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
    public void SetBitmap(
        /// bitmap: (*(ID2D1Bitmap))
        IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (SetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBitmapFunc));
        callback(Self, bitmap);
    }
    delegate void SetBitmapFunc(IntPtr self, IntPtr bitmap);
    public D2D1_EXTEND_MODE GetExtendModeX(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetExtendModeXFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeXFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeXFunc(IntPtr self);
    public D2D1_EXTEND_MODE GetExtendModeY(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (GetExtendModeYFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendModeYFunc));
        return callback(Self);
    }
    delegate D2D1_EXTEND_MODE GetExtendModeYFunc(IntPtr self);
    public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (GetInterpolationModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInterpolationModeFunc));
        return callback(Self);
    }
    delegate D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationModeFunc(IntPtr self);
    public void GetBitmap(
        /// bitmap: (*(*(ID2D1Bitmap)))
        ref IntPtr bitmap
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBitmapFunc));
        callback(Self, ref bitmap);
    }
    delegate void GetBitmapFunc(IntPtr self, ref IntPtr bitmap);
}
}
