
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_MACRO{
    public _D3D_SHADER_MACRO Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct ID3DBlob{
    public ID3D10Blob Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct LPD3DBLOB{
    public ID3DBlob Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct PFN_DESTRUCTION_CALLBACK{
    public IntPtr Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_INCLUDE_TYPE{
    public _D3D_INCLUDE_TYPE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct LPD3DINCLUDE{
    public ID3DInclude Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_VARIABLE_CLASS{
    public _D3D_SHADER_VARIABLE_CLASS Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_VARIABLE_FLAGS{
    public _D3D_SHADER_VARIABLE_FLAGS Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_VARIABLE_TYPE{
    public _D3D_SHADER_VARIABLE_TYPE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_INPUT_FLAGS{
    public _D3D_SHADER_INPUT_FLAGS Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_INPUT_TYPE{
    public _D3D_SHADER_INPUT_TYPE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_CBUFFER_FLAGS{
    public _D3D_SHADER_CBUFFER_FLAGS Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_CBUFFER_TYPE{
    public _D3D_CBUFFER_TYPE Value;
}

[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_PARAMETER_FLAGS{
    public _D3D_PARAMETER_FLAGS Value;
}

}
