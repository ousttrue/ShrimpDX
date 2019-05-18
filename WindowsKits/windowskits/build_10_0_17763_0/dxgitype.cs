
using System;
using System.Runtime.InteropServices;

namespace WindowsKits.build_10_0_17763_0
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_RGB
    {
        public float Red;
        public float Green;
        public float Blue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct _D3DCOLORVALUE
    {
        public float r;
        public float g;
        public float b;
        public float a;
    }

    public struct D3DCOLORVALUE
    {
        public _D3DCOLORVALUE Value;
    }

    public struct DXGI_RGBA
    {
        public D3DCOLORVALUE Value;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_GAMMA_CONTROL
    {
        public DXGI_RGB Scale;
        public DXGI_RGB Offset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public DXGI_RGB[] GammaCurve;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_GAMMA_CONTROL_CAPABILITIES
    {
        public Int32 ScaleAndOffsetSupported;
        public float MaxConvertedValue;
        public float MinConvertedValue;
        public UInt32 NumGammaControlPoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public float[] ControlPointPositions;
    }

    public enum DXGI_MODE_SCANLINE_ORDER
    {
        UNSPECIFIED = 0x00000000,
        PROGRESSIVE = 0x00000001,
        UPPER_FIELD_FIRST = 0x00000002,
        LOWER_FIELD_FIRST = 0x00000003,
    }

    public enum DXGI_MODE_SCALING
    {
        UNSPECIFIED = 0x00000000,
        CENTERED = 0x00000001,
        STRETCHED = 0x00000002,
    }

    public enum DXGI_MODE_ROTATION
    {
        UNSPECIFIED = 0x00000000,
        IDENTITY = 0x00000001,
        ROTATE90 = 0x00000002,
        ROTATE180 = 0x00000003,
        ROTATE270 = 0x00000004,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_MODE_DESC
    {
        public UInt32 Width;
        public UInt32 Height;
        public DXGI_RATIONAL RefreshRate;
        public DXGI_FORMAT Format;
        public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
        public DXGI_MODE_SCALING Scaling;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_JPEG_DC_HUFFMAN_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public Byte[] CodeCounts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public Byte[] CodeValues;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_JPEG_AC_HUFFMAN_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] CodeCounts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 162)]
        public Byte[] CodeValues;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_JPEG_QUANTIZATION_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public Byte[] Elements;
    }

}
