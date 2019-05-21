
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0
{

    public enum DWRITE_MEASURING_MODE
    {
        NATURAL = 0x00000000,
        GDI_CLASSIC = 0x00000001,
        GDI_NATURAL = 0x00000002,
    }

    public enum DWRITE_GLYPH_IMAGE_FORMATS
    {
        NONE = 0x00000000,
        TRUETYPE = 0x00000001,
        CFF = 0x00000002,
        COLR = 0x00000004,
        SVG = 0x00000008,
        PNG = 0x00000010,
        JPEG = 0x00000020,
        TIFF = 0x00000040,
        PREMULTIPLIED_B8G8R8A8 = 0x00000080,
    }

    public enum D2D1_ALPHA_MODE
    {
        UNKNOWN = 0x00000000,
        PREMULTIPLIED = 0x00000001,
        STRAIGHT = 0x00000002,
        IGNORE = 0x00000003,
        FORCE_DWORD = -0x0000001,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D1_PIXEL_FORMAT
    {
        /// (DXGI_FORMAT)
        public DXGI_FORMAT format;

        /// (D2D1_ALPHA_MODE)
        public D2D1_ALPHA_MODE alphaMode;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_POINT_2U
    {
        /// (UINT32)
        public UInt32 x;

        /// (UINT32)
        public UInt32 y;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_POINT_2F
    {
        /// (FLOAT)
        public Single x;

        /// (FLOAT)
        public Single y;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_POINT_2L
    {
        public POINT Value;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_VECTOR_2F
    {
        /// (FLOAT)
        public Single x;

        /// (FLOAT)
        public Single y;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_VECTOR_3F
    {
        /// (FLOAT)
        public Single x;

        /// (FLOAT)
        public Single y;

        /// (FLOAT)
        public Single z;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_VECTOR_4F
    {
        /// (FLOAT)
        public Single x;

        /// (FLOAT)
        public Single y;

        /// (FLOAT)
        public Single z;

        /// (FLOAT)
        public Single w;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_RECT_F
    {
        /// (FLOAT)
        public Single left;

        /// (FLOAT)
        public Single top;

        /// (FLOAT)
        public Single right;

        /// (FLOAT)
        public Single bottom;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_RECT_U
    {
        /// (UINT32)
        public UInt32 left;

        /// (UINT32)
        public UInt32 top;

        /// (UINT32)
        public UInt32 right;

        /// (UINT32)
        public UInt32 bottom;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_RECT_L
    {
        public RECT Value;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_SIZE_F
    {
        /// (FLOAT)
        public Single width;

        /// (FLOAT)
        public Single height;

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_SIZE_U
    {
        /// (UINT32)
        public UInt32 width;

        /// (UINT32)
        public UInt32 height;

    }


    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct D2D_MATRIX_3X2_F
    {
        #region union
        [FieldOffset(0)]
        public Single m11;
        [FieldOffset(4)]
        public Single m12;
        [FieldOffset(8)]
        public Single m21;
        [FieldOffset(12)]
        public Single m22;
        [FieldOffset(16)]
        public Single dx;
        [FieldOffset(20)]
        public Single dy;

        [FieldOffset(0)]
        public Single _11;
        [FieldOffset(4)]
        public Single _12;
        [FieldOffset(8)]
        public Single _21;
        [FieldOffset(12)]
        public Single _22;
        [FieldOffset(16)]
        public Single _31;
        [FieldOffset(20)]
        public Single _32;

        /*
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
        public Single[] m;
        */
        #endregion
    }


    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct D2D_MATRIX_4X3_F
    {
        #region union
        [FieldOffset(0)]
        public Single _11;
        [FieldOffset(4)]
        public Single _12;
        [FieldOffset(8)]
        public Single _13;
        [FieldOffset(12)]
        public Single _21;
        [FieldOffset(16)]
        public Single _22;
        [FieldOffset(20)]
        public Single _23;
        [FieldOffset(24)]
        public Single _31;
        [FieldOffset(28)]
        public Single _32;
        [FieldOffset(32)]
        public Single _33;
        [FieldOffset(36)]
        public Single _41;
        [FieldOffset(40)]
        public Single _42;
        [FieldOffset(44)]
        public Single _43;

        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public Single[] m;
        #endregion
    }


    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    public struct D2D_MATRIX_4X4_F
    {
        #region union
        [FieldOffset(0)]
        public Single _11;
        [FieldOffset(4)]
        public Single _12;
        [FieldOffset(8)]
        public Single _13;
        [FieldOffset(12)]
        public Single _14;
        [FieldOffset(16)]
        public Single _21;
        [FieldOffset(20)]
        public Single _22;
        [FieldOffset(24)]
        public Single _23;
        [FieldOffset(28)]
        public Single _24;
        [FieldOffset(32)]
        public Single _31;
        [FieldOffset(36)]
        public Single _32;
        [FieldOffset(40)]
        public Single _33;
        [FieldOffset(44)]
        public Single _34;
        [FieldOffset(48)]
        public Single _41;
        [FieldOffset(52)]
        public Single _42;
        [FieldOffset(56)]
        public Single _43;
        [FieldOffset(60)]
        public Single _44;

        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public Single[] m;
        #endregion
    }


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D2D_MATRIX_5X4_F
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public Single[] m;
    }










}
