
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0 {

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_RGB{
    /* (float) */float Red;
    /* (float) */float Green;
    /* (float) */float Blue;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct _D3DCOLORVALUE{
    /* (float) */float r;
    /* (float) */float g;
    /* (float) */float b;
    /* (float) */float a;
}

public struct D3DCOLORVALUE{
    public /* (_D3DCOLORVALUE) */_D3DCOLORVALUE Value;
}

public struct DXGI_RGBA{
    public /* (D3DCOLORVALUE) */D3DCOLORVALUE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_GAMMA_CONTROL{
    /* (DXGI_RGB) */DXGI_RGB Scale;
    /* (DXGI_RGB) */DXGI_RGB Offset;
    /* (DXGI_RGB)[1025] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=1025)]public DXGI_RGB[] GammaCurve;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_GAMMA_CONTROL_CAPABILITIES{
    /* (BOOL) */Int32 ScaleAndOffsetSupported;
    /* (float) */float MaxConvertedValue;
    /* (float) */float MinConvertedValue;
    /* (UINT) */UInt32 NumGammaControlPoints;
    /* (float)[1025] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=1025)]public float[] ControlPointPositions;
}

public enum DXGI_MODE_SCANLINE_ORDER {
    UNSPECIFIED = 0x00000000,
    PROGRESSIVE = 0x00000001,
    UPPER_FIELD_FIRST = 0x00000002,
    LOWER_FIELD_FIRST = 0x00000003,
}

public enum DXGI_MODE_SCALING {
    UNSPECIFIED = 0x00000000,
    CENTERED = 0x00000001,
    STRETCHED = 0x00000002,
}

public enum DXGI_MODE_ROTATION {
    UNSPECIFIED = 0x00000000,
    IDENTITY = 0x00000001,
    ROTATE90 = 0x00000002,
    ROTATE180 = 0x00000003,
    ROTATE270 = 0x00000004,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_MODE_DESC{
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 Height;
    /* (DXGI_RATIONAL) */DXGI_RATIONAL RefreshRate;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (DXGI_MODE_SCANLINE_ORDER) */DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    /* (DXGI_MODE_SCALING) */DXGI_MODE_SCALING Scaling;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_DC_HUFFMAN_TABLE{
    /* (BYTE)[12] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]public Byte[] CodeCounts;
    /* (BYTE)[12] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]public Byte[] CodeValues;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_AC_HUFFMAN_TABLE{
    /* (BYTE)[16] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]public Byte[] CodeCounts;
    /* (BYTE)[162] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=162)]public Byte[] CodeValues;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_QUANTIZATION_TABLE{
    /* (BYTE)[64] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]public Byte[] Elements;
}

}
