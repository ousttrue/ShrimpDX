/// d3dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct _D3D_SHADER_MACRO{
    /// (LPCSTR)
    public IntPtr Name;

    /// (LPCSTR)
    public IntPtr Definition;

}
}
