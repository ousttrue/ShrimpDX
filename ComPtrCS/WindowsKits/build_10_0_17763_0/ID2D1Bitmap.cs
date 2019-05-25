/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=7)]
public class ID2D1Bitmap: ID2D1Image {

    static /*readonly*/ Guid s_uuid = new Guid("a2296057-ea42-4099-983b-539fb6505426");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Bitmap>.Value;
    public D2D_SIZE_F GetSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_F GetSizeFunc(IntPtr self);
    public D2D_SIZE_U GetPixelSize(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPixelSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelSizeFunc));
        return callback(Self);
    }
    delegate D2D_SIZE_U GetPixelSizeFunc(IntPtr self);
    public D2D1_PIXEL_FORMAT GetPixelFormat(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPixelFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPixelFormatFunc));
        return callback(Self);
    }
    delegate D2D1_PIXEL_FORMAT GetPixelFormatFunc(IntPtr self);
    public void GetDpi(
        /// dpiX: (*(FLOAT))
        ref Single dpiX
        /// dpiY: (*(FLOAT))
        , ref Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDpiFunc));
        callback(Self, ref dpiX, ref dpiY);
    }
    delegate void GetDpiFunc(IntPtr self, ref Single dpiX, ref Single dpiY);
    public HRESULT CopyFromBitmap(
        /// destPoint: (*(const D2D1_POINT_2U))
        ref D2D_POINT_2U destPoint
        /// bitmap: (*(ID2D1Bitmap))
        , IntPtr bitmap
        /// srcRect: (*(const D2D1_RECT_U))
        , ref D2D_RECT_U srcRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CopyFromBitmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromBitmapFunc));
        return callback(Self, ref destPoint, bitmap, ref srcRect);
    }
    delegate HRESULT CopyFromBitmapFunc(IntPtr self, ref D2D_POINT_2U destPoint, IntPtr bitmap, ref D2D_RECT_U srcRect);
    public HRESULT CopyFromRenderTarget(
        /// destPoint: (*(const D2D1_POINT_2U))
        ref D2D_POINT_2U destPoint
        /// renderTarget: (*(ID2D1RenderTarget))
        , IntPtr renderTarget
        /// srcRect: (*(const D2D1_RECT_U))
        , ref D2D_RECT_U srcRect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CopyFromRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromRenderTargetFunc));
        return callback(Self, ref destPoint, renderTarget, ref srcRect);
    }
    delegate HRESULT CopyFromRenderTargetFunc(IntPtr self, ref D2D_POINT_2U destPoint, IntPtr renderTarget, ref D2D_RECT_U srcRect);
    public HRESULT CopyFromMemory(
        /// dstRect: (*(const D2D1_RECT_U))
        ref D2D_RECT_U dstRect
        /// srcData: (*(const void))
        , IntPtr srcData
        /// pitch: (UINT32)
        , UInt32 pitch
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CopyFromMemoryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyFromMemoryFunc));
        return callback(Self, ref dstRect, srcData, pitch);
    }
    delegate HRESULT CopyFromMemoryFunc(IntPtr self, ref D2D_RECT_U dstRect, IntPtr srcData, UInt32 pitch);
}
}
