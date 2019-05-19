
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace WindowsKits.build_10_0_17763_0 {

public enum D3D11_INPUT_CLASSIFICATION {
    D3D11_INPUT_PER_VERTEX_DATA = 0x00000000,
    D3D11_INPUT_PER_INSTANCE_DATA = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_INPUT_ELEMENT_DESC{
    /// (LPCSTR)
    public IntPtr SemanticName;

    /// (UINT)
    public UInt32 SemanticIndex;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (UINT)
    public UInt32 InputSlot;

    /// (UINT)
    public UInt32 AlignedByteOffset;

    /// (D3D11_INPUT_CLASSIFICATION)
    public D3D11_INPUT_CLASSIFICATION InputSlotClass;

    /// (UINT)
    public UInt32 InstanceDataStepRate;

}

public enum D3D11_FILL_MODE {
    WIREFRAME = 0x00000002,
    SOLID = 0x00000003,
}

public struct D3D11_PRIMITIVE_TOPOLOGY{
    public D3D_PRIMITIVE_TOPOLOGY Value;
}

public struct D3D11_PRIMITIVE{
    public D3D_PRIMITIVE Value;
}

public enum D3D11_CULL_MODE {
    NONE = 0x00000001,
    FRONT = 0x00000002,
    BACK = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SO_DECLARATION_ENTRY{
    /// (UINT)
    public UInt32 Stream;

    /// (LPCSTR)
    public IntPtr SemanticName;

    /// (UINT)
    public UInt32 SemanticIndex;

    /// (BYTE)
    public Byte StartComponent;

    /// (BYTE)
    public Byte ComponentCount;

    /// (BYTE)
    public Byte OutputSlot;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIEWPORT{
    /// (FLOAT)
    public Single TopLeftX;

    /// (FLOAT)
    public Single TopLeftY;

    /// (FLOAT)
    public Single Width;

    /// (FLOAT)
    public Single Height;

    /// (FLOAT)
    public Single MinDepth;

    /// (FLOAT)
    public Single MaxDepth;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS{
    /// (UINT)
    public UInt32 VertexCountPerInstance;

    /// (UINT)
    public UInt32 InstanceCount;

    /// (UINT)
    public UInt32 StartVertexLocation;

    /// (UINT)
    public UInt32 StartInstanceLocation;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS{
    /// (UINT)
    public UInt32 IndexCountPerInstance;

    /// (UINT)
    public UInt32 InstanceCount;

    /// (UINT)
    public UInt32 StartIndexLocation;

    /// (INT)
    public Int32 BaseVertexLocation;

    /// (UINT)
    public UInt32 StartInstanceLocation;

}

public enum D3D11_RESOURCE_DIMENSION {
    UNKNOWN = 0x00000000,
    BUFFER = 0x00000001,
    TEXTURE1D = 0x00000002,
    TEXTURE2D = 0x00000003,
    TEXTURE3D = 0x00000004,
}

public struct D3D11_SRV_DIMENSION{
    public D3D_SRV_DIMENSION Value;
}

public enum D3D11_DSV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE1D = 0x00000001,
    TEXTURE1DARRAY = 0x00000002,
    TEXTURE2D = 0x00000003,
    TEXTURE2DARRAY = 0x00000004,
    TEXTURE2DMS = 0x00000005,
    TEXTURE2DMSARRAY = 0x00000006,
}

public enum D3D11_RTV_DIMENSION {
    UNKNOWN = 0x00000000,
    BUFFER = 0x00000001,
    TEXTURE1D = 0x00000002,
    TEXTURE1DARRAY = 0x00000003,
    TEXTURE2D = 0x00000004,
    TEXTURE2DARRAY = 0x00000005,
    TEXTURE2DMS = 0x00000006,
    TEXTURE2DMSARRAY = 0x00000007,
    TEXTURE3D = 0x00000008,
}

public enum D3D11_UAV_DIMENSION {
    UNKNOWN = 0x00000000,
    BUFFER = 0x00000001,
    TEXTURE1D = 0x00000002,
    TEXTURE1DARRAY = 0x00000003,
    TEXTURE2D = 0x00000004,
    TEXTURE2DARRAY = 0x00000005,
    TEXTURE3D = 0x00000008,
}

public enum D3D11_USAGE {
    DEFAULT = 0x00000000,
    IMMUTABLE = 0x00000001,
    DYNAMIC = 0x00000002,
    STAGING = 0x00000003,
}

public enum D3D11_BIND_FLAG {
    VERTEX_BUFFER = 0x00000001,
    INDEX_BUFFER = 0x00000002,
    CONSTANT_BUFFER = 0x00000004,
    SHADER_RESOURCE = 0x00000008,
    STREAM_OUTPUT = 0x00000010,
    RENDER_TARGET = 0x00000020,
    DEPTH_STENCIL = 0x00000040,
    UNORDERED_ACCESS = 0x00000080,
    DECODER = 0x00000200,
    VIDEO_ENCODER = 0x00000400,
}

public enum D3D11_CPU_ACCESS_FLAG {
    WRITE = 0x00010000,
    READ = 0x00020000,
}

public enum D3D11_RESOURCE_MISC_FLAG {
    GENERATE_MIPS = 0x00000001,
    SHARED = 0x00000002,
    TEXTURECUBE = 0x00000004,
    DRAWINDIRECT_ARGS = 0x00000010,
    BUFFER_ALLOW_RAW_VIEWS = 0x00000020,
    BUFFER_STRUCTURED = 0x00000040,
    RESOURCE_CLAMP = 0x00000080,
    SHARED_KEYEDMUTEX = 0x00000100,
    GDI_COMPATIBLE = 0x00000200,
    SHARED_NTHANDLE = 0x00000800,
    RESTRICTED_CONTENT = 0x00001000,
    RESTRICT_SHARED_RESOURCE = 0x00002000,
    RESTRICT_SHARED_RESOURCE_DRIVER = 0x00004000,
    GUARDED = 0x00008000,
    TILE_POOL = 0x00020000,
    TILED = 0x00040000,
    HW_PROTECTED = 0x00080000,
}

public enum D3D11_MAP {
    READ = 0x00000001,
    WRITE = 0x00000002,
    READ_WRITE = 0x00000003,
    WRITE_DISCARD = 0x00000004,
    WRITE_NO_OVERWRITE = 0x00000005,
}

public enum D3D11_MAP_FLAG {
    DO_NOT_WAIT = 0x00100000,
}

public enum D3D11_RAISE_FLAG {
    DRIVER_INTERNAL_ERROR = 0x00000001,
}

public enum D3D11_CLEAR_FLAG {
    DEPTH = 0x00000001,
    STENCIL = 0x00000002,
}

public struct D3D11_RECT{
    public RECT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BOX{
    /// (UINT)
    public UInt32 left;

    /// (UINT)
    public UInt32 top;

    /// (UINT)
    public UInt32 front;

    /// (UINT)
    public UInt32 right;

    /// (UINT)
    public UInt32 bottom;

    /// (UINT)
    public UInt32 back;

}

[ComImport, Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11DeviceChild{
    void GetDevice(
        /// ppDevice: (*(*(ID3D11Device)))
        ref ID3D11Device ppDevice
    );
    Int32 GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// pDataSize: (*(UINT))
        ref UInt32 pDataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(const void))
        IntPtr pData
    );
    Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// pData: (*(const IUnknown))
        IntPtr pData
    );
}

public enum D3D11_COMPARISON_FUNC {
    D3D11_COMPARISON_NEVER = 0x00000001,
    D3D11_COMPARISON_LESS = 0x00000002,
    D3D11_COMPARISON_EQUAL = 0x00000003,
    D3D11_COMPARISON_LESS_EQUAL = 0x00000004,
    D3D11_COMPARISON_GREATER = 0x00000005,
    D3D11_COMPARISON_NOT_EQUAL = 0x00000006,
    D3D11_COMPARISON_GREATER_EQUAL = 0x00000007,
    D3D11_COMPARISON_ALWAYS = 0x00000008,
}

public enum D3D11_DEPTH_WRITE_MASK {
    ZERO = 0x00000000,
    ALL = 0x00000001,
}

public enum D3D11_STENCIL_OP {
    KEEP = 0x00000001,
    ZERO = 0x00000002,
    REPLACE = 0x00000003,
    INCR_SAT = 0x00000004,
    DECR_SAT = 0x00000005,
    INVERT = 0x00000006,
    INCR = 0x00000007,
    DECR = 0x00000008,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DEPTH_STENCILOP_DESC{
    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilFailOp;

    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilDepthFailOp;

    /// (D3D11_STENCIL_OP)
    public D3D11_STENCIL_OP StencilPassOp;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC StencilFunc;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_DESC{
    /// (BOOL)
    public Int32 DepthEnable;

    /// (D3D11_DEPTH_WRITE_MASK)
    public D3D11_DEPTH_WRITE_MASK DepthWriteMask;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC DepthFunc;

    /// (BOOL)
    public Int32 StencilEnable;

    /// (UINT8)
    public Byte StencilReadMask;

    /// (UINT8)
    public Byte StencilWriteMask;

    /// (D3D11_DEPTH_STENCILOP_DESC)
    public D3D11_DEPTH_STENCILOP_DESC FrontFace;

    /// (D3D11_DEPTH_STENCILOP_DESC)
    public D3D11_DEPTH_STENCILOP_DESC BackFace;

}

[ComImport, Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1")]
public interface ID3D11DepthStencilState: ID3D11DeviceChild {
    void GetDesc(
        /// pDesc: (*(D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDesc
    );
}

public enum D3D11_BLEND {
    ZERO = 0x00000001,
    ONE = 0x00000002,
    SRC_COLOR = 0x00000003,
    INV_SRC_COLOR = 0x00000004,
    SRC_ALPHA = 0x00000005,
    INV_SRC_ALPHA = 0x00000006,
    DEST_ALPHA = 0x00000007,
    INV_DEST_ALPHA = 0x00000008,
    DEST_COLOR = 0x00000009,
    INV_DEST_COLOR = 0x0000000a,
    SRC_ALPHA_SAT = 0x0000000b,
    BLEND_FACTOR = 0x0000000e,
    INV_BLEND_FACTOR = 0x0000000f,
    SRC1_COLOR = 0x00000010,
    INV_SRC1_COLOR = 0x00000011,
    SRC1_ALPHA = 0x00000012,
    INV_SRC1_ALPHA = 0x00000013,
}

public enum D3D11_BLEND_OP {
    ADD = 0x00000001,
    SUBTRACT = 0x00000002,
    REV_SUBTRACT = 0x00000003,
    MIN = 0x00000004,
    MAX = 0x00000005,
}

public enum D3D11_COLOR_WRITE_ENABLE {
    RED = 0x00000001,
    GREEN = 0x00000002,
    BLUE = 0x00000004,
    ALPHA = 0x00000008,
    ALL = 0x0000000f,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RENDER_TARGET_BLEND_DESC{
    /// (BOOL)
    public Int32 BlendEnable;

    /// (D3D11_BLEND)
    public D3D11_BLEND SrcBlend;

    /// (D3D11_BLEND)
    public D3D11_BLEND DestBlend;

    /// (D3D11_BLEND_OP)
    public D3D11_BLEND_OP BlendOp;

    /// (D3D11_BLEND)
    public D3D11_BLEND SrcBlendAlpha;

    /// (D3D11_BLEND)
    public D3D11_BLEND DestBlendAlpha;

    /// (D3D11_BLEND_OP)
    public D3D11_BLEND_OP BlendOpAlpha;

    /// (UINT8)
    public Byte RenderTargetWriteMask;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BLEND_DESC{
    /// (BOOL)
    public Int32 AlphaToCoverageEnable;

    /// (BOOL)
    public Int32 IndependentBlendEnable;

    /// (D3D11_RENDER_TARGET_BLEND_DESC)[8]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public D3D11_RENDER_TARGET_BLEND_DESC[] RenderTarget;

}

[ComImport, Guid("75b68faa-347d-4159-8f45-a0640f01cd9a")]
public interface ID3D11BlendState: ID3D11DeviceChild {
    void GetDesc(
        /// pDesc: (*(D3D11_BLEND_DESC))
        ref D3D11_BLEND_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RASTERIZER_DESC{
    /// (D3D11_FILL_MODE)
    public D3D11_FILL_MODE FillMode;

    /// (D3D11_CULL_MODE)
    public D3D11_CULL_MODE CullMode;

    /// (BOOL)
    public Int32 FrontCounterClockwise;

    /// (INT)
    public Int32 DepthBias;

    /// (FLOAT)
    public Single DepthBiasClamp;

    /// (FLOAT)
    public Single SlopeScaledDepthBias;

    /// (BOOL)
    public Int32 DepthClipEnable;

    /// (BOOL)
    public Int32 ScissorEnable;

    /// (BOOL)
    public Int32 MultisampleEnable;

    /// (BOOL)
    public Int32 AntialiasedLineEnable;

}

[ComImport, Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7")]
public interface ID3D11RasterizerState: ID3D11DeviceChild {
    void GetDesc(
        /// pDesc: (*(D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SUBRESOURCE_DATA{
    /// (*(const void))
    public IntPtr pSysMem;

    /// (UINT)
    public UInt32 SysMemPitch;

    /// (UINT)
    public UInt32 SysMemSlicePitch;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_MAPPED_SUBRESOURCE{
    /// (*(void))
    public IntPtr pData;

    /// (UINT)
    public UInt32 RowPitch;

    /// (UINT)
    public UInt32 DepthPitch;

}

[ComImport, Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d")]
public interface ID3D11Resource: ID3D11DeviceChild {
    void GetType(
        /// pResourceDimension: (*(D3D11_RESOURCE_DIMENSION))
        ref D3D11_RESOURCE_DIMENSION pResourceDimension
    );
    void SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    );
    UInt32 GetEvictionPriority(
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_DESC{
    /// (UINT)
    public UInt32 ByteWidth;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

    /// (UINT)
    public UInt32 StructureByteStride;

}

[ComImport, Guid("48570b85-d1ee-4fcd-a250-eb350722b037")]
public interface ID3D11Buffer: ID3D11Resource {
    void GetDesc(
        /// pDesc: (*(D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE1D_DESC{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 ArraySize;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

}

[ComImport, Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c")]
public interface ID3D11Texture1D: ID3D11Resource {
    void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE1D_DESC))
        ref D3D11_TEXTURE1D_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE2D_DESC{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 ArraySize;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (DXGI_SAMPLE_DESC)
    public DXGI_SAMPLE_DESC SampleDesc;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

}

[ComImport, Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c")]
public interface ID3D11Texture2D: ID3D11Resource {
    void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE3D_DESC{
    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 Depth;

    /// (UINT)
    public UInt32 MipLevels;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    /// (D3D11_USAGE)
    public D3D11_USAGE Usage;

    /// (UINT)
    public UInt32 BindFlags;

    /// (UINT)
    public UInt32 CPUAccessFlags;

    /// (UINT)
    public UInt32 MiscFlags;

}

[ComImport, Guid("037e866e-f56d-4357-a8af-9dabbe6e250e")]
public interface ID3D11Texture3D: ID3D11Resource {
    void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE3D_DESC))
        ref D3D11_TEXTURE3D_DESC pDesc
    );
}

public enum D3D11_TEXTURECUBE_FACE {
    POSITIVE_X = 0x00000000,
    NEGATIVE_X = 0x00000001,
    POSITIVE_Y = 0x00000002,
    NEGATIVE_Y = 0x00000003,
    POSITIVE_Z = 0x00000004,
    NEGATIVE_Z = 0x00000005,
}

[ComImport, Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1")]
public interface ID3D11View: ID3D11DeviceChild {
    void GetResource(
        /// ppResource: (*(*(ID3D11Resource)))
        ref ID3D11Resource ppResource
    );
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_BUFFER_SRV{
    #region union
        [FieldOffset(0)]
        /// (UINT)
        public UInt32 FirstElement;

        [FieldOffset(0)]
        /// (UINT)
        public UInt32 ElementOffset;

    #endregion

    #region union
        [FieldOffset(4)]
        /// (UINT)
        public UInt32 NumElements;

        [FieldOffset(4)]
        /// (UINT)
        public UInt32 ElementWidth;

    #endregion

}

public enum D3D11_BUFFEREX_SRV_FLAG {
    RAW = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFEREX_SRV{
    /// (UINT)
    public UInt32 FirstElement;

    /// (UINT)
    public UInt32 NumElements;

    /// (UINT)
    public UInt32 Flags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXCUBE_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXCUBE_ARRAY_SRV{
    /// (UINT)
    public UInt32 MostDetailedMip;

    /// (UINT)
    public UInt32 MipLevels;

    /// (UINT)
    public UInt32 First2DArrayFace;

    /// (UINT)
    public UInt32 NumCubes;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_SRV{
    /// (UINT)
    public UInt32 UnusedField_NothingToDefine;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_SRV{
    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_SHADER_RESOURCE_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_SRV_DIMENSION)
    public D3D11_SRV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_SRV)
        public D3D11_BUFFER_SRV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_SRV)
        public D3D11_TEX1D_SRV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_SRV)
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_SRV)
        public D3D11_TEX2D_SRV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_SRV)
        public D3D11_TEX2D_ARRAY_SRV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_SRV)
        public D3D11_TEX2DMS_SRV Texture2DMS;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_ARRAY_SRV)
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_SRV)
        public D3D11_TEX3D_SRV Texture3D;

        [FieldOffset(8)]
        /// (D3D11_TEXCUBE_SRV)
        public D3D11_TEXCUBE_SRV TextureCube;

        [FieldOffset(8)]
        /// (D3D11_TEXCUBE_ARRAY_SRV)
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;

        [FieldOffset(8)]
        /// (D3D11_BUFFEREX_SRV)
        public D3D11_BUFFEREX_SRV BufferEx;

    #endregion

}

[ComImport, Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2")]
public interface ID3D11ShaderResourceView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_SHADER_RESOURCE_VIEW_DESC))
        ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
    );
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_BUFFER_RTV{
    #region union
        [FieldOffset(0)]
        /// (UINT)
        public UInt32 FirstElement;

        [FieldOffset(0)]
        /// (UINT)
        public UInt32 ElementOffset;

    #endregion

    #region union
        [FieldOffset(4)]
        /// (UINT)
        public UInt32 NumElements;

        [FieldOffset(4)]
        /// (UINT)
        public UInt32 ElementWidth;

    #endregion

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_RTV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_RTV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_RTV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_RTV{
    /// (UINT)
    public UInt32 UnusedField_NothingToDefine;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_RTV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_RTV{
    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_RTV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstWSlice;

    /// (UINT)
    public UInt32 WSize;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_RENDER_TARGET_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_RTV_DIMENSION)
    public D3D11_RTV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_RTV)
        public D3D11_BUFFER_RTV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_RTV)
        public D3D11_TEX1D_RTV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_RTV)
        public D3D11_TEX1D_ARRAY_RTV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_RTV)
        public D3D11_TEX2D_RTV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_RTV)
        public D3D11_TEX2D_ARRAY_RTV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_RTV)
        public D3D11_TEX2DMS_RTV Texture2DMS;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_ARRAY_RTV)
        public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_RTV)
        public D3D11_TEX3D_RTV Texture3D;

    #endregion

}

[ComImport, Guid("dfdba067-0b8d-4865-875b-d7b4516cc164")]
public interface ID3D11RenderTargetView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_RENDER_TARGET_VIEW_DESC))
        ref D3D11_RENDER_TARGET_VIEW_DESC pDesc
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_DSV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_DSV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_DSV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_DSV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_DSV{
    /// (UINT)
    public UInt32 UnusedField_NothingToDefine;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_DSV{
    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

public enum D3D11_DSV_FLAG {
    READ_ONLY_DEPTH = 0x00000001,
    READ_ONLY_STENCIL = 0x00000002,
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_DSV_DIMENSION)
    public D3D11_DSV_DIMENSION ViewDimension;

    [FieldOffset(8)]
    /// (UINT)
    public UInt32 Flags;

    #region union
        [FieldOffset(12)]
        /// (D3D11_TEX1D_DSV)
        public D3D11_TEX1D_DSV Texture1D;

        [FieldOffset(12)]
        /// (D3D11_TEX1D_ARRAY_DSV)
        public D3D11_TEX1D_ARRAY_DSV Texture1DArray;

        [FieldOffset(12)]
        /// (D3D11_TEX2D_DSV)
        public D3D11_TEX2D_DSV Texture2D;

        [FieldOffset(12)]
        /// (D3D11_TEX2D_ARRAY_DSV)
        public D3D11_TEX2D_ARRAY_DSV Texture2DArray;

        [FieldOffset(12)]
        /// (D3D11_TEX2DMS_DSV)
        public D3D11_TEX2DMS_DSV Texture2DMS;

        [FieldOffset(12)]
        /// (D3D11_TEX2DMS_ARRAY_DSV)
        public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;

    #endregion

}

[ComImport, Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6")]
public interface ID3D11DepthStencilView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_DEPTH_STENCIL_VIEW_DESC))
        ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc
    );
}

