/// d3dcompiler.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D3D_SHADER_DATA{
    /// (LPCVOID)
    public IntPtr pBytecode;

    /// (SIZE_T)
    public UIntPtr BytecodeLength;

}
}
