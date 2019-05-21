
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_PRIMITIVE_TOPOLOGY{
    public D3D_PRIMITIVE_TOPOLOGY Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

public class ID3D11DeviceChild : IUnknownImpl{

    static /*readonly*/ Guid s_uuid = new Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    public void GetDevice(
        /// ppDevice: (*(*(ID3D11Device)))
        ref IntPtr ppDevice
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceFunc));
        callback(Self, ref ppDevice);
    }
    delegate void GetDeviceFunc(IntPtr self, ref IntPtr ppDevice);
    public Int32 GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref guid, ref pDataSize, pData);
    }
    delegate Int32 GetPrivateDataFunc(IntPtr self, ref Guid guid, ref UInt32 pDataSize, IntPtr pData);
    public Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate Int32 SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate Int32 SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
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

public class ID3D11DepthStencilState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("03823efb-8d8f-4e1c-9aa2-f64bb2cbfdf1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_DEPTH_STENCIL_DESC pDesc);
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

public class ID3D11BlendState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("75b68faa-347d-4159-8f45-a0640f01cd9a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_BLEND_DESC))
        ref D3D11_BLEND_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_BLEND_DESC pDesc);
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

public class ID3D11RasterizerState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_RASTERIZER_DESC pDesc);
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

public class ID3D11Resource: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    public void GetType(
        /// pResourceDimension: (*(D3D11_RESOURCE_DIMENSION))
        ref D3D11_RESOURCE_DIMENSION pResourceDimension
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        callback(Self, ref pResourceDimension);
    }
    delegate void GetTypeFunc(IntPtr self, ref D3D11_RESOURCE_DIMENSION pResourceDimension);
    public void SetEvictionPriority(
        /// EvictionPriority: (UINT)
        UInt32 EvictionPriority
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
        callback(Self, EvictionPriority);
    }
    delegate void SetEvictionPriorityFunc(IntPtr self, UInt32 EvictionPriority);
    public UInt32 GetEvictionPriority(
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
        return callback(Self);
    }
    delegate UInt32 GetEvictionPriorityFunc(IntPtr self);
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

public class ID3D11Buffer: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("48570b85-d1ee-4fcd-a250-eb350722b037");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_BUFFER_DESC pDesc);
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

public class ID3D11Texture1D: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("f8fb5c27-c6b3-4f75-a4c8-439af2ef564c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE1D_DESC))
        ref D3D11_TEXTURE1D_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_TEXTURE1D_DESC pDesc);
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

public class ID3D11Texture2D: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_TEXTURE2D_DESC pDesc);
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

public class ID3D11Texture3D: ID3D11Resource {

    static /*readonly*/ Guid s_uuid = new Guid("037e866e-f56d-4357-a8af-9dabbe6e250e");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_TEXTURE3D_DESC))
        ref D3D11_TEXTURE3D_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_TEXTURE3D_DESC pDesc);
}

public enum D3D11_TEXTURECUBE_FACE {
    POSITIVE_X = 0x00000000,
    NEGATIVE_X = 0x00000001,
    POSITIVE_Y = 0x00000002,
    NEGATIVE_Y = 0x00000003,
    POSITIVE_Z = 0x00000004,
    NEGATIVE_Z = 0x00000005,
}

public class ID3D11View: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetResource(
        /// ppResource: (*(*(ID3D11Resource)))
        ref IntPtr ppResource
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceFunc));
        callback(Self, ref ppResource);
    }
    delegate void GetResourceFunc(IntPtr self, ref IntPtr ppResource);
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

public class ID3D11ShaderResourceView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_SHADER_RESOURCE_VIEW_DESC))
        ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
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

public class ID3D11RenderTargetView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("dfdba067-0b8d-4865-875b-d7b4516cc164");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_RENDER_TARGET_VIEW_DESC))
        ref D3D11_RENDER_TARGET_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_RENDER_TARGET_VIEW_DESC pDesc);
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

public class ID3D11DepthStencilView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_DEPTH_STENCIL_VIEW_DESC))
        ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc);
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

public class ID3D11UnorderedAccessView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("28acf509-7f5c-48f6-8611-f316010a6380");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_UNORDERED_ACCESS_VIEW_DESC))
        ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
}

public class ID3D11VertexShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3b301d64-d678-4289-8897-22f8928b72f3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11HullShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("8e5c6061-628a-4c8e-8264-bbe45cb3d5dd");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11DomainShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("f582c508-0f36-490c-9977-31eece268cfa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11GeometryShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("38325b96-effb-4022-ba02-2e795b70275c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11PixelShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("ea82e40d-51dc-4f33-93d4-db7c9125ae8c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11ComputeShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("4f5b196e-c2bd-495e-bd01-1fded38e4969");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
}

public class ID3D11InputLayout: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("e4819ddc-4cf0-4025-bd26-5de82a3e07b7");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
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

public class ID3D11SamplerState: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_SAMPLER_DESC))
        ref D3D11_SAMPLER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_SAMPLER_DESC pDesc);
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

public class ID3D11Asynchronous: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public UInt32 GetDataSize(
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDataSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataSizeFunc));
        return callback(Self);
    }
    delegate UInt32 GetDataSizeFunc(IntPtr self);
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

public class ID3D11Query: ID3D11Asynchronous {

    static /*readonly*/ Guid s_uuid = new Guid("d6c00747-87b7-425e-b84d-44d108560afd");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_QUERY_DESC pDesc);
}

public class ID3D11Predicate: ID3D11Query {

    static /*readonly*/ Guid s_uuid = new Guid("9eb576dd-9f77-4d86-81aa-8bab5fe490e2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 0;
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

public class ID3D11Counter: ID3D11Asynchronous {

    static /*readonly*/ Guid s_uuid = new Guid("6e8c49fb-a371-4770-b440-29086022b741");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_COUNTER_DESC pDesc);
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

public class ID3D11ClassInstance: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 4;
    public void GetClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref IntPtr ppLinkage
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetClassLinkageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassLinkageFunc));
        callback(Self, ref ppLinkage);
    }
    delegate void GetClassLinkageFunc(IntPtr self, ref IntPtr ppLinkage);
    public void GetDesc(
        /// pDesc: (*(D3D11_CLASS_INSTANCE_DESC))
        ref D3D11_CLASS_INSTANCE_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_CLASS_INSTANCE_DESC pDesc);
    public void GetInstanceName(
        /// pInstanceName: (LPSTR)
        IntPtr pInstanceName
        /// pBufferLength: (*(SIZE_T))
        , ref UIntPtr pBufferLength
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetInstanceNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInstanceNameFunc));
        callback(Self, pInstanceName, ref pBufferLength);
    }
    delegate void GetInstanceNameFunc(IntPtr self, IntPtr pInstanceName, ref UIntPtr pBufferLength);
    public void GetTypeName(
        /// pTypeName: (LPSTR)
        IntPtr pTypeName
        /// pBufferLength: (*(SIZE_T))
        , ref UIntPtr pBufferLength
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetTypeNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeNameFunc));
        callback(Self, pTypeName, ref pBufferLength);
    }
    delegate void GetTypeNameFunc(IntPtr self, IntPtr pTypeName, ref UIntPtr pBufferLength);
}

public class ID3D11ClassLinkage: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 GetClassInstance(
        /// pClassInstanceName: (LPCSTR)
        IntPtr pClassInstanceName
        /// InstanceIndex: (UINT)
        , UInt32 InstanceIndex
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppInstance
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassInstanceFunc));
        return callback(Self, pClassInstanceName, InstanceIndex, ref ppInstance);
    }
    delegate Int32 GetClassInstanceFunc(IntPtr self, IntPtr pClassInstanceName, UInt32 InstanceIndex, ref IntPtr ppInstance);
    public Int32 CreateClassInstance(
        /// pClassTypeName: (LPCSTR)
        IntPtr pClassTypeName
        /// ConstantBufferOffset: (UINT)
        , UInt32 ConstantBufferOffset
        /// ConstantVectorOffset: (UINT)
        , UInt32 ConstantVectorOffset
        /// TextureOffset: (UINT)
        , UInt32 TextureOffset
        /// SamplerOffset: (UINT)
        , UInt32 SamplerOffset
        /// ppInstance: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppInstance
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (CreateClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassInstanceFunc));
        return callback(Self, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ref ppInstance);
    }
    delegate Int32 CreateClassInstanceFunc(IntPtr self, IntPtr pClassTypeName, UInt32 ConstantBufferOffset, UInt32 ConstantVectorOffset, UInt32 TextureOffset, UInt32 SamplerOffset, ref IntPtr ppInstance);
}

