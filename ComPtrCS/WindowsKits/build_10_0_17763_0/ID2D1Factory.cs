/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=14)]
public class ID2D1Factory : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("06152247-6f50-465a-9245-118bfd3b6007");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Factory>.Value;
    public HRESULT ReloadSystemMetrics(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (ReloadSystemMetricsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReloadSystemMetricsFunc));
        return callback(Self);
    }
    delegate HRESULT ReloadSystemMetricsFunc(IntPtr self);
    public void GetDesktopDpi(
        /// dpiX: (*(FLOAT))
        ref Single dpiX
        /// dpiY: (*(FLOAT))
        , ref Single dpiY
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetDesktopDpiFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesktopDpiFunc));
        callback(Self, ref dpiX, ref dpiY);
    }
    delegate void GetDesktopDpiFunc(IntPtr self, ref Single dpiX, ref Single dpiY);
    public HRESULT CreateRectangleGeometry(
        /// rectangle: (*(const D2D1_RECT_F))
        ref D2D_RECT_F rectangle
        /// rectangleGeometry: (*(*(ID2D1RectangleGeometry)))
        , ref IntPtr rectangleGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateRectangleGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRectangleGeometryFunc));
        return callback(Self, ref rectangle, ref rectangleGeometry);
    }
    delegate HRESULT CreateRectangleGeometryFunc(IntPtr self, ref D2D_RECT_F rectangle, ref IntPtr rectangleGeometry);
    public HRESULT CreateRoundedRectangleGeometry(
        /// roundedRectangle: (*(const D2D1_ROUNDED_RECT))
        ref D2D1_ROUNDED_RECT roundedRectangle
        /// roundedRectangleGeometry: (*(*(ID2D1RoundedRectangleGeometry)))
        , ref IntPtr roundedRectangleGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateRoundedRectangleGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRoundedRectangleGeometryFunc));
        return callback(Self, ref roundedRectangle, ref roundedRectangleGeometry);
    }
    delegate HRESULT CreateRoundedRectangleGeometryFunc(IntPtr self, ref D2D1_ROUNDED_RECT roundedRectangle, ref IntPtr roundedRectangleGeometry);
    public HRESULT CreateEllipseGeometry(
        /// ellipse: (*(const D2D1_ELLIPSE))
        ref D2D1_ELLIPSE ellipse
        /// ellipseGeometry: (*(*(ID2D1EllipseGeometry)))
        , ref IntPtr ellipseGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateEllipseGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateEllipseGeometryFunc));
        return callback(Self, ref ellipse, ref ellipseGeometry);
    }
    delegate HRESULT CreateEllipseGeometryFunc(IntPtr self, ref D2D1_ELLIPSE ellipse, ref IntPtr ellipseGeometry);
    public HRESULT CreateGeometryGroup(
        /// fillMode: (D2D1_FILL_MODE)
        D2D1_FILL_MODE fillMode
        /// geometries: (*(*(ID2D1Geometry)))
        , ref IntPtr geometries
        /// geometriesCount: (UINT32)
        , UInt32 geometriesCount
        /// geometryGroup: (*(*(ID2D1GeometryGroup)))
        , ref IntPtr geometryGroup
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateGeometryGroupFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryGroupFunc));
        return callback(Self, fillMode, ref geometries, geometriesCount, ref geometryGroup);
    }
    delegate HRESULT CreateGeometryGroupFunc(IntPtr self, D2D1_FILL_MODE fillMode, ref IntPtr geometries, UInt32 geometriesCount, ref IntPtr geometryGroup);
    public HRESULT CreateTransformedGeometry(
        /// sourceGeometry: (*(ID2D1Geometry))
        IntPtr sourceGeometry
        /// transform: (*(const D2D1_MATRIX_3X2_F))
        , ref D2D_MATRIX_3X2_F transform
        /// transformedGeometry: (*(*(ID2D1TransformedGeometry)))
        , ref IntPtr transformedGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateTransformedGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTransformedGeometryFunc));
        return callback(Self, sourceGeometry, ref transform, ref transformedGeometry);
    }
    delegate HRESULT CreateTransformedGeometryFunc(IntPtr self, IntPtr sourceGeometry, ref D2D_MATRIX_3X2_F transform, ref IntPtr transformedGeometry);
    public HRESULT CreatePathGeometry(
        /// pathGeometry: (*(*(ID2D1PathGeometry)))
        ref IntPtr pathGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreatePathGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePathGeometryFunc));
        return callback(Self, ref pathGeometry);
    }
    delegate HRESULT CreatePathGeometryFunc(IntPtr self, ref IntPtr pathGeometry);
    public HRESULT CreateStrokeStyle(
        /// strokeStyleProperties: (*(const D2D1_STROKE_STYLE_PROPERTIES))
        ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties
        /// dashes: (*(const FLOAT))
        , ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
        /// strokeStyle: (*(*(ID2D1StrokeStyle)))
        , ref IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateStrokeStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStrokeStyleFunc));
        return callback(Self, ref strokeStyleProperties, ref dashes, dashesCount, ref strokeStyle);
    }
    delegate HRESULT CreateStrokeStyleFunc(IntPtr self, ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, ref Single dashes, UInt32 dashesCount, ref IntPtr strokeStyle);
    public HRESULT CreateDrawingStateBlock(
        /// drawingStateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION))
        ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription
        /// textRenderingParams: (*(IDWriteRenderingParams))
        , IntPtr textRenderingParams
        /// drawingStateBlock: (*(*(ID2D1DrawingStateBlock)))
        , ref IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateDrawingStateBlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDrawingStateBlockFunc));
        return callback(Self, ref drawingStateDescription, textRenderingParams, ref drawingStateBlock);
    }
    delegate HRESULT CreateDrawingStateBlockFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription, IntPtr textRenderingParams, ref IntPtr drawingStateBlock);
    public HRESULT CreateWicBitmapRenderTarget(
        /// target: (*(IWICBitmap))
        IntPtr target
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        , ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// renderTarget: (*(*(ID2D1RenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateWicBitmapRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateWicBitmapRenderTargetFunc));
        return callback(Self, target, ref renderTargetProperties, ref renderTarget);
    }
    delegate HRESULT CreateWicBitmapRenderTargetFunc(IntPtr self, IntPtr target, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr renderTarget);
    public HRESULT CreateHwndRenderTarget(
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// hwndRenderTargetProperties: (*(const D2D1_HWND_RENDER_TARGET_PROPERTIES))
        , ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties
        /// hwndRenderTarget: (*(*(ID2D1HwndRenderTarget)))
        , ref IntPtr hwndRenderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (CreateHwndRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateHwndRenderTargetFunc));
        return callback(Self, ref renderTargetProperties, ref hwndRenderTargetProperties, ref hwndRenderTarget);
    }
    delegate HRESULT CreateHwndRenderTargetFunc(IntPtr self, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, ref IntPtr hwndRenderTarget);
    public HRESULT CreateDxgiSurfaceRenderTarget(
        /// dxgiSurface: (*(IDXGISurface))
        IntPtr dxgiSurface
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        , ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// renderTarget: (*(*(ID2D1RenderTarget)))
        , ref IntPtr renderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (CreateDxgiSurfaceRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDxgiSurfaceRenderTargetFunc));
        return callback(Self, dxgiSurface, ref renderTargetProperties, ref renderTarget);
    }
    delegate HRESULT CreateDxgiSurfaceRenderTargetFunc(IntPtr self, IntPtr dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr renderTarget);
    public HRESULT CreateDCRenderTarget(
        /// renderTargetProperties: (*(const D2D1_RENDER_TARGET_PROPERTIES))
        ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties
        /// dcRenderTarget: (*(*(ID2D1DCRenderTarget)))
        , ref IntPtr dcRenderTarget
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (CreateDCRenderTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDCRenderTargetFunc));
        return callback(Self, ref renderTargetProperties, ref dcRenderTarget);
    }
    delegate HRESULT CreateDCRenderTargetFunc(IntPtr self, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref IntPtr dcRenderTarget);
}
}
