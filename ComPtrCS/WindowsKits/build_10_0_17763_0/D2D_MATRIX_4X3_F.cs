/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {


[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D2D_MATRIX_4X3_F {
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
  #endregion
}
}
