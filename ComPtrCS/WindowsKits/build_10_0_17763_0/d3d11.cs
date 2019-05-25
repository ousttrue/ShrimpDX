
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_PRIMITIVE_TOPOLOGY{
    public D3D_PRIMITIVE_TOPOLOGY Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_PRIMITIVE{
    public D3D_PRIMITIVE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_SRV_DIMENSION{
    public D3D_SRV_DIMENSION Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_RECT{
    public RECT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct APP_DEPRECATED_HRESULT{
    public HRESULT Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT{
    public D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT Value;
}

public static class D3D11{
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
    public static extern HRESULT D3D11CreateDevice(
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
    public static extern HRESULT D3D11CreateDeviceAndSwapChain(
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