public class ID3D11CommandList: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("a24bc4d1-769e-43f7-8013-98ff566c18e2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public UInt32 GetContextFlags(
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetContextFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContextFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetContextFlagsFunc(IntPtr self);
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

public class ID3D11DeviceContext: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 108;
    public void VSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (VSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void VSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void PSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (PSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void PSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void PSSetShader(
        /// pPixelShader: (*(ID3D11PixelShader))
        IntPtr pPixelShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (PSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetShaderFunc));
        callback(Self, pPixelShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void PSSetShaderFunc(IntPtr self, IntPtr pPixelShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void PSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (PSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void PSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void VSSetShader(
        /// pVertexShader: (*(ID3D11VertexShader))
        IntPtr pVertexShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (VSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetShaderFunc));
        callback(Self, pVertexShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void VSSetShaderFunc(IntPtr self, IntPtr pVertexShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void DrawIndexed(
        /// IndexCount: (UINT)
        UInt32 IndexCount
        /// StartIndexLocation: (UINT)
        , UInt32 StartIndexLocation
        /// BaseVertexLocation: (INT)
        , Int32 BaseVertexLocation
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (DrawIndexedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedFunc));
        callback(Self, IndexCount, StartIndexLocation, BaseVertexLocation);
    }
    delegate void DrawIndexedFunc(IntPtr self, UInt32 IndexCount, UInt32 StartIndexLocation, Int32 BaseVertexLocation);
    public void Draw(
        /// VertexCount: (UINT)
        UInt32 VertexCount
        /// StartVertexLocation: (UINT)
        , UInt32 StartVertexLocation
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
        callback(Self, VertexCount, StartVertexLocation);
    }
    delegate void DrawFunc(IntPtr self, UInt32 VertexCount, UInt32 StartVertexLocation);
    public Int32 Map(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// Subresource: (UINT)
        , UInt32 Subresource
        /// MapType: (D3D11_MAP)
        , D3D11_MAP MapType
        /// MapFlags: (UINT)
        , UInt32 MapFlags
        /// pMappedResource: (*(D3D11_MAPPED_SUBRESOURCE))
        , ref D3D11_MAPPED_SUBRESOURCE pMappedResource
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, pResource, Subresource, MapType, MapFlags, ref pMappedResource);
    }
    delegate Int32 MapFunc(IntPtr self, IntPtr pResource, UInt32 Subresource, D3D11_MAP MapType, UInt32 MapFlags, ref D3D11_MAPPED_SUBRESOURCE pMappedResource);
    public void Unmap(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// Subresource: (UINT)
        , UInt32 Subresource
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        callback(Self, pResource, Subresource);
    }
    delegate void UnmapFunc(IntPtr self, IntPtr pResource, UInt32 Subresource);
    public void PSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (PSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void PSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void IASetInputLayout(
        /// pInputLayout: (*(ID3D11InputLayout))
        IntPtr pInputLayout
    )
    {
        var fp = GetFunctionPointer(10);
        var callback = (IASetInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetInputLayoutFunc));
        callback(Self, pInputLayout);
    }
    delegate void IASetInputLayoutFunc(IntPtr self, IntPtr pInputLayout);
    public void IASetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppVertexBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppVertexBuffers
        /// pStrides: (*(const UINT))
        , ref UInt32 pStrides
        /// pOffsets: (*(const UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(11);
        var callback = (IASetVertexBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetVertexBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides, ref pOffsets);
    }
    delegate void IASetVertexBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppVertexBuffers, ref UInt32 pStrides, ref UInt32 pOffsets);
    public void IASetIndexBuffer(
        /// pIndexBuffer: (*(ID3D11Buffer))
        IntPtr pIndexBuffer
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
        /// Offset: (UINT)
        , UInt32 Offset
    )
    {
        var fp = GetFunctionPointer(12);
        var callback = (IASetIndexBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetIndexBufferFunc));
        callback(Self, pIndexBuffer, Format, Offset);
    }
    delegate void IASetIndexBufferFunc(IntPtr self, IntPtr pIndexBuffer, DXGI_FORMAT Format, UInt32 Offset);
    public void DrawIndexedInstanced(
        /// IndexCountPerInstance: (UINT)
        UInt32 IndexCountPerInstance
        /// InstanceCount: (UINT)
        , UInt32 InstanceCount
        /// StartIndexLocation: (UINT)
        , UInt32 StartIndexLocation
        /// BaseVertexLocation: (INT)
        , Int32 BaseVertexLocation
        /// StartInstanceLocation: (UINT)
        , UInt32 StartInstanceLocation
    )
    {
        var fp = GetFunctionPointer(13);
        var callback = (DrawIndexedInstancedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedInstancedFunc));
        callback(Self, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }
    delegate void DrawIndexedInstancedFunc(IntPtr self, UInt32 IndexCountPerInstance, UInt32 InstanceCount, UInt32 StartIndexLocation, Int32 BaseVertexLocation, UInt32 StartInstanceLocation);
    public void DrawInstanced(
        /// VertexCountPerInstance: (UINT)
        UInt32 VertexCountPerInstance
        /// InstanceCount: (UINT)
        , UInt32 InstanceCount
        /// StartVertexLocation: (UINT)
        , UInt32 StartVertexLocation
        /// StartInstanceLocation: (UINT)
        , UInt32 StartInstanceLocation
    )
    {
        var fp = GetFunctionPointer(14);
        var callback = (DrawInstancedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInstancedFunc));
        callback(Self, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }
    delegate void DrawInstancedFunc(IntPtr self, UInt32 VertexCountPerInstance, UInt32 InstanceCount, UInt32 StartVertexLocation, UInt32 StartInstanceLocation);
    public void GSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(15);
        var callback = (GSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void GSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void GSSetShader(
        /// pShader: (*(ID3D11GeometryShader))
        IntPtr pShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(16);
        var callback = (GSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetShaderFunc));
        callback(Self, pShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void GSSetShaderFunc(IntPtr self, IntPtr pShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void IASetPrimitiveTopology(
        /// Topology: (D3D11_PRIMITIVE_TOPOLOGY)
        D3D11_PRIMITIVE_TOPOLOGY Topology
    )
    {
        var fp = GetFunctionPointer(17);
        var callback = (IASetPrimitiveTopologyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetPrimitiveTopologyFunc));
        callback(Self, Topology);
    }
    delegate void IASetPrimitiveTopologyFunc(IntPtr self, D3D11_PRIMITIVE_TOPOLOGY Topology);
    public void VSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(18);
        var callback = (VSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void VSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void VSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(19);
        var callback = (VSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void VSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void Begin(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
    )
    {
        var fp = GetFunctionPointer(20);
        var callback = (BeginFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginFunc));
        callback(Self, pAsync);
    }
    delegate void BeginFunc(IntPtr self, IntPtr pAsync);
    public void End(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
    )
    {
        var fp = GetFunctionPointer(21);
        var callback = (EndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndFunc));
        callback(Self, pAsync);
    }
    delegate void EndFunc(IntPtr self, IntPtr pAsync);
    public Int32 GetData(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
        /// pData: (*(void))
        , IntPtr pData
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// GetDataFlags: (UINT)
        , UInt32 GetDataFlags
    )
    {
        var fp = GetFunctionPointer(22);
        var callback = (GetDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataFunc));
        return callback(Self, pAsync, pData, DataSize, GetDataFlags);
    }
    delegate Int32 GetDataFunc(IntPtr self, IntPtr pAsync, IntPtr pData, UInt32 DataSize, UInt32 GetDataFlags);
    public void SetPredication(
        /// pPredicate: (*(ID3D11Predicate))
        IntPtr pPredicate
        /// PredicateValue: (BOOL)
        , Int32 PredicateValue
    )
    {
        var fp = GetFunctionPointer(23);
        var callback = (SetPredicationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPredicationFunc));
        callback(Self, pPredicate, PredicateValue);
    }
    delegate void SetPredicationFunc(IntPtr self, IntPtr pPredicate, Int32 PredicateValue);
    public void GSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(24);
        var callback = (GSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void GSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void GSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(25);
        var callback = (GSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void GSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void OMSetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        , IntPtr pDepthStencilView
    )
    {
        var fp = GetFunctionPointer(26);
        var callback = (OMSetRenderTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetRenderTargetsFunc));
        callback(Self, NumViews, ref ppRenderTargetViews, pDepthStencilView);
    }
    delegate void OMSetRenderTargetsFunc(IntPtr self, UInt32 NumViews, ref IntPtr ppRenderTargetViews, IntPtr pDepthStencilView);
    public void OMSetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        , IntPtr pDepthStencilView
        /// UAVStartSlot: (UINT)
        , UInt32 UAVStartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
        /// pUAVInitialCounts: (*(const UINT))
        , ref UInt32 pUAVInitialCounts
    )
    {
        var fp = GetFunctionPointer(27);
        var callback = (OMSetRenderTargetsAndUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetRenderTargetsAndUnorderedAccessViewsFunc));
        callback(Self, NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }
    delegate void OMSetRenderTargetsAndUnorderedAccessViewsFunc(IntPtr self, UInt32 NumRTVs, ref IntPtr ppRenderTargetViews, IntPtr pDepthStencilView, UInt32 UAVStartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews, ref UInt32 pUAVInitialCounts);
    public void OMSetBlendState(
        /// pBlendState: (*(ID3D11BlendState))
        IntPtr pBlendState
        /// BlendFactor: (const FLOAT)[4]
        , ref Vector4 BlendFactor
        /// SampleMask: (UINT)
        , UInt32 SampleMask
    )
    {
        var fp = GetFunctionPointer(28);
        var callback = (OMSetBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetBlendStateFunc));
        callback(Self, pBlendState, ref BlendFactor, SampleMask);
    }
    delegate void OMSetBlendStateFunc(IntPtr self, IntPtr pBlendState, ref Vector4 BlendFactor, UInt32 SampleMask);
    public void OMSetDepthStencilState(
        /// pDepthStencilState: (*(ID3D11DepthStencilState))
        IntPtr pDepthStencilState
        /// StencilRef: (UINT)
        , UInt32 StencilRef
    )
    {
        var fp = GetFunctionPointer(29);
        var callback = (OMSetDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetDepthStencilStateFunc));
        callback(Self, pDepthStencilState, StencilRef);
    }
    delegate void OMSetDepthStencilStateFunc(IntPtr self, IntPtr pDepthStencilState, UInt32 StencilRef);
    public void SOSetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers
        /// ppSOTargets: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppSOTargets
        /// pOffsets: (*(const UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(30);
        var callback = (SOSetTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SOSetTargetsFunc));
        callback(Self, NumBuffers, ref ppSOTargets, ref pOffsets);
    }
    delegate void SOSetTargetsFunc(IntPtr self, UInt32 NumBuffers, ref IntPtr ppSOTargets, ref UInt32 pOffsets);
    public void DrawAuto(
    )
    {
        var fp = GetFunctionPointer(31);
        var callback = (DrawAutoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawAutoFunc));
        callback(Self);
    }
    delegate void DrawAutoFunc(IntPtr self);
    public void DrawIndexedInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(32);
        var callback = (DrawIndexedInstancedIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedInstancedIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DrawIndexedInstancedIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void DrawInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(33);
        var callback = (DrawInstancedIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInstancedIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DrawInstancedIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void Dispatch(
        /// ThreadGroupCountX: (UINT)
        UInt32 ThreadGroupCountX
        /// ThreadGroupCountY: (UINT)
        , UInt32 ThreadGroupCountY
        /// ThreadGroupCountZ: (UINT)
        , UInt32 ThreadGroupCountZ
    )
    {
        var fp = GetFunctionPointer(34);
        var callback = (DispatchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DispatchFunc));
        callback(Self, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }
    delegate void DispatchFunc(IntPtr self, UInt32 ThreadGroupCountX, UInt32 ThreadGroupCountY, UInt32 ThreadGroupCountZ);
    public void DispatchIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(35);
        var callback = (DispatchIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DispatchIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DispatchIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void RSSetState(
        /// pRasterizerState: (*(ID3D11RasterizerState))
        IntPtr pRasterizerState
    )
    {
        var fp = GetFunctionPointer(36);
        var callback = (RSSetStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetStateFunc));
        callback(Self, pRasterizerState);
    }
    delegate void RSSetStateFunc(IntPtr self, IntPtr pRasterizerState);
    public void RSSetViewports(
        /// NumViewports: (UINT)
        UInt32 NumViewports
        /// pViewports: (*(const D3D11_VIEWPORT))
        , ref D3D11_VIEWPORT pViewports
    )
    {
        var fp = GetFunctionPointer(37);
        var callback = (RSSetViewportsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetViewportsFunc));
        callback(Self, NumViewports, ref pViewports);
    }
    delegate void RSSetViewportsFunc(IntPtr self, UInt32 NumViewports, ref D3D11_VIEWPORT pViewports);
    public void RSSetScissorRects(
        /// NumRects: (UINT)
        UInt32 NumRects
        /// pRects: (*(const D3D11_RECT))
        , ref D3D11_RECT pRects
    )
    {
        var fp = GetFunctionPointer(38);
        var callback = (RSSetScissorRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetScissorRectsFunc));
        callback(Self, NumRects, ref pRects);
    }
    delegate void RSSetScissorRectsFunc(IntPtr self, UInt32 NumRects, ref D3D11_RECT pRects);
    public void CopySubresourceRegion(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// DstX: (UINT)
        , UInt32 DstX
        /// DstY: (UINT)
        , UInt32 DstY
        /// DstZ: (UINT)
        , UInt32 DstZ
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
        /// SrcSubresource: (UINT)
        , UInt32 SrcSubresource
        /// pSrcBox: (*(const D3D11_BOX))
        , ref D3D11_BOX pSrcBox
    )
    {
        var fp = GetFunctionPointer(39);
        var callback = (CopySubresourceRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopySubresourceRegionFunc));
        callback(Self, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox);
    }
    delegate void CopySubresourceRegionFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, UInt32 DstX, UInt32 DstY, UInt32 DstZ, IntPtr pSrcResource, UInt32 SrcSubresource, ref D3D11_BOX pSrcBox);
    public void CopyResource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
    )
    {
        var fp = GetFunctionPointer(40);
        var callback = (CopyResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyResourceFunc));
        callback(Self, pDstResource, pSrcResource);
    }
    delegate void CopyResourceFunc(IntPtr self, IntPtr pDstResource, IntPtr pSrcResource);
    public void UpdateSubresource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// pDstBox: (*(const D3D11_BOX))
        , ref D3D11_BOX pDstBox
        /// pSrcData: (*(const void))
        , IntPtr pSrcData
        /// SrcRowPitch: (UINT)
        , UInt32 SrcRowPitch
        /// SrcDepthPitch: (UINT)
        , UInt32 SrcDepthPitch
    )
    {
        var fp = GetFunctionPointer(41);
        var callback = (UpdateSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UpdateSubresourceFunc));
        callback(Self, pDstResource, DstSubresource, ref pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }
    delegate void UpdateSubresourceFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, ref D3D11_BOX pDstBox, IntPtr pSrcData, UInt32 SrcRowPitch, UInt32 SrcDepthPitch);
    public void CopyStructureCount(
        /// pDstBuffer: (*(ID3D11Buffer))
        IntPtr pDstBuffer
        /// DstAlignedByteOffset: (UINT)
        , UInt32 DstAlignedByteOffset
        /// pSrcView: (*(ID3D11UnorderedAccessView))
        , IntPtr pSrcView
    )
    {
        var fp = GetFunctionPointer(42);
        var callback = (CopyStructureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyStructureCountFunc));
        callback(Self, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }
    delegate void CopyStructureCountFunc(IntPtr self, IntPtr pDstBuffer, UInt32 DstAlignedByteOffset, IntPtr pSrcView);
    public void ClearRenderTargetView(
        /// pRenderTargetView: (*(ID3D11RenderTargetView))
        IntPtr pRenderTargetView
        /// ColorRGBA: (const FLOAT)[4]
        , ref Vector4 ColorRGBA
    )
    {
        var fp = GetFunctionPointer(43);
        var callback = (ClearRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearRenderTargetViewFunc));
        callback(Self, pRenderTargetView, ref ColorRGBA);
    }
    delegate void ClearRenderTargetViewFunc(IntPtr self, IntPtr pRenderTargetView, ref Vector4 ColorRGBA);
    public void ClearUnorderedAccessViewUint(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        IntPtr pUnorderedAccessView
        /// Values: (const UINT)[4]
        , ref UInt32 Values
    )
    {
        var fp = GetFunctionPointer(44);
        var callback = (ClearUnorderedAccessViewUintFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearUnorderedAccessViewUintFunc));
        callback(Self, pUnorderedAccessView, ref Values);
    }
    delegate void ClearUnorderedAccessViewUintFunc(IntPtr self, IntPtr pUnorderedAccessView, ref UInt32 Values);
    public void ClearUnorderedAccessViewFloat(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        IntPtr pUnorderedAccessView
        /// Values: (const FLOAT)[4]
        , ref Vector4 Values
    )
    {
        var fp = GetFunctionPointer(45);
        var callback = (ClearUnorderedAccessViewFloatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearUnorderedAccessViewFloatFunc));
        callback(Self, pUnorderedAccessView, ref Values);
    }
    delegate void ClearUnorderedAccessViewFloatFunc(IntPtr self, IntPtr pUnorderedAccessView, ref Vector4 Values);
    public void ClearDepthStencilView(
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        IntPtr pDepthStencilView
        /// ClearFlags: (UINT)
        , UInt32 ClearFlags
        /// Depth: (FLOAT)
        , Single Depth
        /// Stencil: (UINT8)
        , Byte Stencil
    )
    {
        var fp = GetFunctionPointer(46);
        var callback = (ClearDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearDepthStencilViewFunc));
        callback(Self, pDepthStencilView, ClearFlags, Depth, Stencil);
    }
    delegate void ClearDepthStencilViewFunc(IntPtr self, IntPtr pDepthStencilView, UInt32 ClearFlags, Single Depth, Byte Stencil);
    public void GenerateMips(
        /// pShaderResourceView: (*(ID3D11ShaderResourceView))
        IntPtr pShaderResourceView
    )
    {
        var fp = GetFunctionPointer(47);
        var callback = (GenerateMipsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GenerateMipsFunc));
        callback(Self, pShaderResourceView);
    }
    delegate void GenerateMipsFunc(IntPtr self, IntPtr pShaderResourceView);
    public void SetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// MinLOD: (FLOAT)
        , Single MinLOD
    )
    {
        var fp = GetFunctionPointer(48);
        var callback = (SetResourceMinLODFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetResourceMinLODFunc));
        callback(Self, pResource, MinLOD);
    }
    delegate void SetResourceMinLODFunc(IntPtr self, IntPtr pResource, Single MinLOD);
    public Single GetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
    )
    {
        var fp = GetFunctionPointer(49);
        var callback = (GetResourceMinLODFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceMinLODFunc));
        return callback(Self, pResource);
    }
    delegate Single GetResourceMinLODFunc(IntPtr self, IntPtr pResource);
    public void ResolveSubresource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
        /// SrcSubresource: (UINT)
        , UInt32 SrcSubresource
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
    )
    {
        var fp = GetFunctionPointer(50);
        var callback = (ResolveSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResolveSubresourceFunc));
        callback(Self, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }
    delegate void ResolveSubresourceFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, IntPtr pSrcResource, UInt32 SrcSubresource, DXGI_FORMAT Format);
    public void ExecuteCommandList(
        /// pCommandList: (*(ID3D11CommandList))
        IntPtr pCommandList
        /// RestoreContextState: (BOOL)
        , Int32 RestoreContextState
    )
    {
        var fp = GetFunctionPointer(51);
        var callback = (ExecuteCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ExecuteCommandListFunc));
        callback(Self, pCommandList, RestoreContextState);
    }
    delegate void ExecuteCommandListFunc(IntPtr self, IntPtr pCommandList, Int32 RestoreContextState);
    public void HSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(52);
        var callback = (HSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void HSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void HSSetShader(
        /// pHullShader: (*(ID3D11HullShader))
        IntPtr pHullShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(53);
        var callback = (HSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetShaderFunc));
        callback(Self, pHullShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void HSSetShaderFunc(IntPtr self, IntPtr pHullShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void HSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(54);
        var callback = (HSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void HSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void HSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(55);
        var callback = (HSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void HSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void DSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(56);
        var callback = (DSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void DSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void DSSetShader(
        /// pDomainShader: (*(ID3D11DomainShader))
        IntPtr pDomainShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(57);
        var callback = (DSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetShaderFunc));
        callback(Self, pDomainShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void DSSetShaderFunc(IntPtr self, IntPtr pDomainShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void DSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(58);
        var callback = (DSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void DSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void DSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(59);
        var callback = (DSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void DSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void CSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(60);
        var callback = (CSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void CSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void CSSetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
        /// pUAVInitialCounts: (*(const UINT))
        , ref UInt32 pUAVInitialCounts
    )
    {
        var fp = GetFunctionPointer(61);
        var callback = (CSSetUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetUnorderedAccessViewsFunc));
        callback(Self, StartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }
    delegate void CSSetUnorderedAccessViewsFunc(IntPtr self, UInt32 StartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews, ref UInt32 pUAVInitialCounts);
    public void CSSetShader(
        /// pComputeShader: (*(ID3D11ComputeShader))
        IntPtr pComputeShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(62);
        var callback = (CSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetShaderFunc));
        callback(Self, pComputeShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void CSSetShaderFunc(IntPtr self, IntPtr pComputeShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void CSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(63);
        var callback = (CSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void CSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void CSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(64);
        var callback = (CSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void CSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void VSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(65);
        var callback = (VSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void VSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void PSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(66);
        var callback = (PSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void PSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void PSGetShader(
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        ref IntPtr ppPixelShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(67);
        var callback = (PSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetShaderFunc));
        callback(Self, ref ppPixelShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void PSGetShaderFunc(IntPtr self, ref IntPtr ppPixelShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void PSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(68);
        var callback = (PSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void PSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void VSGetShader(
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        ref IntPtr ppVertexShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(69);
        var callback = (VSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetShaderFunc));
        callback(Self, ref ppVertexShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void VSGetShaderFunc(IntPtr self, ref IntPtr ppVertexShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void PSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(70);
        var callback = (PSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void PSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void IAGetInputLayout(
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        ref IntPtr ppInputLayout
    )
    {
        var fp = GetFunctionPointer(71);
        var callback = (IAGetInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetInputLayoutFunc));
        callback(Self, ref ppInputLayout);
    }
    delegate void IAGetInputLayoutFunc(IntPtr self, ref IntPtr ppInputLayout);
    public void IAGetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppVertexBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppVertexBuffers
        /// pStrides: (*(UINT))
        , ref UInt32 pStrides
        /// pOffsets: (*(UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(72);
        var callback = (IAGetVertexBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetVertexBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides, ref pOffsets);
    }
    delegate void IAGetVertexBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppVertexBuffers, ref UInt32 pStrides, ref UInt32 pOffsets);
    public void IAGetIndexBuffer(
        /// pIndexBuffer: (*(*(ID3D11Buffer)))
        ref IntPtr pIndexBuffer
        /// Format: (*(DXGI_FORMAT))
        , ref DXGI_FORMAT Format
        /// Offset: (*(UINT))
        , ref UInt32 Offset
    )
    {
        var fp = GetFunctionPointer(73);
        var callback = (IAGetIndexBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetIndexBufferFunc));
        callback(Self, ref pIndexBuffer, ref Format, ref Offset);
    }
    delegate void IAGetIndexBufferFunc(IntPtr self, ref IntPtr pIndexBuffer, ref DXGI_FORMAT Format, ref UInt32 Offset);
    public void GSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(74);
        var callback = (GSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void GSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void GSGetShader(
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        ref IntPtr ppGeometryShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(75);
        var callback = (GSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetShaderFunc));
        callback(Self, ref ppGeometryShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void GSGetShaderFunc(IntPtr self, ref IntPtr ppGeometryShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void IAGetPrimitiveTopology(
        /// pTopology: (*(D3D11_PRIMITIVE_TOPOLOGY))
        ref D3D11_PRIMITIVE_TOPOLOGY pTopology
    )
    {
        var fp = GetFunctionPointer(76);
        var callback = (IAGetPrimitiveTopologyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetPrimitiveTopologyFunc));
        callback(Self, ref pTopology);
    }
    delegate void IAGetPrimitiveTopologyFunc(IntPtr self, ref D3D11_PRIMITIVE_TOPOLOGY pTopology);
    public void VSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(77);
        var callback = (VSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void VSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void VSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(78);
        var callback = (VSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void VSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void GetPredication(
        /// ppPredicate: (*(*(ID3D11Predicate)))
        ref IntPtr ppPredicate
        /// pPredicateValue: (*(BOOL))
        , IntPtr pPredicateValue
    )
    {
        var fp = GetFunctionPointer(79);
        var callback = (GetPredicationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPredicationFunc));
        callback(Self, ref ppPredicate, pPredicateValue);
    }
    delegate void GetPredicationFunc(IntPtr self, ref IntPtr ppPredicate, IntPtr pPredicateValue);
    public void GSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(80);
        var callback = (GSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void GSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void GSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(81);
        var callback = (GSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void GSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void OMGetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
    )
    {
        var fp = GetFunctionPointer(82);
        var callback = (OMGetRenderTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetRenderTargetsFunc));
        callback(Self, NumViews, ref ppRenderTargetViews, ref ppDepthStencilView);
    }
    delegate void OMGetRenderTargetsFunc(IntPtr self, UInt32 NumViews, ref IntPtr ppRenderTargetViews, ref IntPtr ppDepthStencilView);
    public void OMGetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
        /// UAVStartSlot: (UINT)
        , UInt32 UAVStartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
    )
    {
        var fp = GetFunctionPointer(83);
        var callback = (OMGetRenderTargetsAndUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetRenderTargetsAndUnorderedAccessViewsFunc));
        callback(Self, NumRTVs, ref ppRenderTargetViews, ref ppDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }
    delegate void OMGetRenderTargetsAndUnorderedAccessViewsFunc(IntPtr self, UInt32 NumRTVs, ref IntPtr ppRenderTargetViews, ref IntPtr ppDepthStencilView, UInt32 UAVStartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews);
    public void OMGetBlendState(
        /// ppBlendState: (*(*(ID3D11BlendState)))
        ref IntPtr ppBlendState
        /// BlendFactor: (FLOAT)[4]
        , ref Vector4 BlendFactor
        /// pSampleMask: (*(UINT))
        , ref UInt32 pSampleMask
    )
    {
        var fp = GetFunctionPointer(84);
        var callback = (OMGetBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetBlendStateFunc));
        callback(Self, ref ppBlendState, ref BlendFactor, ref pSampleMask);
    }
    delegate void OMGetBlendStateFunc(IntPtr self, ref IntPtr ppBlendState, ref Vector4 BlendFactor, ref UInt32 pSampleMask);
    public void OMGetDepthStencilState(
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        ref IntPtr ppDepthStencilState
        /// pStencilRef: (*(UINT))
        , ref UInt32 pStencilRef
    )
    {
        var fp = GetFunctionPointer(85);
        var callback = (OMGetDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetDepthStencilStateFunc));
        callback(Self, ref ppDepthStencilState, ref pStencilRef);
    }
    delegate void OMGetDepthStencilStateFunc(IntPtr self, ref IntPtr ppDepthStencilState, ref UInt32 pStencilRef);
    public void SOGetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers
        /// ppSOTargets: (*(*(ID3D11Buffer)))
        , ref IntPtr ppSOTargets
    )
    {
        var fp = GetFunctionPointer(86);
        var callback = (SOGetTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SOGetTargetsFunc));
        callback(Self, NumBuffers, ref ppSOTargets);
    }
    delegate void SOGetTargetsFunc(IntPtr self, UInt32 NumBuffers, ref IntPtr ppSOTargets);
    public void RSGetState(
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        ref IntPtr ppRasterizerState
    )
    {
        var fp = GetFunctionPointer(87);
        var callback = (RSGetStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetStateFunc));
        callback(Self, ref ppRasterizerState);
    }
    delegate void RSGetStateFunc(IntPtr self, ref IntPtr ppRasterizerState);
    public void RSGetViewports(
        /// pNumViewports: (*(UINT))
        ref UInt32 pNumViewports
        /// pViewports: (*(D3D11_VIEWPORT))
        , ref D3D11_VIEWPORT pViewports
    )
    {
        var fp = GetFunctionPointer(88);
        var callback = (RSGetViewportsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetViewportsFunc));
        callback(Self, ref pNumViewports, ref pViewports);
    }
    delegate void RSGetViewportsFunc(IntPtr self, ref UInt32 pNumViewports, ref D3D11_VIEWPORT pViewports);
    public void RSGetScissorRects(
        /// pNumRects: (*(UINT))
        ref UInt32 pNumRects
        /// pRects: (*(D3D11_RECT))
        , ref D3D11_RECT pRects
    )
    {
        var fp = GetFunctionPointer(89);
        var callback = (RSGetScissorRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetScissorRectsFunc));
        callback(Self, ref pNumRects, ref pRects);
    }
    delegate void RSGetScissorRectsFunc(IntPtr self, ref UInt32 pNumRects, ref D3D11_RECT pRects);
    public void HSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(90);
        var callback = (HSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void HSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void HSGetShader(
        /// ppHullShader: (*(*(ID3D11HullShader)))
        ref IntPtr ppHullShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(91);
        var callback = (HSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetShaderFunc));
        callback(Self, ref ppHullShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void HSGetShaderFunc(IntPtr self, ref IntPtr ppHullShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void HSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(92);
        var callback = (HSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void HSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void HSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(93);
        var callback = (HSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void HSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void DSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(94);
        var callback = (DSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void DSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void DSGetShader(
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        ref IntPtr ppDomainShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(95);
        var callback = (DSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetShaderFunc));
        callback(Self, ref ppDomainShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void DSGetShaderFunc(IntPtr self, ref IntPtr ppDomainShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void DSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(96);
        var callback = (DSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void DSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void DSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(97);
        var callback = (DSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void DSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void CSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(98);
        var callback = (CSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void CSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void CSGetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
    )
    {
        var fp = GetFunctionPointer(99);
        var callback = (CSGetUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetUnorderedAccessViewsFunc));
        callback(Self, StartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }
    delegate void CSGetUnorderedAccessViewsFunc(IntPtr self, UInt32 StartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews);
    public void CSGetShader(
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        ref IntPtr ppComputeShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(100);
        var callback = (CSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetShaderFunc));
        callback(Self, ref ppComputeShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void CSGetShaderFunc(IntPtr self, ref IntPtr ppComputeShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void CSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(101);
        var callback = (CSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void CSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void CSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(102);
        var callback = (CSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void CSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void ClearState(
    )
    {
        var fp = GetFunctionPointer(103);
        var callback = (ClearStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearStateFunc));
        callback(Self);
    }
    delegate void ClearStateFunc(IntPtr self);
    public void Flush(
    )
    {
        var fp = GetFunctionPointer(104);
        var callback = (FlushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FlushFunc));
        callback(Self);
    }
    delegate void FlushFunc(IntPtr self);
    public D3D11_DEVICE_CONTEXT_TYPE GetType(
    )
    {
        var fp = GetFunctionPointer(105);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        return callback(Self);
    }
    delegate D3D11_DEVICE_CONTEXT_TYPE GetTypeFunc(IntPtr self);
    public UInt32 GetContextFlags(
    )
    {
        var fp = GetFunctionPointer(106);
        var callback = (GetContextFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContextFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetContextFlagsFunc(IntPtr self);
    public Int32 FinishCommandList(
        /// RestoreDeferredContextState: (BOOL)
        Int32 RestoreDeferredContextState
        /// ppCommandList: (*(*(ID3D11CommandList)))
        , ref IntPtr ppCommandList
    )
    {
        var fp = GetFunctionPointer(107);
        var callback = (FinishCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FinishCommandListFunc));
        return callback(Self, RestoreDeferredContextState, ref ppCommandList);
    }
    delegate Int32 FinishCommandListFunc(IntPtr self, Int32 RestoreDeferredContextState, ref IntPtr ppCommandList);
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

public class ID3D11VideoDecoder: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public Int32 GetCreationParameters(
        /// pVideoDesc: (*(D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetCreationParametersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationParametersFunc));
        return callback(Self, ref pVideoDesc, ref pConfig);
    }
    delegate Int32 GetCreationParametersFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pVideoDesc, ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    public Int32 GetDriverHandle(
        /// pDriverHandle: (*(HANDLE))
        ref IntPtr pDriverHandle
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetDriverHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDriverHandleFunc));
        return callback(Self, ref pDriverHandle);
    }
    delegate Int32 GetDriverHandleFunc(IntPtr self, ref IntPtr pDriverHandle);
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

public class ID3D11VideoProcessorEnumerator: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("31627037-53ab-4200-9061-05faa9ab45f9");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 6;
    public Int32 GetVideoProcessorContentDesc(
        /// pContentDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetVideoProcessorContentDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorContentDescFunc));
        return callback(Self, ref pContentDesc);
    }
    delegate Int32 GetVideoProcessorContentDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
    public Int32 CheckVideoProcessorFormat(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// pFlags: (*(UINT))
        , ref UInt32 pFlags
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (CheckVideoProcessorFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckVideoProcessorFormatFunc));
        return callback(Self, Format, ref pFlags);
    }
    delegate Int32 CheckVideoProcessorFormatFunc(IntPtr self, DXGI_FORMAT Format, ref UInt32 pFlags);
    public Int32 GetVideoProcessorCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_CAPS))
        ref D3D11_VIDEO_PROCESSOR_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetVideoProcessorCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorCapsFunc));
        return callback(Self, ref pCaps);
    }
    delegate Int32 GetVideoProcessorCapsFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CAPS pCaps);
    public Int32 GetVideoProcessorRateConversionCaps(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        , ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetVideoProcessorRateConversionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorRateConversionCapsFunc));
        return callback(Self, TypeIndex, ref pCaps);
    }
    delegate Int32 GetVideoProcessorRateConversionCapsFunc(IntPtr self, UInt32 TypeIndex, ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
    public Int32 GetVideoProcessorCustomRate(
        /// TypeIndex: (UINT)
        UInt32 TypeIndex
        /// CustomRateIndex: (UINT)
        , UInt32 CustomRateIndex
        /// pRate: (*(D3D11_VIDEO_PROCESSOR_CUSTOM_RATE))
        , ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (GetVideoProcessorCustomRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorCustomRateFunc));
        return callback(Self, TypeIndex, CustomRateIndex, ref pRate);
    }
    delegate Int32 GetVideoProcessorCustomRateFunc(IntPtr self, UInt32 TypeIndex, UInt32 CustomRateIndex, ref D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
    public Int32 GetVideoProcessorFilterRange(
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// pRange: (*(D3D11_VIDEO_PROCESSOR_FILTER_RANGE))
        , ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (GetVideoProcessorFilterRangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoProcessorFilterRangeFunc));
        return callback(Self, Filter, ref pRange);
    }
    delegate Int32 GetVideoProcessorFilterRangeFunc(IntPtr self, D3D11_VIDEO_PROCESSOR_FILTER Filter, ref D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
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
    public IntPtr pInputSurface;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfaces;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppPastSurfacesRight;

    /// (*(ID3D11VideoProcessorInputView))
    public IntPtr pInputSurfaceRight;

    /// (*(*(ID3D11VideoProcessorInputView)))
    public IntPtr ppFutureSurfacesRight;

}

public class ID3D11VideoProcessor: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 2;
    public void GetContentDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetContentDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContentDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetContentDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc);
    public void GetRateConversionCaps(
        /// pCaps: (*(D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS))
        ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetRateConversionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRateConversionCapsFunc));
        callback(Self, ref pCaps);
    }
    delegate void GetRateConversionCapsFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
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

public class ID3D11AuthenticatedChannel: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3015a308-dcbd-47aa-a747-192486d14d4a");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 3;
    public Int32 GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetCertificateSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateSizeFunc));
        return callback(Self, ref pCertificateSize);
    }
    delegate Int32 GetCertificateSizeFunc(IntPtr self, ref UInt32 pCertificateSize);
    public Int32 GetCertificate(
        /// CertificateSize: (UINT)
        UInt32 CertificateSize
        /// pCertificate: (*(BYTE))
        , ref Byte pCertificate
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
        return callback(Self, CertificateSize, ref pCertificate);
    }
    delegate Int32 GetCertificateFunc(IntPtr self, UInt32 CertificateSize, ref Byte pCertificate);
    public void GetChannelHandle(
        /// pChannelHandle: (*(HANDLE))
        ref IntPtr pChannelHandle
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetChannelHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetChannelHandleFunc));
        callback(Self, ref pChannelHandle);
    }
    delegate void GetChannelHandleFunc(IntPtr self, ref IntPtr pChannelHandle);
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

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
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

public class ID3D11CryptoSession: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 5;
    public void GetCryptoType(
        /// pCryptoType: (*(GUID))
        ref Guid pCryptoType
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetCryptoTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoTypeFunc));
        callback(Self, ref pCryptoType);
    }
    delegate void GetCryptoTypeFunc(IntPtr self, ref Guid pCryptoType);
    public void GetDecoderProfile(
        /// pDecoderProfile: (*(GUID))
        ref Guid pDecoderProfile
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (GetDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderProfileFunc));
        callback(Self, ref pDecoderProfile);
    }
    delegate void GetDecoderProfileFunc(IntPtr self, ref Guid pDecoderProfile);
    public Int32 GetCertificateSize(
        /// pCertificateSize: (*(UINT))
        ref UInt32 pCertificateSize
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (GetCertificateSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateSizeFunc));
        return callback(Self, ref pCertificateSize);
    }
    delegate Int32 GetCertificateSizeFunc(IntPtr self, ref UInt32 pCertificateSize);
    public Int32 GetCertificate(
        /// CertificateSize: (UINT)
        UInt32 CertificateSize
        /// pCertificate: (*(BYTE))
        , ref Byte pCertificate
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
        return callback(Self, CertificateSize, ref pCertificate);
    }
    delegate Int32 GetCertificateFunc(IntPtr self, UInt32 CertificateSize, ref Byte pCertificate);
    public void GetCryptoSessionHandle(
        /// pCryptoSessionHandle: (*(HANDLE))
        ref IntPtr pCryptoSessionHandle
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (GetCryptoSessionHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoSessionHandleFunc));
        callback(Self, ref pCryptoSessionHandle);
    }
    delegate void GetCryptoSessionHandleFunc(IntPtr self, ref IntPtr pCryptoSessionHandle);
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

public class ID3D11VideoDecoderOutputView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("c2931aea-2a85-4f20-860f-fba1fd256e18");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
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

public class ID3D11VideoProcessorInputView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("11ec5a5f-51dc-4945-ab34-6e8c21300ea5");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc);
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

public class ID3D11VideoProcessorOutputView: ID3D11View {

    static /*readonly*/ Guid s_uuid = new Guid("a048285e-25a9-4527-bd93-d68b68c44254");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 1;
    public void GetDesc(
        /// pDesc: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
        callback(Self, ref pDesc);
    }
    delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc);
}

