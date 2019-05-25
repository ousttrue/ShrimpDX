/// dcommon.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {


[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D2D_MATRIX_3X2_F {
  #region union
    [FieldOffset(0)]
    public Single m11;
    [FieldOffset(4)]
    public Single m12;
    [FieldOffset(8)]
    public Single m21;
    [FieldOffset(12)]
    public Single m22;
    [FieldOffset(16)]
    public Single dx;
    [FieldOffset(20)]
    public Single dy;

    [FieldOffset(0)]
    public Single _11;
    [FieldOffset(4)]
    public Single _12;
    [FieldOffset(8)]
    public Single _21;
    [FieldOffset(12)]
    public Single _22;
    [FieldOffset(16)]
    public Single _31;
    [FieldOffset(20)]
    public Single _32;
  #endregion
}
}