public enum D3D11_BUFFER_UAV_FLAG {
    RAW = 0x00000001,
    APPEND = 0x00000002,
    COUNTER = 0x00000004,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_UAV{
    /// (UINT)
    public UInt32 FirstElement;

    /// (UINT)
    public UInt32 NumElements;

    /// (UINT)
    public UInt32 Flags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_UAV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_UAV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_UAV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_UAV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_UAV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstWSlice;

    /// (UINT)
    public UInt32 WSize;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_UNORDERED_ACCESS_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_UAV_DIMENSION)
    public D3D11_UAV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_UAV)
        public D3D11_BUFFER_UAV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_UAV)
        public D3D11_TEX1D_UAV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_UAV)
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_UAV)
        public D3D11_TEX2D_UAV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_UAV)
        public D3D11_TEX2D_ARRAY_UAV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_UAV)
        public D3D11_TEX3D_UAV Texture3D;

    #endregion

}

[ComImport, Guid("28acf509-7f5c-48f6-8611-f316010a6380")]
public interface ID3D11UnorderedAccessView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_UNORDERED_ACCESS_VIEW_DESC))
        ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc
    );
}

[ComImport, Guid("3b301d64-d678-4289-8897-22f8928b72f3")]
public interface ID3D11VertexShader: ID3D11DeviceChild {
}

[ComImport, Guid("8e5c6061-628a-4c8e-8264-bbe45cb3d5dd")]
public interface ID3D11HullShader: ID3D11DeviceChild {
}

[ComImport, Guid("f582c508-0f36-490c-9977-31eece268cfa")]
public interface ID3D11DomainShader: ID3D11DeviceChild {
}

[ComImport, Guid("38325b96-effb-4022-ba02-2e795b70275c")]
public interface ID3D11GeometryShader: ID3D11DeviceChild {
}

[ComImport, Guid("ea82e40d-51dc-4f33-93d4-db7c9125ae8c")]
public interface ID3D11PixelShader: ID3D11DeviceChild {
}

[ComImport, Guid("4f5b196e-c2bd-495e-bd01-1fded38e4969")]
public interface ID3D11ComputeShader: ID3D11DeviceChild {
}

[ComImport, Guid("e4819ddc-4cf0-4025-bd26-5de82a3e07b7")]
public interface ID3D11InputLayout: ID3D11DeviceChild {
}

public enum D3D11_FILTER {
    MIN_MAG_MIP_POINT = 0x00000000,
    MIN_MAG_POINT_MIP_LINEAR = 0x00000001,
    MIN_POINT_MAG_LINEAR_MIP_POINT = 0x00000004,
    MIN_POINT_MAG_MIP_LINEAR = 0x00000005,
    MIN_LINEAR_MAG_MIP_POINT = 0x00000010,
    MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x00000011,
    MIN_MAG_LINEAR_MIP_POINT = 0x00000014,
    MIN_MAG_MIP_LINEAR = 0x00000015,
    ANISOTROPIC = 0x00000055,
    COMPARISON_MIN_MAG_MIP_POINT = 0x00000080,
    COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x00000081,
    COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x00000084,
    COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x00000085,
    COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x00000090,
    COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x00000091,
    COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x00000094,
    COMPARISON_MIN_MAG_MIP_LINEAR = 0x00000095,
    COMPARISON_ANISOTROPIC = 0x000000d5,
    MINIMUM_MIN_MAG_MIP_POINT = 0x00000100,
    MINIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x00000101,
    MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x00000104,
    MINIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x00000105,
    MINIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x00000110,
    MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x00000111,
    MINIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x00000114,
    MINIMUM_MIN_MAG_MIP_LINEAR = 0x00000115,
    MINIMUM_ANISOTROPIC = 0x00000155,
    MAXIMUM_MIN_MAG_MIP_POINT = 0x00000180,
    MAXIMUM_MIN_MAG_POINT_MIP_LINEAR = 0x00000181,
    MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x00000184,
    MAXIMUM_MIN_POINT_MAG_MIP_LINEAR = 0x00000185,
    MAXIMUM_MIN_LINEAR_MAG_MIP_POINT = 0x00000190,
    MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x00000191,
    MAXIMUM_MIN_MAG_LINEAR_MIP_POINT = 0x00000194,
    MAXIMUM_MIN_MAG_MIP_LINEAR = 0x00000195,
    MAXIMUM_ANISOTROPIC = 0x000001d5,
}

public enum D3D11_FILTER_TYPE {
    POINT = 0x00000000,
    LINEAR = 0x00000001,
}

public enum D3D11_FILTER_REDUCTION_TYPE {
    STANDARD = 0x00000000,
    COMPARISON = 0x00000001,
    MINIMUM = 0x00000002,
    MAXIMUM = 0x00000003,
}