public class ID3D11VideoContext: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 58;
    public Int32 GetDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        , D3D11_VIDEO_DECODER_BUFFER_TYPE Type
        /// pBufferSize: (*(UINT))
        , ref UInt32 pBufferSize
        /// ppBuffer: (*(*(void)))
        , ref IntPtr ppBuffer
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (GetDecoderBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderBufferFunc));
        return callback(Self, pDecoder, Type, ref pBufferSize, ref ppBuffer);
    }
    delegate Int32 GetDecoderBufferFunc(IntPtr self, IntPtr pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, ref UInt32 pBufferSize, ref IntPtr ppBuffer);
    public Int32 ReleaseDecoderBuffer(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// Type: (D3D11_VIDEO_DECODER_BUFFER_TYPE)
        , D3D11_VIDEO_DECODER_BUFFER_TYPE Type
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (ReleaseDecoderBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDecoderBufferFunc));
        return callback(Self, pDecoder, Type);
    }
    delegate Int32 ReleaseDecoderBufferFunc(IntPtr self, IntPtr pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
    public Int32 DecoderBeginFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// pView: (*(ID3D11VideoDecoderOutputView))
        , IntPtr pView
        /// ContentKeySize: (UINT)
        , UInt32 ContentKeySize
        /// pContentKey: (*(const void))
        , IntPtr pContentKey
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (DecoderBeginFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderBeginFrameFunc));
        return callback(Self, pDecoder, pView, ContentKeySize, pContentKey);
    }
    delegate Int32 DecoderBeginFrameFunc(IntPtr self, IntPtr pDecoder, IntPtr pView, UInt32 ContentKeySize, IntPtr pContentKey);
    public Int32 DecoderEndFrame(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (DecoderEndFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderEndFrameFunc));
        return callback(Self, pDecoder);
    }
    delegate Int32 DecoderEndFrameFunc(IntPtr self, IntPtr pDecoder);
    public Int32 SubmitDecoderBuffers(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// pBufferDesc: (*(const D3D11_VIDEO_DECODER_BUFFER_DESC))
        , ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (SubmitDecoderBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SubmitDecoderBuffersFunc));
        return callback(Self, pDecoder, NumBuffers, ref pBufferDesc);
    }
    delegate Int32 SubmitDecoderBuffersFunc(IntPtr self, IntPtr pDecoder, UInt32 NumBuffers, ref D3D11_VIDEO_DECODER_BUFFER_DESC pBufferDesc);
    public APP_DEPRECATED_HRESULT DecoderExtension(
        /// pDecoder: (*(ID3D11VideoDecoder))
        IntPtr pDecoder
        /// pExtensionData: (*(const D3D11_VIDEO_DECODER_EXTENSION))
        , ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (DecoderExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecoderExtensionFunc));
        return callback(Self, pDecoder, ref pExtensionData);
    }
    delegate APP_DEPRECATED_HRESULT DecoderExtensionFunc(IntPtr self, IntPtr pDecoder, ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
    public void VideoProcessorSetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (VideoProcessorSetOutputTargetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputTargetRectFunc));
        callback(Self, pVideoProcessor, Enable, ref pRect);
    }
    delegate void VideoProcessorSetOutputTargetRectFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// YCbCr: (BOOL)
        , Int32 YCbCr
        /// pColor: (*(const D3D11_VIDEO_COLOR))
        , ref D3D11_VIDEO_COLOR pColor
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (VideoProcessorSetOutputBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputBackgroundColorFunc));
        callback(Self, pVideoProcessor, YCbCr, ref pColor);
    }
    delegate void VideoProcessorSetOutputBackgroundColorFunc(IntPtr self, IntPtr pVideoProcessor, Int32 YCbCr, ref D3D11_VIDEO_COLOR pColor);
    public void VideoProcessorSetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (VideoProcessorSetOutputColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputColorSpaceFunc));
        callback(Self, pVideoProcessor, ref pColorSpace);
    }
    delegate void VideoProcessorSetOutputColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorSetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// AlphaFillMode: (D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE)
        , D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (VideoProcessorSetOutputAlphaFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputAlphaFillModeFunc));
        callback(Self, pVideoProcessor, AlphaFillMode, StreamIndex);
    }
    delegate void VideoProcessorSetOutputAlphaFillModeFunc(IntPtr self, IntPtr pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, UInt32 StreamIndex);
    public void VideoProcessorSetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
        /// Size: (SIZE)
        , SIZE Size
    )
    {
        var fp = GetFunctionPointer(10);
        var callback = (VideoProcessorSetOutputConstrictionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputConstrictionFunc));
        callback(Self, pVideoProcessor, Enable, Size);
    }
    delegate void VideoProcessorSetOutputConstrictionFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable, SIZE Size);
    public void VideoProcessorSetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enable: (BOOL)
        , Int32 Enable
    )
    {
        var fp = GetFunctionPointer(11);
        var callback = (VideoProcessorSetOutputStereoModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputStereoModeFunc));
        callback(Self, pVideoProcessor, Enable);
    }
    delegate void VideoProcessorSetOutputStereoModeFunc(IntPtr self, IntPtr pVideoProcessor, Int32 Enable);
    public APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(12);
        var callback = (VideoProcessorSetOutputExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetOutputExtensionFunc));
        return callback(Self, pVideoProcessor, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorSetOutputExtensionFunc(IntPtr self, IntPtr pVideoProcessor, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorGetOutputTargetRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// Enabled: (*(BOOL))
        , IntPtr Enabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(13);
        var callback = (VideoProcessorGetOutputTargetRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputTargetRectFunc));
        callback(Self, pVideoProcessor, Enabled, ref pRect);
    }
    delegate void VideoProcessorGetOutputTargetRectFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr Enabled, ref RECT pRect);
    public void VideoProcessorGetOutputBackgroundColor(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pYCbCr: (*(BOOL))
        , IntPtr pYCbCr
        /// pColor: (*(D3D11_VIDEO_COLOR))
        , ref D3D11_VIDEO_COLOR pColor
    )
    {
        var fp = GetFunctionPointer(14);
        var callback = (VideoProcessorGetOutputBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputBackgroundColorFunc));
        callback(Self, pVideoProcessor, pYCbCr, ref pColor);
    }
    delegate void VideoProcessorGetOutputBackgroundColorFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pYCbCr, ref D3D11_VIDEO_COLOR pColor);
    public void VideoProcessorGetOutputColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(15);
        var callback = (VideoProcessorGetOutputColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputColorSpaceFunc));
        callback(Self, pVideoProcessor, ref pColorSpace);
    }
    delegate void VideoProcessorGetOutputColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorGetOutputAlphaFillMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pAlphaFillMode: (*(D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE))
        , ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode
        /// pStreamIndex: (*(UINT))
        , ref UInt32 pStreamIndex
    )
    {
        var fp = GetFunctionPointer(16);
        var callback = (VideoProcessorGetOutputAlphaFillModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputAlphaFillModeFunc));
        callback(Self, pVideoProcessor, ref pAlphaFillMode, ref pStreamIndex);
    }
    delegate void VideoProcessorGetOutputAlphaFillModeFunc(IntPtr self, IntPtr pVideoProcessor, ref D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, ref UInt32 pStreamIndex);
    public void VideoProcessorGetOutputConstriction(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pSize: (*(SIZE))
        , ref SIZE pSize
    )
    {
        var fp = GetFunctionPointer(17);
        var callback = (VideoProcessorGetOutputConstrictionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputConstrictionFunc));
        callback(Self, pVideoProcessor, pEnabled, ref pSize);
    }
    delegate void VideoProcessorGetOutputConstrictionFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pEnabled, ref SIZE pSize);
    public void VideoProcessorGetOutputStereoMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
    )
    {
        var fp = GetFunctionPointer(18);
        var callback = (VideoProcessorGetOutputStereoModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputStereoModeFunc));
        callback(Self, pVideoProcessor, pEnabled);
    }
    delegate void VideoProcessorGetOutputStereoModeFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pEnabled);
    public APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(19);
        var callback = (VideoProcessorGetOutputExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetOutputExtensionFunc));
        return callback(Self, pVideoProcessor, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorGetOutputExtensionFunc(IntPtr self, IntPtr pVideoProcessor, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorSetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// FrameFormat: (D3D11_VIDEO_FRAME_FORMAT)
        , D3D11_VIDEO_FRAME_FORMAT FrameFormat
    )
    {
        var fp = GetFunctionPointer(20);
        var callback = (VideoProcessorSetStreamFrameFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamFrameFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, FrameFormat);
    }
    delegate void VideoProcessorSetStreamFrameFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat);
    public void VideoProcessorSetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pColorSpace: (*(const D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(21);
        var callback = (VideoProcessorSetStreamColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamColorSpaceFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pColorSpace);
    }
    delegate void VideoProcessorSetStreamColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorSetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// OutputRate: (D3D11_VIDEO_PROCESSOR_OUTPUT_RATE)
        , D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate
        /// RepeatFrame: (BOOL)
        , Int32 RepeatFrame
        /// pCustomRate: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pCustomRate
    )
    {
        var fp = GetFunctionPointer(22);
        var callback = (VideoProcessorSetStreamOutputRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamOutputRateFunc));
        callback(Self, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, ref pCustomRate);
    }
    delegate void VideoProcessorSetStreamOutputRateFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, Int32 RepeatFrame, ref DXGI_RATIONAL pCustomRate);
    public void VideoProcessorSetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(23);
        var callback = (VideoProcessorSetStreamSourceRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamSourceRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pRect);
    }
    delegate void VideoProcessorSetStreamSourceRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pRect: (*(const RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(24);
        var callback = (VideoProcessorSetStreamDestRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamDestRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pRect);
    }
    delegate void VideoProcessorSetStreamDestRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref RECT pRect);
    public void VideoProcessorSetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Alpha: (FLOAT)
        , Single Alpha
    )
    {
        var fp = GetFunctionPointer(25);
        var callback = (VideoProcessorSetStreamAlphaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamAlphaFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Alpha);
    }
    delegate void VideoProcessorSetStreamAlphaFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, Single Alpha);
    public void VideoProcessorSetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Count: (UINT)
        , UInt32 Count
        /// pEntries: (*(const UINT))
        , ref UInt32 pEntries
    )
    {
        var fp = GetFunctionPointer(26);
        var callback = (VideoProcessorSetStreamPaletteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamPaletteFunc));
        callback(Self, pVideoProcessor, StreamIndex, Count, ref pEntries);
    }
    delegate void VideoProcessorSetStreamPaletteFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, UInt32 Count, ref UInt32 pEntries);
    public void VideoProcessorSetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// pSourceAspectRatio: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pSourceAspectRatio
        /// pDestinationAspectRatio: (*(const DXGI_RATIONAL))
        , ref DXGI_RATIONAL pDestinationAspectRatio
    )
    {
        var fp = GetFunctionPointer(27);
        var callback = (VideoProcessorSetStreamPixelAspectRatioFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamPixelAspectRatioFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, ref pSourceAspectRatio, ref pDestinationAspectRatio);
    }
    delegate void VideoProcessorSetStreamPixelAspectRatioFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, ref DXGI_RATIONAL pSourceAspectRatio, ref DXGI_RATIONAL pDestinationAspectRatio);
    public void VideoProcessorSetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Lower: (FLOAT)
        , Single Lower
        /// Upper: (FLOAT)
        , Single Upper
    )
    {
        var fp = GetFunctionPointer(28);
        var callback = (VideoProcessorSetStreamLumaKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamLumaKeyFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }
    delegate void VideoProcessorSetStreamLumaKeyFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, Single Lower, Single Upper);
    public void VideoProcessorSetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Format: (D3D11_VIDEO_PROCESSOR_STEREO_FORMAT)
        , D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format
        /// LeftViewFrame0: (BOOL)
        , Int32 LeftViewFrame0
        /// BaseViewFrame0: (BOOL)
        , Int32 BaseViewFrame0
        /// FlipMode: (D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE)
        , D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode
        /// MonoOffset: (int)
        , int MonoOffset
    )
    {
        var fp = GetFunctionPointer(29);
        var callback = (VideoProcessorSetStreamStereoFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamStereoFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }
    delegate void VideoProcessorSetStreamStereoFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, Int32 LeftViewFrame0, Int32 BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset);
    public void VideoProcessorSetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
    )
    {
        var fp = GetFunctionPointer(30);
        var callback = (VideoProcessorSetStreamAutoProcessingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamAutoProcessingModeFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable);
    }
    delegate void VideoProcessorSetStreamAutoProcessingModeFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable);
    public void VideoProcessorSetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        , D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// Enable: (BOOL)
        , Int32 Enable
        /// Level: (int)
        , int Level
    )
    {
        var fp = GetFunctionPointer(31);
        var callback = (VideoProcessorSetStreamFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamFilterFunc));
        callback(Self, pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }
    delegate void VideoProcessorSetStreamFilterFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, Int32 Enable, int Level);
    public APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(32);
        var callback = (VideoProcessorSetStreamExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamExtensionFunc));
        return callback(Self, pVideoProcessor, StreamIndex, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorSetStreamExtensionFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public void VideoProcessorGetStreamFrameFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pFrameFormat: (*(D3D11_VIDEO_FRAME_FORMAT))
        , ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat
    )
    {
        var fp = GetFunctionPointer(33);
        var callback = (VideoProcessorGetStreamFrameFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamFrameFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pFrameFormat);
    }
    delegate void VideoProcessorGetStreamFrameFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
    public void VideoProcessorGetStreamColorSpace(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pColorSpace: (*(D3D11_VIDEO_PROCESSOR_COLOR_SPACE))
        , ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace
    )
    {
        var fp = GetFunctionPointer(34);
        var callback = (VideoProcessorGetStreamColorSpaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamColorSpaceFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pColorSpace);
    }
    delegate void VideoProcessorGetStreamColorSpaceFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
    public void VideoProcessorGetStreamOutputRate(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pOutputRate: (*(D3D11_VIDEO_PROCESSOR_OUTPUT_RATE))
        , ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate
        /// pRepeatFrame: (*(BOOL))
        , IntPtr pRepeatFrame
        /// pCustomRate: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pCustomRate
    )
    {
        var fp = GetFunctionPointer(35);
        var callback = (VideoProcessorGetStreamOutputRateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamOutputRateFunc));
        callback(Self, pVideoProcessor, StreamIndex, ref pOutputRate, pRepeatFrame, ref pCustomRate);
    }
    delegate void VideoProcessorGetStreamOutputRateFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, IntPtr pRepeatFrame, ref DXGI_RATIONAL pCustomRate);
    public void VideoProcessorGetStreamSourceRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(36);
        var callback = (VideoProcessorGetStreamSourceRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamSourceRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pRect);
    }
    delegate void VideoProcessorGetStreamSourceRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref RECT pRect);
    public void VideoProcessorGetStreamDestRect(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pRect: (*(RECT))
        , ref RECT pRect
    )
    {
        var fp = GetFunctionPointer(37);
        var callback = (VideoProcessorGetStreamDestRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamDestRectFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pRect);
    }
    delegate void VideoProcessorGetStreamDestRectFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref RECT pRect);
    public void VideoProcessorGetStreamAlpha(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pAlpha: (*(FLOAT))
        , ref Single pAlpha
    )
    {
        var fp = GetFunctionPointer(38);
        var callback = (VideoProcessorGetStreamAlphaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamAlphaFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pAlpha);
    }
    delegate void VideoProcessorGetStreamAlphaFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref Single pAlpha);
    public void VideoProcessorGetStreamPalette(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Count: (UINT)
        , UInt32 Count
        /// pEntries: (*(UINT))
        , ref UInt32 pEntries
    )
    {
        var fp = GetFunctionPointer(39);
        var callback = (VideoProcessorGetStreamPaletteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamPaletteFunc));
        callback(Self, pVideoProcessor, StreamIndex, Count, ref pEntries);
    }
    delegate void VideoProcessorGetStreamPaletteFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, UInt32 Count, ref UInt32 pEntries);
    public void VideoProcessorGetStreamPixelAspectRatio(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pSourceAspectRatio: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pSourceAspectRatio
        /// pDestinationAspectRatio: (*(DXGI_RATIONAL))
        , ref DXGI_RATIONAL pDestinationAspectRatio
    )
    {
        var fp = GetFunctionPointer(40);
        var callback = (VideoProcessorGetStreamPixelAspectRatioFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamPixelAspectRatioFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pSourceAspectRatio, ref pDestinationAspectRatio);
    }
    delegate void VideoProcessorGetStreamPixelAspectRatioFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref DXGI_RATIONAL pSourceAspectRatio, ref DXGI_RATIONAL pDestinationAspectRatio);
    public void VideoProcessorGetStreamLumaKey(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pLower: (*(FLOAT))
        , ref Single pLower
        /// pUpper: (*(FLOAT))
        , ref Single pUpper
    )
    {
        var fp = GetFunctionPointer(41);
        var callback = (VideoProcessorGetStreamLumaKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamLumaKeyFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled, ref pLower, ref pUpper);
    }
    delegate void VideoProcessorGetStreamLumaKeyFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled, ref Single pLower, ref Single pUpper);
    public void VideoProcessorGetStreamStereoFormat(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnable: (*(BOOL))
        , IntPtr pEnable
        /// pFormat: (*(D3D11_VIDEO_PROCESSOR_STEREO_FORMAT))
        , ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat
        /// pLeftViewFrame0: (*(BOOL))
        , IntPtr pLeftViewFrame0
        /// pBaseViewFrame0: (*(BOOL))
        , IntPtr pBaseViewFrame0
        /// pFlipMode: (*(D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE))
        , ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode
        /// MonoOffset: (*(int))
        , ref int MonoOffset
    )
    {
        var fp = GetFunctionPointer(42);
        var callback = (VideoProcessorGetStreamStereoFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamStereoFormatFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
    }
    delegate void VideoProcessorGetStreamStereoFormatFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnable, ref D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, IntPtr pLeftViewFrame0, IntPtr pBaseViewFrame0, ref D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, ref int MonoOffset);
    public void VideoProcessorGetStreamAutoProcessingMode(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
    )
    {
        var fp = GetFunctionPointer(43);
        var callback = (VideoProcessorGetStreamAutoProcessingModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamAutoProcessingModeFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnabled);
    }
    delegate void VideoProcessorGetStreamAutoProcessingModeFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnabled);
    public void VideoProcessorGetStreamFilter(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Filter: (D3D11_VIDEO_PROCESSOR_FILTER)
        , D3D11_VIDEO_PROCESSOR_FILTER Filter
        /// pEnabled: (*(BOOL))
        , IntPtr pEnabled
        /// pLevel: (*(int))
        , ref int pLevel
    )
    {
        var fp = GetFunctionPointer(44);
        var callback = (VideoProcessorGetStreamFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamFilterFunc));
        callback(Self, pVideoProcessor, StreamIndex, Filter, pEnabled, ref pLevel);
    }
    delegate void VideoProcessorGetStreamFilterFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, IntPtr pEnabled, ref int pLevel);
    public APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtension(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pExtensionGuid: (*(const GUID))
        , ref Guid pExtensionGuid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(45);
        var callback = (VideoProcessorGetStreamExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamExtensionFunc));
        return callback(Self, pVideoProcessor, StreamIndex, ref pExtensionGuid, DataSize, pData);
    }
    delegate APP_DEPRECATED_HRESULT VideoProcessorGetStreamExtensionFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, ref Guid pExtensionGuid, UInt32 DataSize, IntPtr pData);
    public Int32 VideoProcessorBlt(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// pView: (*(ID3D11VideoProcessorOutputView))
        , IntPtr pView
        /// OutputFrame: (UINT)
        , UInt32 OutputFrame
        /// StreamCount: (UINT)
        , UInt32 StreamCount
        /// pStreams: (*(const D3D11_VIDEO_PROCESSOR_STREAM))
        , ref D3D11_VIDEO_PROCESSOR_STREAM pStreams
    )
    {
        var fp = GetFunctionPointer(46);
        var callback = (VideoProcessorBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorBltFunc));
        return callback(Self, pVideoProcessor, pView, OutputFrame, StreamCount, ref pStreams);
    }
    delegate Int32 VideoProcessorBltFunc(IntPtr self, IntPtr pVideoProcessor, IntPtr pView, UInt32 OutputFrame, UInt32 StreamCount, ref D3D11_VIDEO_PROCESSOR_STREAM pStreams);
    public Int32 NegotiateCryptoSessionKeyExchange(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(47);
        var callback = (NegotiateCryptoSessionKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NegotiateCryptoSessionKeyExchangeFunc));
        return callback(Self, pCryptoSession, DataSize, pData);
    }
    delegate Int32 NegotiateCryptoSessionKeyExchangeFunc(IntPtr self, IntPtr pCryptoSession, UInt32 DataSize, IntPtr pData);
    public void EncryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// pSrcSurface: (*(ID3D11Texture2D))
        , IntPtr pSrcSurface
        /// pDstSurface: (*(ID3D11Texture2D))
        , IntPtr pDstSurface
        /// IVSize: (UINT)
        , UInt32 IVSize
        /// pIV: (*(void))
        , IntPtr pIV
    )
    {
        var fp = GetFunctionPointer(48);
        var callback = (EncryptionBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EncryptionBltFunc));
        callback(Self, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }
    delegate void EncryptionBltFunc(IntPtr self, IntPtr pCryptoSession, IntPtr pSrcSurface, IntPtr pDstSurface, UInt32 IVSize, IntPtr pIV);
    public void DecryptionBlt(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// pSrcSurface: (*(ID3D11Texture2D))
        , IntPtr pSrcSurface
        /// pDstSurface: (*(ID3D11Texture2D))
        , IntPtr pDstSurface
        /// pEncryptedBlockInfo: (*(D3D11_ENCRYPTED_BLOCK_INFO))
        , ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo
        /// ContentKeySize: (UINT)
        , UInt32 ContentKeySize
        /// pContentKey: (*(const void))
        , IntPtr pContentKey
        /// IVSize: (UINT)
        , UInt32 IVSize
        /// pIV: (*(void))
        , IntPtr pIV
    )
    {
        var fp = GetFunctionPointer(49);
        var callback = (DecryptionBltFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DecryptionBltFunc));
        callback(Self, pCryptoSession, pSrcSurface, pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }
    delegate void DecryptionBltFunc(IntPtr self, IntPtr pCryptoSession, IntPtr pSrcSurface, IntPtr pDstSurface, ref D3D11_ENCRYPTED_BLOCK_INFO pEncryptedBlockInfo, UInt32 ContentKeySize, IntPtr pContentKey, UInt32 IVSize, IntPtr pIV);
    public void StartSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// RandomNumberSize: (UINT)
        , UInt32 RandomNumberSize
        /// pRandomNumber: (*(void))
        , IntPtr pRandomNumber
    )
    {
        var fp = GetFunctionPointer(50);
        var callback = (StartSessionKeyRefreshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StartSessionKeyRefreshFunc));
        callback(Self, pCryptoSession, RandomNumberSize, pRandomNumber);
    }
    delegate void StartSessionKeyRefreshFunc(IntPtr self, IntPtr pCryptoSession, UInt32 RandomNumberSize, IntPtr pRandomNumber);
    public void FinishSessionKeyRefresh(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
    )
    {
        var fp = GetFunctionPointer(51);
        var callback = (FinishSessionKeyRefreshFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FinishSessionKeyRefreshFunc));
        callback(Self, pCryptoSession);
    }
    delegate void FinishSessionKeyRefreshFunc(IntPtr self, IntPtr pCryptoSession);
    public Int32 GetEncryptionBltKey(
        /// pCryptoSession: (*(ID3D11CryptoSession))
        IntPtr pCryptoSession
        /// KeySize: (UINT)
        , UInt32 KeySize
        /// pReadbackKey: (*(void))
        , IntPtr pReadbackKey
    )
    {
        var fp = GetFunctionPointer(52);
        var callback = (GetEncryptionBltKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEncryptionBltKeyFunc));
        return callback(Self, pCryptoSession, KeySize, pReadbackKey);
    }
    delegate Int32 GetEncryptionBltKeyFunc(IntPtr self, IntPtr pCryptoSession, UInt32 KeySize, IntPtr pReadbackKey);
    public Int32 NegotiateAuthenticatedChannelKeyExchange(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(53);
        var callback = (NegotiateAuthenticatedChannelKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NegotiateAuthenticatedChannelKeyExchangeFunc));
        return callback(Self, pChannel, DataSize, pData);
    }
    delegate Int32 NegotiateAuthenticatedChannelKeyExchangeFunc(IntPtr self, IntPtr pChannel, UInt32 DataSize, IntPtr pData);
    public Int32 QueryAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// InputSize: (UINT)
        , UInt32 InputSize
        /// pInput: (*(const void))
        , IntPtr pInput
        /// OutputSize: (UINT)
        , UInt32 OutputSize
        /// pOutput: (*(void))
        , IntPtr pOutput
    )
    {
        var fp = GetFunctionPointer(54);
        var callback = (QueryAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryAuthenticatedChannelFunc));
        return callback(Self, pChannel, InputSize, pInput, OutputSize, pOutput);
    }
    delegate Int32 QueryAuthenticatedChannelFunc(IntPtr self, IntPtr pChannel, UInt32 InputSize, IntPtr pInput, UInt32 OutputSize, IntPtr pOutput);
    public Int32 ConfigureAuthenticatedChannel(
        /// pChannel: (*(ID3D11AuthenticatedChannel))
        IntPtr pChannel
        /// InputSize: (UINT)
        , UInt32 InputSize
        /// pInput: (*(const void))
        , IntPtr pInput
        /// pOutput: (*(D3D11_AUTHENTICATED_CONFIGURE_OUTPUT))
        , ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput
    )
    {
        var fp = GetFunctionPointer(55);
        var callback = (ConfigureAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConfigureAuthenticatedChannelFunc));
        return callback(Self, pChannel, InputSize, pInput, ref pOutput);
    }
    delegate Int32 ConfigureAuthenticatedChannelFunc(IntPtr self, IntPtr pChannel, UInt32 InputSize, IntPtr pInput, ref D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
    public void VideoProcessorSetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// Enable: (BOOL)
        , Int32 Enable
        /// Rotation: (D3D11_VIDEO_PROCESSOR_ROTATION)
        , D3D11_VIDEO_PROCESSOR_ROTATION Rotation
    )
    {
        var fp = GetFunctionPointer(56);
        var callback = (VideoProcessorSetStreamRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorSetStreamRotationFunc));
        callback(Self, pVideoProcessor, StreamIndex, Enable, Rotation);
    }
    delegate void VideoProcessorSetStreamRotationFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, Int32 Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
    public void VideoProcessorGetStreamRotation(
        /// pVideoProcessor: (*(ID3D11VideoProcessor))
        IntPtr pVideoProcessor
        /// StreamIndex: (UINT)
        , UInt32 StreamIndex
        /// pEnable: (*(BOOL))
        , IntPtr pEnable
        /// pRotation: (*(D3D11_VIDEO_PROCESSOR_ROTATION))
        , ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation
    )
    {
        var fp = GetFunctionPointer(57);
        var callback = (VideoProcessorGetStreamRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VideoProcessorGetStreamRotationFunc));
        callback(Self, pVideoProcessor, StreamIndex, pEnable, ref pRotation);
    }
    delegate void VideoProcessorGetStreamRotationFunc(IntPtr self, IntPtr pVideoProcessor, UInt32 StreamIndex, IntPtr pEnable, ref D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
}

