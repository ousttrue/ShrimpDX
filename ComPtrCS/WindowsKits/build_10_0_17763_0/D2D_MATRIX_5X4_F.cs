/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {


[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D_MATRIX_5X4_F
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=20)]
    public Single[] m;
}
}