public enum D3D11_TEXTURE_ADDRESS_MODE {
    WRAP = 0x00000001,
    MIRROR = 0x00000002,
    CLAMP = 0x00000003,
    BORDER = 0x00000004,
    MIRROR_ONCE = 0x00000005,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SAMPLER_DESC{
    /// (D3D11_FILTER)
    public D3D11_FILTER Filter;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressU;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressV;

    /// (D3D11_TEXTURE_ADDRESS_MODE)
    public D3D11_TEXTURE_ADDRESS_MODE AddressW;

    /// (FLOAT)
    public Single MipLODBias;

    /// (UINT)
    public UInt32 MaxAnisotropy;

    /// (D3D11_COMPARISON_FUNC)
    public D3D11_COMPARISON_FUNC ComparisonFunc;

    /// (FLOAT)[4]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public Single[] BorderColor;

    /// (FLOAT)
    public Single MinLOD;

    /// (FLOAT)
    public Single MaxLOD;

}

[ComImport, Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5")]
public interface ID3D11SamplerState: ID3D11DeviceChild {
    void GetDesc(
        /// pDesc: (*(D3D11_SAMPLER_DESC))
        ref D3D11_SAMPLER_DESC pDesc
    );
}

public enum D3D11_FORMAT_SUPPORT {
    BUFFER = 0x00000001,
    IA_VERTEX_BUFFER = 0x00000002,
    IA_INDEX_BUFFER = 0x00000004,
    SO_BUFFER = 0x00000008,
    TEXTURE1D = 0x00000010,
    TEXTURE2D = 0x00000020,
    TEXTURE3D = 0x00000040,
    TEXTURECUBE = 0x00000080,
    SHADER_LOAD = 0x00000100,
    SHADER_SAMPLE = 0x00000200,
    SHADER_SAMPLE_COMPARISON = 0x00000400,
    SHADER_SAMPLE_MONO_TEXT = 0x00000800,
    MIP = 0x00001000,
    MIP_AUTOGEN = 0x00002000,
    RENDER_TARGET = 0x00004000,
    BLENDABLE = 0x00008000,
    DEPTH_STENCIL = 0x00010000,
    CPU_LOCKABLE = 0x00020000,
    MULTISAMPLE_RESOLVE = 0x00040000,
    DISPLAY = 0x00080000,
    CAST_WITHIN_BIT_LAYOUT = 0x00100000,
    MULTISAMPLE_RENDERTARGET = 0x00200000,
    MULTISAMPLE_LOAD = 0x00400000,
    SHADER_GATHER = 0x00800000,
    BACK_BUFFER_CAST = 0x01000000,
    TYPED_UNORDERED_ACCESS_VIEW = 0x02000000,
    SHADER_GATHER_COMPARISON = 0x04000000,
    DECODER_OUTPUT = 0x08000000,
    VIDEO_PROCESSOR_OUTPUT = 0x10000000,
    VIDEO_PROCESSOR_INPUT = 0x20000000,
    VIDEO_ENCODER = 0x40000000,
}

public enum D3D11_FORMAT_SUPPORT2 {
    UAV_ATOMIC_ADD = 0x00000001,
    UAV_ATOMIC_BITWISE_OPS = 0x00000002,
    UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE = 0x00000004,
    UAV_ATOMIC_EXCHANGE = 0x00000008,
    UAV_ATOMIC_SIGNED_MIN_OR_MAX = 0x00000010,
    UAV_ATOMIC_UNSIGNED_MIN_OR_MAX = 0x00000020,
    UAV_TYPED_LOAD = 0x00000040,
    UAV_TYPED_STORE = 0x00000080,
    OUTPUT_MERGER_LOGIC_OP = 0x00000100,
    TILED = 0x00000200,
    SHAREABLE = 0x00000400,
    MULTIPLANE_OVERLAY = 0x00004000,
}

[ComImport, Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b")]
public interface ID3D11Asynchronous: ID3D11DeviceChild {
    UInt32 GetDataSize(
    );
}

public enum D3D11_ASYNC_GETDATA_FLAG {
    DONOTFLUSH = 0x00000001,
}

public enum D3D11_QUERY {
    EVENT = 0x00000000,
    OCCLUSION = 0x00000001,
    TIMESTAMP = 0x00000002,
    TIMESTAMP_DISJOINT = 0x00000003,
    PIPELINE_STATISTICS = 0x00000004,
    OCCLUSION_PREDICATE = 0x00000005,
    SO_STATISTICS = 0x00000006,
    SO_OVERFLOW_PREDICATE = 0x00000007,
    SO_STATISTICS_STREAM0 = 0x00000008,
    SO_OVERFLOW_PREDICATE_STREAM0 = 0x00000009,
    SO_STATISTICS_STREAM1 = 0x0000000a,
    SO_OVERFLOW_PREDICATE_STREAM1 = 0x0000000b,
    SO_STATISTICS_STREAM2 = 0x0000000c,
    SO_OVERFLOW_PREDICATE_STREAM2 = 0x0000000d,
    SO_STATISTICS_STREAM3 = 0x0000000e,
    SO_OVERFLOW_PREDICATE_STREAM3 = 0x0000000f,
}

public enum D3D11_QUERY_MISC_FLAG {
    PREDICATEHINT = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DESC{
    /// (D3D11_QUERY)
    public D3D11_QUERY Query;

    /// (UINT)
    public UInt32 MiscFlags;

}

[ComImport, Guid("d6c00747-87b7-425e-b84d-44d108560afd")]
public interface ID3D11Query: ID3D11Asynchronous {
    void GetDesc(
        /// pDesc: (*(D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pDesc
    );
}

[ComImport, Guid("9eb576dd-9f77-4d86-81aa-8bab5fe490e2")]
public interface ID3D11Predicate: ID3D11Query {
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_TIMESTAMP_DISJOINT{
    /// (UINT64)
    public UInt64 Frequency;

    /// (BOOL)
    public Int32 Disjoint;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_PIPELINE_STATISTICS{
    /// (UINT64)
    public UInt64 IAVertices;

    /// (UINT64)
    public UInt64 IAPrimitives;

    /// (UINT64)
    public UInt64 VSInvocations;

    /// (UINT64)
    public UInt64 GSInvocations;

    /// (UINT64)
    public UInt64 GSPrimitives;

    /// (UINT64)
    public UInt64 CInvocations;

    /// (UINT64)
    public UInt64 CPrimitives;

    /// (UINT64)
    public UInt64 PSInvocations;

    /// (UINT64)
    public UInt64 HSInvocations;

    /// (UINT64)
    public UInt64 DSInvocations;

    /// (UINT64)
    public UInt64 CSInvocations;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_SO_STATISTICS{
    /// (UINT64)
    public UInt64 NumPrimitivesWritten;

    /// (UINT64)
    public UInt64 PrimitivesStorageNeeded;

}

public enum D3D11_COUNTER {
    DEVICE_DEPENDENT_0 = 0x40000000,
}

public enum D3D11_COUNTER_TYPE {
    FLOAT32 = 0x00000000,
    UINT16 = 0x00000001,
    UINT32 = 0x00000002,
    UINT64 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_COUNTER_DESC{
    /// (D3D11_COUNTER)
    public D3D11_COUNTER Counter;

    /// (UINT)
    public UInt32 MiscFlags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_COUNTER_INFO{
    /// (D3D11_COUNTER)
    public D3D11_COUNTER LastDeviceDependentCounter;

    /// (UINT)
    public UInt32 NumSimultaneousCounters;

    /// (UINT8)
    public Byte NumDetectableParallelUnits;

}

[ComImport, Guid("6e8c49fb-a371-4770-b440-29086022b741")]
public interface ID3D11Counter: ID3D11Asynchronous {
    void GetDesc(
        /// pDesc: (*(D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pDesc
    );
}

public enum D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS {
    D3D11_STANDARD_MULTISAMPLE_PATTERN = -0x0000001,
    D3D11_CENTER_MULTISAMPLE_PATTERN = -0x0000002,
}

public enum D3D11_DEVICE_CONTEXT_TYPE {
    D3D11_DEVICE_CONTEXT_IMMEDIATE = 0x00000000,
    D3D11_DEVICE_CONTEXT_DEFERRED = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_CLASS_INSTANCE_DESC{
    /// (UINT)
    public UInt32 InstanceId;

    /// (UINT)
    public UInt32 InstanceIndex;

    /// (UINT)
    public UInt32 TypeId;

    /// (UINT)
    public UInt32 ConstantBuffer;

    /// (UINT)
    public UInt32 BaseConstantBufferOffset;

    /// (UINT)
    public UInt32 BaseTexture;

    /// (UINT)
    public UInt32 BaseSampler;

    /// (BOOL)
    public Int32 Created;

}

[ComImport, Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb")]
public interface ID3D11ClassInstance: ID3D11DeviceChild {
    void GetClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref ID3D11ClassLinkage ppLinkage
    );
    void GetDesc(
        /// pDesc: (*(D3D11_CLASS_INSTANCE_DESC))
        ref D3D11_CLASS_INSTANCE_DESC pDesc
    );
    void GetInstanceName(
        /// pInstanceName: (LPSTR)
        IntPtr pInstanceName,
        /// pBufferLength: (*(SIZE_T))
        ref UIntPtr pBufferLength
    );
    void GetTypeName(
        /// pTypeName: (LPSTR)
        IntPtr pTypeName,
        /// pBufferLength: (*(SIZE_T))
        ref UIntPtr pBufferLength
    );
}

[ComImport, Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed")]
public interface ID3D11ClassLinkage: ID3D11DeviceChild {
    Int32 GetClassInstance(
        /// pClassInstanceName: (LPCSTR)
        IntPtr pClassInstanceName,
        /// InstanceIndex: (UINT)
        UInt32 InstanceIndex,
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppInstance
    );
    Int32 CreateClassInstance(
        /// pClassTypeName: (LPCSTR)
        IntPtr pClassTypeName,
        /// ConstantBufferOffset: (UINT)
        UInt32 ConstantBufferOffset,
        /// ConstantVectorOffset: (UINT)
        UInt32 ConstantVectorOffset,
        /// TextureOffset: (UINT)
        UInt32 TextureOffset,
        /// SamplerOffset: (UINT)
        UInt32 SamplerOffset,
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppInstance
    );
}

[ComImport, Guid("a24bc4d1-769e-43f7-8013-98ff566c18e2")]
public interface ID3D11CommandList: ID3D11DeviceChild {
    UInt32 GetContextFlags(
    );
}

public enum D3D11_FEATURE {
    THREADING = 0x00000000,
    DOUBLES = 0x00000001,
    FORMAT_SUPPORT = 0x00000002,
    FORMAT_SUPPORT2 = 0x00000003,
    D3D10_X_HARDWARE_OPTIONS = 0x00000004,
    D3D11_OPTIONS = 0x00000005,
    ARCHITECTURE_INFO = 0x00000006,
    D3D9_OPTIONS = 0x00000007,
    SHADER_MIN_PRECISION_SUPPORT = 0x00000008,
    D3D9_SHADOW_SUPPORT = 0x00000009,
    D3D11_OPTIONS1 = 0x0000000a,
    D3D9_SIMPLE_INSTANCING_SUPPORT = 0x0000000b,
    MARKER_SUPPORT = 0x0000000c,
    D3D9_OPTIONS1 = 0x0000000d,
    D3D11_OPTIONS2 = 0x0000000e,
    D3D11_OPTIONS3 = 0x0000000f,
    GPU_VIRTUAL_ADDRESS_SUPPORT = 0x00000010,
    D3D11_OPTIONS4 = 0x00000011,
    SHADER_CACHE = 0x00000012,
    D3D11_OPTIONS5 = 0x00000013,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_THREADING{
    /// (BOOL)
    public Int32 DriverConcurrentCreates;

    /// (BOOL)
    public Int32 DriverCommandLists;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_DOUBLES{
    /// (BOOL)
    public Int32 DoublePrecisionFloatShaderOps;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_FORMAT_SUPPORT{
    /// (DXGI_FORMAT)
    public DXGI_FORMAT InFormat;

    /// (UINT)
    public UInt32 OutFormatSupport;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_FORMAT_SUPPORT2{
    /// (DXGI_FORMAT)
    public DXGI_FORMAT InFormat;

    /// (UINT)
    public UInt32 OutFormatSupport2;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS{
    /// (BOOL)
    public Int32 ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS{
    /// (BOOL)
    public Int32 OutputMergerLogicOp;

    /// (BOOL)
    public Int32 UAVOnlyRenderingForcedSampleCount;

    /// (BOOL)
    public Int32 DiscardAPIsSeenByDriver;

    /// (BOOL)
    public Int32 FlagsForUpdateAndCopySeenByDriver;

    /// (BOOL)
    public Int32 ClearView;

    /// (BOOL)
    public Int32 CopyWithOverlap;

    /// (BOOL)
    public Int32 ConstantBufferPartialUpdate;

    /// (BOOL)
    public Int32 ConstantBufferOffsetting;

    /// (BOOL)
    public Int32 MapNoOverwriteOnDynamicConstantBuffer;

    /// (BOOL)
    public Int32 MapNoOverwriteOnDynamicBufferSRV;

    /// (BOOL)
    public Int32 MultisampleRTVWithForcedSampleCountOne;

    /// (BOOL)
    public Int32 SAD4ShaderInstructions;

    /// (BOOL)
    public Int32 ExtendedDoublesShaderInstructions;

    /// (BOOL)
    public Int32 ExtendedResourceSharing;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_ARCHITECTURE_INFO{
    /// (BOOL)
    public Int32 TileBasedDeferredRenderer;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_OPTIONS{
    /// (BOOL)
    public Int32 FullNonPow2TextureSupport;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_SHADOW_SUPPORT{
    /// (BOOL)
    public Int32 SupportsDepthAsTextureWithLessEqualComparisonFilter;

}

public enum D3D11_SHADER_MIN_PRECISION_SUPPORT {
    D3D11_SHADER_MIN_PRECISION_10_BIT = 0x00000001,
    D3D11_SHADER_MIN_PRECISION_16_BIT = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT{
    /// (UINT)
    public UInt32 PixelShaderMinPrecision;

    /// (UINT)
    public UInt32 AllOtherShaderStagesMinPrecision;

}

public enum D3D11_TILED_RESOURCES_TIER {
    D3D11_TILED_RESOURCES_NOT_SUPPORTED = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
    _3 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS1{
    /// (D3D11_TILED_RESOURCES_TIER)
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

    /// (BOOL)
    public Int32 MinMaxFiltering;

    /// (BOOL)
    public Int32 ClearViewAlsoSupportsDepthOnlyFormats;

    /// (BOOL)
    public Int32 MapOnDefaultBuffers;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_SIMPLE_INSTANCING_SUPPORT{
    /// (BOOL)
    public Int32 SimpleInstancingSupported;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_MARKER_SUPPORT{
    /// (BOOL)
    public Int32 Profile;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_OPTIONS1{
    /// (BOOL)
    public Int32 FullNonPow2TextureSupported;

    /// (BOOL)
    public Int32 DepthAsTextureWithLessEqualComparisonFilterSupported;

    /// (BOOL)
    public Int32 SimpleInstancingSupported;

    /// (BOOL)
    public Int32 TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;

}

public enum D3D11_CONSERVATIVE_RASTERIZATION_TIER {
    D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
    _3 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS2{
    /// (BOOL)
    public Int32 PSSpecifiedStencilRefSupported;

    /// (BOOL)
    public Int32 TypedUAVLoadAdditionalFormats;

    /// (BOOL)
    public Int32 ROVsSupported;

    /// (D3D11_CONSERVATIVE_RASTERIZATION_TIER)
    public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

    /// (D3D11_TILED_RESOURCES_TIER)
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

    /// (BOOL)
    public Int32 MapOnDefaultTextures;

    /// (BOOL)
    public Int32 StandardSwizzle;

    /// (BOOL)
    public Int32 UnifiedMemoryArchitecture;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS3{
    /// (BOOL)
    public Int32 VPAndRTArrayIndexFromAnyShaderFeedingRasterizer;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT{
    /// (UINT)
    public UInt32 MaxGPUVirtualAddressBitsPerResource;

    /// (UINT)
    public UInt32 MaxGPUVirtualAddressBitsPerProcess;

}

public enum D3D11_SHADER_CACHE_SUPPORT_FLAGS {
    D3D11_SHADER_CACHE_SUPPORT_NONE = 0x00000000,
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x00000001,
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_SHADER_CACHE{
    /// (UINT)
    public UInt32 SupportFlags;

}

public enum D3D11_SHARED_RESOURCE_TIER {
    _0 = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS5{
    /// (D3D11_SHARED_RESOURCE_TIER)
    public D3D11_SHARED_RESOURCE_TIER SharedResourceTier;

}

[ComImport, Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
public interface ID3D11DeviceContext: ID3D11DeviceChild {
    void VSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void PSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void PSSetShader(
        /// pPixelShader: (*(ID3D11PixelShader))
        ID3D11PixelShader pPixelShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void PSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void VSSetShader(
        /// pVertexShader: (*(ID3D11VertexShader))
        ID3D11VertexShader pVertexShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void DrawIndexed(
        /// IndexCount: (UINT)
        UInt32 IndexCount,
        /// StartIndexLocation: (UINT)
        UInt32 StartIndexLocation,
        /// BaseVertexLocation: (INT)
        Int32 BaseVertexLocation
    );
    void Draw(
        /// VertexCount: (UINT)
        UInt32 VertexCount,
        /// StartVertexLocation: (UINT)
        UInt32 StartVertexLocation
    );
    Int32 Map(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// Subresource: (UINT)
        UInt32 Subresource,
        /// MapType: (D3D11_MAP)
        D3D11_MAP MapType,
        /// MapFlags: (UINT)
        UInt32 MapFlags,
        /// pMappedResource: (*(D3D11_MAPPED_SUBRESOURCE))
        ref D3D11_MAPPED_SUBRESOURCE pMappedResource
    );
    void Unmap(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// Subresource: (UINT)
        UInt32 Subresource
    );
    void PSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void IASetInputLayout(
        /// pInputLayout: (*(ID3D11InputLayout))
        ID3D11InputLayout pInputLayout
    );
    void IASetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppVertexBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppVertexBuffers,
        /// pStrides: (*(const UINT))
        ref UInt32 pStrides,
        /// pOffsets: (*(const UINT))
        ref UInt32 pOffsets
    );
    void IASetIndexBuffer(
        /// pIndexBuffer: (*(ID3D11Buffer))
        ID3D11Buffer pIndexBuffer,
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format,
        /// Offset: (UINT)
        UInt32 Offset
    );
    void DrawIndexedInstanced(
        /// IndexCountPerInstance: (UINT)
        UInt32 IndexCountPerInstance,
        /// InstanceCount: (UINT)
        UInt32 InstanceCount,
        /// StartIndexLocation: (UINT)
        UInt32 StartIndexLocation,
        /// BaseVertexLocation: (INT)
        Int32 BaseVertexLocation,
        /// StartInstanceLocation: (UINT)
        UInt32 StartInstanceLocation
    );
    void DrawInstanced(
        /// VertexCountPerInstance: (UINT)
        UInt32 VertexCountPerInstance,
        /// InstanceCount: (UINT)
        UInt32 InstanceCount,
        /// StartVertexLocation: (UINT)
        UInt32 StartVertexLocation,
        /// StartInstanceLocation: (UINT)
        UInt32 StartInstanceLocation
    );
    void GSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void GSSetShader(
        /// pShader: (*(ID3D11GeometryShader))
        ID3D11GeometryShader pShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void IASetPrimitiveTopology(
        /// Topology: (D3D11_PRIMITIVE_TOPOLOGY)
        D3D11_PRIMITIVE_TOPOLOGY Topology
    );
    void VSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void VSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void Begin(
        /// pAsync: (*(ID3D11Asynchronous))
        ID3D11Asynchronous pAsync
    );
    void End(
        /// pAsync: (*(ID3D11Asynchronous))
        ID3D11Asynchronous pAsync
    );
    Int32 GetData(
        /// pAsync: (*(ID3D11Asynchronous))
        ID3D11Asynchronous pAsync,
        /// pData: (*(void))
        IntPtr pData,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// GetDataFlags: (UINT)
        UInt32 GetDataFlags
    );
    void SetPredication(
        /// pPredicate: (*(ID3D11Predicate))
        ID3D11Predicate pPredicate,
        /// PredicateValue: (BOOL)
        Int32 PredicateValue
    );
    void GSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void GSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void OMSetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        ref ID3D11RenderTargetView ppRenderTargetViews,
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        ID3D11DepthStencilView pDepthStencilView
    );
    void OMSetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs,
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        ref ID3D11RenderTargetView ppRenderTargetViews,
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        ID3D11DepthStencilView pDepthStencilView,
        /// UAVStartSlot: (UINT)
        UInt32 UAVStartSlot,
        /// NumUAVs: (UINT)
        UInt32 NumUAVs,
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        ref ID3D11UnorderedAccessView ppUnorderedAccessViews,
        /// pUAVInitialCounts: (*(const UINT))
        ref UInt32 pUAVInitialCounts
    );
    void OMSetBlendState(
        /// pBlendState: (*(ID3D11BlendState))
        ID3D11BlendState pBlendState,
        /// BlendFactor: (const FLOAT)[4]
        ref Vector4 BlendFactor,
        /// SampleMask: (UINT)
        UInt32 SampleMask
    );
    void OMSetDepthStencilState(
        /// pDepthStencilState: (*(ID3D11DepthStencilState))
        ID3D11DepthStencilState pDepthStencilState,
        /// StencilRef: (UINT)
        UInt32 StencilRef
    );
    void SOSetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppSOTargets: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppSOTargets,
        /// pOffsets: (*(const UINT))
        ref UInt32 pOffsets
    );
    void DrawAuto(
    );
    void DrawIndexedInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        ID3D11Buffer pBufferForArgs,
        /// AlignedByteOffsetForArgs: (UINT)
        UInt32 AlignedByteOffsetForArgs
    );
    void DrawInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        ID3D11Buffer pBufferForArgs,
        /// AlignedByteOffsetForArgs: (UINT)
        UInt32 AlignedByteOffsetForArgs
    );
    void Dispatch(
        /// ThreadGroupCountX: (UINT)
        UInt32 ThreadGroupCountX,
        /// ThreadGroupCountY: (UINT)
        UInt32 ThreadGroupCountY,
        /// ThreadGroupCountZ: (UINT)
        UInt32 ThreadGroupCountZ
    );
    void DispatchIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        ID3D11Buffer pBufferForArgs,
        /// AlignedByteOffsetForArgs: (UINT)
        UInt32 AlignedByteOffsetForArgs
    );
    void RSSetState(
        /// pRasterizerState: (*(ID3D11RasterizerState))
        ID3D11RasterizerState pRasterizerState
    );
    void RSSetViewports(
        /// NumViewports: (UINT)
        UInt32 NumViewports,
        /// pViewports: (*(const D3D11_VIEWPORT))
        ref D3D11_VIEWPORT pViewports
    );
    void RSSetScissorRects(
        /// NumRects: (UINT)
        UInt32 NumRects,
        /// pRects: (*(const D3D11_RECT))
        ref D3D11_RECT pRects
    );
    void CopySubresourceRegion(
        /// pDstResource: (*(ID3D11Resource))
        ID3D11Resource pDstResource,
        /// DstSubresource: (UINT)
        UInt32 DstSubresource,
        /// DstX: (UINT)
        UInt32 DstX,
        /// DstY: (UINT)
        UInt32 DstY,
        /// DstZ: (UINT)
        UInt32 DstZ,
        /// pSrcResource: (*(ID3D11Resource))
        ID3D11Resource pSrcResource,
        /// SrcSubresource: (UINT)
        UInt32 SrcSubresource,
        /// pSrcBox: (*(const D3D11_BOX))
        ref D3D11_BOX pSrcBox
    );
    void CopyResource(
        /// pDstResource: (*(ID3D11Resource))
        ID3D11Resource pDstResource,
        /// pSrcResource: (*(ID3D11Resource))
        ID3D11Resource pSrcResource
    );
    void UpdateSubresource(
        /// pDstResource: (*(ID3D11Resource))
        ID3D11Resource pDstResource,
        /// DstSubresource: (UINT)
        UInt32 DstSubresource,
        /// pDstBox: (*(const D3D11_BOX))
        ref D3D11_BOX pDstBox,
        /// pSrcData: (*(const void))
        IntPtr pSrcData,
        /// SrcRowPitch: (UINT)
        UInt32 SrcRowPitch,
        /// SrcDepthPitch: (UINT)
        UInt32 SrcDepthPitch
    );
    void CopyStructureCount(
        /// pDstBuffer: (*(ID3D11Buffer))
        ID3D11Buffer pDstBuffer,
        /// DstAlignedByteOffset: (UINT)
        UInt32 DstAlignedByteOffset,
        /// pSrcView: (*(ID3D11UnorderedAccessView))
        ID3D11UnorderedAccessView pSrcView
    );
    void ClearRenderTargetView(
        /// pRenderTargetView: (*(ID3D11RenderTargetView))
        ID3D11RenderTargetView pRenderTargetView,
        /// ColorRGBA: (const FLOAT)[4]
        ref Vector4 ColorRGBA
    );
    void ClearUnorderedAccessViewUint(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        ID3D11UnorderedAccessView pUnorderedAccessView,
        /// Values: (const UINT)[4]
        UInt32[] Values
    );
    void ClearUnorderedAccessViewFloat(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        ID3D11UnorderedAccessView pUnorderedAccessView,
        /// Values: (const FLOAT)[4]
        ref Vector4 Values
    );
    void ClearDepthStencilView(
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        ID3D11DepthStencilView pDepthStencilView,
        /// ClearFlags: (UINT)
        UInt32 ClearFlags,
        /// Depth: (FLOAT)
        Single Depth,
        /// Stencil: (UINT8)
        Byte Stencil
    );
    void GenerateMips(
        /// pShaderResourceView: (*(ID3D11ShaderResourceView))
        ID3D11ShaderResourceView pShaderResourceView
    );
    void SetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// MinLOD: (FLOAT)
        Single MinLOD
    );
    Single GetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource
    );
    void ResolveSubresource(
        /// pDstResource: (*(ID3D11Resource))
        ID3D11Resource pDstResource,
        /// DstSubresource: (UINT)
        UInt32 DstSubresource,
        /// pSrcResource: (*(ID3D11Resource))
        ID3D11Resource pSrcResource,
        /// SrcSubresource: (UINT)
        UInt32 SrcSubresource,
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
    );
    void ExecuteCommandList(
        /// pCommandList: (*(ID3D11CommandList))
        ID3D11CommandList pCommandList,
        /// RestoreContextState: (BOOL)
        Int32 RestoreContextState
    );
    void HSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void HSSetShader(
        /// pHullShader: (*(ID3D11HullShader))
        ID3D11HullShader pHullShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void HSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void HSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void DSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void DSSetShader(
        /// pDomainShader: (*(ID3D11DomainShader))
        ID3D11DomainShader pDomainShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void DSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void DSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void CSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void CSSetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumUAVs: (UINT)
        UInt32 NumUAVs,
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        ref ID3D11UnorderedAccessView ppUnorderedAccessViews,
        /// pUAVInitialCounts: (*(const UINT))
        ref UInt32 pUAVInitialCounts
    );
    void CSSetShader(
        /// pComputeShader: (*(ID3D11ComputeShader))
        ID3D11ComputeShader pComputeShader,
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// NumClassInstances: (UINT)
        UInt32 NumClassInstances
    );
    void CSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void CSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void VSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void PSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void PSGetShader(
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        ref ID3D11PixelShader ppPixelShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void PSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void VSGetShader(
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        ref ID3D11VertexShader ppVertexShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void PSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void IAGetInputLayout(
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        ref ID3D11InputLayout ppInputLayout
    );
    void IAGetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppVertexBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppVertexBuffers,
        /// pStrides: (*(UINT))
        ref UInt32 pStrides,
        /// pOffsets: (*(UINT))
        ref UInt32 pOffsets
    );
    void IAGetIndexBuffer(
        /// pIndexBuffer: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer pIndexBuffer,
        /// Format: (*(DXGI_FORMAT))
        ref DXGI_FORMAT Format,
        /// Offset: (*(UINT))
        ref UInt32 Offset
    );
    void GSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void GSGetShader(
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        ref ID3D11GeometryShader ppGeometryShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void IAGetPrimitiveTopology(
        /// pTopology: (*(D3D11_PRIMITIVE_TOPOLOGY))
        ref D3D11_PRIMITIVE_TOPOLOGY pTopology
    );
    void VSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void VSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void GetPredication(
        /// ppPredicate: (*(*(ID3D11Predicate)))
        ref ID3D11Predicate ppPredicate,
        /// pPredicateValue: (*(BOOL))
        ref Int32 pPredicateValue
    );
    void GSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void GSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void OMGetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        ref ID3D11RenderTargetView ppRenderTargetViews,
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        ref ID3D11DepthStencilView ppDepthStencilView
    );
    void OMGetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs,
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        ref ID3D11RenderTargetView ppRenderTargetViews,
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        ref ID3D11DepthStencilView ppDepthStencilView,
        /// UAVStartSlot: (UINT)
        UInt32 UAVStartSlot,
        /// NumUAVs: (UINT)
        UInt32 NumUAVs,
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        ref ID3D11UnorderedAccessView ppUnorderedAccessViews
    );
    void OMGetBlendState(
        /// ppBlendState: (*(*(ID3D11BlendState)))
        ref ID3D11BlendState ppBlendState,
        /// BlendFactor: (FLOAT)[4]
        ref Vector4 BlendFactor,
        /// pSampleMask: (*(UINT))
        ref UInt32 pSampleMask
    );
    void OMGetDepthStencilState(
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        ref ID3D11DepthStencilState ppDepthStencilState,
        /// pStencilRef: (*(UINT))
        ref UInt32 pStencilRef
    );
    void SOGetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppSOTargets: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppSOTargets
    );
    void RSGetState(
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        ref ID3D11RasterizerState ppRasterizerState
    );
    void RSGetViewports(
        /// pNumViewports: (*(UINT))
        ref UInt32 pNumViewports,
        /// pViewports: (*(D3D11_VIEWPORT))
        ref D3D11_VIEWPORT pViewports
    );
    void RSGetScissorRects(
        /// pNumRects: (*(UINT))
        ref UInt32 pNumRects,
        /// pRects: (*(D3D11_RECT))
        ref D3D11_RECT pRects
    );
    void HSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void HSGetShader(
        /// ppHullShader: (*(*(ID3D11HullShader)))
        ref ID3D11HullShader ppHullShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void HSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void HSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void DSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void DSGetShader(
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        ref ID3D11DomainShader ppDomainShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void DSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void DSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void CSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumViews: (UINT)
        UInt32 NumViews,
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppShaderResourceViews
    );
    void CSGetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumUAVs: (UINT)
        UInt32 NumUAVs,
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        ref ID3D11UnorderedAccessView ppUnorderedAccessViews
    );
    void CSGetShader(
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        ref ID3D11ComputeShader ppComputeShader,
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        ref ID3D11ClassInstance ppClassInstances,
        /// pNumClassInstances: (*(UINT))
        ref UInt32 pNumClassInstances
    );
    void CSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumSamplers: (UINT)
        UInt32 NumSamplers,
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplers
    );
    void CSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppConstantBuffers
    );
    void ClearState(
    );
    void Flush(
    );
    D3D11_DEVICE_CONTEXT_TYPE GetType(
    );
    UInt32 GetContextFlags(
    );
    Int32 FinishCommandList(
        /// RestoreDeferredContextState: (BOOL)
        Int32 RestoreDeferredContextState,
        /// ppCommandList: (*(*(ID3D11CommandList)))
        ref ID3D11CommandList ppCommandList
    );
}

public struct APP_DEPRECATED_HRESULT{
    public Int32 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_DESC{
    /// (GUID)
    public Guid Guid;

    /// (UINT)
    public UInt32 SampleWidth;

    /// (UINT)
    public UInt32 SampleHeight;

    /// (DXGI_FORMAT)
    public DXGI_FORMAT OutputFormat;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_CONFIG{
    /// (GUID)
    public Guid guidConfigBitstreamEncryption;

    /// (GUID)
    public Guid guidConfigMBcontrolEncryption;

    /// (GUID)
    public Guid guidConfigResidDiffEncryption;

    /// (UINT)
    public UInt32 ConfigBitstreamRaw;

    /// (UINT)
    public UInt32 ConfigMBcontrolRasterOrder;

    /// (UINT)
    public UInt32 ConfigResidDiffHost;

    /// (UINT)
    public UInt32 ConfigSpatialResid8;

    /// (UINT)
    public UInt32 ConfigResid8Subtraction;

    /// (UINT)
    public UInt32 ConfigSpatialHost8or9Clipping;

    /// (UINT)
    public UInt32 ConfigSpatialResidInterleaved;

    /// (UINT)
    public UInt32 ConfigIntraResidUnsigned;

    /// (UINT)
    public UInt32 ConfigResidDiffAccelerator;

    /// (UINT)
    public UInt32 ConfigHostInverseScan;

    /// (UINT)
    public UInt32 ConfigSpecificIDCT;

    /// (UINT)
    public UInt32 Config4GroupedCoefs;

    /// (USHORT)
    public UInt16 ConfigMinRenderTargetBuffCount;

    /// (USHORT)
    public UInt16 ConfigDecoderSpecific;

}

public enum D3D11_VIDEO_DECODER_BUFFER_TYPE {
    D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS = 0x00000000,
    D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL = 0x00000001,
    D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE = 0x00000002,
    D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL = 0x00000003,
    D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX = 0x00000004,
    D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL = 0x00000005,
    D3D11_VIDEO_DECODER_BUFFER_BITSTREAM = 0x00000006,
    D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR = 0x00000007,
    D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN = 0x00000008,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct _D3D11_AES_CTR_IV{
    /// (UINT64)
    public UInt64 IV;

    /// (UINT64)
    public UInt64 Count;

}

public struct D3D11_AES_CTR_IV{
    public _D3D11_AES_CTR_IV Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_ENCRYPTED_BLOCK_INFO{
    /// (UINT)
    public UInt32 NumEncryptedBytesAtBeginning;

    /// (UINT)
    public UInt32 NumBytesInSkipPattern;

    /// (UINT)
    public UInt32 NumBytesInEncryptPattern;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_BUFFER_DESC{
    /// (D3D11_VIDEO_DECODER_BUFFER_TYPE)
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

    /// (UINT)
    public UInt32 BufferIndex;

    /// (UINT)
    public UInt32 DataOffset;

    /// (UINT)
    public UInt32 DataSize;

    /// (UINT)
    public UInt32 FirstMBaddress;

    /// (UINT)
    public UInt32 NumMBsInBuffer;

    /// (UINT)
    public UInt32 Width;

    /// (UINT)
    public UInt32 Height;

    /// (UINT)
    public UInt32 Stride;

    /// (UINT)
    public UInt32 ReservedBits;

    /// (*(void))
    public IntPtr pIV;

    /// (UINT)
    public UInt32 IVSize;

    /// (BOOL)
    public Int32 PartialEncryption;

    /// (D3D11_ENCRYPTED_BLOCK_INFO)
    public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_EXTENSION{
    /// (UINT)
    public UInt32 Function;

    /// (*(void))
    public IntPtr pPrivateInputData;

    /// (UINT)
    public UInt32 PrivateInputDataSize;

    /// (*(void))
    public IntPtr pPrivateOutputData;

    /// (UINT)
    public UInt32 PrivateOutputDataSize;

    /// (UINT)
    public UInt32 ResourceCount;

    /// (*(*(ID3D11Resource)))
    public IntPtr ppResourceList;

}

[ComImport, Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c")]
public interface ID3D11VideoDecoder: ID3D11DeviceChild {
    Int32 GetCreationParameters(
        /// pVideoDesc: (*(D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc,
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        ref D3D11_VIDEO_DECODER_CONFIG pConfig
    );
    Int32 GetDriverHandle(
        /// pDriverHandle: (*(HANDLE))
        ref IntPtr pDriverHandle
    );
}

public enum D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT {
    INPUT = 0x00000001,
    OUTPUT = 0x00000002,
}

public enum D3D11_VIDEO_PROCESSOR_DEVICE_CAPS {
    LINEAR_SPACE = 0x00000001,
    xvYCC = 0x00000002,
    RGB_RANGE_CONVERSION = 0x00000004,
    YCbCr_MATRIX_CONVERSION = 0x00000008,
    NOMINAL_RANGE = 0x00000010,
}

public enum D3D11_VIDEO_PROCESSOR_FEATURE_CAPS {
    ALPHA_FILL = 0x00000001,
    CONSTRICTION = 0x00000002,
    LUMA_KEY = 0x00000004,
    ALPHA_PALETTE = 0x00000008,
    LEGACY = 0x00000010,
    STEREO = 0x00000020,
    ROTATION = 0x00000040,
    ALPHA_STREAM = 0x00000080,
    PIXEL_ASPECT_RATIO = 0x00000100,
    MIRROR = 0x00000200,
    SHADER_USAGE = 0x00000400,
    METADATA_HDR10 = 0x00000800,
}

public enum D3D11_VIDEO_PROCESSOR_FILTER_CAPS {
    BRIGHTNESS = 0x00000001,
    CONTRAST = 0x00000002,
    HUE = 0x00000004,
    SATURATION = 0x00000008,
    NOISE_REDUCTION = 0x00000010,
    EDGE_ENHANCEMENT = 0x00000020,
    ANAMORPHIC_SCALING = 0x00000040,
    STEREO_ADJUSTMENT = 0x00000080,
}

public enum D3D11_VIDEO_PROCESSOR_FORMAT_CAPS {
    RGB_INTERLACED = 0x00000001,
    RGB_PROCAMP = 0x00000002,
    RGB_LUMA_KEY = 0x00000004,
    PALETTE_INTERLACED = 0x00000008,
}

public enum D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS {
    DENOISE = 0x00000001,
    DERINGING = 0x00000002,
    EDGE_ENHANCEMENT = 0x00000004,
    COLOR_CORRECTION = 0x00000008,
    FLESH_TONE_MAPPING = 0x00000010,
    IMAGE_STABILIZATION = 0x00000020,
    SUPER_RESOLUTION = 0x00000040,
    ANAMORPHIC_SCALING = 0x00000080,
}

public enum D3D11_VIDEO_PROCESSOR_STEREO_CAPS {
    MONO_OFFSET = 0x00000001,
    ROW_INTERLEAVED = 0x00000002,
    COLUMN_INTERLEAVED = 0x00000004,
    CHECKERBOARD = 0x00000008,
    FLIP_MODE = 0x00000010,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CAPS{
    /// (UINT)
    public UInt32 DeviceCaps;

    /// (UINT)
    public UInt32 FeatureCaps;

    /// (UINT)
    public UInt32 FilterCaps;

    /// (UINT)
    public UInt32 InputFormatCaps;

    /// (UINT)
    public UInt32 AutoStreamCaps;

    /// (UINT)
    public UInt32 StereoCaps;

    /// (UINT)
    public UInt32 RateConversionCapsCount;

    /// (UINT)
    public UInt32 MaxInputStreams;

    /// (UINT)
    public UInt32 MaxStreamStates;

}

public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS {
    DEINTERLACE_BLEND = 0x00000001,
    DEINTERLACE_BOB = 0x00000002,
    DEINTERLACE_ADAPTIVE = 0x00000004,
    DEINTERLACE_MOTION_COMPENSATION = 0x00000008,
    INVERSE_TELECINE = 0x00000010,
    FRAME_RATE_CONVERSION = 0x00000020,
}

public enum D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS {
    _32 = 0x00000001,
    _22 = 0x00000002,
    _2224 = 0x00000004,
    _2332 = 0x00000008,
    _32322 = 0x00000010,
    _55 = 0x00000020,
    _64 = 0x00000040,
    _87 = 0x00000080,
    _222222222223 = 0x00000100,
    OTHER = -0x80000000,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS{
    /// (UINT)
    public UInt32 PastFrames;

    /// (UINT)
    public UInt32 FutureFrames;

    /// (UINT)
    public UInt32 ProcessorCaps;

    /// (UINT)
    public UInt32 ITelecineCaps;

    /// (UINT)
    public UInt32 CustomRateCount;

}

public enum D3D11_CONTENT_PROTECTION_CAPS {
    SOFTWARE = 0x00000001,
    HARDWARE = 0x00000002,
    PROTECTION_ALWAYS_ON = 0x00000004,
    PARTIAL_DECRYPTION = 0x00000008,
    CONTENT_KEY = 0x00000010,
    FRESHEN_SESSION_KEY = 0x00000020,
    ENCRYPTED_READ_BACK = 0x00000040,
    ENCRYPTED_READ_BACK_KEY = 0x00000080,
    SEQUENTIAL_CTR_IV = 0x00000100,
    ENCRYPT_SLICEDATA_ONLY = 0x00000200,
    DECRYPTION_BLT = 0x00000400,
    HARDWARE_PROTECT_UNCOMPRESSED = 0x00000800,
    HARDWARE_PROTECTED_MEMORY_PAGEABLE = 0x00001000,
    HARDWARE_TEARDOWN = 0x00002000,
    HARDWARE_DRM_COMMUNICATION = 0x00004000,
    HARDWARE_DRM_COMMUNICATION_MULTI_THREADED = 0x00008000,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS{
    /// (UINT)
    public UInt32 Caps;

    /// (UINT)
    public UInt32 KeyExchangeTypeCount;

    /// (UINT)
    public UInt32 BlockAlignmentSize;

    /// (ULONGLONG)
    public UInt64 ProtectedMemorySize;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE{
    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL CustomRate;

    /// (UINT)
    public UInt32 OutputFrames;

    /// (BOOL)
    public Int32 InputInterlaced;

    /// (UINT)
    public UInt32 InputFramesOrFields;

}

public enum D3D11_VIDEO_PROCESSOR_FILTER {
    BRIGHTNESS = 0x00000000,
    CONTRAST = 0x00000001,
    HUE = 0x00000002,
    SATURATION = 0x00000003,
    NOISE_REDUCTION = 0x00000004,
    EDGE_ENHANCEMENT = 0x00000005,
    ANAMORPHIC_SCALING = 0x00000006,
    STEREO_ADJUSTMENT = 0x00000007,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_FILTER_RANGE{
    /// (int)
    public int Minimum;

    /// (int)
    public int Maximum;

    /// (int)
    public int Default;

    /// (float)
    public float Multiplier;

}

public enum D3D11_VIDEO_FRAME_FORMAT {
    PROGRESSIVE = 0x00000000,
    INTERLACED_TOP_FIELD_FIRST = 0x00000001,
    INTERLACED_BOTTOM_FIELD_FIRST = 0x00000002,
}

public enum D3D11_VIDEO_USAGE {
    PLAYBACK_NORMAL = 0x00000000,
    OPTIMAL_SPEED = 0x00000001,
    OPTIMAL_QUALITY = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CONTENT_DESC{
    /// (D3D11_VIDEO_FRAME_FORMAT)
    public D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL InputFrameRate;

    /// (UINT)
    public UInt32 InputWidth;

    /// (UINT)
    public UInt32 InputHeight;

    /// (DXGI_RATIONAL)
    public DXGI_RATIONAL OutputFrameRate;

    /// (UINT)
    public UInt32 OutputWidth;

    /// (UINT)
    public UInt32 OutputHeight;

    /// (D3D11_VIDEO_USAGE)
    public D3D11_VIDEO_USAGE Usage;

}

[ComImport, Guid("31627037-53ab-4200-9061-05faa9ab45f9")]
public interface ID3D11VideoProcessorEnumerator: ID3D11DeviceChild {
    Int32 GetVideoProcessorContentDesc(
        /// pContentDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc
    );
    Int32 CheckVideoProcessorFormat(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format,
        /// pFlags: (*(UINT))
        ref UInt32 pFlags
    );
    Int32 GetVideoProcessorCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_CAPS))
        ref D3D11_VIDEO_PROCESSOR_CAPS pCaps
    );
    Int32 GetVideoProcessorRateConversionCaps(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex,
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    );
    Int32 GetVideoProcessorCustomRate(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex,
        /// CustomRateIndex: (UINT)
        UInt32 CustomRateIndex,
        /// pRate: (*(D3D11_VIDEO_PROCESSOR_CUSTOM_RATE))
        ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate
    );
    Int32 GetVideoProcessorFilterRange(
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        /// pRange: (*(D3D11_VIDEO_PROCESSOR_FILTER_RANGE))
        ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR_RGBA{
    /// (float)
    public float R;

    /// (float)
    public float G;

    /// (float)
    public float B;

    /// (float)
    public float A;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR_YCbCrA{
    /// (float)
    public float Y;

    /// (float)
    public float Cb;

    /// (float)
    public float Cr;

    /// (float)
    public float A;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR{
    #region union
        [FieldOffset(0)]
        /// (D3D11_VIDEO_COLOR_YCbCrA)
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr;

        [FieldOffset(0)]
        /// (D3D11_VIDEO_COLOR_RGBA)
        public D3D11_VIDEO_COLOR_RGBA RGBA;

    #endregion

}

public enum D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE {
    UNDEFINED = 0x00000000,
    _16_235 = 0x00000001,
    _0_255 = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE{
    /// (UINT)
    public UInt32 Usage;

    /// (UINT)
    public UInt32 RGB_Range;

    /// (UINT)
    public UInt32 YCbCr_Matrix;

    /// (UINT)
    public UInt32 YCbCr_xvYCC;

    /// (UINT)
    public UInt32 Nominal_Range;

    /// (UINT)
    public UInt32 Reserved;

}

public enum D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE {
    OPAQUE = 0x00000000,
    BACKGROUND = 0x00000001,
    DESTINATION = 0x00000002,
    SOURCE_STREAM = 0x00000003,
}

public enum D3D11_VIDEO_PROCESSOR_OUTPUT_RATE {
    NORMAL = 0x00000000,
    HALF = 0x00000001,
    CUSTOM = 0x00000002,
}

public enum D3D11_VIDEO_PROCESSOR_STEREO_FORMAT {
    MONO = 0x00000000,
    HORIZONTAL = 0x00000001,
    VERTICAL = 0x00000002,
    SEPARATE = 0x00000003,
    MONO_OFFSET = 0x00000004,
    ROW_INTERLEAVED = 0x00000005,
    COLUMN_INTERLEAVED = 0x00000006,
    CHECKERBOARD = 0x00000007,
}

public enum D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE {
    NONE = 0x00000000,
    FRAME0 = 0x00000001,
    FRAME1 = 0x00000002,
}

public enum D3D11_VIDEO_PROCESSOR_ROTATION {
    IDENTITY = 0x00000000,
    _90 = 0x00000001,
    _180 = 0x00000002,
    _270 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_STREAM{
    /// (BOOL)
    public Int32 Enable;

    /// (UINT)
    public UInt32 OutputIndex;

    /// (UINT)
    public UInt32 InputFrameOrField;

    /// (UINT)
    public UInt32 PastFrames;

    /// (UINT)
    public UInt32 FutureFrames;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppPastSurfaces;

    /// (*(ID3D11VideoProcessorInputView))
    public ID3D11VideoProcessorInputView pInputSurface;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfaces;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppPastSurfacesRight;

    /// (*(ID3D11VideoProcessorInputView))
    public ID3D11VideoProcessorInputView pInputSurfaceRight;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfacesRight;

}

[ComImport, Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c")]
public interface ID3D11VideoProcessor: ID3D11DeviceChild {
    void GetContentDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc
    );
    void GetRateConversionCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_OMAC{
    /// (BYTE)[16]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public Byte[] Omac;

}

public enum D3D11_AUTHENTICATED_CHANNEL_TYPE {
    D3D11_AUTHENTICATED_CHANNEL_D3D11 = 0x00000001,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE = 0x00000002,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE = 0x00000003,
}

[ComImport, Guid("3015a308-dcbd-47aa-a747-192486d14d4a")]
public interface ID3D11AuthenticatedChannel: ID3D11DeviceChild {
    Int32 GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    );
    Int32 GetCertificate(
        /// CertificateSize: (UINT)
        UInt32 CertificateSize,
        /// pCertificate: (*(BYTE))
        ref Byte pCertificate
    );
    void GetChannelHandle(
        /// pChannelHandle: (*(HANDLE))
        ref IntPtr pChannelHandle
    );
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_INPUT{
    /// (GUID)
    public Guid QueryType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT{
    /// (D3D11_OMAC)
    public D3D11_OMAC omac;

    /// (GUID)
    public Guid QueryType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

    /// (HRESULT)
    public Int32 ReturnCode;

}


[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
struct __MIDL___MIDL_itf_d3d11_0000_0034_0001{
    UInt32 ProtectionEnabled;
    UInt32 OverlayOrFullscreenRequired;
    UInt32 Reserved;
}
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_PROTECTION_FLAGS{
    /* (struct __MIDL___MIDL_itf_d3d11_0000_0034_0001) */__MIDL___MIDL_itf_d3d11_0000_0034_0001 Flags;
    /* (UINT) */UInt32 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (D3D11_AUTHENTICATED_PROTECTION_FLAGS)
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (D3D11_AUTHENTICATED_CHANNEL_TYPE)
    public D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (HANDLE)
    public IntPtr DeviceHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (HANDLE)
    public IntPtr DecoderHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (HANDLE)
    public IntPtr DecoderHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (HANDLE)
    public IntPtr DeviceHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 RestrictedSharedResourceProcessCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (UINT)
    public UInt32 ProcessIndex;

}

public enum D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE {
    D3D11_PROCESSIDTYPE_UNKNOWN = 0x00000000,
    D3D11_PROCESSIDTYPE_DWM = 0x00000001,
    D3D11_PROCESSIDTYPE_HANDLE = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 ProcessIndex;

    /// (D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE)
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier;

    /// (HANDLE)
    public IntPtr ProcessHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 UnrestrictedProtectedSharedResourceCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (HANDLE)
    public IntPtr DeviceHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (HANDLE)
    public IntPtr DeviceHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (UINT)
    public UInt32 OutputIDCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (HANDLE)
    public IntPtr DeviceHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (UINT)
    public UInt32 OutputIDIndex;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (HANDLE)
    public IntPtr DeviceHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (UINT)
    public UInt32 OutputIDIndex;

    /// (UINT64)
    public UInt64 OutputID;

}

public enum D3D11_BUS_TYPE {
    OTHER = 0x00000000,
    PCI = 0x00000001,
    PCIX = 0x00000002,
    PCIEXPRESS = 0x00000003,
    AGP = 0x00000004,
    D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x00010000,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x00020000,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x00030000,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x00040000,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x00050000,
    D3D11_BUS_IMPL_MODIFIER_NON_STANDARD = -0x80000000,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (D3D11_BUS_TYPE)
    public D3D11_BUS_TYPE BusType;

    /// (BOOL)
    public Int32 AccessibleInContiguousBlocks;

    /// (BOOL)
    public Int32 AccessibleInNonContiguousBlocks;

}

public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT{
    public D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_COUNT_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 EncryptionGuidCount;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_INPUT{
    /// (D3D11_AUTHENTICATED_QUERY_INPUT)
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// (UINT)
    public UInt32 EncryptionGuidIndex;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (UINT)
    public UInt32 EncryptionGuidIndex;

    /// (GUID)
    public Guid EncryptionGuid;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CURRENT_ACCESSIBILITY_ENCRYPTION_OUTPUT{
    /// (D3D11_AUTHENTICATED_QUERY_OUTPUT)
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// (GUID)
    public Guid EncryptionGuid;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_INPUT{
    /// (D3D11_OMAC)
    public D3D11_OMAC omac;

    /// (GUID)
    public Guid ConfigureType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_OUTPUT{
    /// (D3D11_OMAC)
    public D3D11_OMAC omac;

    /// (GUID)
    public Guid ConfigureType;

    /// (HANDLE)
    public IntPtr hChannel;

    /// (UINT)
    public UInt32 SequenceNumber;

    /// (HRESULT)
    public Int32 ReturnCode;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (UINT)
    public UInt32 StartSequenceQuery;

    /// (UINT)
    public UInt32 StartSequenceConfigure;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (D3D11_AUTHENTICATED_PROTECTION_FLAGS)
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (HANDLE)
    public IntPtr DecoderHandle;

    /// (HANDLE)
    public IntPtr CryptoSessionHandle;

    /// (HANDLE)
    public IntPtr DeviceHandle;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE)
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;

    /// (HANDLE)
    public IntPtr ProcessHandle;

    /// (BOOL)
    public Int32 AllowAccess;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_ACCESSIBLE_ENCRYPTION_INPUT{
    /// (D3D11_AUTHENTICATED_CONFIGURE_INPUT)
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// (GUID)
    public Guid EncryptionGuid;

}

[ComImport, Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720")]
public interface ID3D11CryptoSession: ID3D11DeviceChild {
    void GetCryptoType(
        /// pCryptoType: (*(GUID))
        ref Guid pCryptoType
    );
    void GetDecoderProfile(
        /// pDecoderProfile: (*(GUID))
        ref Guid pDecoderProfile
    );
    Int32 GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    );
    Int32 GetCertificate(
        /// CertificateSize: (UINT)
        UInt32 CertificateSize,
        /// pCertificate: (*(BYTE))
        ref Byte pCertificate
    );
    void GetCryptoSessionHandle(
        /// pCryptoSessionHandle: (*(HANDLE))
        ref IntPtr pCryptoSessionHandle
    );
}

public enum D3D11_VDOV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VDOV{
    /// (UINT)
    public UInt32 ArraySlice;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (GUID)
    public Guid DecodeProfile;

    [FieldOffset(4)]
    /// (D3D11_VDOV_DIMENSION)
    public D3D11_VDOV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_TEX2D_VDOV)
        public D3D11_TEX2D_VDOV Texture2D;

    #endregion

}

[ComImport, Guid("c2931aea-2a85-4f20-860f-fba1fd256e18")]
public interface ID3D11VideoDecoderOutputView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc
    );
}

public enum D3D11_VPIV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VPIV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 ArraySlice;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (UINT)
    public UInt32 FourCC;

    [FieldOffset(4)]
    /// (D3D11_VPIV_DIMENSION)
    public D3D11_VPIV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_TEX2D_VPIV)
        public D3D11_TEX2D_VPIV Texture2D;

    #endregion

}

[ComImport, Guid("11ec5a5f-51dc-4945-ab34-6e8c21300ea5")]
public interface ID3D11VideoProcessorInputView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc
    );
}

public enum D3D11_VPOV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
    TEXTURE2DARRAY = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VPOV{
    /// (UINT)
    public UInt32 MipSlice;

}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_VPOV{
    /// (UINT)
    public UInt32 MipSlice;

    /// (UINT)
    public UInt32 FirstArraySlice;

    /// (UINT)
    public UInt32 ArraySize;

}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (D3D11_VPOV_DIMENSION)
    public D3D11_VPOV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(4)]
        /// (D3D11_TEX2D_VPOV)
        public D3D11_TEX2D_VPOV Texture2D;

        [FieldOffset(4)]
        /// (D3D11_TEX2D_ARRAY_VPOV)
        public D3D11_TEX2D_ARRAY_VPOV Texture2DArray;

    #endregion

}

[ComImport, Guid("a048285e-25a9-4527-bd93-d68b68c44254")]
public interface ID3D11VideoProcessorOutputView: ID3D11View {
    void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc
    );
}

[ComImport, Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
public interface ID3D11VideoContext: ID3D11DeviceChild {
    Int32 GetDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder,
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        D3D11_VIDEO_DECODER_BUFFER_TYPE Type,
        /// pBufferSize: (*(UINT))
        ref UInt32 pBufferSize,
        /// ppBuffer: (*(*(void)))
        ref IntPtr ppBuffer
    );
    Int32 ReleaseDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder,
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        D3D11_VIDEO_DECODER_BUFFER_TYPE Type
    );
    Int32 DecoderBeginFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder,
        /// pView: (*(ID3D11VideoDecoderOutputView))
        ID3D11VideoDecoderOutputView pView,
        /// ContentKeySize: (UINT)
        UInt32 ContentKeySize,
        /// pContentKey: (*(const void))
        IntPtr pContentKey
    );
    Int32 DecoderEndFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder
    );
    Int32 SubmitDecoderBuffers(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder,
        /// NumBuffers: (UINT)
        UInt32 NumBuffers,
        /// pBufferDesc: (*(const D3D11_VIDEO_DECODER_BUFFER_DESC))
        ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc
    );
    APP_DEPRECATED_HRESULT DecoderExtension(
        /// pDecoder: (*(ID3D11VideoDecoder))
        ID3D11VideoDecoder pDecoder,
        /// pExtensionData: (*(const D3D11_VIDEO_DECODER_EXTENSION))
        ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData
    );
    void VideoProcessorSetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// Enable: (BOOL)
        Int32 Enable,
        /// pRect: (*(const RECT))
        ref RECT pRect
    );
    void VideoProcessorSetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// YCbCr: (BOOL)
        Int32 YCbCr,
        /// pColor: (*(const D3D11_VIDEO_COLOR))
        ref D3D11_VIDEO_COLOR pColor
    );
    void VideoProcessorSetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    );
    void VideoProcessorSetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// AlphaFillMode: (D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE)
        D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex
    );
    void VideoProcessorSetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Size: (SIZE)
        SIZE Size
    );
    void VideoProcessorSetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// Enable: (BOOL)
        Int32 Enable
    );
    APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pExtensionGuid: (*(const GUID))
        ref Guid pExtensionGuid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    void VideoProcessorGetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// Enabled: (*(BOOL))
        ref Int32 Enabled,
        /// pRect: (*(RECT))
        ref RECT pRect
    );
    void VideoProcessorGetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pYCbCr: (*(BOOL))
        ref Int32 pYCbCr,
        /// pColor: (*(D3D11_VIDEO_COLOR))
        ref D3D11_VIDEO_COLOR pColor
    );
    void VideoProcessorGetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    );
    void VideoProcessorGetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pAlphaFillMode: (*(D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE))
        ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode,
        /// pStreamIndex: (*(UINT))
        ref UInt32 pStreamIndex
    );
    void VideoProcessorGetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pSize: (*(SIZE))
        ref SIZE pSize
    );
    void VideoProcessorGetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled
    );
    APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pExtensionGuid: (*(const GUID))
        ref Guid pExtensionGuid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    void VideoProcessorSetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// FrameFormat: (D3D11_VIDEO_FRAME_FORMAT)
        D3D11_VIDEO_FRAME_FORMAT FrameFormat
    );
    void VideoProcessorSetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    );
    void VideoProcessorSetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// OutputRate: (D3D11_VIDEO_PROCESSOR_OUTPUT_RATE)
        D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate,
        /// RepeatFrame: (BOOL)
        Int32 RepeatFrame,
        /// pCustomRate: (*(const DXGI_RATIONAL))
        ref DXGI_RATIONAL pCustomRate
    );
    void VideoProcessorSetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// pRect: (*(const RECT))
        ref RECT pRect
    );
    void VideoProcessorSetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// pRect: (*(const RECT))
        ref RECT pRect
    );
    void VideoProcessorSetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Alpha: (FLOAT)
        Single Alpha
    );
    void VideoProcessorSetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Count: (UINT)
        UInt32 Count,
        /// pEntries: (*(const UINT))
        ref UInt32 pEntries
    );
    void VideoProcessorSetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// pSourceAspectRatio: (*(const DXGI_RATIONAL))
        ref DXGI_RATIONAL pSourceAspectRatio,
        /// pDestinationAspectRatio: (*(const DXGI_RATIONAL))
        ref DXGI_RATIONAL pDestinationAspectRatio
    );
    void VideoProcessorSetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Lower: (FLOAT)
        Single Lower,
        /// Upper: (FLOAT)
        Single Upper
    );
    void VideoProcessorSetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Format: (D3D11_VIDEO_PROCESSOR_STEREO_FORMAT)
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format,
        /// LeftViewFrame0: (BOOL)
        Int32 LeftViewFrame0,
        /// BaseViewFrame0: (BOOL)
        Int32 BaseViewFrame0,
        /// FlipMode: (D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE)
        D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode,
        /// MonoOffset: (int)
        int MonoOffset
    );
    void VideoProcessorSetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable
    );
    void VideoProcessorSetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Level: (int)
        int Level
    );
    APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pExtensionGuid: (*(const GUID))
        ref Guid pExtensionGuid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    void VideoProcessorGetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pFrameFormat: (*(D3D11_VIDEO_FRAME_FORMAT))
        ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat
    );
    void VideoProcessorGetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    );
    void VideoProcessorGetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pOutputRate: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_RATE))
        ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate,
        /// pRepeatFrame: (*(BOOL))
        ref Int32 pRepeatFrame,
        /// pCustomRate: (*(DXGI_RATIONAL))
        ref DXGI_RATIONAL pCustomRate
    );
    void VideoProcessorGetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pRect: (*(RECT))
        ref RECT pRect
    );
    void VideoProcessorGetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pRect: (*(RECT))
        ref RECT pRect
    );
    void VideoProcessorGetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pAlpha: (*(FLOAT))
        ref Single pAlpha
    );
    void VideoProcessorGetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Count: (UINT)
        UInt32 Count,
        /// pEntries: (*(UINT))
        ref UInt32 pEntries
    );
    void VideoProcessorGetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pSourceAspectRatio: (*(DXGI_RATIONAL))
        ref DXGI_RATIONAL pSourceAspectRatio,
        /// pDestinationAspectRatio: (*(DXGI_RATIONAL))
        ref DXGI_RATIONAL pDestinationAspectRatio
    );
    void VideoProcessorGetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pLower: (*(FLOAT))
        ref Single pLower,
        /// pUpper: (*(FLOAT))
        ref Single pUpper
    );
    void VideoProcessorGetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnable: (*(BOOL))
        ref Int32 pEnable,
        /// pFormat: (*(D3D11_VIDEO_PROCESSOR_STEREO_FORMAT))
        ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat,
        /// pLeftViewFrame0: (*(BOOL))
        ref Int32 pLeftViewFrame0,
        /// pBaseViewFrame0: (*(BOOL))
        ref Int32 pBaseViewFrame0,
        /// pFlipMode: (*(D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE))
        ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode,
        /// MonoOffset: (*(int))
        ref int MonoOffset
    );
    void VideoProcessorGetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled
    );
    void VideoProcessorGetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        /// pEnabled: (*(BOOL))
        ref Int32 pEnabled,
        /// pLevel: (*(int))
        ref int pLevel
    );
    APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pExtensionGuid: (*(const GUID))
        ref Guid pExtensionGuid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    Int32 VideoProcessorBlt(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// pView: (*(ID3D11VideoProcessorOutputView))
        ID3D11VideoProcessorOutputView pView,
        /// OutputFrame: (UINT)
        UInt32 OutputFrame,
        /// StreamCount: (UINT)
        UInt32 StreamCount,
        /// pStreams: (*(const D3D11_VIDEO_PROCESSOR_STREAM))
        ref D3D11_VIDEO_PROCESSOR_STREAM pStreams
    );
    Int32 NegotiateCryptoSessionKeyExchange(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    void EncryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession,
        /// pSrcSurface: (*(ID3D11Texture2D))
        ID3D11Texture2D pSrcSurface,
        /// pDstSurface: (*(ID3D11Texture2D))
        ID3D11Texture2D pDstSurface,
        /// IVSize: (UINT)
        UInt32 IVSize,
        /// pIV: (*(void))
        IntPtr pIV
    );
    void DecryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession,
        /// pSrcSurface: (*(ID3D11Texture2D))
        ID3D11Texture2D pSrcSurface,
        /// pDstSurface: (*(ID3D11Texture2D))
        ID3D11Texture2D pDstSurface,
        /// pEncryptedBlockInfo: (*(D3D11_ENCRYPTED_BLOCK_INFO))
        ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo,
        /// ContentKeySize: (UINT)
        UInt32 ContentKeySize,
        /// pContentKey: (*(const void))
        IntPtr pContentKey,
        /// IVSize: (UINT)
        UInt32 IVSize,
        /// pIV: (*(void))
        IntPtr pIV
    );
    void StartSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession,
        /// RandomNumberSize: (UINT)
        UInt32 RandomNumberSize,
        /// pRandomNumber: (*(void))
        IntPtr pRandomNumber
    );
    void FinishSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession
    );
    Int32 GetEncryptionBltKey(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        ID3D11CryptoSession pCryptoSession,
        /// KeySize: (UINT)
        UInt32 KeySize,
        /// pReadbackKey: (*(void))
        IntPtr pReadbackKey
    );
    Int32 NegotiateAuthenticatedChannelKeyExchange(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        ID3D11AuthenticatedChannel pChannel,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    Int32 QueryAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        ID3D11AuthenticatedChannel pChannel,
        /// InputSize: (UINT)
        UInt32 InputSize,
        /// pInput: (*(const void))
        IntPtr pInput,
        /// OutputSize: (UINT)
        UInt32 OutputSize,
        /// pOutput: (*(void))
        IntPtr pOutput
    );
    Int32 ConfigureAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        ID3D11AuthenticatedChannel pChannel,
        /// InputSize: (UINT)
        UInt32 InputSize,
        /// pInput: (*(const void))
        IntPtr pInput,
        /// pOutput: (*(D3D11_AUTHENTICATED_CONFIGURE_OUTPUT))
        ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput
    );
    void VideoProcessorSetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// Enable: (BOOL)
        Int32 Enable,
        /// Rotation: (D3D11_VIDEO_PROCESSOR_ROTATION)
        D3D11_VIDEO_PROCESSOR_ROTATION Rotation
    );
    void VideoProcessorGetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        ID3D11VideoProcessor pVideoProcessor,
        /// StreamIndex: (UINT)
        UInt32 StreamIndex,
        /// pEnable: (*(BOOL))
        ref Int32 pEnable,
        /// pRotation: (*(D3D11_VIDEO_PROCESSOR_ROTATION))
        ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation
    );
}

