
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
    /* (LPCSTR) */IntPtr SemanticName;
    /* (UINT) */UInt32 SemanticIndex;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (UINT) */UInt32 InputSlot;
    /* (UINT) */UInt32 AlignedByteOffset;
    /* (D3D11_INPUT_CLASSIFICATION) */D3D11_INPUT_CLASSIFICATION InputSlotClass;
    /* (UINT) */UInt32 InstanceDataStepRate;
}

public enum D3D11_FILL_MODE {
    WIREFRAME = 0x00000002,
    SOLID = 0x00000003,
}

public struct D3D11_PRIMITIVE_TOPOLOGY{
    public /* (D3D_PRIMITIVE_TOPOLOGY) */D3D_PRIMITIVE_TOPOLOGY Value;
}

public struct D3D11_PRIMITIVE{
    public /* (D3D_PRIMITIVE) */D3D_PRIMITIVE Value;
}

public enum D3D11_CULL_MODE {
    NONE = 0x00000001,
    FRONT = 0x00000002,
    BACK = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SO_DECLARATION_ENTRY{
    /* (UINT) */UInt32 Stream;
    /* (LPCSTR) */IntPtr SemanticName;
    /* (UINT) */UInt32 SemanticIndex;
    /* (BYTE) */Byte StartComponent;
    /* (BYTE) */Byte ComponentCount;
    /* (BYTE) */Byte OutputSlot;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIEWPORT{
    /* (FLOAT) */Single TopLeftX;
    /* (FLOAT) */Single TopLeftY;
    /* (FLOAT) */Single Width;
    /* (FLOAT) */Single Height;
    /* (FLOAT) */Single MinDepth;
    /* (FLOAT) */Single MaxDepth;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS{
    /* (UINT) */UInt32 VertexCountPerInstance;
    /* (UINT) */UInt32 InstanceCount;
    /* (UINT) */UInt32 StartVertexLocation;
    /* (UINT) */UInt32 StartInstanceLocation;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS{
    /* (UINT) */UInt32 IndexCountPerInstance;
    /* (UINT) */UInt32 InstanceCount;
    /* (UINT) */UInt32 StartIndexLocation;
    /* (INT) */Int32 BaseVertexLocation;
    /* (UINT) */UInt32 StartInstanceLocation;
}

public enum D3D11_RESOURCE_DIMENSION {
    UNKNOWN = 0x00000000,
    BUFFER = 0x00000001,
    TEXTURE1D = 0x00000002,
    TEXTURE2D = 0x00000003,
    TEXTURE3D = 0x00000004,
}

public struct D3D11_SRV_DIMENSION{
    public /* (D3D_SRV_DIMENSION) */D3D_SRV_DIMENSION Value;
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
    public /* (RECT) */RECT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BOX{
    /* (UINT) */UInt32 left;
    /* (UINT) */UInt32 top;
    /* (UINT) */UInt32 front;
    /* (UINT) */UInt32 right;
    /* (UINT) */UInt32 bottom;
    /* (UINT) */UInt32 back;
}

[ComImport, Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11DeviceChild{
    /* (void) */void GetDevice(/* (*(*(ID3D11Device))) */ref ID3D11Device ppDevice);
    /* (HRESULT) */Int32 GetPrivateData(/* (&(const GUID)) */ref Guid guid, /* (*(UINT)) */ref UInt32 pDataSize, /* (*(void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateData(/* (&(const GUID)) */ref Guid guid, /* (UINT) */UInt32 DataSize, /* (*(const void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateDataInterface(/* (&(const GUID)) */ref Guid guid, /* (*(const IUnknown)) */IntPtr pData);
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
    /* (D3D11_STENCIL_OP) */D3D11_STENCIL_OP StencilFailOp;
    /* (D3D11_STENCIL_OP) */D3D11_STENCIL_OP StencilDepthFailOp;
    /* (D3D11_STENCIL_OP) */D3D11_STENCIL_OP StencilPassOp;
    /* (D3D11_COMPARISON_FUNC) */D3D11_COMPARISON_FUNC StencilFunc;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_DESC{
    /* (BOOL) */Int32 DepthEnable;
    /* (D3D11_DEPTH_WRITE_MASK) */D3D11_DEPTH_WRITE_MASK DepthWriteMask;
    /* (D3D11_COMPARISON_FUNC) */D3D11_COMPARISON_FUNC DepthFunc;
    /* (BOOL) */Int32 StencilEnable;
    /* (UINT8) */Byte StencilReadMask;
    /* (UINT8) */Byte StencilWriteMask;
    /* (D3D11_DEPTH_STENCILOP_DESC) */D3D11_DEPTH_STENCILOP_DESC FrontFace;
    /* (D3D11_DEPTH_STENCILOP_DESC) */D3D11_DEPTH_STENCILOP_DESC BackFace;
}

[ComImport, Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1")]
public interface ID3D11DepthStencilState: ID3D11DeviceChild {
    /* (void) */void GetDesc(/* (*(D3D11_DEPTH_STENCIL_DESC)) */ref D3D11_DEPTH_STENCIL_DESC pDesc);
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
    /* (BOOL) */Int32 BlendEnable;
    /* (D3D11_BLEND) */D3D11_BLEND SrcBlend;
    /* (D3D11_BLEND) */D3D11_BLEND DestBlend;
    /* (D3D11_BLEND_OP) */D3D11_BLEND_OP BlendOp;
    /* (D3D11_BLEND) */D3D11_BLEND SrcBlendAlpha;
    /* (D3D11_BLEND) */D3D11_BLEND DestBlendAlpha;
    /* (D3D11_BLEND_OP) */D3D11_BLEND_OP BlendOpAlpha;
    /* (UINT8) */Byte RenderTargetWriteMask;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BLEND_DESC{
    /* (BOOL) */Int32 AlphaToCoverageEnable;
    /* (BOOL) */Int32 IndependentBlendEnable;
    /* (D3D11_RENDER_TARGET_BLEND_DESC)[8] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]public D3D11_RENDER_TARGET_BLEND_DESC[] RenderTarget;
}

[ComImport, Guid("75b68faa-347d-4159-8f45-a0640f01cd9a")]
public interface ID3D11BlendState: ID3D11DeviceChild {
    /* (void) */void GetDesc(/* (*(D3D11_BLEND_DESC)) */ref D3D11_BLEND_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RASTERIZER_DESC{
    /* (D3D11_FILL_MODE) */D3D11_FILL_MODE FillMode;
    /* (D3D11_CULL_MODE) */D3D11_CULL_MODE CullMode;
    /* (BOOL) */Int32 FrontCounterClockwise;
    /* (INT) */Int32 DepthBias;
    /* (FLOAT) */Single DepthBiasClamp;
    /* (FLOAT) */Single SlopeScaledDepthBias;
    /* (BOOL) */Int32 DepthClipEnable;
    /* (BOOL) */Int32 ScissorEnable;
    /* (BOOL) */Int32 MultisampleEnable;
    /* (BOOL) */Int32 AntialiasedLineEnable;
}

[ComImport, Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7")]
public interface ID3D11RasterizerState: ID3D11DeviceChild {
    /* (void) */void GetDesc(/* (*(D3D11_RASTERIZER_DESC)) */ref D3D11_RASTERIZER_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SUBRESOURCE_DATA{
    /* (*(const void)) */IntPtr pSysMem;
    /* (UINT) */UInt32 SysMemPitch;
    /* (UINT) */UInt32 SysMemSlicePitch;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_MAPPED_SUBRESOURCE{
    /* (*(void)) */IntPtr pData;
    /* (UINT) */UInt32 RowPitch;
    /* (UINT) */UInt32 DepthPitch;
}

[ComImport, Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d")]
public interface ID3D11Resource: ID3D11DeviceChild {
    /* (void) */void GetType(/* (*(D3D11_RESOURCE_DIMENSION)) */ref D3D11_RESOURCE_DIMENSION pResourceDimension);
    /* (void) */void SetEvictionPriority(/* (UINT) */UInt32 EvictionPriority);
    /* (UINT) */UInt32 GetEvictionPriority();
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_DESC{
    /* (UINT) */UInt32 ByteWidth;
    /* (D3D11_USAGE) */D3D11_USAGE Usage;
    /* (UINT) */UInt32 BindFlags;
    /* (UINT) */UInt32 CPUAccessFlags;
    /* (UINT) */UInt32 MiscFlags;
    /* (UINT) */UInt32 StructureByteStride;
}

[ComImport, Guid("48570b85-d1ee-4fcd-a250-eb350722b037")]
public interface ID3D11Buffer: ID3D11Resource {
    /* (void) */void GetDesc(/* (*(D3D11_BUFFER_DESC)) */ref D3D11_BUFFER_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE1D_DESC{
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 MipLevels;
    /* (UINT) */UInt32 ArraySize;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (D3D11_USAGE) */D3D11_USAGE Usage;
    /* (UINT) */UInt32 BindFlags;
    /* (UINT) */UInt32 CPUAccessFlags;
    /* (UINT) */UInt32 MiscFlags;
}

[ComImport, Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c")]
public interface ID3D11Texture1D: ID3D11Resource {
    /* (void) */void GetDesc(/* (*(D3D11_TEXTURE1D_DESC)) */ref D3D11_TEXTURE1D_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE2D_DESC{
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 Height;
    /* (UINT) */UInt32 MipLevels;
    /* (UINT) */UInt32 ArraySize;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (DXGI_SAMPLE_DESC) */DXGI_SAMPLE_DESC SampleDesc;
    /* (D3D11_USAGE) */D3D11_USAGE Usage;
    /* (UINT) */UInt32 BindFlags;
    /* (UINT) */UInt32 CPUAccessFlags;
    /* (UINT) */UInt32 MiscFlags;
}

[ComImport, Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c")]
public interface ID3D11Texture2D: ID3D11Resource {
    /* (void) */void GetDesc(/* (*(D3D11_TEXTURE2D_DESC)) */ref D3D11_TEXTURE2D_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXTURE3D_DESC{
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 Height;
    /* (UINT) */UInt32 Depth;
    /* (UINT) */UInt32 MipLevels;
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    /* (D3D11_USAGE) */D3D11_USAGE Usage;
    /* (UINT) */UInt32 BindFlags;
    /* (UINT) */UInt32 CPUAccessFlags;
    /* (UINT) */UInt32 MiscFlags;
}

[ComImport, Guid("037e866e-f56d-4357-a8af-9dabbe6e250e")]
public interface ID3D11Texture3D: ID3D11Resource {
    /* (void) */void GetDesc(/* (*(D3D11_TEXTURE3D_DESC)) */ref D3D11_TEXTURE3D_DESC pDesc);
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
    /* (void) */void GetResource(/* (*(*(ID3D11Resource))) */ref ID3D11Resource ppResource);
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_BUFFER_SRV{
    #region union
        [FieldOffset(0)]
        /* (UINT) */UInt32 FirstElement;
        [FieldOffset(0)]
        /* (UINT) */UInt32 ElementOffset;
    #endregion
    #region union
        [FieldOffset(4)]
        /* (UINT) */UInt32 NumElements;
        [FieldOffset(4)]
        /* (UINT) */UInt32 ElementWidth;
    #endregion
}

public enum D3D11_BUFFEREX_SRV_FLAG {
    RAW = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFEREX_SRV{
    /* (UINT) */UInt32 FirstElement;
    /* (UINT) */UInt32 NumElements;
    /* (UINT) */UInt32 Flags;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXCUBE_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEXCUBE_ARRAY_SRV{
    /* (UINT) */UInt32 MostDetailedMip;
    /* (UINT) */UInt32 MipLevels;
    /* (UINT) */UInt32 First2DArrayFace;
    /* (UINT) */UInt32 NumCubes;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_SRV{
    /* (UINT) */UInt32 UnusedField_NothingToDefine;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_SRV{
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_SHADER_RESOURCE_VIEW_DESC{
    [FieldOffset(0)]
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    [FieldOffset(4)]
    /* (D3D11_SRV_DIMENSION) */D3D11_SRV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(8)]
        /* (D3D11_BUFFER_SRV) */D3D11_BUFFER_SRV Buffer;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_SRV) */D3D11_TEX1D_SRV Texture1D;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_ARRAY_SRV) */D3D11_TEX1D_ARRAY_SRV Texture1DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_SRV) */D3D11_TEX2D_SRV Texture2D;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_ARRAY_SRV) */D3D11_TEX2D_ARRAY_SRV Texture2DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX2DMS_SRV) */D3D11_TEX2DMS_SRV Texture2DMS;
        [FieldOffset(8)]
        /* (D3D11_TEX2DMS_ARRAY_SRV) */D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        [FieldOffset(8)]
        /* (D3D11_TEX3D_SRV) */D3D11_TEX3D_SRV Texture3D;
        [FieldOffset(8)]
        /* (D3D11_TEXCUBE_SRV) */D3D11_TEXCUBE_SRV TextureCube;
        [FieldOffset(8)]
        /* (D3D11_TEXCUBE_ARRAY_SRV) */D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
        [FieldOffset(8)]
        /* (D3D11_BUFFEREX_SRV) */D3D11_BUFFEREX_SRV BufferEx;
    #endregion
}

[ComImport, Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2")]
public interface ID3D11ShaderResourceView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_SHADER_RESOURCE_VIEW_DESC)) */ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_BUFFER_RTV{
    #region union
        [FieldOffset(0)]
        /* (UINT) */UInt32 FirstElement;
        [FieldOffset(0)]
        /* (UINT) */UInt32 ElementOffset;
    #endregion
    #region union
        [FieldOffset(4)]
        /* (UINT) */UInt32 NumElements;
        [FieldOffset(4)]
        /* (UINT) */UInt32 ElementWidth;
    #endregion
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_RTV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_RTV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_RTV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_RTV{
    /* (UINT) */UInt32 UnusedField_NothingToDefine;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_RTV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_RTV{
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_RTV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstWSlice;
    /* (UINT) */UInt32 WSize;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_RENDER_TARGET_VIEW_DESC{
    [FieldOffset(0)]
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    [FieldOffset(4)]
    /* (D3D11_RTV_DIMENSION) */D3D11_RTV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(8)]
        /* (D3D11_BUFFER_RTV) */D3D11_BUFFER_RTV Buffer;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_RTV) */D3D11_TEX1D_RTV Texture1D;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_ARRAY_RTV) */D3D11_TEX1D_ARRAY_RTV Texture1DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_RTV) */D3D11_TEX2D_RTV Texture2D;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_ARRAY_RTV) */D3D11_TEX2D_ARRAY_RTV Texture2DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX2DMS_RTV) */D3D11_TEX2DMS_RTV Texture2DMS;
        [FieldOffset(8)]
        /* (D3D11_TEX2DMS_ARRAY_RTV) */D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;
        [FieldOffset(8)]
        /* (D3D11_TEX3D_RTV) */D3D11_TEX3D_RTV Texture3D;
    #endregion
}

[ComImport, Guid("dfdba067-0b8d-4865-875b-d7b4516cc164")]
public interface ID3D11RenderTargetView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_RENDER_TARGET_VIEW_DESC)) */ref D3D11_RENDER_TARGET_VIEW_DESC pDesc);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_DSV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_DSV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_DSV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_DSV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_DSV{
    /* (UINT) */UInt32 UnusedField_NothingToDefine;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2DMS_ARRAY_DSV{
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

public enum D3D11_DSV_FLAG {
    READ_ONLY_DEPTH = 0x00000001,
    READ_ONLY_STENCIL = 0x00000002,
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_VIEW_DESC{
    [FieldOffset(0)]
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    [FieldOffset(4)]
    /* (D3D11_DSV_DIMENSION) */D3D11_DSV_DIMENSION ViewDimension;
    [FieldOffset(8)]
    /* (UINT) */UInt32 Flags;
    #region union
        [FieldOffset(12)]
        /* (D3D11_TEX1D_DSV) */D3D11_TEX1D_DSV Texture1D;
        [FieldOffset(12)]
        /* (D3D11_TEX1D_ARRAY_DSV) */D3D11_TEX1D_ARRAY_DSV Texture1DArray;
        [FieldOffset(12)]
        /* (D3D11_TEX2D_DSV) */D3D11_TEX2D_DSV Texture2D;
        [FieldOffset(12)]
        /* (D3D11_TEX2D_ARRAY_DSV) */D3D11_TEX2D_ARRAY_DSV Texture2DArray;
        [FieldOffset(12)]
        /* (D3D11_TEX2DMS_DSV) */D3D11_TEX2DMS_DSV Texture2DMS;
        [FieldOffset(12)]
        /* (D3D11_TEX2DMS_ARRAY_DSV) */D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
    #endregion
}

[ComImport, Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6")]
public interface ID3D11DepthStencilView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_DEPTH_STENCIL_VIEW_DESC)) */ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc);
}

public enum D3D11_BUFFER_UAV_FLAG {
    RAW = 0x00000001,
    APPEND = 0x00000002,
    COUNTER = 0x00000004,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_BUFFER_UAV{
    /* (UINT) */UInt32 FirstElement;
    /* (UINT) */UInt32 NumElements;
    /* (UINT) */UInt32 Flags;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_UAV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX1D_ARRAY_UAV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_UAV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_UAV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX3D_UAV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstWSlice;
    /* (UINT) */UInt32 WSize;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_UNORDERED_ACCESS_VIEW_DESC{
    [FieldOffset(0)]
    /* (DXGI_FORMAT) */DXGI_FORMAT Format;
    [FieldOffset(4)]
    /* (D3D11_UAV_DIMENSION) */D3D11_UAV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(8)]
        /* (D3D11_BUFFER_UAV) */D3D11_BUFFER_UAV Buffer;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_UAV) */D3D11_TEX1D_UAV Texture1D;
        [FieldOffset(8)]
        /* (D3D11_TEX1D_ARRAY_UAV) */D3D11_TEX1D_ARRAY_UAV Texture1DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_UAV) */D3D11_TEX2D_UAV Texture2D;
        [FieldOffset(8)]
        /* (D3D11_TEX2D_ARRAY_UAV) */D3D11_TEX2D_ARRAY_UAV Texture2DArray;
        [FieldOffset(8)]
        /* (D3D11_TEX3D_UAV) */D3D11_TEX3D_UAV Texture3D;
    #endregion
}

[ComImport, Guid("28acf509-7f5c-48f6-8611-f316010a6380")]
public interface ID3D11UnorderedAccessView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_UNORDERED_ACCESS_VIEW_DESC)) */ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
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
    /* (D3D11_FILTER) */D3D11_FILTER Filter;
    /* (D3D11_TEXTURE_ADDRESS_MODE) */D3D11_TEXTURE_ADDRESS_MODE AddressU;
    /* (D3D11_TEXTURE_ADDRESS_MODE) */D3D11_TEXTURE_ADDRESS_MODE AddressV;
    /* (D3D11_TEXTURE_ADDRESS_MODE) */D3D11_TEXTURE_ADDRESS_MODE AddressW;
    /* (FLOAT) */Single MipLODBias;
    /* (UINT) */UInt32 MaxAnisotropy;
    /* (D3D11_COMPARISON_FUNC) */D3D11_COMPARISON_FUNC ComparisonFunc;
    /* (FLOAT)[4] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]public Single[] BorderColor;
    /* (FLOAT) */Single MinLOD;
    /* (FLOAT) */Single MaxLOD;
}

[ComImport, Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5")]
public interface ID3D11SamplerState: ID3D11DeviceChild {
    /* (void) */void GetDesc(/* (*(D3D11_SAMPLER_DESC)) */ref D3D11_SAMPLER_DESC pDesc);
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
    /* (UINT) */UInt32 GetDataSize();
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
    /* (D3D11_QUERY) */D3D11_QUERY Query;
    /* (UINT) */UInt32 MiscFlags;
}

[ComImport, Guid("d6c00747-87b7-425e-b84d-44d108560afd")]
public interface ID3D11Query: ID3D11Asynchronous {
    /* (void) */void GetDesc(/* (*(D3D11_QUERY_DESC)) */ref D3D11_QUERY_DESC pDesc);
}

[ComImport, Guid("9eb576dd-9f77-4d86-81aa-8bab5fe490e2")]
public interface ID3D11Predicate: ID3D11Query {
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_TIMESTAMP_DISJOINT{
    /* (UINT64) */UInt64 Frequency;
    /* (BOOL) */Int32 Disjoint;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_PIPELINE_STATISTICS{
    /* (UINT64) */UInt64 IAVertices;
    /* (UINT64) */UInt64 IAPrimitives;
    /* (UINT64) */UInt64 VSInvocations;
    /* (UINT64) */UInt64 GSInvocations;
    /* (UINT64) */UInt64 GSPrimitives;
    /* (UINT64) */UInt64 CInvocations;
    /* (UINT64) */UInt64 CPrimitives;
    /* (UINT64) */UInt64 PSInvocations;
    /* (UINT64) */UInt64 HSInvocations;
    /* (UINT64) */UInt64 DSInvocations;
    /* (UINT64) */UInt64 CSInvocations;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_QUERY_DATA_SO_STATISTICS{
    /* (UINT64) */UInt64 NumPrimitivesWritten;
    /* (UINT64) */UInt64 PrimitivesStorageNeeded;
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
    /* (D3D11_COUNTER) */D3D11_COUNTER Counter;
    /* (UINT) */UInt32 MiscFlags;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_COUNTER_INFO{
    /* (D3D11_COUNTER) */D3D11_COUNTER LastDeviceDependentCounter;
    /* (UINT) */UInt32 NumSimultaneousCounters;
    /* (UINT8) */Byte NumDetectableParallelUnits;
}

[ComImport, Guid("6e8c49fb-a371-4770-b440-29086022b741")]
public interface ID3D11Counter: ID3D11Asynchronous {
    /* (void) */void GetDesc(/* (*(D3D11_COUNTER_DESC)) */ref D3D11_COUNTER_DESC pDesc);
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
    /* (UINT) */UInt32 InstanceId;
    /* (UINT) */UInt32 InstanceIndex;
    /* (UINT) */UInt32 TypeId;
    /* (UINT) */UInt32 ConstantBuffer;
    /* (UINT) */UInt32 BaseConstantBufferOffset;
    /* (UINT) */UInt32 BaseTexture;
    /* (UINT) */UInt32 BaseSampler;
    /* (BOOL) */Int32 Created;
}

[ComImport, Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb")]
public interface ID3D11ClassInstance: ID3D11DeviceChild {
    /* (void) */void GetClassLinkage(/* (*(*(ID3D11ClassLinkage))) */ref ID3D11ClassLinkage ppLinkage);
    /* (void) */void GetDesc(/* (*(D3D11_CLASS_INSTANCE_DESC)) */ref D3D11_CLASS_INSTANCE_DESC pDesc);
    /* (void) */void GetInstanceName(/* (LPSTR) */IntPtr pInstanceName, /* (*(SIZE_T)) */ref UIntPtr pBufferLength);
    /* (void) */void GetTypeName(/* (LPSTR) */IntPtr pTypeName, /* (*(SIZE_T)) */ref UIntPtr pBufferLength);
}

[ComImport, Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed")]
public interface ID3D11ClassLinkage: ID3D11DeviceChild {
    /* (HRESULT) */Int32 GetClassInstance(/* (LPCSTR) */IntPtr pClassInstanceName, /* (UINT) */UInt32 InstanceIndex, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppInstance);
    /* (HRESULT) */Int32 CreateClassInstance(/* (LPCSTR) */IntPtr pClassTypeName, /* (UINT) */UInt32 ConstantBufferOffset, /* (UINT) */UInt32 ConstantVectorOffset, /* (UINT) */UInt32 TextureOffset, /* (UINT) */UInt32 SamplerOffset, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppInstance);
}

[ComImport, Guid("a24bc4d1-769e-43f7-8013-98ff566c18e2")]
public interface ID3D11CommandList: ID3D11DeviceChild {
    /* (UINT) */UInt32 GetContextFlags();
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
    /* (BOOL) */Int32 DriverConcurrentCreates;
    /* (BOOL) */Int32 DriverCommandLists;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_DOUBLES{
    /* (BOOL) */Int32 DoublePrecisionFloatShaderOps;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_FORMAT_SUPPORT{
    /* (DXGI_FORMAT) */DXGI_FORMAT InFormat;
    /* (UINT) */UInt32 OutFormatSupport;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_FORMAT_SUPPORT2{
    /* (DXGI_FORMAT) */DXGI_FORMAT InFormat;
    /* (UINT) */UInt32 OutFormatSupport2;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS{
    /* (BOOL) */Int32 ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS{
    /* (BOOL) */Int32 OutputMergerLogicOp;
    /* (BOOL) */Int32 UAVOnlyRenderingForcedSampleCount;
    /* (BOOL) */Int32 DiscardAPIsSeenByDriver;
    /* (BOOL) */Int32 FlagsForUpdateAndCopySeenByDriver;
    /* (BOOL) */Int32 ClearView;
    /* (BOOL) */Int32 CopyWithOverlap;
    /* (BOOL) */Int32 ConstantBufferPartialUpdate;
    /* (BOOL) */Int32 ConstantBufferOffsetting;
    /* (BOOL) */Int32 MapNoOverwriteOnDynamicConstantBuffer;
    /* (BOOL) */Int32 MapNoOverwriteOnDynamicBufferSRV;
    /* (BOOL) */Int32 MultisampleRTVWithForcedSampleCountOne;
    /* (BOOL) */Int32 SAD4ShaderInstructions;
    /* (BOOL) */Int32 ExtendedDoublesShaderInstructions;
    /* (BOOL) */Int32 ExtendedResourceSharing;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_ARCHITECTURE_INFO{
    /* (BOOL) */Int32 TileBasedDeferredRenderer;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_OPTIONS{
    /* (BOOL) */Int32 FullNonPow2TextureSupport;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_SHADOW_SUPPORT{
    /* (BOOL) */Int32 SupportsDepthAsTextureWithLessEqualComparisonFilter;
}

public enum D3D11_SHADER_MIN_PRECISION_SUPPORT {
    D3D11_SHADER_MIN_PRECISION_10_BIT = 0x00000001,
    D3D11_SHADER_MIN_PRECISION_16_BIT = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT{
    /* (UINT) */UInt32 PixelShaderMinPrecision;
    /* (UINT) */UInt32 AllOtherShaderStagesMinPrecision;
}

public enum D3D11_TILED_RESOURCES_TIER {
    D3D11_TILED_RESOURCES_NOT_SUPPORTED = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
    _3 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS1{
    /* (D3D11_TILED_RESOURCES_TIER) */D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    /* (BOOL) */Int32 MinMaxFiltering;
    /* (BOOL) */Int32 ClearViewAlsoSupportsDepthOnlyFormats;
    /* (BOOL) */Int32 MapOnDefaultBuffers;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_SIMPLE_INSTANCING_SUPPORT{
    /* (BOOL) */Int32 SimpleInstancingSupported;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_MARKER_SUPPORT{
    /* (BOOL) */Int32 Profile;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D9_OPTIONS1{
    /* (BOOL) */Int32 FullNonPow2TextureSupported;
    /* (BOOL) */Int32 DepthAsTextureWithLessEqualComparisonFilterSupported;
    /* (BOOL) */Int32 SimpleInstancingSupported;
    /* (BOOL) */Int32 TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
}

public enum D3D11_CONSERVATIVE_RASTERIZATION_TIER {
    D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
    _3 = 0x00000003,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS2{
    /* (BOOL) */Int32 PSSpecifiedStencilRefSupported;
    /* (BOOL) */Int32 TypedUAVLoadAdditionalFormats;
    /* (BOOL) */Int32 ROVsSupported;
    /* (D3D11_CONSERVATIVE_RASTERIZATION_TIER) */D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    /* (D3D11_TILED_RESOURCES_TIER) */D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    /* (BOOL) */Int32 MapOnDefaultTextures;
    /* (BOOL) */Int32 StandardSwizzle;
    /* (BOOL) */Int32 UnifiedMemoryArchitecture;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS3{
    /* (BOOL) */Int32 VPAndRTArrayIndexFromAnyShaderFeedingRasterizer;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT{
    /* (UINT) */UInt32 MaxGPUVirtualAddressBitsPerResource;
    /* (UINT) */UInt32 MaxGPUVirtualAddressBitsPerProcess;
}

public enum D3D11_SHADER_CACHE_SUPPORT_FLAGS {
    D3D11_SHADER_CACHE_SUPPORT_NONE = 0x00000000,
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x00000001,
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_SHADER_CACHE{
    /* (UINT) */UInt32 SupportFlags;
}

public enum D3D11_SHARED_RESOURCE_TIER {
    _0 = 0x00000000,
    _1 = 0x00000001,
    _2 = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_FEATURE_DATA_D3D11_OPTIONS5{
    /* (D3D11_SHARED_RESOURCE_TIER) */D3D11_SHARED_RESOURCE_TIER SharedResourceTier;
}

[ComImport, Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
public interface ID3D11DeviceContext: ID3D11DeviceChild {
    /* (void) */void VSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void PSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void PSSetShader(/* (*(ID3D11PixelShader)) */ID3D11PixelShader pPixelShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void PSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void VSSetShader(/* (*(ID3D11VertexShader)) */ID3D11VertexShader pVertexShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void DrawIndexed(/* (UINT) */UInt32 IndexCount, /* (UINT) */UInt32 StartIndexLocation, /* (INT) */Int32 BaseVertexLocation);
    /* (void) */void Draw(/* (UINT) */UInt32 VertexCount, /* (UINT) */UInt32 StartVertexLocation);
    /* (HRESULT) */Int32 Map(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (UINT) */UInt32 Subresource, /* (D3D11_MAP) */D3D11_MAP MapType, /* (UINT) */UInt32 MapFlags, /* (*(D3D11_MAPPED_SUBRESOURCE)) */ref D3D11_MAPPED_SUBRESOURCE pMappedResource);
    /* (void) */void Unmap(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (UINT) */UInt32 Subresource);
    /* (void) */void PSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void IASetInputLayout(/* (*(ID3D11InputLayout)) */ID3D11InputLayout pInputLayout);
    /* (void) */void IASetVertexBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppVertexBuffers, /* (*(const UINT)) */ref UInt32 pStrides, /* (*(const UINT)) */ref UInt32 pOffsets);
    /* (void) */void IASetIndexBuffer(/* (*(ID3D11Buffer)) */ID3D11Buffer pIndexBuffer, /* (DXGI_FORMAT) */DXGI_FORMAT Format, /* (UINT) */UInt32 Offset);
    /* (void) */void DrawIndexedInstanced(/* (UINT) */UInt32 IndexCountPerInstance, /* (UINT) */UInt32 InstanceCount, /* (UINT) */UInt32 StartIndexLocation, /* (INT) */Int32 BaseVertexLocation, /* (UINT) */UInt32 StartInstanceLocation);
    /* (void) */void DrawInstanced(/* (UINT) */UInt32 VertexCountPerInstance, /* (UINT) */UInt32 InstanceCount, /* (UINT) */UInt32 StartVertexLocation, /* (UINT) */UInt32 StartInstanceLocation);
    /* (void) */void GSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void GSSetShader(/* (*(ID3D11GeometryShader)) */ID3D11GeometryShader pShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void IASetPrimitiveTopology(/* (D3D11_PRIMITIVE_TOPOLOGY) */D3D11_PRIMITIVE_TOPOLOGY Topology);
    /* (void) */void VSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void VSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void Begin(/* (*(ID3D11Asynchronous)) */ID3D11Asynchronous pAsync);
    /* (void) */void End(/* (*(ID3D11Asynchronous)) */ID3D11Asynchronous pAsync);
    /* (HRESULT) */Int32 GetData(/* (*(ID3D11Asynchronous)) */ID3D11Asynchronous pAsync, /* (*(void)) */IntPtr pData, /* (UINT) */UInt32 DataSize, /* (UINT) */UInt32 GetDataFlags);
    /* (void) */void SetPredication(/* (*(ID3D11Predicate)) */ID3D11Predicate pPredicate, /* (BOOL) */Int32 PredicateValue);
    /* (void) */void GSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void GSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void OMSetRenderTargets(/* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11RenderTargetView))) */ref ID3D11RenderTargetView ppRenderTargetViews, /* (*(ID3D11DepthStencilView)) */ID3D11DepthStencilView pDepthStencilView);
    /* (void) */void OMSetRenderTargetsAndUnorderedAccessViews(/* (UINT) */UInt32 NumRTVs, /* (*(const *(ID3D11RenderTargetView))) */ref ID3D11RenderTargetView ppRenderTargetViews, /* (*(ID3D11DepthStencilView)) */ID3D11DepthStencilView pDepthStencilView, /* (UINT) */UInt32 UAVStartSlot, /* (UINT) */UInt32 NumUAVs, /* (*(const *(ID3D11UnorderedAccessView))) */ref ID3D11UnorderedAccessView ppUnorderedAccessViews, /* (*(const UINT)) */ref UInt32 pUAVInitialCounts);
    /* (void) */void OMSetBlendState(/* (*(ID3D11BlendState)) */ID3D11BlendState pBlendState, /* (const FLOAT)[4] */ref Vector4 BlendFactor, /* (UINT) */UInt32 SampleMask);
    /* (void) */void OMSetDepthStencilState(/* (*(ID3D11DepthStencilState)) */ID3D11DepthStencilState pDepthStencilState, /* (UINT) */UInt32 StencilRef);
    /* (void) */void SOSetTargets(/* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppSOTargets, /* (*(const UINT)) */ref UInt32 pOffsets);
    /* (void) */void DrawAuto();
    /* (void) */void DrawIndexedInstancedIndirect(/* (*(ID3D11Buffer)) */ID3D11Buffer pBufferForArgs, /* (UINT) */UInt32 AlignedByteOffsetForArgs);
    /* (void) */void DrawInstancedIndirect(/* (*(ID3D11Buffer)) */ID3D11Buffer pBufferForArgs, /* (UINT) */UInt32 AlignedByteOffsetForArgs);
    /* (void) */void Dispatch(/* (UINT) */UInt32 ThreadGroupCountX, /* (UINT) */UInt32 ThreadGroupCountY, /* (UINT) */UInt32 ThreadGroupCountZ);
    /* (void) */void DispatchIndirect(/* (*(ID3D11Buffer)) */ID3D11Buffer pBufferForArgs, /* (UINT) */UInt32 AlignedByteOffsetForArgs);
    /* (void) */void RSSetState(/* (*(ID3D11RasterizerState)) */ID3D11RasterizerState pRasterizerState);
    /* (void) */void RSSetViewports(/* (UINT) */UInt32 NumViewports, /* (*(const D3D11_VIEWPORT)) */ref D3D11_VIEWPORT pViewports);
    /* (void) */void RSSetScissorRects(/* (UINT) */UInt32 NumRects, /* (*(const D3D11_RECT)) */ref D3D11_RECT pRects);
    /* (void) */void CopySubresourceRegion(/* (*(ID3D11Resource)) */ID3D11Resource pDstResource, /* (UINT) */UInt32 DstSubresource, /* (UINT) */UInt32 DstX, /* (UINT) */UInt32 DstY, /* (UINT) */UInt32 DstZ, /* (*(ID3D11Resource)) */ID3D11Resource pSrcResource, /* (UINT) */UInt32 SrcSubresource, /* (*(const D3D11_BOX)) */ref D3D11_BOX pSrcBox);
    /* (void) */void CopyResource(/* (*(ID3D11Resource)) */ID3D11Resource pDstResource, /* (*(ID3D11Resource)) */ID3D11Resource pSrcResource);
    /* (void) */void UpdateSubresource(/* (*(ID3D11Resource)) */ID3D11Resource pDstResource, /* (UINT) */UInt32 DstSubresource, /* (*(const D3D11_BOX)) */ref D3D11_BOX pDstBox, /* (*(const void)) */IntPtr pSrcData, /* (UINT) */UInt32 SrcRowPitch, /* (UINT) */UInt32 SrcDepthPitch);
    /* (void) */void CopyStructureCount(/* (*(ID3D11Buffer)) */ID3D11Buffer pDstBuffer, /* (UINT) */UInt32 DstAlignedByteOffset, /* (*(ID3D11UnorderedAccessView)) */ID3D11UnorderedAccessView pSrcView);
    /* (void) */void ClearRenderTargetView(/* (*(ID3D11RenderTargetView)) */ID3D11RenderTargetView pRenderTargetView, /* (const FLOAT)[4] */ref Vector4 ColorRGBA);
    /* (void) */void ClearUnorderedAccessViewUint(/* (*(ID3D11UnorderedAccessView)) */ID3D11UnorderedAccessView pUnorderedAccessView, /* (const UINT)[4] */UInt32[] Values);
    /* (void) */void ClearUnorderedAccessViewFloat(/* (*(ID3D11UnorderedAccessView)) */ID3D11UnorderedAccessView pUnorderedAccessView, /* (const FLOAT)[4] */ref Vector4 Values);
    /* (void) */void ClearDepthStencilView(/* (*(ID3D11DepthStencilView)) */ID3D11DepthStencilView pDepthStencilView, /* (UINT) */UInt32 ClearFlags, /* (FLOAT) */Single Depth, /* (UINT8) */Byte Stencil);
    /* (void) */void GenerateMips(/* (*(ID3D11ShaderResourceView)) */ID3D11ShaderResourceView pShaderResourceView);
    /* (void) */void SetResourceMinLOD(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (FLOAT) */Single MinLOD);
    /* (FLOAT) */Single GetResourceMinLOD(/* (*(ID3D11Resource)) */ID3D11Resource pResource);
    /* (void) */void ResolveSubresource(/* (*(ID3D11Resource)) */ID3D11Resource pDstResource, /* (UINT) */UInt32 DstSubresource, /* (*(ID3D11Resource)) */ID3D11Resource pSrcResource, /* (UINT) */UInt32 SrcSubresource, /* (DXGI_FORMAT) */DXGI_FORMAT Format);
    /* (void) */void ExecuteCommandList(/* (*(ID3D11CommandList)) */ID3D11CommandList pCommandList, /* (BOOL) */Int32 RestoreContextState);
    /* (void) */void HSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void HSSetShader(/* (*(ID3D11HullShader)) */ID3D11HullShader pHullShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void HSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void HSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void DSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void DSSetShader(/* (*(ID3D11DomainShader)) */ID3D11DomainShader pDomainShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void DSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void DSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void CSSetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(const *(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void CSSetUnorderedAccessViews(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumUAVs, /* (*(const *(ID3D11UnorderedAccessView))) */ref ID3D11UnorderedAccessView ppUnorderedAccessViews, /* (*(const UINT)) */ref UInt32 pUAVInitialCounts);
    /* (void) */void CSSetShader(/* (*(ID3D11ComputeShader)) */ID3D11ComputeShader pComputeShader, /* (*(const *(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (UINT) */UInt32 NumClassInstances);
    /* (void) */void CSSetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(const *(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void CSSetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(const *(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void VSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void PSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void PSGetShader(/* (*(*(ID3D11PixelShader))) */ref ID3D11PixelShader ppPixelShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void PSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void VSGetShader(/* (*(*(ID3D11VertexShader))) */ref ID3D11VertexShader ppVertexShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void PSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void IAGetInputLayout(/* (*(*(ID3D11InputLayout))) */ref ID3D11InputLayout ppInputLayout);
    /* (void) */void IAGetVertexBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppVertexBuffers, /* (*(UINT)) */ref UInt32 pStrides, /* (*(UINT)) */ref UInt32 pOffsets);
    /* (void) */void IAGetIndexBuffer(/* (*(*(ID3D11Buffer))) */ref ID3D11Buffer pIndexBuffer, /* (*(DXGI_FORMAT)) */ref DXGI_FORMAT Format, /* (*(UINT)) */ref UInt32 Offset);
    /* (void) */void GSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void GSGetShader(/* (*(*(ID3D11GeometryShader))) */ref ID3D11GeometryShader ppGeometryShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void IAGetPrimitiveTopology(/* (*(D3D11_PRIMITIVE_TOPOLOGY)) */ref D3D11_PRIMITIVE_TOPOLOGY pTopology);
    /* (void) */void VSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void VSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void GetPredication(/* (*(*(ID3D11Predicate))) */ref ID3D11Predicate ppPredicate, /* (*(BOOL)) */ref Int32 pPredicateValue);
    /* (void) */void GSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void GSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void OMGetRenderTargets(/* (UINT) */UInt32 NumViews, /* (*(*(ID3D11RenderTargetView))) */ref ID3D11RenderTargetView ppRenderTargetViews, /* (*(*(ID3D11DepthStencilView))) */ref ID3D11DepthStencilView ppDepthStencilView);
    /* (void) */void OMGetRenderTargetsAndUnorderedAccessViews(/* (UINT) */UInt32 NumRTVs, /* (*(*(ID3D11RenderTargetView))) */ref ID3D11RenderTargetView ppRenderTargetViews, /* (*(*(ID3D11DepthStencilView))) */ref ID3D11DepthStencilView ppDepthStencilView, /* (UINT) */UInt32 UAVStartSlot, /* (UINT) */UInt32 NumUAVs, /* (*(*(ID3D11UnorderedAccessView))) */ref ID3D11UnorderedAccessView ppUnorderedAccessViews);
    /* (void) */void OMGetBlendState(/* (*(*(ID3D11BlendState))) */ref ID3D11BlendState ppBlendState, /* (FLOAT)[4] */ref Vector4 BlendFactor, /* (*(UINT)) */ref UInt32 pSampleMask);
    /* (void) */void OMGetDepthStencilState(/* (*(*(ID3D11DepthStencilState))) */ref ID3D11DepthStencilState ppDepthStencilState, /* (*(UINT)) */ref UInt32 pStencilRef);
    /* (void) */void SOGetTargets(/* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppSOTargets);
    /* (void) */void RSGetState(/* (*(*(ID3D11RasterizerState))) */ref ID3D11RasterizerState ppRasterizerState);
    /* (void) */void RSGetViewports(/* (*(UINT)) */ref UInt32 pNumViewports, /* (*(D3D11_VIEWPORT)) */ref D3D11_VIEWPORT pViewports);
    /* (void) */void RSGetScissorRects(/* (*(UINT)) */ref UInt32 pNumRects, /* (*(D3D11_RECT)) */ref D3D11_RECT pRects);
    /* (void) */void HSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void HSGetShader(/* (*(*(ID3D11HullShader))) */ref ID3D11HullShader ppHullShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void HSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void HSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void DSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void DSGetShader(/* (*(*(ID3D11DomainShader))) */ref ID3D11DomainShader ppDomainShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void DSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void DSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void CSGetShaderResources(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumViews, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppShaderResourceViews);
    /* (void) */void CSGetUnorderedAccessViews(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumUAVs, /* (*(*(ID3D11UnorderedAccessView))) */ref ID3D11UnorderedAccessView ppUnorderedAccessViews);
    /* (void) */void CSGetShader(/* (*(*(ID3D11ComputeShader))) */ref ID3D11ComputeShader ppComputeShader, /* (*(*(ID3D11ClassInstance))) */ref ID3D11ClassInstance ppClassInstances, /* (*(UINT)) */ref UInt32 pNumClassInstances);
    /* (void) */void CSGetSamplers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumSamplers, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplers);
    /* (void) */void CSGetConstantBuffers(/* (UINT) */UInt32 StartSlot, /* (UINT) */UInt32 NumBuffers, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppConstantBuffers);
    /* (void) */void ClearState();
    /* (void) */void Flush();
    /* (D3D11_DEVICE_CONTEXT_TYPE) */D3D11_DEVICE_CONTEXT_TYPE GetType();
    /* (UINT) */UInt32 GetContextFlags();
    /* (HRESULT) */Int32 FinishCommandList(/* (BOOL) */Int32 RestoreDeferredContextState, /* (*(*(ID3D11CommandList))) */ref ID3D11CommandList ppCommandList);
}

public struct APP_DEPRECATED_HRESULT{
    public /* (HRESULT) */Int32 Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_DESC{
    /* (GUID) */Guid Guid;
    /* (UINT) */UInt32 SampleWidth;
    /* (UINT) */UInt32 SampleHeight;
    /* (DXGI_FORMAT) */DXGI_FORMAT OutputFormat;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_CONFIG{
    /* (GUID) */Guid guidConfigBitstreamEncryption;
    /* (GUID) */Guid guidConfigMBcontrolEncryption;
    /* (GUID) */Guid guidConfigResidDiffEncryption;
    /* (UINT) */UInt32 ConfigBitstreamRaw;
    /* (UINT) */UInt32 ConfigMBcontrolRasterOrder;
    /* (UINT) */UInt32 ConfigResidDiffHost;
    /* (UINT) */UInt32 ConfigSpatialResid8;
    /* (UINT) */UInt32 ConfigResid8Subtraction;
    /* (UINT) */UInt32 ConfigSpatialHost8or9Clipping;
    /* (UINT) */UInt32 ConfigSpatialResidInterleaved;
    /* (UINT) */UInt32 ConfigIntraResidUnsigned;
    /* (UINT) */UInt32 ConfigResidDiffAccelerator;
    /* (UINT) */UInt32 ConfigHostInverseScan;
    /* (UINT) */UInt32 ConfigSpecificIDCT;
    /* (UINT) */UInt32 Config4GroupedCoefs;
    /* (USHORT) */UInt16 ConfigMinRenderTargetBuffCount;
    /* (USHORT) */UInt16 ConfigDecoderSpecific;
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
    /* (UINT64) */UInt64 IV;
    /* (UINT64) */UInt64 Count;
}

public struct D3D11_AES_CTR_IV{
    public /* (_D3D11_AES_CTR_IV) */_D3D11_AES_CTR_IV Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_ENCRYPTED_BLOCK_INFO{
    /* (UINT) */UInt32 NumEncryptedBytesAtBeginning;
    /* (UINT) */UInt32 NumBytesInSkipPattern;
    /* (UINT) */UInt32 NumBytesInEncryptPattern;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_BUFFER_DESC{
    /* (D3D11_VIDEO_DECODER_BUFFER_TYPE) */D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    /* (UINT) */UInt32 BufferIndex;
    /* (UINT) */UInt32 DataOffset;
    /* (UINT) */UInt32 DataSize;
    /* (UINT) */UInt32 FirstMBaddress;
    /* (UINT) */UInt32 NumMBsInBuffer;
    /* (UINT) */UInt32 Width;
    /* (UINT) */UInt32 Height;
    /* (UINT) */UInt32 Stride;
    /* (UINT) */UInt32 ReservedBits;
    /* (*(void)) */IntPtr pIV;
    /* (UINT) */UInt32 IVSize;
    /* (BOOL) */Int32 PartialEncryption;
    /* (D3D11_ENCRYPTED_BLOCK_INFO) */D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_EXTENSION{
    /* (UINT) */UInt32 Function;
    /* (*(void)) */IntPtr pPrivateInputData;
    /* (UINT) */UInt32 PrivateInputDataSize;
    /* (*(void)) */IntPtr pPrivateOutputData;
    /* (UINT) */UInt32 PrivateOutputDataSize;
    /* (UINT) */UInt32 ResourceCount;
    /* (*(*(ID3D11Resource))) */IntPtr ppResourceList;
}

[ComImport, Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c")]
public interface ID3D11VideoDecoder: ID3D11DeviceChild {
    /* (HRESULT) */Int32 GetCreationParameters(/* (*(D3D11_VIDEO_DECODER_DESC)) */ref D3D11_VIDEO_DECODER_DESC pVideoDesc, /* (*(D3D11_VIDEO_DECODER_CONFIG)) */ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    /* (HRESULT) */Int32 GetDriverHandle(/* (*(HANDLE)) */ref IntPtr pDriverHandle);
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
    /* (UINT) */UInt32 DeviceCaps;
    /* (UINT) */UInt32 FeatureCaps;
    /* (UINT) */UInt32 FilterCaps;
    /* (UINT) */UInt32 InputFormatCaps;
    /* (UINT) */UInt32 AutoStreamCaps;
    /* (UINT) */UInt32 StereoCaps;
    /* (UINT) */UInt32 RateConversionCapsCount;
    /* (UINT) */UInt32 MaxInputStreams;
    /* (UINT) */UInt32 MaxStreamStates;
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
    /* (UINT) */UInt32 PastFrames;
    /* (UINT) */UInt32 FutureFrames;
    /* (UINT) */UInt32 ProcessorCaps;
    /* (UINT) */UInt32 ITelecineCaps;
    /* (UINT) */UInt32 CustomRateCount;
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
    /* (UINT) */UInt32 Caps;
    /* (UINT) */UInt32 KeyExchangeTypeCount;
    /* (UINT) */UInt32 BlockAlignmentSize;
    /* (ULONGLONG) */UInt64 ProtectedMemorySize;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE{
    /* (DXGI_RATIONAL) */DXGI_RATIONAL CustomRate;
    /* (UINT) */UInt32 OutputFrames;
    /* (BOOL) */Int32 InputInterlaced;
    /* (UINT) */UInt32 InputFramesOrFields;
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
    /* (int) */int Minimum;
    /* (int) */int Maximum;
    /* (int) */int Default;
    /* (float) */float Multiplier;
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
    /* (D3D11_VIDEO_FRAME_FORMAT) */D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;
    /* (DXGI_RATIONAL) */DXGI_RATIONAL InputFrameRate;
    /* (UINT) */UInt32 InputWidth;
    /* (UINT) */UInt32 InputHeight;
    /* (DXGI_RATIONAL) */DXGI_RATIONAL OutputFrameRate;
    /* (UINT) */UInt32 OutputWidth;
    /* (UINT) */UInt32 OutputHeight;
    /* (D3D11_VIDEO_USAGE) */D3D11_VIDEO_USAGE Usage;
}

[ComImport, Guid("31627037-53ab-4200-9061-05faa9ab45f9")]
public interface ID3D11VideoProcessorEnumerator: ID3D11DeviceChild {
    /* (HRESULT) */Int32 GetVideoProcessorContentDesc(/* (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC)) */ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
    /* (HRESULT) */Int32 CheckVideoProcessorFormat(/* (DXGI_FORMAT) */DXGI_FORMAT Format, /* (*(UINT)) */ref UInt32 pFlags);
    /* (HRESULT) */Int32 GetVideoProcessorCaps(/* (*(D3D11_VIDEO_PROCESSOR_CAPS)) */ref D3D11_VIDEO_PROCESSOR_CAPS pCaps);
    /* (HRESULT) */Int32 GetVideoProcessorRateConversionCaps(/* (UINT) */UInt32 TypeIndex, /* (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS)) */ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
    /* (HRESULT) */Int32 GetVideoProcessorCustomRate(/* (UINT) */UInt32 TypeIndex, /* (UINT) */UInt32 CustomRateIndex, /* (*(D3D11_VIDEO_PROCESSOR_CUSTOM_RATE)) */ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
    /* (HRESULT) */Int32 GetVideoProcessorFilterRange(/* (D3D11_VIDEO_PROCESSOR_FILTER) */D3D11_VIDEO_PROCESSOR_FILTER Filter, /* (*(D3D11_VIDEO_PROCESSOR_FILTER_RANGE)) */ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR_RGBA{
    /* (float) */float R;
    /* (float) */float G;
    /* (float) */float B;
    /* (float) */float A;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR_YCbCrA{
    /* (float) */float Y;
    /* (float) */float Cb;
    /* (float) */float Cr;
    /* (float) */float A;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR{
    #region union
        [FieldOffset(0)]
        /* (D3D11_VIDEO_COLOR_YCbCrA) */D3D11_VIDEO_COLOR_YCbCrA YCbCr;
        [FieldOffset(0)]
        /* (D3D11_VIDEO_COLOR_RGBA) */D3D11_VIDEO_COLOR_RGBA RGBA;
    #endregion
}

public enum D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE {
    UNDEFINED = 0x00000000,
    _16_235 = 0x00000001,
    _0_255 = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE{
    /* (UINT) */UInt32 Usage;
    /* (UINT) */UInt32 RGB_Range;
    /* (UINT) */UInt32 YCbCr_Matrix;
    /* (UINT) */UInt32 YCbCr_xvYCC;
    /* (UINT) */UInt32 Nominal_Range;
    /* (UINT) */UInt32 Reserved;
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
    /* (BOOL) */Int32 Enable;
    /* (UINT) */UInt32 OutputIndex;
    /* (UINT) */UInt32 InputFrameOrField;
    /* (UINT) */UInt32 PastFrames;
    /* (UINT) */UInt32 FutureFrames;
    /* (*(*(ID3D11VideoProcessorInputView))) */IntPtr ppPastSurfaces;
    /* (*(ID3D11VideoProcessorInputView)) */ID3D11VideoProcessorInputView pInputSurface;
    /* (*(*(ID3D11VideoProcessorInputView))) */IntPtr ppFutureSurfaces;
    /* (*(*(ID3D11VideoProcessorInputView))) */IntPtr ppPastSurfacesRight;
    /* (*(ID3D11VideoProcessorInputView)) */ID3D11VideoProcessorInputView pInputSurfaceRight;
    /* (*(*(ID3D11VideoProcessorInputView))) */IntPtr ppFutureSurfacesRight;
}

[ComImport, Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c")]
public interface ID3D11VideoProcessor: ID3D11DeviceChild {
    /* (void) */void GetContentDesc(/* (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC)) */ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc);
    /* (void) */void GetRateConversionCaps(/* (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS)) */ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_OMAC{
    /* (BYTE)[16] */[MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]public Byte[] Omac;
}

public enum D3D11_AUTHENTICATED_CHANNEL_TYPE {
    D3D11_AUTHENTICATED_CHANNEL_D3D11 = 0x00000001,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_SOFTWARE = 0x00000002,
    D3D11_AUTHENTICATED_CHANNEL_DRIVER_HARDWARE = 0x00000003,
}

[ComImport, Guid("3015a308-dcbd-47aa-a747-192486d14d4a")]
public interface ID3D11AuthenticatedChannel: ID3D11DeviceChild {
    /* (HRESULT) */Int32 GetCertificateSize(/* (*(UINT)) */ref UInt32 pCertificateSize);
    /* (HRESULT) */Int32 GetCertificate(/* (UINT) */UInt32 CertificateSize, /* (*(BYTE)) */ref Byte pCertificate);
    /* (void) */void GetChannelHandle(/* (*(HANDLE)) */ref IntPtr pChannelHandle);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_INPUT{
    /* (GUID) */Guid QueryType;
    /* (HANDLE) */IntPtr hChannel;
    /* (UINT) */UInt32 SequenceNumber;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT{
    /* (D3D11_OMAC) */D3D11_OMAC omac;
    /* (GUID) */Guid QueryType;
    /* (HANDLE) */IntPtr hChannel;
    /* (UINT) */UInt32 SequenceNumber;
    /* (HRESULT) */Int32 ReturnCode;
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
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (D3D11_AUTHENTICATED_PROTECTION_FLAGS) */D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (D3D11_AUTHENTICATED_CHANNEL_TYPE) */D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_DEVICE_HANDLE_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (HANDLE) */IntPtr DeviceHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT{
    /* (D3D11_AUTHENTICATED_QUERY_INPUT) */D3D11_AUTHENTICATED_QUERY_INPUT Input;
    /* (HANDLE) */IntPtr DecoderHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (HANDLE) */IntPtr DecoderHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
    /* (HANDLE) */IntPtr DeviceHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (UINT) */UInt32 RestrictedSharedResourceProcessCount;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_INPUT{
    /* (D3D11_AUTHENTICATED_QUERY_INPUT) */D3D11_AUTHENTICATED_QUERY_INPUT Input;
    /* (UINT) */UInt32 ProcessIndex;
}

public enum D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE {
    D3D11_PROCESSIDTYPE_UNKNOWN = 0x00000000,
    D3D11_PROCESSIDTYPE_DWM = 0x00000001,
    D3D11_PROCESSIDTYPE_HANDLE = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (UINT) */UInt32 ProcessIndex;
    /* (D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE) */D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier;
    /* (HANDLE) */IntPtr ProcessHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (UINT) */UInt32 UnrestrictedProtectedSharedResourceCount;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT{
    /* (D3D11_AUTHENTICATED_QUERY_INPUT) */D3D11_AUTHENTICATED_QUERY_INPUT Input;
    /* (HANDLE) */IntPtr DeviceHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (HANDLE) */IntPtr DeviceHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
    /* (UINT) */UInt32 OutputIDCount;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT{
    /* (D3D11_AUTHENTICATED_QUERY_INPUT) */D3D11_AUTHENTICATED_QUERY_INPUT Input;
    /* (HANDLE) */IntPtr DeviceHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
    /* (UINT) */UInt32 OutputIDIndex;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (HANDLE) */IntPtr DeviceHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
    /* (UINT) */UInt32 OutputIDIndex;
    /* (UINT64) */UInt64 OutputID;
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
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (D3D11_BUS_TYPE) */D3D11_BUS_TYPE BusType;
    /* (BOOL) */Int32 AccessibleInContiguousBlocks;
    /* (BOOL) */Int32 AccessibleInNonContiguousBlocks;
}

public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT{
    public /* (D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_COUNT_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (UINT) */UInt32 EncryptionGuidCount;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_INPUT{
    /* (D3D11_AUTHENTICATED_QUERY_INPUT) */D3D11_AUTHENTICATED_QUERY_INPUT Input;
    /* (UINT) */UInt32 EncryptionGuidIndex;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (UINT) */UInt32 EncryptionGuidIndex;
    /* (GUID) */Guid EncryptionGuid;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_CURRENT_ACCESSIBILITY_ENCRYPTION_OUTPUT{
    /* (D3D11_AUTHENTICATED_QUERY_OUTPUT) */D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /* (GUID) */Guid EncryptionGuid;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_INPUT{
    /* (D3D11_OMAC) */D3D11_OMAC omac;
    /* (GUID) */Guid ConfigureType;
    /* (HANDLE) */IntPtr hChannel;
    /* (UINT) */UInt32 SequenceNumber;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_OUTPUT{
    /* (D3D11_OMAC) */D3D11_OMAC omac;
    /* (GUID) */Guid ConfigureType;
    /* (HANDLE) */IntPtr hChannel;
    /* (UINT) */UInt32 SequenceNumber;
    /* (HRESULT) */Int32 ReturnCode;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT{
    /* (D3D11_AUTHENTICATED_CONFIGURE_INPUT) */D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /* (UINT) */UInt32 StartSequenceQuery;
    /* (UINT) */UInt32 StartSequenceConfigure;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT{
    /* (D3D11_AUTHENTICATED_CONFIGURE_INPUT) */D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /* (D3D11_AUTHENTICATED_PROTECTION_FLAGS) */D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION_INPUT{
    /* (D3D11_AUTHENTICATED_CONFIGURE_INPUT) */D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /* (HANDLE) */IntPtr DecoderHandle;
    /* (HANDLE) */IntPtr CryptoSessionHandle;
    /* (HANDLE) */IntPtr DeviceHandle;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT{
    /* (D3D11_AUTHENTICATED_CONFIGURE_INPUT) */D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /* (D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE) */D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;
    /* (HANDLE) */IntPtr ProcessHandle;
    /* (BOOL) */Int32 AllowAccess;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_CONFIGURE_ACCESSIBLE_ENCRYPTION_INPUT{
    /* (D3D11_AUTHENTICATED_CONFIGURE_INPUT) */D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /* (GUID) */Guid EncryptionGuid;
}

[ComImport, Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720")]
public interface ID3D11CryptoSession: ID3D11DeviceChild {
    /* (void) */void GetCryptoType(/* (*(GUID)) */ref Guid pCryptoType);
    /* (void) */void GetDecoderProfile(/* (*(GUID)) */ref Guid pDecoderProfile);
    /* (HRESULT) */Int32 GetCertificateSize(/* (*(UINT)) */ref UInt32 pCertificateSize);
    /* (HRESULT) */Int32 GetCertificate(/* (UINT) */UInt32 CertificateSize, /* (*(BYTE)) */ref Byte pCertificate);
    /* (void) */void GetCryptoSessionHandle(/* (*(HANDLE)) */ref IntPtr pCryptoSessionHandle);
}

public enum D3D11_VDOV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VDOV{
    /* (UINT) */UInt32 ArraySlice;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /* (GUID) */Guid DecodeProfile;
    [FieldOffset(4)]
    /* (D3D11_VDOV_DIMENSION) */D3D11_VDOV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(8)]
        /* (D3D11_TEX2D_VDOV) */D3D11_TEX2D_VDOV Texture2D;
    #endregion
}

[ComImport, Guid("c2931aea-2a85-4f20-860f-fba1fd256e18")]
public interface ID3D11VideoDecoderOutputView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC)) */ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
}

public enum D3D11_VPIV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VPIV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 ArraySlice;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC{
    [FieldOffset(0)]
    /* (UINT) */UInt32 FourCC;
    [FieldOffset(4)]
    /* (D3D11_VPIV_DIMENSION) */D3D11_VPIV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(8)]
        /* (D3D11_TEX2D_VPIV) */D3D11_TEX2D_VPIV Texture2D;
    #endregion
}

[ComImport, Guid("11ec5a5f-51dc-4945-ab34-6e8c21300ea5")]
public interface ID3D11VideoProcessorInputView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC)) */ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc);
}

public enum D3D11_VPOV_DIMENSION {
    UNKNOWN = 0x00000000,
    TEXTURE2D = 0x00000001,
    TEXTURE2DARRAY = 0x00000002,
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_VPOV{
    /* (UINT) */UInt32 MipSlice;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_TEX2D_ARRAY_VPOV{
    /* (UINT) */UInt32 MipSlice;
    /* (UINT) */UInt32 FirstArraySlice;
    /* (UINT) */UInt32 ArraySize;
}

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /* (D3D11_VPOV_DIMENSION) */D3D11_VPOV_DIMENSION ViewDimension;
    #region union
        [FieldOffset(4)]
        /* (D3D11_TEX2D_VPOV) */D3D11_TEX2D_VPOV Texture2D;
        [FieldOffset(4)]
        /* (D3D11_TEX2D_ARRAY_VPOV) */D3D11_TEX2D_ARRAY_VPOV Texture2DArray;
    #endregion
}

[ComImport, Guid("a048285e-25a9-4527-bd93-d68b68c44254")]
public interface ID3D11VideoProcessorOutputView: ID3D11View {
    /* (void) */void GetDesc(/* (*(D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC)) */ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc);
}

[ComImport, Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
public interface ID3D11VideoContext: ID3D11DeviceChild {
    /* (HRESULT) */Int32 GetDecoderBuffer(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder, /* (D3D11_VIDEO_DECODER_BUFFER_TYPE) */D3D11_VIDEO_DECODER_BUFFER_TYPE Type, /* (*(UINT)) */ref UInt32 pBufferSize, /* (*(*(void))) */ref IntPtr ppBuffer);
    /* (HRESULT) */Int32 ReleaseDecoderBuffer(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder, /* (D3D11_VIDEO_DECODER_BUFFER_TYPE) */D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
    /* (HRESULT) */Int32 DecoderBeginFrame(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder, /* (*(ID3D11VideoDecoderOutputView)) */ID3D11VideoDecoderOutputView pView, /* (UINT) */UInt32 ContentKeySize, /* (*(const void)) */IntPtr pContentKey);
    /* (HRESULT) */Int32 DecoderEndFrame(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder);
    /* (HRESULT) */Int32 SubmitDecoderBuffers(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder, /* (UINT) */UInt32 NumBuffers, /* (*(const D3D11_VIDEO_DECODER_BUFFER_DESC)) */ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc);
    /* (APP_DEPRECATED_HRESULT) */APP_DEPRECATED_HRESULT DecoderExtension(/* (*(ID3D11VideoDecoder)) */ID3D11VideoDecoder pDecoder, /* (*(const D3D11_VIDEO_DECODER_EXTENSION)) */ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
    /* (void) */void VideoProcessorSetOutputTargetRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (BOOL) */Int32 Enable, /* (*(const RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorSetOutputBackgroundColor(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (BOOL) */Int32 YCbCr, /* (*(const D3D11_VIDEO_COLOR)) */ref D3D11_VIDEO_COLOR pColor);
    /* (void) */void VideoProcessorSetOutputColorSpace(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE)) */ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    /* (void) */void VideoProcessorSetOutputAlphaFillMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE) */D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, /* (UINT) */UInt32 StreamIndex);
    /* (void) */void VideoProcessorSetOutputConstriction(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (BOOL) */Int32 Enable, /* (SIZE) */SIZE Size);
    /* (void) */void VideoProcessorSetOutputStereoMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (BOOL) */Int32 Enable);
    /* (APP_DEPRECATED_HRESULT) */APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtension(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(const GUID)) */ref Guid pExtensionGuid, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (void) */void VideoProcessorGetOutputTargetRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(BOOL)) */ref Int32 Enabled, /* (*(RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorGetOutputBackgroundColor(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(BOOL)) */ref Int32 pYCbCr, /* (*(D3D11_VIDEO_COLOR)) */ref D3D11_VIDEO_COLOR pColor);
    /* (void) */void VideoProcessorGetOutputColorSpace(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE)) */ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    /* (void) */void VideoProcessorGetOutputAlphaFillMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE)) */ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, /* (*(UINT)) */ref UInt32 pStreamIndex);
    /* (void) */void VideoProcessorGetOutputConstriction(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(SIZE)) */ref SIZE pSize);
    /* (void) */void VideoProcessorGetOutputStereoMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(BOOL)) */ref Int32 pEnabled);
    /* (APP_DEPRECATED_HRESULT) */APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtension(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(const GUID)) */ref Guid pExtensionGuid, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (void) */void VideoProcessorSetStreamFrameFormat(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (D3D11_VIDEO_FRAME_FORMAT) */D3D11_VIDEO_FRAME_FORMAT FrameFormat);
    /* (void) */void VideoProcessorSetStreamColorSpace(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE)) */ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    /* (void) */void VideoProcessorSetStreamOutputRate(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (D3D11_VIDEO_PROCESSOR_OUTPUT_RATE) */D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, /* (BOOL) */Int32 RepeatFrame, /* (*(const DXGI_RATIONAL)) */ref DXGI_RATIONAL pCustomRate);
    /* (void) */void VideoProcessorSetStreamSourceRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (*(const RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorSetStreamDestRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (*(const RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorSetStreamAlpha(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (FLOAT) */Single Alpha);
    /* (void) */void VideoProcessorSetStreamPalette(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (UINT) */UInt32 Count, /* (*(const UINT)) */ref UInt32 pEntries);
    /* (void) */void VideoProcessorSetStreamPixelAspectRatio(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (*(const DXGI_RATIONAL)) */ref DXGI_RATIONAL pSourceAspectRatio, /* (*(const DXGI_RATIONAL)) */ref DXGI_RATIONAL pDestinationAspectRatio);
    /* (void) */void VideoProcessorSetStreamLumaKey(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (FLOAT) */Single Lower, /* (FLOAT) */Single Upper);
    /* (void) */void VideoProcessorSetStreamStereoFormat(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (D3D11_VIDEO_PROCESSOR_STEREO_FORMAT) */D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, /* (BOOL) */Int32 LeftViewFrame0, /* (BOOL) */Int32 BaseViewFrame0, /* (D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE) */D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, /* (int) */int MonoOffset);
    /* (void) */void VideoProcessorSetStreamAutoProcessingMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable);
    /* (void) */void VideoProcessorSetStreamFilter(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (D3D11_VIDEO_PROCESSOR_FILTER) */D3D11_VIDEO_PROCESSOR_FILTER Filter, /* (BOOL) */Int32 Enable, /* (int) */int Level);
    /* (APP_DEPRECATED_HRESULT) */APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtension(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(const GUID)) */ref Guid pExtensionGuid, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (void) */void VideoProcessorGetStreamFrameFormat(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(D3D11_VIDEO_FRAME_FORMAT)) */ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
    /* (void) */void VideoProcessorGetStreamColorSpace(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE)) */ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    /* (void) */void VideoProcessorGetStreamOutputRate(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(D3D11_VIDEO_PROCESSOR_OUTPUT_RATE)) */ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, /* (*(BOOL)) */ref Int32 pRepeatFrame, /* (*(DXGI_RATIONAL)) */ref DXGI_RATIONAL pCustomRate);
    /* (void) */void VideoProcessorGetStreamSourceRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorGetStreamDestRect(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(RECT)) */ref RECT pRect);
    /* (void) */void VideoProcessorGetStreamAlpha(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(FLOAT)) */ref Single pAlpha);
    /* (void) */void VideoProcessorGetStreamPalette(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (UINT) */UInt32 Count, /* (*(UINT)) */ref UInt32 pEntries);
    /* (void) */void VideoProcessorGetStreamPixelAspectRatio(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(DXGI_RATIONAL)) */ref DXGI_RATIONAL pSourceAspectRatio, /* (*(DXGI_RATIONAL)) */ref DXGI_RATIONAL pDestinationAspectRatio);
    /* (void) */void VideoProcessorGetStreamLumaKey(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(FLOAT)) */ref Single pLower, /* (*(FLOAT)) */ref Single pUpper);
    /* (void) */void VideoProcessorGetStreamStereoFormat(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnable, /* (*(D3D11_VIDEO_PROCESSOR_STEREO_FORMAT)) */ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, /* (*(BOOL)) */ref Int32 pLeftViewFrame0, /* (*(BOOL)) */ref Int32 pBaseViewFrame0, /* (*(D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE)) */ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, /* (*(int)) */ref int MonoOffset);
    /* (void) */void VideoProcessorGetStreamAutoProcessingMode(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnabled);
    /* (void) */void VideoProcessorGetStreamFilter(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (D3D11_VIDEO_PROCESSOR_FILTER) */D3D11_VIDEO_PROCESSOR_FILTER Filter, /* (*(BOOL)) */ref Int32 pEnabled, /* (*(int)) */ref int pLevel);
    /* (APP_DEPRECATED_HRESULT) */APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtension(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(const GUID)) */ref Guid pExtensionGuid, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (HRESULT) */Int32 VideoProcessorBlt(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (*(ID3D11VideoProcessorOutputView)) */ID3D11VideoProcessorOutputView pView, /* (UINT) */UInt32 OutputFrame, /* (UINT) */UInt32 StreamCount, /* (*(const D3D11_VIDEO_PROCESSOR_STREAM)) */ref D3D11_VIDEO_PROCESSOR_STREAM pStreams);
    /* (HRESULT) */Int32 NegotiateCryptoSessionKeyExchange(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (void) */void EncryptionBlt(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession, /* (*(ID3D11Texture2D)) */ID3D11Texture2D pSrcSurface, /* (*(ID3D11Texture2D)) */ID3D11Texture2D pDstSurface, /* (UINT) */UInt32 IVSize, /* (*(void)) */IntPtr pIV);
    /* (void) */void DecryptionBlt(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession, /* (*(ID3D11Texture2D)) */ID3D11Texture2D pSrcSurface, /* (*(ID3D11Texture2D)) */ID3D11Texture2D pDstSurface, /* (*(D3D11_ENCRYPTED_BLOCK_INFO)) */ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo, /* (UINT) */UInt32 ContentKeySize, /* (*(const void)) */IntPtr pContentKey, /* (UINT) */UInt32 IVSize, /* (*(void)) */IntPtr pIV);
    /* (void) */void StartSessionKeyRefresh(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession, /* (UINT) */UInt32 RandomNumberSize, /* (*(void)) */IntPtr pRandomNumber);
    /* (void) */void FinishSessionKeyRefresh(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession);
    /* (HRESULT) */Int32 GetEncryptionBltKey(/* (*(ID3D11CryptoSession)) */ID3D11CryptoSession pCryptoSession, /* (UINT) */UInt32 KeySize, /* (*(void)) */IntPtr pReadbackKey);
    /* (HRESULT) */Int32 NegotiateAuthenticatedChannelKeyExchange(/* (*(ID3D11AuthenticatedChannel)) */ID3D11AuthenticatedChannel pChannel, /* (UINT) */UInt32 DataSize, /* (*(void)) */IntPtr pData);
    /* (HRESULT) */Int32 QueryAuthenticatedChannel(/* (*(ID3D11AuthenticatedChannel)) */ID3D11AuthenticatedChannel pChannel, /* (UINT) */UInt32 InputSize, /* (*(const void)) */IntPtr pInput, /* (UINT) */UInt32 OutputSize, /* (*(void)) */IntPtr pOutput);
    /* (HRESULT) */Int32 ConfigureAuthenticatedChannel(/* (*(ID3D11AuthenticatedChannel)) */ID3D11AuthenticatedChannel pChannel, /* (UINT) */UInt32 InputSize, /* (*(const void)) */IntPtr pInput, /* (*(D3D11_AUTHENTICATED_CONFIGURE_OUTPUT)) */ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
    /* (void) */void VideoProcessorSetStreamRotation(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (BOOL) */Int32 Enable, /* (D3D11_VIDEO_PROCESSOR_ROTATION) */D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
    /* (void) */void VideoProcessorGetStreamRotation(/* (*(ID3D11VideoProcessor)) */ID3D11VideoProcessor pVideoProcessor, /* (UINT) */UInt32 StreamIndex, /* (*(BOOL)) */ref Int32 pEnable, /* (*(D3D11_VIDEO_PROCESSOR_ROTATION)) */ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
}

[ComImport, Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11VideoDevice{
    /* (HRESULT) */Int32 CreateVideoDecoder(/* (*(const D3D11_VIDEO_DECODER_DESC)) */ref D3D11_VIDEO_DECODER_DESC pVideoDesc, /* (*(const D3D11_VIDEO_DECODER_CONFIG)) */ref D3D11_VIDEO_DECODER_CONFIG pConfig, /* (*(*(ID3D11VideoDecoder))) */ref ID3D11VideoDecoder ppDecoder);
    /* (HRESULT) */Int32 CreateVideoProcessor(/* (*(ID3D11VideoProcessorEnumerator)) */ID3D11VideoProcessorEnumerator pEnum, /* (UINT) */UInt32 RateConversionIndex, /* (*(*(ID3D11VideoProcessor))) */ref ID3D11VideoProcessor ppVideoProcessor);
    /* (HRESULT) */Int32 CreateAuthenticatedChannel(/* (D3D11_AUTHENTICATED_CHANNEL_TYPE) */D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, /* (*(*(ID3D11AuthenticatedChannel))) */ref ID3D11AuthenticatedChannel ppAuthenticatedChannel);
    /* (HRESULT) */Int32 CreateCryptoSession(/* (*(const GUID)) */ref Guid pCryptoType, /* (*(const GUID)) */ref Guid pDecoderProfile, /* (*(const GUID)) */ref Guid pKeyExchangeType, /* (*(*(ID3D11CryptoSession))) */ref ID3D11CryptoSession ppCryptoSession);
    /* (HRESULT) */Int32 CreateVideoDecoderOutputView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC)) */ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, /* (*(*(ID3D11VideoDecoderOutputView))) */ref ID3D11VideoDecoderOutputView ppVDOVView);
    /* (HRESULT) */Int32 CreateVideoProcessorInputView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(ID3D11VideoProcessorEnumerator)) */ID3D11VideoProcessorEnumerator pEnum, /* (*(const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC)) */ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, /* (*(*(ID3D11VideoProcessorInputView))) */ref ID3D11VideoProcessorInputView ppVPIView);
    /* (HRESULT) */Int32 CreateVideoProcessorOutputView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(ID3D11VideoProcessorEnumerator)) */ID3D11VideoProcessorEnumerator pEnum, /* (*(const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC)) */ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, /* (*(*(ID3D11VideoProcessorOutputView))) */ref ID3D11VideoProcessorOutputView ppVPOView);
    /* (HRESULT) */Int32 CreateVideoProcessorEnumerator(/* (*(const D3D11_VIDEO_PROCESSOR_CONTENT_DESC)) */ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, /* (*(*(ID3D11VideoProcessorEnumerator))) */ref ID3D11VideoProcessorEnumerator ppEnum);
    /* (UINT) */UInt32 GetVideoDecoderProfileCount();
    /* (HRESULT) */Int32 GetVideoDecoderProfile(/* (UINT) */UInt32 Index, /* (*(GUID)) */ref Guid pDecoderProfile);
    /* (HRESULT) */Int32 CheckVideoDecoderFormat(/* (*(const GUID)) */ref Guid pDecoderProfile, /* (DXGI_FORMAT) */DXGI_FORMAT Format, /* (*(BOOL)) */ref Int32 pSupported);
    /* (HRESULT) */Int32 GetVideoDecoderConfigCount(/* (*(const D3D11_VIDEO_DECODER_DESC)) */ref D3D11_VIDEO_DECODER_DESC pDesc, /* (*(UINT)) */ref UInt32 pCount);
    /* (HRESULT) */Int32 GetVideoDecoderConfig(/* (*(const D3D11_VIDEO_DECODER_DESC)) */ref D3D11_VIDEO_DECODER_DESC pDesc, /* (UINT) */UInt32 Index, /* (*(D3D11_VIDEO_DECODER_CONFIG)) */ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    /* (HRESULT) */Int32 GetContentProtectionCaps(/* (*(const GUID)) */ref Guid pCryptoType, /* (*(const GUID)) */ref Guid pDecoderProfile, /* (*(D3D11_VIDEO_CONTENT_PROTECTION_CAPS)) */ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
    /* (HRESULT) */Int32 CheckCryptoKeyExchange(/* (*(const GUID)) */ref Guid pCryptoType, /* (*(const GUID)) */ref Guid pDecoderProfile, /* (UINT) */UInt32 Index, /* (*(GUID)) */ref Guid pKeyExchangeType);
    /* (HRESULT) */Int32 SetPrivateData(/* (&(const GUID)) */ref Guid guid, /* (UINT) */UInt32 DataSize, /* (*(const void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateDataInterface(/* (&(const GUID)) */ref Guid guid, /* (*(const IUnknown)) */IntPtr pData);
}

[ComImport, Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ID3D11Device{
    /* (HRESULT) */Int32 CreateBuffer(/* (*(const D3D11_BUFFER_DESC)) */ref D3D11_BUFFER_DESC pDesc, /* (*(const D3D11_SUBRESOURCE_DATA)) */ref D3D11_SUBRESOURCE_DATA pInitialData, /* (*(*(ID3D11Buffer))) */ref ID3D11Buffer ppBuffer);
    /* (HRESULT) */Int32 CreateTexture1D(/* (*(const D3D11_TEXTURE1D_DESC)) */ref D3D11_TEXTURE1D_DESC pDesc, /* (*(const D3D11_SUBRESOURCE_DATA)) */ref D3D11_SUBRESOURCE_DATA pInitialData, /* (*(*(ID3D11Texture1D))) */ref ID3D11Texture1D ppTexture1D);
    /* (HRESULT) */Int32 CreateTexture2D(/* (*(const D3D11_TEXTURE2D_DESC)) */ref D3D11_TEXTURE2D_DESC pDesc, /* (*(const D3D11_SUBRESOURCE_DATA)) */ref D3D11_SUBRESOURCE_DATA pInitialData, /* (*(*(ID3D11Texture2D))) */ref ID3D11Texture2D ppTexture2D);
    /* (HRESULT) */Int32 CreateTexture3D(/* (*(const D3D11_TEXTURE3D_DESC)) */ref D3D11_TEXTURE3D_DESC pDesc, /* (*(const D3D11_SUBRESOURCE_DATA)) */ref D3D11_SUBRESOURCE_DATA pInitialData, /* (*(*(ID3D11Texture3D))) */ref ID3D11Texture3D ppTexture3D);
    /* (HRESULT) */Int32 CreateShaderResourceView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(const D3D11_SHADER_RESOURCE_VIEW_DESC)) */ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc, /* (*(*(ID3D11ShaderResourceView))) */ref ID3D11ShaderResourceView ppSRView);
    /* (HRESULT) */Int32 CreateUnorderedAccessView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(const D3D11_UNORDERED_ACCESS_VIEW_DESC)) */ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc, /* (*(*(ID3D11UnorderedAccessView))) */ref ID3D11UnorderedAccessView ppUAView);
    /* (HRESULT) */Int32 CreateRenderTargetView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(const D3D11_RENDER_TARGET_VIEW_DESC)) */ref D3D11_RENDER_TARGET_VIEW_DESC pDesc, /* (*(*(ID3D11RenderTargetView))) */ref ID3D11RenderTargetView ppRTView);
    /* (HRESULT) */Int32 CreateDepthStencilView(/* (*(ID3D11Resource)) */ID3D11Resource pResource, /* (*(const D3D11_DEPTH_STENCIL_VIEW_DESC)) */ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc, /* (*(*(ID3D11DepthStencilView))) */ref ID3D11DepthStencilView ppDepthStencilView);
    /* (HRESULT) */Int32 CreateInputLayout(/* (*(const D3D11_INPUT_ELEMENT_DESC)) */ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs, /* (UINT) */UInt32 NumElements, /* (*(const void)) */IntPtr pShaderBytecodeWithInputSignature, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(*(ID3D11InputLayout))) */ref ID3D11InputLayout ppInputLayout);
    /* (HRESULT) */Int32 CreateVertexShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11VertexShader))) */ref ID3D11VertexShader ppVertexShader);
    /* (HRESULT) */Int32 CreateGeometryShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11GeometryShader))) */ref ID3D11GeometryShader ppGeometryShader);
    /* (HRESULT) */Int32 CreateGeometryShaderWithStreamOutput(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(const D3D11_SO_DECLARATION_ENTRY)) */ref D3D11_SO_DECLARATION_ENTRY pSODeclaration, /* (UINT) */UInt32 NumEntries, /* (*(const UINT)) */ref UInt32 pBufferStrides, /* (UINT) */UInt32 NumStrides, /* (UINT) */UInt32 RasterizedStream, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11GeometryShader))) */ref ID3D11GeometryShader ppGeometryShader);
    /* (HRESULT) */Int32 CreatePixelShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11PixelShader))) */ref ID3D11PixelShader ppPixelShader);
    /* (HRESULT) */Int32 CreateHullShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11HullShader))) */ref ID3D11HullShader ppHullShader);
    /* (HRESULT) */Int32 CreateDomainShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11DomainShader))) */ref ID3D11DomainShader ppDomainShader);
    /* (HRESULT) */Int32 CreateComputeShader(/* (*(const void)) */IntPtr pShaderBytecode, /* (SIZE_T) */UIntPtr BytecodeLength, /* (*(ID3D11ClassLinkage)) */ID3D11ClassLinkage pClassLinkage, /* (*(*(ID3D11ComputeShader))) */ref ID3D11ComputeShader ppComputeShader);
    /* (HRESULT) */Int32 CreateClassLinkage(/* (*(*(ID3D11ClassLinkage))) */ref ID3D11ClassLinkage ppLinkage);
    /* (HRESULT) */Int32 CreateBlendState(/* (*(const D3D11_BLEND_DESC)) */ref D3D11_BLEND_DESC pBlendStateDesc, /* (*(*(ID3D11BlendState))) */ref ID3D11BlendState ppBlendState);
    /* (HRESULT) */Int32 CreateDepthStencilState(/* (*(const D3D11_DEPTH_STENCIL_DESC)) */ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, /* (*(*(ID3D11DepthStencilState))) */ref ID3D11DepthStencilState ppDepthStencilState);
    /* (HRESULT) */Int32 CreateRasterizerState(/* (*(const D3D11_RASTERIZER_DESC)) */ref D3D11_RASTERIZER_DESC pRasterizerDesc, /* (*(*(ID3D11RasterizerState))) */ref ID3D11RasterizerState ppRasterizerState);
    /* (HRESULT) */Int32 CreateSamplerState(/* (*(const D3D11_SAMPLER_DESC)) */ref D3D11_SAMPLER_DESC pSamplerDesc, /* (*(*(ID3D11SamplerState))) */ref ID3D11SamplerState ppSamplerState);
    /* (HRESULT) */Int32 CreateQuery(/* (*(const D3D11_QUERY_DESC)) */ref D3D11_QUERY_DESC pQueryDesc, /* (*(*(ID3D11Query))) */ref ID3D11Query ppQuery);
    /* (HRESULT) */Int32 CreatePredicate(/* (*(const D3D11_QUERY_DESC)) */ref D3D11_QUERY_DESC pPredicateDesc, /* (*(*(ID3D11Predicate))) */ref ID3D11Predicate ppPredicate);
    /* (HRESULT) */Int32 CreateCounter(/* (*(const D3D11_COUNTER_DESC)) */ref D3D11_COUNTER_DESC pCounterDesc, /* (*(*(ID3D11Counter))) */ref ID3D11Counter ppCounter);
    /* (HRESULT) */Int32 CreateDeferredContext(/* (UINT) */UInt32 ContextFlags, /* (*(*(ID3D11DeviceContext))) */ref ID3D11DeviceContext ppDeferredContext);
    /* (HRESULT) */Int32 OpenSharedResource(/* (HANDLE) */IntPtr hResource, /* (&(const IID)) */ref Guid ReturnedInterface, /* (*(*(void))) */ref IntPtr ppResource);
    /* (HRESULT) */Int32 CheckFormatSupport(/* (DXGI_FORMAT) */DXGI_FORMAT Format, /* (*(UINT)) */ref UInt32 pFormatSupport);
    /* (HRESULT) */Int32 CheckMultisampleQualityLevels(/* (DXGI_FORMAT) */DXGI_FORMAT Format, /* (UINT) */UInt32 SampleCount, /* (*(UINT)) */ref UInt32 pNumQualityLevels);
    /* (void) */void CheckCounterInfo(/* (*(D3D11_COUNTER_INFO)) */ref D3D11_COUNTER_INFO pCounterInfo);
    /* (HRESULT) */Int32 CheckCounter(/* (*(const D3D11_COUNTER_DESC)) */ref D3D11_COUNTER_DESC pDesc, /* (*(D3D11_COUNTER_TYPE)) */ref D3D11_COUNTER_TYPE pType, /* (*(UINT)) */ref UInt32 pActiveCounters, /* (LPSTR) */IntPtr szName, /* (*(UINT)) */ref UInt32 pNameLength, /* (LPSTR) */IntPtr szUnits, /* (*(UINT)) */ref UInt32 pUnitsLength, /* (LPSTR) */IntPtr szDescription, /* (*(UINT)) */ref UInt32 pDescriptionLength);
    /* (HRESULT) */Int32 CheckFeatureSupport(/* (D3D11_FEATURE) */D3D11_FEATURE Feature, /* (*(void)) */IntPtr pFeatureSupportData, /* (UINT) */UInt32 FeatureSupportDataSize);
    /* (HRESULT) */Int32 GetPrivateData(/* (&(const GUID)) */ref Guid guid, /* (*(UINT)) */ref UInt32 pDataSize, /* (*(void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateData(/* (&(const GUID)) */ref Guid guid, /* (UINT) */UInt32 DataSize, /* (*(const void)) */IntPtr pData);
    /* (HRESULT) */Int32 SetPrivateDataInterface(/* (&(const GUID)) */ref Guid guid, /* (*(const IUnknown)) */IntPtr pData);
    /* (D3D_FEATURE_LEVEL) */D3D_FEATURE_LEVEL GetFeatureLevel();
    /* (UINT) */UInt32 GetCreationFlags();
    /* (HRESULT) */Int32 GetDeviceRemovedReason();
    /* (void) */void GetImmediateContext(/* (*(*(ID3D11DeviceContext))) */ref ID3D11DeviceContext ppImmediateContext);
    /* (HRESULT) */Int32 SetExceptionMode(/* (UINT) */UInt32 RaiseFlags);
    /* (UINT) */UInt32 GetExceptionMode();
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
public static extern /* (UINT) */UInt32 D3D11CalcSubresource(/* (UINT) */UInt32 MipSlice, /* (UINT) */UInt32 ArraySlice, /* (UINT) */UInt32 MipLevels);

[DllImport("D3D11.dll")]
public static extern /* (HRESULT) */Int32 D3D11CreateDevice(/* (*(IDXGIAdapter)) */IDXGIAdapter pAdapter, /* (D3D_DRIVER_TYPE) */D3D_DRIVER_TYPE DriverType, /* (HMODULE) */IntPtr Software, /* (UINT) */UInt32 Flags, /* (*(const D3D_FEATURE_LEVEL)) */ref D3D_FEATURE_LEVEL pFeatureLevels, /* (UINT) */UInt32 FeatureLevels, /* (UINT) */UInt32 SDKVersion, /* (*(*(ID3D11Device))) */ref ID3D11Device ppDevice, /* (*(D3D_FEATURE_LEVEL)) */ref D3D_FEATURE_LEVEL pFeatureLevel, /* (*(*(ID3D11DeviceContext))) */ref ID3D11DeviceContext ppImmediateContext);

[DllImport("D3D11.dll")]
public static extern /* (HRESULT) */Int32 D3D11CreateDeviceAndSwapChain(/* (*(IDXGIAdapter)) */IDXGIAdapter pAdapter, /* (D3D_DRIVER_TYPE) */D3D_DRIVER_TYPE DriverType, /* (HMODULE) */IntPtr Software, /* (UINT) */UInt32 Flags, /* (*(const D3D_FEATURE_LEVEL)) */ref D3D_FEATURE_LEVEL pFeatureLevels, /* (UINT) */UInt32 FeatureLevels, /* (UINT) */UInt32 SDKVersion, /* (*(const DXGI_SWAP_CHAIN_DESC)) */ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc, /* (*(*(IDXGISwapChain))) */ref IDXGISwapChain ppSwapChain, /* (*(*(ID3D11Device))) */ref ID3D11Device ppDevice, /* (*(D3D_FEATURE_LEVEL)) */ref D3D_FEATURE_LEVEL pFeatureLevel, /* (*(*(ID3D11DeviceContext))) */ref ID3D11DeviceContext ppImmediateContext);

}
}
