// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public static partial class Constants {
        // unknown type: D2D1_INVALID_TAG ULONGLONG_MAX
        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = ( 0.25f );
        // unknown type: D2D1FORCEINLINE FORCEINLINE
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BEZIER_SEGMENT // 1
    {
        public System.Numerics.Vector2 point1;
        public System.Numerics.Vector2 point2;
        public System.Numerics.Vector2 point3;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_TRIANGLE // 1
    {
        public System.Numerics.Vector2 point1;
        public System.Numerics.Vector2 point2;
        public System.Numerics.Vector2 point3;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_ROUNDED_RECT // 1
    {
        public System.Numerics.Vector4 rect;
        public float radiusX;
        public float radiusY;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_ELLIPSE // 1
    {
        public System.Numerics.Vector2 point;
        public float radiusX;
        public float radiusY;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_QUADRATIC_BEZIER_SEGMENT // 1
    {
        public System.Numerics.Vector2 point1;
        public System.Numerics.Vector2 point2;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_ARC_SEGMENT // 1
    {
        public System.Numerics.Vector2 point;
        public D2D_SIZE_F size;
        public float rotationAngle;
        public D2D1_SWEEP_DIRECTION sweepDirection;
        public D2D1_ARC_SIZE arcSize;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_STROKE_STYLE_PROPERTIES // 1
    {
        public D2D1_CAP_STYLE startCap;
        public D2D1_CAP_STYLE endCap;
        public D2D1_CAP_STYLE dashCap;
        public D2D1_LINE_JOIN lineJoin;
        public float miterLimit;
        public D2D1_DASH_STYLE dashStyle;
        public float dashOffset;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_DRAWING_STATE_DESCRIPTION // 1
    {
        public D2D1_ANTIALIAS_MODE antialiasMode;
        public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;
        public ulong tag1;
        public ulong tag2;
        public System.Numerics.Matrix3x2 transform;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_RENDER_TARGET_PROPERTIES // 1
    {
        public D2D1_RENDER_TARGET_TYPE type;
        public D2D1_PIXEL_FORMAT pixelFormat;
        public float dpiX;
        public float dpiY;
        public D2D1_RENDER_TARGET_USAGE usage;
        public D2D1_FEATURE_LEVEL minLevel;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_PROPERTIES // 1
    {
        public D2D1_PIXEL_FORMAT pixelFormat;
        public float dpiX;
        public float dpiY;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_BRUSH_PROPERTIES // 1
    {
        public D2D1_EXTEND_MODE extendModeX;
        public D2D1_EXTEND_MODE extendModeY;
        public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BRUSH_PROPERTIES // 1
    {
        public float opacity;
        public System.Numerics.Matrix3x2 transform;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_GRADIENT_STOP // 1
    {
        public float position;
        public System.Numerics.Vector4 color;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES // 1
    {
        public System.Numerics.Vector2 startPoint;
        public System.Numerics.Vector2 endPoint;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES // 1
    {
        public System.Numerics.Vector2 center;
        public System.Numerics.Vector2 gradientOriginOffset;
        public float radiusX;
        public float radiusY;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_LAYER_PARAMETERS // 1
    {
        public System.Numerics.Vector4 contentBounds;
        public ID2D1Geometry geometricMask;
        public D2D1_ANTIALIAS_MODE maskAntialiasMode;
        public System.Numerics.Matrix3x2 maskTransform;
        public float opacity;
        public ID2D1Brush opacityBrush;
        public D2D1_LAYER_OPTIONS layerOptions;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_HWND_RENDER_TARGET_PROPERTIES // 1
    {
        public IntPtr hwnd;
        public D2D_SIZE_U pixelSize;
        public D2D1_PRESENT_OPTIONS presentOptions;
    }
    // forward declaration ID2D1SimplifiedGeometrySink;
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_FACTORY_OPTIONS // 1
    {
        public D2D1_DEBUG_LEVEL debugLevel;
    }
    public static class d2d1 {
        [DllImport("d2d1.dll")]
        public static extern int D2D1CreateFactory(
            D2D1_FACTORY_TYPE factoryType,
            ref Guid riid,
            ref D2D1_FACTORY_OPTIONS pFactoryOptions,
            out IntPtr ppIFactory
        );
        [DllImport("d2d1.dll")]
        public static extern void D2D1MakeRotateMatrix(
            float angle,
            System.Numerics.Vector2 center,
            out System.Numerics.Matrix3x2 matrix
        );
        [DllImport("d2d1.dll")]
        public static extern void D2D1MakeSkewMatrix(
            float angleX,
            float angleY,
            System.Numerics.Vector2 center,
            out System.Numerics.Matrix3x2 matrix
        );
        [DllImport("d2d1.dll")]
        public static extern int D2D1IsMatrixInvertible(
            ref System.Numerics.Matrix3x2 matrix
        );
        [DllImport("d2d1.dll")]
        public static extern int D2D1InvertMatrix(
            out System.Numerics.Matrix3x2 matrix
        );
    }
}