[ComImport, Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11VideoDevice{
    Int32 CreateVideoDecoder(
        /// pVideoDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc,
        /// pConfig: (*(const D3D11_VIDEO_DECODER_CONFIG))
        ref D3D11_VIDEO_DECODER_CONFIG pConfig,
        /// ppDecoder: (*(*(ID3D11VideoDecoder)))
        ref ID3D11VideoDecoder ppDecoder
    );
    Int32 CreateVideoProcessor(
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        ID3D11VideoProcessorEnumerator pEnum,
        /// RateConversionIndex: (UINT)
        UInt32 RateConversionIndex,
        /// ppVideoProcessor: (*(*(ID3D11VideoProcessor)))
        ref ID3D11VideoProcessor ppVideoProcessor
    );
    Int32 CreateAuthenticatedChannel(
        /// ChannelType: (D3D11_AUTHENTICATED_CHANNEL_TYPE)
        D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType,
        /// ppAuthenticatedChannel: (*(*(ID3D11AuthenticatedChannel)))
        ref ID3D11AuthenticatedChannel ppAuthenticatedChannel
    );
    Int32 CreateCryptoSession(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType,
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile,
        /// pKeyExchangeType: (*(const GUID))
        ref Guid pKeyExchangeType,
        /// ppCryptoSession: (*(*(ID3D11CryptoSession)))
        ref ID3D11CryptoSession ppCryptoSession
    );
    Int32 CreateVideoDecoderOutputView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pDesc: (*(const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc,
        /// ppVDOVView: (*(*(ID3D11VideoDecoderOutputView)))
        ref ID3D11VideoDecoderOutputView ppVDOVView
    );
    Int32 CreateVideoProcessorInputView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        ID3D11VideoProcessorEnumerator pEnum,
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc,
        /// ppVPIView: (*(*(ID3D11VideoProcessorInputView)))
        ref ID3D11VideoProcessorInputView ppVPIView
    );
    Int32 CreateVideoProcessorOutputView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        ID3D11VideoProcessorEnumerator pEnum,
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc,
        /// ppVPOView: (*(*(ID3D11VideoProcessorOutputView)))
        ref ID3D11VideoProcessorOutputView ppVPOView
    );
    Int32 CreateVideoProcessorEnumerator(
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc,
        /// ppEnum: (*(*(ID3D11VideoProcessorEnumerator)))
        ref ID3D11VideoProcessorEnumerator ppEnum
    );
    UInt32 GetVideoDecoderProfileCount(
    );
    Int32 GetVideoDecoderProfile(
        /// Index: (UINT)
        UInt32 Index,
        /// pDecoderProfile: (*(GUID))
        ref Guid pDecoderProfile
    );
    Int32 CheckVideoDecoderFormat(
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile,
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format,
        /// pSupported: (*(BOOL))
        ref Int32 pSupported
    );
    Int32 GetVideoDecoderConfigCount(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc,
        /// pCount: (*(UINT))
        ref UInt32 pCount
    );
    Int32 GetVideoDecoderConfig(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc,
        /// Index: (UINT)
        UInt32 Index,
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        ref D3D11_VIDEO_DECODER_CONFIG pConfig
    );
    Int32 GetContentProtectionCaps(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType,
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile,
        /// pCaps: (*(D3D11_VIDEO_CONTENT_PROTECTION_CAPS))
        ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps
    );
    Int32 CheckCryptoKeyExchange(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType,
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile,
        /// Index: (UINT)
        UInt32 Index,
        /// pKeyExchangeType: (*(GUID))
        ref Guid pKeyExchangeType
    );
    Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(const void))
        IntPtr pData
    );
    Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// pData: (*(const IUnknown))
        IntPtr pData
    );
}

