
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {









[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct D2D1_TAG{
    public UInt64 Value;
}

public static class D2D1{
public const int D2D1_DEFAULT_FLATTENING_TOLERANCE = unchecked((int)( 0.25f ));
[DllImport("D2D1.dll", CallingConvention = CallingConvention.StdCall)]
public static extern HRESULT D2D1CreateFactory(
    /// factoryType: (D2D1_FACTORY_TYPE)
    D2D1_FACTORY_TYPE factoryType
    /// riid: (&(const IID))
    , ref Guid riid
    /// pFactoryOptions: (*(const D2D1_FACTORY_OPTIONS))
    , ref D2D1_FACTORY_OPTIONS pFactoryOptions
    /// ppIFactory: (*(*(void)))
    , ref IntPtr ppIFactory
);

[DllImport("D2D1.dll", CallingConvention = CallingConvention.StdCall)]
public static extern void D2D1MakeRotateMatrix(
    /// angle: (FLOAT)
    Single angle
    /// center: (D2D1_POINT_2F)
    , D2D_POINT_2F center
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    , ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll", CallingConvention = CallingConvention.StdCall)]
public static extern void D2D1MakeSkewMatrix(
    /// angleX: (FLOAT)
    Single angleX
    /// angleY: (FLOAT)
    , Single angleY
    /// center: (D2D1_POINT_2F)
    , D2D_POINT_2F center
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    , ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll", CallingConvention = CallingConvention.StdCall)]
public static extern Int32 D2D1IsMatrixInvertible(
    /// matrix: (*(const D2D1_MATRIX_3X2_F))
    ref D2D_MATRIX_3X2_F matrix
);

[DllImport("D2D1.dll", CallingConvention = CallingConvention.StdCall)]
public static extern Int32 D2D1InvertMatrix(
    /// matrix: (*(D2D1_MATRIX_3X2_F))
    ref D2D_MATRIX_3X2_F matrix
);

}
}