public class ID3D11VideoDevice : IUnknownImpl{

    static /*readonly*/ Guid s_uuid = new Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 17;
    public Int32 CreateVideoDecoder(
        /// pVideoDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pVideoDesc
        /// pConfig: (*(const D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
        /// ppDecoder: (*(*(ID3D11VideoDecoder)))
        , ref IntPtr ppDecoder
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (CreateVideoDecoderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoDecoderFunc));
        return callback(Self, ref pVideoDesc, ref pConfig, ref ppDecoder);
    }
    delegate Int32 CreateVideoDecoderFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pVideoDesc, ref D3D11_VIDEO_DECODER_CONFIG pConfig, ref IntPtr ppDecoder);
    public Int32 CreateVideoProcessor(
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        IntPtr pEnum
        /// RateConversionIndex: (UINT)
        , UInt32 RateConversionIndex
        /// ppVideoProcessor: (*(*(ID3D11VideoProcessor)))
        , ref IntPtr ppVideoProcessor
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (CreateVideoProcessorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorFunc));
        return callback(Self, pEnum, RateConversionIndex, ref ppVideoProcessor);
    }
    delegate Int32 CreateVideoProcessorFunc(IntPtr self, IntPtr pEnum, UInt32 RateConversionIndex, ref IntPtr ppVideoProcessor);
    public Int32 CreateAuthenticatedChannel(
        /// ChannelType: (D3D11_AUTHENTICATED_CHANNEL_TYPE)
        D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType
        /// ppAuthenticatedChannel: (*(*(ID3D11AuthenticatedChannel)))
        , ref IntPtr ppAuthenticatedChannel
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (CreateAuthenticatedChannelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateAuthenticatedChannelFunc));
        return callback(Self, ChannelType, ref ppAuthenticatedChannel);
    }
    delegate Int32 CreateAuthenticatedChannelFunc(IntPtr self, D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ref IntPtr ppAuthenticatedChannel);
    public Int32 CreateCryptoSession(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// pKeyExchangeType: (*(const GUID))
        , ref Guid pKeyExchangeType
        /// ppCryptoSession: (*(*(ID3D11CryptoSession)))
        , ref IntPtr ppCryptoSession
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (CreateCryptoSessionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCryptoSessionFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, ref pKeyExchangeType, ref ppCryptoSession);
    }
    delegate Int32 CreateCryptoSessionFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref IntPtr ppCryptoSession);
    public Int32 CreateVideoDecoderOutputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC))
        , ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc
        /// ppVDOVView: (*(*(ID3D11VideoDecoderOutputView)))
        , ref IntPtr ppVDOVView
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (CreateVideoDecoderOutputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoDecoderOutputViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppVDOVView);
    }
    delegate Int32 CreateVideoDecoderOutputViewFunc(IntPtr self, IntPtr pResource, ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, ref IntPtr ppVDOVView);
    public Int32 CreateVideoProcessorInputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        , IntPtr pEnum
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC))
        , ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc
        /// ppVPIView: (*(*(ID3D11VideoProcessorInputView)))
        , ref IntPtr ppVPIView
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (CreateVideoProcessorInputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorInputViewFunc));
        return callback(Self, pResource, pEnum, ref pDesc, ref ppVPIView);
    }
    delegate Int32 CreateVideoProcessorInputViewFunc(IntPtr self, IntPtr pResource, IntPtr pEnum, ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, ref IntPtr ppVPIView);
    public Int32 CreateVideoProcessorOutputView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pEnum: (*(ID3D11VideoProcessorEnumerator))
        , IntPtr pEnum
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC))
        , ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc
        /// ppVPOView: (*(*(ID3D11VideoProcessorOutputView)))
        , ref IntPtr ppVPOView
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (CreateVideoProcessorOutputViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorOutputViewFunc));
        return callback(Self, pResource, pEnum, ref pDesc, ref ppVPOView);
    }
    delegate Int32 CreateVideoProcessorOutputViewFunc(IntPtr self, IntPtr pResource, IntPtr pEnum, ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, ref IntPtr ppVPOView);
    public Int32 CreateVideoProcessorEnumerator(
        /// pDesc: (*(const D3D11_VIDEO_PROCESSOR_CONTENT_DESC))
        ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc
        /// ppEnum: (*(*(ID3D11VideoProcessorEnumerator)))
        , ref IntPtr ppEnum
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (CreateVideoProcessorEnumeratorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVideoProcessorEnumeratorFunc));
        return callback(Self, ref pDesc, ref ppEnum);
    }
    delegate Int32 CreateVideoProcessorEnumeratorFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, ref IntPtr ppEnum);
    public UInt32 GetVideoDecoderProfileCount(
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (GetVideoDecoderProfileCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderProfileCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetVideoDecoderProfileCountFunc(IntPtr self);
    public Int32 GetVideoDecoderProfile(
        /// Index: (UINT)
        UInt32 Index
        /// pDecoderProfile: (*(GUID))
        , ref Guid pDecoderProfile
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (GetVideoDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderProfileFunc));
        return callback(Self, Index, ref pDecoderProfile);
    }
    delegate Int32 GetVideoDecoderProfileFunc(IntPtr self, UInt32 Index, ref Guid pDecoderProfile);
    public Int32 CheckVideoDecoderFormat(
        /// pDecoderProfile: (*(const GUID))
        ref Guid pDecoderProfile
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
        /// pSupported: (*(BOOL))
        , IntPtr pSupported
    )
    {
        var fp = GetFunctionPointer(10);
        var callback = (CheckVideoDecoderFormatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckVideoDecoderFormatFunc));
        return callback(Self, ref pDecoderProfile, Format, pSupported);
    }
    delegate Int32 CheckVideoDecoderFormatFunc(IntPtr self, ref Guid pDecoderProfile, DXGI_FORMAT Format, IntPtr pSupported);
    public Int32 GetVideoDecoderConfigCount(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc
        /// pCount: (*(UINT))
        , ref UInt32 pCount
    )
    {
        var fp = GetFunctionPointer(11);
        var callback = (GetVideoDecoderConfigCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderConfigCountFunc));
        return callback(Self, ref pDesc, ref pCount);
    }
    delegate Int32 GetVideoDecoderConfigCountFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pDesc, ref UInt32 pCount);
    public Int32 GetVideoDecoderConfig(
        /// pDesc: (*(const D3D11_VIDEO_DECODER_DESC))
        ref D3D11_VIDEO_DECODER_DESC pDesc
        /// Index: (UINT)
        , UInt32 Index
        /// pConfig: (*(D3D11_VIDEO_DECODER_CONFIG))
        , ref D3D11_VIDEO_DECODER_CONFIG pConfig
    )
    {
        var fp = GetFunctionPointer(12);
        var callback = (GetVideoDecoderConfigFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetVideoDecoderConfigFunc));
        return callback(Self, ref pDesc, Index, ref pConfig);
    }
    delegate Int32 GetVideoDecoderConfigFunc(IntPtr self, ref D3D11_VIDEO_DECODER_DESC pDesc, UInt32 Index, ref D3D11_VIDEO_DECODER_CONFIG pConfig);
    public Int32 GetContentProtectionCaps(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// pCaps: (*(D3D11_VIDEO_CONTENT_PROTECTION_CAPS))
        , ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps
    )
    {
        var fp = GetFunctionPointer(13);
        var callback = (GetContentProtectionCapsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContentProtectionCapsFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, ref pCaps);
    }
    delegate Int32 GetContentProtectionCapsFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, ref D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
    public Int32 CheckCryptoKeyExchange(
        /// pCryptoType: (*(const GUID))
        ref Guid pCryptoType
        /// pDecoderProfile: (*(const GUID))
        , ref Guid pDecoderProfile
        /// Index: (UINT)
        , UInt32 Index
        /// pKeyExchangeType: (*(GUID))
        , ref Guid pKeyExchangeType
    )
    {
        var fp = GetFunctionPointer(14);
        var callback = (CheckCryptoKeyExchangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCryptoKeyExchangeFunc));
        return callback(Self, ref pCryptoType, ref pDecoderProfile, Index, ref pKeyExchangeType);
    }
    delegate Int32 CheckCryptoKeyExchangeFunc(IntPtr self, ref Guid pCryptoType, ref Guid pDecoderProfile, UInt32 Index, ref Guid pKeyExchangeType);
    public Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(15);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate Int32 SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(16);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate Int32 SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
}