[ComImport, Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11Device{
    Int32 CreateBuffer(
        /// pDesc: (*(const D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc,
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        ref D3D11_SUBRESOURCE_DATA pInitialData,
        /// ppBuffer: (*(*(ID3D11Buffer)))
        ref ID3D11Buffer ppBuffer
    );
    Int32 CreateTexture1D(
        /// pDesc: (*(const D3D11_TEXTURE1D_DESC))
        ref D3D11_TEXTURE1D_DESC pDesc,
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        ref D3D11_SUBRESOURCE_DATA pInitialData,
        /// ppTexture1D: (*(*(ID3D11Texture1D)))
        ref ID3D11Texture1D ppTexture1D
    );
    Int32 CreateTexture2D(
        /// pDesc: (*(const D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc,
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        ref D3D11_SUBRESOURCE_DATA pInitialData,
        /// ppTexture2D: (*(*(ID3D11Texture2D)))
        ref ID3D11Texture2D ppTexture2D
    );
    Int32 CreateTexture3D(
        /// pDesc: (*(const D3D11_TEXTURE3D_DESC))
        ref D3D11_TEXTURE3D_DESC pDesc,
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        ref D3D11_SUBRESOURCE_DATA pInitialData,
        /// ppTexture3D: (*(*(ID3D11Texture3D)))
        ref ID3D11Texture3D ppTexture3D
    );
    Int32 CreateShaderResourceView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pDesc: (*(const D3D11_SHADER_RESOURCE_VIEW_DESC))
        ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc,
        /// ppSRView: (*(*(ID3D11ShaderResourceView)))
        ref ID3D11ShaderResourceView ppSRView
    );
    Int32 CreateUnorderedAccessView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pDesc: (*(const D3D11_UNORDERED_ACCESS_VIEW_DESC))
        ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc,
        /// ppUAView: (*(*(ID3D11UnorderedAccessView)))
        ref ID3D11UnorderedAccessView ppUAView
    );
    Int32 CreateRenderTargetView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pDesc: (*(const D3D11_RENDER_TARGET_VIEW_DESC))
        ref D3D11_RENDER_TARGET_VIEW_DESC pDesc,
        /// ppRTView: (*(*(ID3D11RenderTargetView)))
        ref ID3D11RenderTargetView ppRTView
    );
    Int32 CreateDepthStencilView(
        /// pResource: (*(ID3D11Resource))
        ID3D11Resource pResource,
        /// pDesc: (*(const D3D11_DEPTH_STENCIL_VIEW_DESC))
        ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc,
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        ref ID3D11DepthStencilView ppDepthStencilView
    );
    Int32 CreateInputLayout(
        /// pInputElementDescs: (*(const D3D11_INPUT_ELEMENT_DESC))
        ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs,
        /// NumElements: (UINT)
        UInt32 NumElements,
        /// pShaderBytecodeWithInputSignature: (*(const void))
        IntPtr pShaderBytecodeWithInputSignature,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        ref ID3D11InputLayout ppInputLayout
    );
    Int32 CreateVertexShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        ref ID3D11VertexShader ppVertexShader
    );
    Int32 CreateGeometryShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        ref ID3D11GeometryShader ppGeometryShader
    );
    Int32 CreateGeometryShaderWithStreamOutput(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pSODeclaration: (*(const D3D11_SO_DECLARATION_ENTRY))
        ref D3D11_SO_DECLARATION_ENTRY pSODeclaration,
        /// NumEntries: (UINT)
        UInt32 NumEntries,
        /// pBufferStrides: (*(const UINT))
        ref UInt32 pBufferStrides,
        /// NumStrides: (UINT)
        UInt32 NumStrides,
        /// RasterizedStream: (UINT)
        UInt32 RasterizedStream,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        ref ID3D11GeometryShader ppGeometryShader
    );
    Int32 CreatePixelShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        ref ID3D11PixelShader ppPixelShader
    );
    Int32 CreateHullShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppHullShader: (*(*(ID3D11HullShader)))
        ref ID3D11HullShader ppHullShader
    );
    Int32 CreateDomainShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        ref ID3D11DomainShader ppDomainShader
    );
    Int32 CreateComputeShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode,
        /// BytecodeLength: (SIZE_T)
        UIntPtr BytecodeLength,
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        ID3D11ClassLinkage pClassLinkage,
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        ref ID3D11ComputeShader ppComputeShader
    );
    Int32 CreateClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref ID3D11ClassLinkage ppLinkage
    );
    Int32 CreateBlendState(
        /// pBlendStateDesc: (*(const D3D11_BLEND_DESC))
        ref D3D11_BLEND_DESC pBlendStateDesc,
        /// ppBlendState: (*(*(ID3D11BlendState)))
        ref ID3D11BlendState ppBlendState
    );
    Int32 CreateDepthStencilState(
        /// pDepthStencilDesc: (*(const D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc,
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        ref ID3D11DepthStencilState ppDepthStencilState
    );
    Int32 CreateRasterizerState(
        /// pRasterizerDesc: (*(const D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pRasterizerDesc,
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        ref ID3D11RasterizerState ppRasterizerState
    );
    Int32 CreateSamplerState(
        /// pSamplerDesc: (*(const D3D11_SAMPLER_DESC))
        ref D3D11_SAMPLER_DESC pSamplerDesc,
        /// ppSamplerState: (*(*(ID3D11SamplerState)))
        ref ID3D11SamplerState ppSamplerState
    );
    Int32 CreateQuery(
        /// pQueryDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pQueryDesc,
        /// ppQuery: (*(*(ID3D11Query)))
        ref ID3D11Query ppQuery
    );
    Int32 CreatePredicate(
        /// pPredicateDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pPredicateDesc,
        /// ppPredicate: (*(*(ID3D11Predicate)))
        ref ID3D11Predicate ppPredicate
    );
    Int32 CreateCounter(
        /// pCounterDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pCounterDesc,
        /// ppCounter: (*(*(ID3D11Counter)))
        ref ID3D11Counter ppCounter
    );
    Int32 CreateDeferredContext(
        /// ContextFlags: (UINT)
        UInt32 ContextFlags,
        /// ppDeferredContext: (*(*(ID3D11DeviceContext)))
        ref ID3D11DeviceContext ppDeferredContext
    );
    Int32 OpenSharedResource(
        /// hResource: (HANDLE)
        IntPtr hResource,
        /// ReturnedInterface: (&(const IID))
        ref Guid ReturnedInterface,
        /// ppResource: (*(*(void)))
        ref IntPtr ppResource
    );
    Int32 CheckFormatSupport(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format,
        /// pFormatSupport: (*(UINT))
        ref UInt32 pFormatSupport
    );
    Int32 CheckMultisampleQualityLevels(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format,
        /// SampleCount: (UINT)
        UInt32 SampleCount,
        /// pNumQualityLevels: (*(UINT))
        ref UInt32 pNumQualityLevels
    );
    void CheckCounterInfo(
        /// pCounterInfo: (*(D3D11_COUNTER_INFO))
        ref D3D11_COUNTER_INFO pCounterInfo
    );
    Int32 CheckCounter(
        /// pDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pDesc,
        /// pType: (*(D3D11_COUNTER_TYPE))
        ref D3D11_COUNTER_TYPE pType,
        /// pActiveCounters: (*(UINT))
        ref UInt32 pActiveCounters,
        /// szName: (LPSTR)
        IntPtr szName,
        /// pNameLength: (*(UINT))
        ref UInt32 pNameLength,
        /// szUnits: (LPSTR)
        IntPtr szUnits,
        /// pUnitsLength: (*(UINT))
        ref UInt32 pUnitsLength,
        /// szDescription: (LPSTR)
        IntPtr szDescription,
        /// pDescriptionLength: (*(UINT))
        ref UInt32 pDescriptionLength
    );
    Int32 CheckFeatureSupport(
        /// Feature: (D3D11_FEATURE)
        D3D11_FEATURE Feature,
        /// pFeatureSupportData: (*(void))
        IntPtr pFeatureSupportData,
        /// FeatureSupportDataSize: (UINT)
        UInt32 FeatureSupportDataSize
    );
    Int32 GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// pDataSize: (*(UINT))
        ref UInt32 pDataSize,
        /// pData: (*(void))
        IntPtr pData
    );
    Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// DataSize: (UINT)
        UInt32 DataSize,
        /// pData: (*(const void))
        IntPtr pData
    );
    Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid,
        /// pData: (*(const IUnknown))
        IntPtr pData
    );
    D3D_FEATURE_LEVEL GetFeatureLevel(
    );
    UInt32 GetCreationFlags(
    );
    Int32 GetDeviceRemovedReason(
    );
    void GetImmediateContext(
        /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
        ref ID3D11DeviceContext ppImmediateContext
    );
    Int32 SetExceptionMode(
        /// RaiseFlags: (UINT)
        UInt32 RaiseFlags
    );
    UInt32 GetExceptionMode(
    );
}

