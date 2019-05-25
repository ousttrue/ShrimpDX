
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public static class D3DCOMPILER{
public const int D3D_COMPILER_VERSION = unchecked((int)47);
public const int D3DCOMPILE_DEBUG = unchecked((int)( 1 << 0 ));
public const int D3DCOMPILE_SKIP_VALIDATION = unchecked((int)( 1 << 1 ));
public const int D3DCOMPILE_SKIP_OPTIMIZATION = unchecked((int)( 1 << 2 ));
public const int D3DCOMPILE_PACK_MATRIX_ROW_MAJOR = unchecked((int)( 1 << 3 ));
public const int D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR = unchecked((int)( 1 << 4 ));
public const int D3DCOMPILE_PARTIAL_PRECISION = unchecked((int)( 1 << 5 ));
public const int D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT = unchecked((int)( 1 << 6 ));
public const int D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT = unchecked((int)( 1 << 7 ));
public const int D3DCOMPILE_NO_PRESHADER = unchecked((int)( 1 << 8 ));
public const int D3DCOMPILE_AVOID_FLOW_CONTROL = unchecked((int)( 1 << 9 ));
public const int D3DCOMPILE_PREFER_FLOW_CONTROL = unchecked((int)( 1 << 10 ));
public const int D3DCOMPILE_ENABLE_STRICTNESS = unchecked((int)( 1 << 11 ));
public const int D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY = unchecked((int)( 1 << 12 ));
public const int D3DCOMPILE_IEEE_STRICTNESS = unchecked((int)( 1 << 13 ));
public const int D3DCOMPILE_OPTIMIZATION_LEVEL0 = unchecked((int)( 1 << 14 ));
public const int D3DCOMPILE_OPTIMIZATION_LEVEL1 = unchecked((int)0);
public const int D3DCOMPILE_OPTIMIZATION_LEVEL2 = unchecked((int)( ( 1 << 14 ) | ( 1 << 15 ) ));
public const int D3DCOMPILE_OPTIMIZATION_LEVEL3 = unchecked((int)( 1 << 15 ));
public const int D3DCOMPILE_RESERVED16 = unchecked((int)( 1 << 16 ));
public const int D3DCOMPILE_RESERVED17 = unchecked((int)( 1 << 17 ));
public const int D3DCOMPILE_WARNINGS_ARE_ERRORS = unchecked((int)( 1 << 18 ));
public const int D3DCOMPILE_RESOURCES_MAY_ALIAS = unchecked((int)( 1 << 19 ));
public const int D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES = unchecked((int)( 1 << 20 ));
public const int D3DCOMPILE_ALL_RESOURCES_BOUND = unchecked((int)( 1 << 21 ));
public const int D3DCOMPILE_DEBUG_NAME_FOR_SOURCE = unchecked((int)( 1 << 22 ));
public const int D3DCOMPILE_DEBUG_NAME_FOR_BINARY = unchecked((int)( 1 << 23 ));
public const int D3DCOMPILE_EFFECT_CHILD_EFFECT = unchecked((int)( 1 << 0 ));
public const int D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS = unchecked((int)( 1 << 1 ));
public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST = unchecked((int)0);
public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 = unchecked((int)( 1 << 4 ));
public const int D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 = unchecked((int)( 1 << 5 ));
public const int D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS = unchecked((int)0x00000001);
public const int D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS = unchecked((int)0x00000002);
public const int D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH = unchecked((int)0x00000004);
public const int D3D_DISASM_ENABLE_COLOR_CODE = unchecked((int)0x00000001);
public const int D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = unchecked((int)0x00000002);
public const int D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = unchecked((int)0x00000004);
public const int D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = unchecked((int)0x00000008);
public const int D3D_DISASM_DISABLE_DEBUG_INFO = unchecked((int)0x00000010);
public const int D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = unchecked((int)0x00000020);
public const int D3D_DISASM_INSTRUCTION_ONLY = unchecked((int)0x00000040);
public const int D3D_DISASM_PRINT_HEX_LITERALS = unchecked((int)0x00000080);
public const int D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = unchecked((int)0x00000001);
public const int D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = unchecked((int)0x00000001);
[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DReadFileToBlob(
    /// pFileName: (LPCWSTR)
    IntPtr pFileName
    /// ppContents: (*(*(ID3DBlob)))
    , ref IntPtr ppContents
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DWriteBlobToFile(
    /// pBlob: (*(ID3DBlob))
    IntPtr pBlob
    /// pFileName: (LPCWSTR)
    , IntPtr pFileName
    /// bOverwrite: (BOOL)
    , Int32 bOverwrite
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCompile(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// pSourceName: (LPCSTR)
    , IntPtr pSourceName
    /// pDefines: (*(const D3D_SHADER_MACRO))
    , ref D3D_SHADER_MACRO pDefines
    /// pInclude: (*(ID3DInclude))
    , IntPtr pInclude
    /// pEntrypoint: (LPCSTR)
    , IntPtr pEntrypoint
    /// pTarget: (LPCSTR)
    , IntPtr pTarget
    /// Flags1: (UINT)
    , UInt32 Flags1
    /// Flags2: (UINT)
    , UInt32 Flags2
    /// ppCode: (*(*(ID3DBlob)))
    , ref IntPtr ppCode
    /// ppErrorMsgs: (*(*(ID3DBlob)))
    , ref IntPtr ppErrorMsgs
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCompile2(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// pSourceName: (LPCSTR)
    , IntPtr pSourceName
    /// pDefines: (*(const D3D_SHADER_MACRO))
    , ref D3D_SHADER_MACRO pDefines
    /// pInclude: (*(ID3DInclude))
    , IntPtr pInclude
    /// pEntrypoint: (LPCSTR)
    , IntPtr pEntrypoint
    /// pTarget: (LPCSTR)
    , IntPtr pTarget
    /// Flags1: (UINT)
    , UInt32 Flags1
    /// Flags2: (UINT)
    , UInt32 Flags2
    /// SecondaryDataFlags: (UINT)
    , UInt32 SecondaryDataFlags
    /// pSecondaryData: (LPCVOID)
    , IntPtr pSecondaryData
    /// SecondaryDataSize: (SIZE_T)
    , UIntPtr SecondaryDataSize
    /// ppCode: (*(*(ID3DBlob)))
    , ref IntPtr ppCode
    /// ppErrorMsgs: (*(*(ID3DBlob)))
    , ref IntPtr ppErrorMsgs
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCompileFromFile(
    /// pFileName: (LPCWSTR)
    IntPtr pFileName
    /// pDefines: (*(const D3D_SHADER_MACRO))
    , ref D3D_SHADER_MACRO pDefines
    /// pInclude: (*(ID3DInclude))
    , IntPtr pInclude
    /// pEntrypoint: (LPCSTR)
    , IntPtr pEntrypoint
    /// pTarget: (LPCSTR)
    , IntPtr pTarget
    /// Flags1: (UINT)
    , UInt32 Flags1
    /// Flags2: (UINT)
    , UInt32 Flags2
    /// ppCode: (*(*(ID3DBlob)))
    , ref IntPtr ppCode
    /// ppErrorMsgs: (*(*(ID3DBlob)))
    , ref IntPtr ppErrorMsgs
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DPreprocess(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// pSourceName: (LPCSTR)
    , IntPtr pSourceName
    /// pDefines: (*(const D3D_SHADER_MACRO))
    , ref D3D_SHADER_MACRO pDefines
    /// pInclude: (*(ID3DInclude))
    , IntPtr pInclude
    /// ppCodeText: (*(*(ID3DBlob)))
    , ref IntPtr ppCodeText
    /// ppErrorMsgs: (*(*(ID3DBlob)))
    , ref IntPtr ppErrorMsgs
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetDebugInfo(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// ppDebugInfo: (*(*(ID3DBlob)))
    , ref IntPtr ppDebugInfo
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DReflect(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// pInterface: (&(const IID))
    , ref Guid pInterface
    /// ppReflector: (*(*(void)))
    , ref IntPtr ppReflector
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DReflectLibrary(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// riid: (&(const IID))
    , ref Guid riid
    /// ppReflector: (*(LPVOID))
    , ref IntPtr ppReflector
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DDisassemble(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// Flags: (UINT)
    , UInt32 Flags
    /// szComments: (LPCSTR)
    , IntPtr szComments
    /// ppDisassembly: (*(*(ID3DBlob)))
    , ref IntPtr ppDisassembly
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DDisassembleRegion(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// Flags: (UINT)
    , UInt32 Flags
    /// szComments: (LPCSTR)
    , IntPtr szComments
    /// StartByteOffset: (SIZE_T)
    , UIntPtr StartByteOffset
    /// NumInsts: (SIZE_T)
    , UIntPtr NumInsts
    /// pFinishByteOffset: (*(SIZE_T))
    , ref UIntPtr pFinishByteOffset
    /// ppDisassembly: (*(*(ID3DBlob)))
    , ref IntPtr ppDisassembly
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCreateLinker(
    /// ppLinker: (*(*(struct ID3D11Linker)))
    ref IntPtr ppLinker
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DLoadModule(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// cbSrcDataSize: (SIZE_T)
    , UIntPtr cbSrcDataSize
    /// ppModule: (*(*(struct ID3D11Module)))
    , ref IntPtr ppModule
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCreateFunctionLinkingGraph(
    /// uFlags: (UINT)
    UInt32 uFlags
    /// ppFunctionLinkingGraph: (*(*(struct ID3D11FunctionLinkingGraph)))
    , ref IntPtr ppFunctionLinkingGraph
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetTraceInstructionOffsets(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// Flags: (UINT)
    , UInt32 Flags
    /// StartInstIndex: (SIZE_T)
    , UIntPtr StartInstIndex
    /// NumInsts: (SIZE_T)
    , UIntPtr NumInsts
    /// pOffsets: (*(SIZE_T))
    , ref UIntPtr pOffsets
    /// pTotalInsts: (*(SIZE_T))
    , ref UIntPtr pTotalInsts
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetInputSignatureBlob(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// ppSignatureBlob: (*(*(ID3DBlob)))
    , ref IntPtr ppSignatureBlob
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetOutputSignatureBlob(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// ppSignatureBlob: (*(*(ID3DBlob)))
    , ref IntPtr ppSignatureBlob
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetInputAndOutputSignatureBlob(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// ppSignatureBlob: (*(*(ID3DBlob)))
    , ref IntPtr ppSignatureBlob
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DStripShader(
    /// pShaderBytecode: (LPCVOID)
    IntPtr pShaderBytecode
    /// BytecodeLength: (SIZE_T)
    , UIntPtr BytecodeLength
    /// uStripFlags: (UINT)
    , UInt32 uStripFlags
    /// ppStrippedBlob: (*(*(ID3DBlob)))
    , ref IntPtr ppStrippedBlob
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DGetBlobPart(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// Part: (D3D_BLOB_PART)
    , D3D_BLOB_PART Part
    /// Flags: (UINT)
    , UInt32 Flags
    /// ppPart: (*(*(ID3DBlob)))
    , ref IntPtr ppPart
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DSetBlobPart(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// Part: (D3D_BLOB_PART)
    , D3D_BLOB_PART Part
    /// Flags: (UINT)
    , UInt32 Flags
    /// pPart: (LPCVOID)
    , IntPtr pPart
    /// PartSize: (SIZE_T)
    , UIntPtr PartSize
    /// ppNewShader: (*(*(ID3DBlob)))
    , ref IntPtr ppNewShader
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCreateBlob(
    /// Size: (SIZE_T)
    UIntPtr Size
    /// ppBlob: (*(*(ID3DBlob)))
    , ref IntPtr ppBlob
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DCompressShaders(
    /// uNumShaders: (UINT)
    UInt32 uNumShaders
    /// pShaderData: (*(D3D_SHADER_DATA))
    , ref D3D_SHADER_DATA pShaderData
    /// uFlags: (UINT)
    , UInt32 uFlags
    /// ppCompressedData: (*(*(ID3DBlob)))
    , ref IntPtr ppCompressedData
);

[DllImport("D3dcompiler_47.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D3DDecompressShaders(
    /// pSrcData: (LPCVOID)
    IntPtr pSrcData
    /// SrcDataSize: (SIZE_T)
    , UIntPtr SrcDataSize
    /// uNumShaders: (UINT)
    , UInt32 uNumShaders
    /// uStartIndex: (UINT)
    , UInt32 uStartIndex
    /// pIndices: (*(UINT))
    , ref UInt32 pIndices
    /// uFlags: (UINT)
    , UInt32 uFlags
    /// ppShaders: (*(*(ID3DBlob)))
    , ref IntPtr ppShaders
    /// pTotalShaders: (*(UINT))
    , ref UInt32 pTotalShaders
);

}
}