public class ID3D11Device : IUnknownImpl{

    static /*readonly*/ Guid s_uuid = new Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
    static int MethodCount => 40;
    public Int32 CreateBuffer(
        /// pDesc: (*(const D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppBuffer: (*(*(ID3D11Buffer)))
        , ref IntPtr ppBuffer
    )
    {
        var fp = GetFunctionPointer(0);
        var callback = (CreateBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBufferFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppBuffer);
    }
    delegate Int32 CreateBufferFunc(IntPtr self, ref D3D11_BUFFER_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppBuffer);
    public Int32 CreateTexture1D(
        /// pDesc: (*(const D3D11_TEXTURE1D_DESC))
        ref D3D11_TEXTURE1D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture1D: (*(*(ID3D11Texture1D)))
        , ref IntPtr ppTexture1D
    )
    {
        var fp = GetFunctionPointer(1);
        var callback = (CreateTexture1DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture1DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture1D);
    }
    delegate Int32 CreateTexture1DFunc(IntPtr self, ref D3D11_TEXTURE1D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture1D);
    public Int32 CreateTexture2D(
        /// pDesc: (*(const D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture2D: (*(*(ID3D11Texture2D)))
        , ref IntPtr ppTexture2D
    )
    {
        var fp = GetFunctionPointer(2);
        var callback = (CreateTexture2DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture2DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture2D);
    }
    delegate Int32 CreateTexture2DFunc(IntPtr self, ref D3D11_TEXTURE2D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture2D);
    public Int32 CreateTexture3D(
        /// pDesc: (*(const D3D11_TEXTURE3D_DESC))
        ref D3D11_TEXTURE3D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture3D: (*(*(ID3D11Texture3D)))
        , ref IntPtr ppTexture3D
    )
    {
        var fp = GetFunctionPointer(3);
        var callback = (CreateTexture3DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture3DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture3D);
    }
    delegate Int32 CreateTexture3DFunc(IntPtr self, ref D3D11_TEXTURE3D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture3D);
    public Int32 CreateShaderResourceView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_SHADER_RESOURCE_VIEW_DESC))
        , ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
        /// ppSRView: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppSRView
    )
    {
        var fp = GetFunctionPointer(4);
        var callback = (CreateShaderResourceViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateShaderResourceViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppSRView);
    }
    delegate Int32 CreateShaderResourceViewFunc(IntPtr self, IntPtr pResource, ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc, ref IntPtr ppSRView);
    public Int32 CreateUnorderedAccessView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_UNORDERED_ACCESS_VIEW_DESC))
        , ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc
        /// ppUAView: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUAView
    )
    {
        var fp = GetFunctionPointer(5);
        var callback = (CreateUnorderedAccessViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateUnorderedAccessViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppUAView);
    }
    delegate Int32 CreateUnorderedAccessViewFunc(IntPtr self, IntPtr pResource, ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc, ref IntPtr ppUAView);
    public Int32 CreateRenderTargetView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_RENDER_TARGET_VIEW_DESC))
        , ref D3D11_RENDER_TARGET_VIEW_DESC pDesc
        /// ppRTView: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRTView
    )
    {
        var fp = GetFunctionPointer(6);
        var callback = (CreateRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRenderTargetViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppRTView);
    }
    delegate Int32 CreateRenderTargetViewFunc(IntPtr self, IntPtr pResource, ref D3D11_RENDER_TARGET_VIEW_DESC pDesc, ref IntPtr ppRTView);
    public Int32 CreateDepthStencilView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_DEPTH_STENCIL_VIEW_DESC))
        , ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
    )
    {
        var fp = GetFunctionPointer(7);
        var callback = (CreateDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDepthStencilViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppDepthStencilView);
    }
    delegate Int32 CreateDepthStencilViewFunc(IntPtr self, IntPtr pResource, ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc, ref IntPtr ppDepthStencilView);
    public Int32 CreateInputLayout(
        /// pInputElementDescs: (*(const D3D11_INPUT_ELEMENT_DESC))
        ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs
        /// NumElements: (UINT)
        , UInt32 NumElements
        /// pShaderBytecodeWithInputSignature: (*(const void))
        , IntPtr pShaderBytecodeWithInputSignature
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        , ref IntPtr ppInputLayout
    )
    {
        var fp = GetFunctionPointer(8);
        var callback = (CreateInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateInputLayoutFunc));
        return callback(Self, ref pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ref ppInputLayout);
    }
    delegate Int32 CreateInputLayoutFunc(IntPtr self, ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs, UInt32 NumElements, IntPtr pShaderBytecodeWithInputSignature, UIntPtr BytecodeLength, ref IntPtr ppInputLayout);
    public Int32 CreateVertexShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        , ref IntPtr ppVertexShader
    )
    {
        var fp = GetFunctionPointer(9);
        var callback = (CreateVertexShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVertexShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppVertexShader);
    }
    delegate Int32 CreateVertexShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppVertexShader);
    public Int32 CreateGeometryShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        , ref IntPtr ppGeometryShader
    )
    {
        var fp = GetFunctionPointer(10);
        var callback = (CreateGeometryShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppGeometryShader);
    }
    delegate Int32 CreateGeometryShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppGeometryShader);
    public Int32 CreateGeometryShaderWithStreamOutput(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pSODeclaration: (*(const D3D11_SO_DECLARATION_ENTRY))
        , ref D3D11_SO_DECLARATION_ENTRY pSODeclaration
        /// NumEntries: (UINT)
        , UInt32 NumEntries
        /// pBufferStrides: (*(const UINT))
        , ref UInt32 pBufferStrides
        /// NumStrides: (UINT)
        , UInt32 NumStrides
        /// RasterizedStream: (UINT)
        , UInt32 RasterizedStream
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        , ref IntPtr ppGeometryShader
    )
    {
        var fp = GetFunctionPointer(11);
        var callback = (CreateGeometryShaderWithStreamOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryShaderWithStreamOutputFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, ref pSODeclaration, NumEntries, ref pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ref ppGeometryShader);
    }
    delegate Int32 CreateGeometryShaderWithStreamOutputFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, ref D3D11_SO_DECLARATION_ENTRY pSODeclaration, UInt32 NumEntries, ref UInt32 pBufferStrides, UInt32 NumStrides, UInt32 RasterizedStream, IntPtr pClassLinkage, ref IntPtr ppGeometryShader);
    public Int32 CreatePixelShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        , ref IntPtr ppPixelShader
    )
    {
        var fp = GetFunctionPointer(12);
        var callback = (CreatePixelShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePixelShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppPixelShader);
    }
    delegate Int32 CreatePixelShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppPixelShader);
    public Int32 CreateHullShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppHullShader: (*(*(ID3D11HullShader)))
        , ref IntPtr ppHullShader
    )
    {
        var fp = GetFunctionPointer(13);
        var callback = (CreateHullShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateHullShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppHullShader);
    }
    delegate Int32 CreateHullShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppHullShader);
    public Int32 CreateDomainShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        , ref IntPtr ppDomainShader
    )
    {
        var fp = GetFunctionPointer(14);
        var callback = (CreateDomainShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDomainShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppDomainShader);
    }
    delegate Int32 CreateDomainShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppDomainShader);
    public Int32 CreateComputeShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        , ref IntPtr ppComputeShader
    )
    {
        var fp = GetFunctionPointer(15);
        var callback = (CreateComputeShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateComputeShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppComputeShader);
    }
    delegate Int32 CreateComputeShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppComputeShader);
    public Int32 CreateClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref IntPtr ppLinkage
    )
    {
        var fp = GetFunctionPointer(16);
        var callback = (CreateClassLinkageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassLinkageFunc));
        return callback(Self, ref ppLinkage);
    }
    delegate Int32 CreateClassLinkageFunc(IntPtr self, ref IntPtr ppLinkage);
    public Int32 CreateBlendState(
        /// pBlendStateDesc: (*(const D3D11_BLEND_DESC))
        ref D3D11_BLEND_DESC pBlendStateDesc
        /// ppBlendState: (*(*(ID3D11BlendState)))
        , ref IntPtr ppBlendState
    )
    {
        var fp = GetFunctionPointer(17);
        var callback = (CreateBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBlendStateFunc));
        return callback(Self, ref pBlendStateDesc, ref ppBlendState);
    }
    delegate Int32 CreateBlendStateFunc(IntPtr self, ref D3D11_BLEND_DESC pBlendStateDesc, ref IntPtr ppBlendState);
    public Int32 CreateDepthStencilState(
        /// pDepthStencilDesc: (*(const D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        , ref IntPtr ppDepthStencilState
    )
    {
        var fp = GetFunctionPointer(18);
        var callback = (CreateDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDepthStencilStateFunc));
        return callback(Self, ref pDepthStencilDesc, ref ppDepthStencilState);
    }
    delegate Int32 CreateDepthStencilStateFunc(IntPtr self, ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, ref IntPtr ppDepthStencilState);
    public Int32 CreateRasterizerState(
        /// pRasterizerDesc: (*(const D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pRasterizerDesc
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        , ref IntPtr ppRasterizerState
    )
    {
        var fp = GetFunctionPointer(19);
        var callback = (CreateRasterizerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRasterizerStateFunc));
        return callback(Self, ref pRasterizerDesc, ref ppRasterizerState);
    }
    delegate Int32 CreateRasterizerStateFunc(IntPtr self, ref D3D11_RASTERIZER_DESC pRasterizerDesc, ref IntPtr ppRasterizerState);
    public Int32 CreateSamplerState(
        /// pSamplerDesc: (*(const D3D11_SAMPLER_DESC))
        ref D3D11_SAMPLER_DESC pSamplerDesc
        /// ppSamplerState: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplerState
    )
    {
        var fp = GetFunctionPointer(20);
        var callback = (CreateSamplerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSamplerStateFunc));
        return callback(Self, ref pSamplerDesc, ref ppSamplerState);
    }
    delegate Int32 CreateSamplerStateFunc(IntPtr self, ref D3D11_SAMPLER_DESC pSamplerDesc, ref IntPtr ppSamplerState);
    public Int32 CreateQuery(
        /// pQueryDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pQueryDesc
        /// ppQuery: (*(*(ID3D11Query)))
        , ref IntPtr ppQuery
    )
    {
        var fp = GetFunctionPointer(21);
        var callback = (CreateQueryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateQueryFunc));
        return callback(Self, ref pQueryDesc, ref ppQuery);
    }
    delegate Int32 CreateQueryFunc(IntPtr self, ref D3D11_QUERY_DESC pQueryDesc, ref IntPtr ppQuery);
    public Int32 CreatePredicate(
        /// pPredicateDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pPredicateDesc
        /// ppPredicate: (*(*(ID3D11Predicate)))
        , ref IntPtr ppPredicate
    )
    {
        var fp = GetFunctionPointer(22);
        var callback = (CreatePredicateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePredicateFunc));
        return callback(Self, ref pPredicateDesc, ref ppPredicate);
    }
    delegate Int32 CreatePredicateFunc(IntPtr self, ref D3D11_QUERY_DESC pPredicateDesc, ref IntPtr ppPredicate);
    public Int32 CreateCounter(
        /// pCounterDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pCounterDesc
        /// ppCounter: (*(*(ID3D11Counter)))
        , ref IntPtr ppCounter
    )
    {
        var fp = GetFunctionPointer(23);
        var callback = (CreateCounterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCounterFunc));
        return callback(Self, ref pCounterDesc, ref ppCounter);
    }
    delegate Int32 CreateCounterFunc(IntPtr self, ref D3D11_COUNTER_DESC pCounterDesc, ref IntPtr ppCounter);
    public Int32 CreateDeferredContext(
        /// ContextFlags: (UINT)
        UInt32 ContextFlags
        /// ppDeferredContext: (*(*(ID3D11DeviceContext)))
        , ref IntPtr ppDeferredContext
    )
    {
        var fp = GetFunctionPointer(24);
        var callback = (CreateDeferredContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeferredContextFunc));
        return callback(Self, ContextFlags, ref ppDeferredContext);
    }
    delegate Int32 CreateDeferredContextFunc(IntPtr self, UInt32 ContextFlags, ref IntPtr ppDeferredContext);
    public Int32 OpenSharedResource(
        /// hResource: (HANDLE)
        IntPtr hResource
        /// ReturnedInterface: (&(const IID))
        , ref Guid ReturnedInterface
        /// ppResource: (*(*(void)))
        , ref IntPtr ppResource
    )
    {
        var fp = GetFunctionPointer(25);
        var callback = (OpenSharedResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenSharedResourceFunc));
        return callback(Self, hResource, ref ReturnedInterface, ref ppResource);
    }
    delegate Int32 OpenSharedResourceFunc(IntPtr self, IntPtr hResource, ref Guid ReturnedInterface, ref IntPtr ppResource);
    public Int32 CheckFormatSupport(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// pFormatSupport: (*(UINT))
        , ref UInt32 pFormatSupport
    )
    {
        var fp = GetFunctionPointer(26);
        var callback = (CheckFormatSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckFormatSupportFunc));
        return callback(Self, Format, ref pFormatSupport);
    }
    delegate Int32 CheckFormatSupportFunc(IntPtr self, DXGI_FORMAT Format, ref UInt32 pFormatSupport);
    public Int32 CheckMultisampleQualityLevels(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// SampleCount: (UINT)
        , UInt32 SampleCount
        /// pNumQualityLevels: (*(UINT))
        , ref UInt32 pNumQualityLevels
    )
    {
        var fp = GetFunctionPointer(27);
        var callback = (CheckMultisampleQualityLevelsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckMultisampleQualityLevelsFunc));
        return callback(Self, Format, SampleCount, ref pNumQualityLevels);
    }
    delegate Int32 CheckMultisampleQualityLevelsFunc(IntPtr self, DXGI_FORMAT Format, UInt32 SampleCount, ref UInt32 pNumQualityLevels);
    public void CheckCounterInfo(
        /// pCounterInfo: (*(D3D11_COUNTER_INFO))
        ref D3D11_COUNTER_INFO pCounterInfo
    )
    {
        var fp = GetFunctionPointer(28);
        var callback = (CheckCounterInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCounterInfoFunc));
        callback(Self, ref pCounterInfo);
    }
    delegate void CheckCounterInfoFunc(IntPtr self, ref D3D11_COUNTER_INFO pCounterInfo);
    public Int32 CheckCounter(
        /// pDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pDesc
        /// pType: (*(D3D11_COUNTER_TYPE))
        , ref D3D11_COUNTER_TYPE pType
        /// pActiveCounters: (*(UINT))
        , ref UInt32 pActiveCounters
        /// szName: (LPSTR)
        , IntPtr szName
        /// pNameLength: (*(UINT))
        , ref UInt32 pNameLength
        /// szUnits: (LPSTR)
        , IntPtr szUnits
        /// pUnitsLength: (*(UINT))
        , ref UInt32 pUnitsLength
        /// szDescription: (LPSTR)
        , IntPtr szDescription
        /// pDescriptionLength: (*(UINT))
        , ref UInt32 pDescriptionLength
    )
    {
        var fp = GetFunctionPointer(29);
        var callback = (CheckCounterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCounterFunc));
        return callback(Self, ref pDesc, ref pType, ref pActiveCounters, szName, ref pNameLength, szUnits, ref pUnitsLength, szDescription, ref pDescriptionLength);
    }
    delegate Int32 CheckCounterFunc(IntPtr self, ref D3D11_COUNTER_DESC pDesc, ref D3D11_COUNTER_TYPE pType, ref UInt32 pActiveCounters, IntPtr szName, ref UInt32 pNameLength, IntPtr szUnits, ref UInt32 pUnitsLength, IntPtr szDescription, ref UInt32 pDescriptionLength);
    public Int32 CheckFeatureSupport(
        /// Feature: (D3D11_FEATURE)
        D3D11_FEATURE Feature
        /// pFeatureSupportData: (*(void))
        , IntPtr pFeatureSupportData
        /// FeatureSupportDataSize: (UINT)
        , UInt32 FeatureSupportDataSize
    )
    {
        var fp = GetFunctionPointer(30);
        var callback = (CheckFeatureSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckFeatureSupportFunc));
        return callback(Self, Feature, pFeatureSupportData, FeatureSupportDataSize);
    }
    delegate Int32 CheckFeatureSupportFunc(IntPtr self, D3D11_FEATURE Feature, IntPtr pFeatureSupportData, UInt32 FeatureSupportDataSize);
    public Int32 GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(31);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref guid, ref pDataSize, pData);
    }
    delegate Int32 GetPrivateDataFunc(IntPtr self, ref Guid guid, ref UInt32 pDataSize, IntPtr pData);
    public Int32 SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(32);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate Int32 SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public Int32 SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(33);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate Int32 SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
    public D3D_FEATURE_LEVEL GetFeatureLevel(
    )
    {
        var fp = GetFunctionPointer(34);
        var callback = (GetFeatureLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFeatureLevelFunc));
        return callback(Self);
    }
    delegate D3D_FEATURE_LEVEL GetFeatureLevelFunc(IntPtr self);
    public UInt32 GetCreationFlags(
    )
    {
        var fp = GetFunctionPointer(35);
        var callback = (GetCreationFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetCreationFlagsFunc(IntPtr self);
    public Int32 GetDeviceRemovedReason(
    )
    {
        var fp = GetFunctionPointer(36);
        var callback = (GetDeviceRemovedReasonFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceRemovedReasonFunc));
        return callback(Self);
    }
    delegate Int32 GetDeviceRemovedReasonFunc(IntPtr self);
    public void GetImmediateContext(
        /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
        ref IntPtr ppImmediateContext
    )
    {
        var fp = GetFunctionPointer(37);
        var callback = (GetImmediateContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImmediateContextFunc));
        callback(Self, ref ppImmediateContext);
    }
    delegate void GetImmediateContextFunc(IntPtr self, ref IntPtr ppImmediateContext);
    public Int32 SetExceptionMode(
        /// RaiseFlags: (UINT)
        UInt32 RaiseFlags
    )
    {
        var fp = GetFunctionPointer(38);
        var callback = (SetExceptionModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExceptionModeFunc));
        return callback(Self, RaiseFlags);
    }
    delegate Int32 SetExceptionModeFunc(IntPtr self, UInt32 RaiseFlags);
    public UInt32 GetExceptionMode(
    )
    {
        var fp = GetFunctionPointer(39);
        var callback = (GetExceptionModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExceptionModeFunc));
        return callback(Self);
    }
    delegate UInt32 GetExceptionModeFunc(IntPtr self);
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
public const int __REQUIRED_RPCNDR_H_VERSION__ = unchecked((int)500);
public const int __REQUIRED_RPCSAL_H_VERSION__ = unchecked((int)100);
public const int D3D11_16BIT_INDEX_STRIP_CUT_VALUE = unchecked((int)( 0xffff ));
public const int D3D11_32BIT_INDEX_STRIP_CUT_VALUE = unchecked((int)( 0xffffffff ));
public const int D3D11_8BIT_INDEX_STRIP_CUT_VALUE = unchecked((int)( 0xff ));
public const int D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = unchecked((int)( 9 ));
public const int D3D11_CLIP_OR_CULL_DISTANCE_COUNT = unchecked((int)( 8 ));
public const int D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = unchecked((int)( 2 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = unchecked((int)( 14 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = unchecked((int)( 15 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = unchecked((int)( 16 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = unchecked((int)( 15 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = unchecked((int)( 64 ));
public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = unchecked((int)( 128 ));
public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = unchecked((int)( 128 ));
public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT = unchecked((int)( 16 ));
public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT = unchecked((int)( 16 ));
public const int D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = unchecked((int)( 32 ));
public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_COMMONSHADER_TEMP_REGISTER_COUNT = unchecked((int)( 4096 ));
public const int D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = unchecked((int)( 3 ));
public const int D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS = unchecked((int)( 3 ));
public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = unchecked((int)( 10 ));
public const int D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = unchecked((int)( - 10 ));
public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = unchecked((int)( - 8 ));
public const int D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = unchecked((int)( 7 ));
public const int D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 256 ));
public const int D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 64 ));
public const int D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 240 ));
public const int D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 68 ));
public const int D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 224 ));
public const int D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 72 ));
public const int D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 208 ));
public const int D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 76 ));
public const int D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 192 ));
public const int D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 84 ));
public const int D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 176 ));
public const int D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 92 ));
public const int D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 160 ));
public const int D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 100 ));
public const int D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 144 ));
public const int D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 112 ));
public const int D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 128 ));
public const int D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 128 ));
public const int D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 112 ));
public const int D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 144 ));
public const int D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 96 ));
public const int D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 168 ));
public const int D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 80 ));
public const int D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 204 ));
public const int D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 64 ));
public const int D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 256 ));
public const int D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 48 ));
public const int D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 340 ));
public const int D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 32 ));
public const int D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 512 ));
public const int D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = unchecked((int)( 16 ));
public const int D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = unchecked((int)( 768 ));
public const int D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = unchecked((int)( 1 ));
public const int D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = unchecked((int)( 256 ));
public const int D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = unchecked((int)( 768 ));
public const int D3D11_CS_4_X_THREAD_GROUP_MAX_X = unchecked((int)( 768 ));
public const int D3D11_CS_4_X_THREAD_GROUP_MAX_Y = unchecked((int)( 768 ));
public const int D3D11_CS_4_X_UAV_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = unchecked((int)( 65535 ));
public const int D3D11_CS_TGSM_REGISTER_COUNT = unchecked((int)( 8192 ));
public const int D3D11_CS_TGSM_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS = unchecked((int)( 3 ));
public const int D3D11_CS_THREADGROUPID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS = unchecked((int)( 3 ));
public const int D3D11_CS_THREADIDINGROUP_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_CS_THREADID_REGISTER_COMPONENTS = unchecked((int)( 3 ));
public const int D3D11_CS_THREADID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = unchecked((int)( 1024 ));
public const int D3D11_CS_THREAD_GROUP_MAX_X = unchecked((int)( 1024 ));
public const int D3D11_CS_THREAD_GROUP_MAX_Y = unchecked((int)( 1024 ));
public const int D3D11_CS_THREAD_GROUP_MAX_Z = unchecked((int)( 64 ));
public const int D3D11_CS_THREAD_GROUP_MIN_X = unchecked((int)( 1 ));
public const int D3D11_CS_THREAD_GROUP_MIN_Y = unchecked((int)( 1 ));
public const int D3D11_CS_THREAD_GROUP_MIN_Z = unchecked((int)( 1 ));
public const int D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = unchecked((int)( 16384 ));
public const int D3D11_DEFAULT_BLEND_FACTOR_ALPHA = unchecked((int)( 1.0f ));
public const int D3D11_DEFAULT_BLEND_FACTOR_BLUE = unchecked((int)( 1.0f ));
public const int D3D11_DEFAULT_BLEND_FACTOR_GREEN = unchecked((int)( 1.0f ));
public const int D3D11_DEFAULT_BLEND_FACTOR_RED = unchecked((int)( 1.0f ));
public const int D3D11_DEFAULT_BORDER_COLOR_COMPONENT = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_DEPTH_BIAS = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_DEPTH_BIAS_CLAMP = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_MAX_ANISOTROPY = unchecked((int)( 16 ));
public const int D3D11_DEFAULT_MIP_LOD_BIAS = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_SAMPLE_MASK = unchecked((int)( 0xffffffff ));
public const int D3D11_DEFAULT_SCISSOR_ENDX = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_SCISSOR_ENDY = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_SCISSOR_STARTX = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_SCISSOR_STARTY = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_STENCIL_READ_MASK = unchecked((int)( 0xff ));
public const int D3D11_DEFAULT_STENCIL_REFERENCE = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_STENCIL_WRITE_MASK = unchecked((int)( 0xff ));
public const int D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_VIEWPORT_HEIGHT = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_VIEWPORT_MAX_DEPTH = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_VIEWPORT_MIN_DEPTH = unchecked((int)( 0.0f ));
public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTX = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_VIEWPORT_TOPLEFTY = unchecked((int)( 0 ));
public const int D3D11_DEFAULT_VIEWPORT_WIDTH = unchecked((int)( 0 ));
public const int D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = unchecked((int)( 3968 ));
public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = unchecked((int)( 3 ));
public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_DS_OUTPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_DS_OUTPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_FLOAT16_FUSED_TOLERANCE_IN_ULP = unchecked((int)( 0.6 ));
public const int D3D11_FLOAT32_MAX = unchecked((int)( 3.402823466e+38f ));
public const int D3D11_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = unchecked((int)( 0.6f ));
public const int D3D11_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = unchecked((int)( 2.4f ));
public const int D3D11_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = unchecked((int)( 1.0f ));
public const int D3D11_FLOAT_TO_SRGB_OFFSET = unchecked((int)( 0.055f ));
public const int D3D11_FLOAT_TO_SRGB_SCALE_1 = unchecked((int)( 12.92f ));
public const int D3D11_FLOAT_TO_SRGB_SCALE_2 = unchecked((int)( 1.055f ));
public const int D3D11_FLOAT_TO_SRGB_THRESHOLD = unchecked((int)( 0.0031308f ));
public const int D3D11_FTOI_INSTRUCTION_MAX_INPUT = unchecked((int)( 2147483647.999f ));
public const int D3D11_FTOI_INSTRUCTION_MIN_INPUT = unchecked((int)( - 2147483648.999f ));
public const int D3D11_FTOU_INSTRUCTION_MAX_INPUT = unchecked((int)( 4294967295.999f ));
public const int D3D11_FTOU_INSTRUCTION_MIN_INPUT = unchecked((int)( 0.0f ));
public const int D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_INPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_INPUT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_GS_INPUT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_GS_INPUT_REGISTER_VERTICES = unchecked((int)( 32 ));
public const int D3D11_GS_MAX_INSTANCE_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = unchecked((int)( 1024 ));
public const int D3D11_GS_OUTPUT_ELEMENTS = unchecked((int)( 32 ));
public const int D3D11_GS_OUTPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_GS_OUTPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = unchecked((int)( 0xffffffff ));
public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = unchecked((int)( 0xffffffff ));
public const int D3D11_HS_MAXTESSFACTOR_LOWER_BOUND = unchecked((int)( 1.0f ));
public const int D3D11_HS_MAXTESSFACTOR_UPPER_BOUND = unchecked((int)( 64.0f ));
public const int D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = unchecked((int)( 3968 ));
public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = unchecked((int)( 128 ));
public const int D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = unchecked((int)( 0 ));
public const int D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY = unchecked((int)( 0 ));
public const int D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = unchecked((int)( 0 ));
public const int D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = unchecked((int)( 1 ));
public const int D3D11_IA_INSTANCE_ID_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_PRIMITIVE_ID_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_VERTEX_ID_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = unchecked((int)( 32 ));
public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = unchecked((int)( 128 ));
public const int D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = unchecked((int)( 32 ));
public const int D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = unchecked((int)( 0xffffffff ));
public const int D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER = unchecked((int)( 0xffffffff ));
public const int D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = unchecked((int)( 0xffffffff ));
public const int D3D11_KEEP_UNORDERED_ACCESS_VIEWS = unchecked((int)( 0xffffffff ));
public const int D3D11_LINEAR_GAMMA = unchecked((int)( 1.0f ));
public const int D3D11_MAJOR_VERSION = unchecked((int)( 11 ));
public const int D3D11_MAX_BORDER_COLOR_COMPONENT = unchecked((int)( 1.0f ));
public const int D3D11_MAX_DEPTH = unchecked((int)( 1.0f ));
public const int D3D11_MAX_MAXANISOTROPY = unchecked((int)( 16 ));
public const int D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT = unchecked((int)( 32 ));
public const int D3D11_MAX_POSITION_VALUE = unchecked((int)( 3.402823466e+34f ));
public const int D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP = unchecked((int)( 17 ));
public const int D3D11_MINOR_VERSION = unchecked((int)( 0 ));
public const int D3D11_MIN_BORDER_COLOR_COMPONENT = unchecked((int)( 0.0f ));
public const int D3D11_MIN_DEPTH = unchecked((int)( 0.0f ));
public const int D3D11_MIN_MAXANISOTROPY = unchecked((int)( 0 ));
public const int D3D11_MIP_LOD_BIAS_MAX = unchecked((int)( 15.99f ));
public const int D3D11_MIP_LOD_BIAS_MIN = unchecked((int)( - 16.0f ));
public const int D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT = unchecked((int)( 8 ));
public const int D3D11_MIP_LOD_RANGE_BIT_COUNT = unchecked((int)( 8 ));
public const int D3D11_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = unchecked((int)( 1.4f ));
public const int D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = unchecked((int)( 0 ));
public const int D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT = unchecked((int)( 15 ));
public const int D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = unchecked((int)( 16 ));
public const int D3D11_PS_CS_UAV_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_PS_CS_UAV_REGISTER_COUNT = unchecked((int)( 8 ));
public const int D3D11_PS_CS_UAV_REGISTER_READS_PER_INST = unchecked((int)( 1 ));
public const int D3D11_PS_CS_UAV_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_PS_FRONTFACING_DEFAULT_VALUE = unchecked((int)( 0xffffffff ));
public const int D3D11_PS_FRONTFACING_FALSE_VALUE = unchecked((int)( 0 ));
public const int D3D11_PS_FRONTFACING_TRUE_VALUE = unchecked((int)( 0xffffffff ));
public const int D3D11_PS_INPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_PS_INPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_PS_INPUT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_PS_INPUT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = unchecked((int)( 0.0f ));
public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS = unchecked((int)( 1 ));
public const int D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_PS_OUTPUT_MASK_REGISTER_COUNT = unchecked((int)( 1 ));
public const int D3D11_PS_OUTPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_PS_OUTPUT_REGISTER_COUNT = unchecked((int)( 8 ));
public const int D3D11_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = unchecked((int)( 0.5f ));
public const int D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT = unchecked((int)( 16 ));
public const int D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = unchecked((int)( 4096 ));
public const int D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = unchecked((int)( 27 ));
public const int D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = unchecked((int)( 4096 ));
public const int D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = unchecked((int)( 4096 ));
public const int D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = unchecked((int)( 32 ));
public const int D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = unchecked((int)( 32 ));
public const int D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = unchecked((int)( 16384 ));
public const int D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = unchecked((int)( 1024 ));
public const int D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = unchecked((int)( 4096 ));
public const int D3D11_REQ_MAXANISOTROPY = unchecked((int)( 16 ));
public const int D3D11_REQ_MIP_LEVELS = unchecked((int)( 15 ));
public const int D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = unchecked((int)( 2048 ));
public const int D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = unchecked((int)( 4096 ));
public const int D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = unchecked((int)( 16384 ));
public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = unchecked((int)( 128 ));
public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = unchecked((int)( 0.25f ));
public const int D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = unchecked((int)( 2048 ));
public const int D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = unchecked((int)( 20 ));
public const int D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = unchecked((int)( 4096 ));
public const int D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = unchecked((int)( 2048 ));
public const int D3D11_REQ_TEXTURE1D_U_DIMENSION = unchecked((int)( 16384 ));
public const int D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = unchecked((int)( 2048 ));
public const int D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION = unchecked((int)( 16384 ));
public const int D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = unchecked((int)( 2048 ));
public const int D3D11_REQ_TEXTURECUBE_DIMENSION = unchecked((int)( 16384 ));
public const int D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = unchecked((int)( 0 ));
public const int D3D11_SHADER_MAJOR_VERSION = unchecked((int)( 5 ));
public const int D3D11_SHADER_MAX_INSTANCES = unchecked((int)( 65535 ));
public const int D3D11_SHADER_MAX_INTERFACES = unchecked((int)( 253 ));
public const int D3D11_SHADER_MAX_INTERFACE_CALL_SITES = unchecked((int)( 4096 ));
public const int D3D11_SHADER_MAX_TYPES = unchecked((int)( 65535 ));
public const int D3D11_SHADER_MINOR_VERSION = unchecked((int)( 0 ));
public const int D3D11_SHIFT_INSTRUCTION_PAD_VALUE = unchecked((int)( 0 ));
public const int D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = unchecked((int)( 5 ));
public const int D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT = unchecked((int)( 8 ));
public const int D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES = unchecked((int)( 2048 ));
public const int D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = unchecked((int)( 512 ));
public const int D3D11_SO_BUFFER_SLOT_COUNT = unchecked((int)( 4 ));
public const int D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP = unchecked((int)( 0xffffffff ));
public const int D3D11_SO_NO_RASTERIZED_STREAM = unchecked((int)( 0xffffffff ));
public const int D3D11_SO_OUTPUT_COMPONENT_COUNT = unchecked((int)( 128 ));
public const int D3D11_SO_STREAM_COUNT = unchecked((int)( 4 ));
public const int D3D11_SPEC_DATE_DAY = unchecked((int)( 16 ));
public const int D3D11_SPEC_DATE_MONTH = unchecked((int)( 05 ));
public const int D3D11_SPEC_DATE_YEAR = unchecked((int)( 2011 ));
public const int D3D11_SPEC_VERSION = unchecked((int)( 1.07 ));
public const int D3D11_SRGB_GAMMA = unchecked((int)( 2.2f ));
public const int D3D11_SRGB_TO_FLOAT_DENOMINATOR_1 = unchecked((int)( 12.92f ));
public const int D3D11_SRGB_TO_FLOAT_DENOMINATOR_2 = unchecked((int)( 1.055f ));
public const int D3D11_SRGB_TO_FLOAT_EXPONENT = unchecked((int)( 2.4f ));
public const int D3D11_SRGB_TO_FLOAT_OFFSET = unchecked((int)( 0.055f ));
public const int D3D11_SRGB_TO_FLOAT_THRESHOLD = unchecked((int)( 0.04045f ));
public const int D3D11_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = unchecked((int)( 0.5f ));
public const int D3D11_STANDARD_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = unchecked((int)( 64 ));
public const int D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = unchecked((int)( 4 ));
public const int D3D11_STANDARD_PIXEL_COMPONENT_COUNT = unchecked((int)( 128 ));
public const int D3D11_STANDARD_PIXEL_ELEMENT_COUNT = unchecked((int)( 32 ));
public const int D3D11_STANDARD_VECTOR_SIZE = unchecked((int)( 4 ));
public const int D3D11_STANDARD_VERTEX_ELEMENT_COUNT = unchecked((int)( 32 ));
public const int D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = unchecked((int)( 64 ));
public const int D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT = unchecked((int)( 8 ));
public const int D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT = unchecked((int)( 8 ));
public const int D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = unchecked((int)( 64 ));
public const int D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = unchecked((int)( 64 ));
public const int D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = unchecked((int)( 63 ));
public const int D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR = unchecked((int)( 64 ));
public const int D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = unchecked((int)( 2 ));
public const int D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = unchecked((int)( 1 ));
public const int D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = unchecked((int)( 1 ));
public const int D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT = unchecked((int)( 16 ));
public const int D3D11_UNBOUND_MEMORY_ACCESS_RESULT = unchecked((int)( 0 ));
public const int D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = unchecked((int)( 15 ));
public const int D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = unchecked((int)( 16 ));
public const int D3D11_VIEWPORT_BOUNDS_MAX = unchecked((int)( 32767 ));
public const int D3D11_VIEWPORT_BOUNDS_MIN = unchecked((int)( - 32768 ));
public const int D3D11_VS_INPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_VS_INPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_VS_INPUT_REGISTER_READS_PER_INST = unchecked((int)( 2 ));
public const int D3D11_VS_INPUT_REGISTER_READ_PORTS = unchecked((int)( 1 ));
public const int D3D11_VS_OUTPUT_REGISTER_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = unchecked((int)( 32 ));
public const int D3D11_VS_OUTPUT_REGISTER_COUNT = unchecked((int)( 32 ));
public const int D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = unchecked((int)( 10 ));
public const int D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = unchecked((int)( 25 ));
public const int D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = unchecked((int)( 25 ));
public const int D3D11_1_UAV_SLOT_COUNT = unchecked((int)( 64 ));
public const int D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES = unchecked((int)( 65536 ));
public const int D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS = unchecked((int)( 4 ));
public const int D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT = unchecked((int)( 256 ));
public const int _FACD3D11 = unchecked((int)( 0x87c ));
public const int _FACD3D11DEBUG = unchecked((int)( ( _FACD3D11 + 1 ) ));
public const int D3D11_APPEND_ALIGNED_ELEMENT = unchecked((int)( 0xffffffff ));
public const int D3D11_FILTER_REDUCTION_TYPE_MASK = unchecked((int)( 0x3 ));
public const int D3D11_FILTER_REDUCTION_TYPE_SHIFT = unchecked((int)( 7 ));
public const int D3D11_FILTER_TYPE_MASK = unchecked((int)( 0x3 ));
public const int D3D11_MIN_FILTER_SHIFT = unchecked((int)( 4 ));
public const int D3D11_MAG_FILTER_SHIFT = unchecked((int)( 2 ));
public const int D3D11_MIP_FILTER_SHIFT = unchecked((int)( 0 ));
public const int D3D11_COMPARISON_FILTERING_BIT = unchecked((int)( 0x80 ));
public const int D3D11_ANISOTROPIC_FILTERING_BIT = unchecked((int)( 0x40 ));
public const int D3D11_SDK_VERSION = unchecked((int)( 7 ));
[DllImport("D3D11.dll")]
public static extern UInt32 D3D11CalcSubresource(
    /// MipSlice: (UINT)
    UInt32 MipSlice
    /// ArraySlice: (UINT)
    , UInt32 ArraySlice
    /// MipLevels: (UINT)
    , UInt32 MipLevels
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
        ref IntPtr ppDevice,
        /// pFeatureLevel: (*(D3D_FEATURE_LEVEL))
        ref D3D_FEATURE_LEVEL pFeatureLevel,
        /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
        ref IntPtr ppImmediateContext
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
        ref IntPtr ppSwapChain,
        /// ppDevice: (*(*(ID3D11Device)))
        ref IntPtr ppDevice,
        /// pFeatureLevel: (*(D3D_FEATURE_LEVEL))
        ref D3D_FEATURE_LEVEL pFeatureLevel,
        /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
        ref IntPtr ppImmediateContext
    );
    
}
}