public enum D3D11_CREATE_DEVICE_FLAG {
    SINGLETHREADED = 0x00000001,
    DEBUG = 0x00000002,
    SWITCH_TO_REF = 0x00000004,
    PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 0x00000008,
    BGRA_SUPPORT = 0x00000020,
    DEBUGGABLE = 0x00000040,
    PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 0x00000080,
    DISABLE_GPU_TIMEOUT = 0x00000100,
    VIDEO_SUPPORT = 0x00000800,
}

public static class d3d11{
[DllImport("D3D11.dll")]
public static extern UInt32 D3D11CalcSubresource(
    /// MipSlice: (UINT)
    UInt32 MipSlice,
    /// ArraySlice: (UINT)
    UInt32 ArraySlice,
    /// MipLevels: (UINT)
    UInt32 MipLevels
);

[DllImport("D3D11.dll")]
public static extern Int32 D3D11CreateDevice(
    /// pAdapter: (*(IDXGIAdapter))
    IDXGIAdapter pAdapter,
    /// DriverType: (D3D_DRIVER_TYPE)
    D3D_DRIVER_TYPE DriverType,
    /// Software: (HMODULE)
    IntPtr Software,
    /// Flags: (UINT)
    UInt32 Flags,
    /// pFeatureLevels: (*(const D3D_FEATURE_LEVEL))
    ref D3D_FEATURE_LEVEL pFeatureLevels,
    /// FeatureLevels: (UINT)
    UInt32 FeatureLevels,
    /// SDKVersion: (UINT)
    UInt32 SDKVersion,
    /// ppDevice: (*(*(ID3D11Device)))
    ref ID3D11Device ppDevice,
    /// pFeatureLevel: (*(D3D_FEATURE_LEVEL))
    ref D3D_FEATURE_LEVEL pFeatureLevel,
    /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
    ref ID3D11DeviceContext ppImmediateContext
);

[DllImport("D3D11.dll")]
public static extern Int32 D3D11CreateDeviceAndSwapChain(
    /// pAdapter: (*(IDXGIAdapter))
    IDXGIAdapter pAdapter,
    /// DriverType: (D3D_DRIVER_TYPE)
    D3D_DRIVER_TYPE DriverType,
    /// Software: (HMODULE)
    IntPtr Software,
    /// Flags: (UINT)
    UInt32 Flags,
    /// pFeatureLevels: (*(const D3D_FEATURE_LEVEL))
    ref D3D_FEATURE_LEVEL pFeatureLevels,
    /// FeatureLevels: (UINT)
    UInt32 FeatureLevels,
    /// SDKVersion: (UINT)
    UInt32 SDKVersion,
    /// pSwapChainDesc: (*(const DXGI_SWAP_CHAIN_DESC))
    ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc,
    /// ppSwapChain: (*(*(IDXGISwapChain)))
    ref IDXGISwapChain ppSwapChain,
    /// ppDevice: (*(*(ID3D11Device)))
    ref ID3D11Device ppDevice,
    /// pFeatureLevel: (*(D3D_FEATURE_LEVEL))
    ref D3D_FEATURE_LEVEL pFeatureLevel,
    /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
    ref ID3D11DeviceContext ppImmediateContext
);

}
}
