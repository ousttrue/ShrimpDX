
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {









public static class D2D1_1{
public const int D2D1_INVALID_PROPERTY_INDEX = unchecked((int)UInt32.MaxValue);
[DllImport("D2D1.dll")]
public static extern HRESULT D2D1CreateDevice(
    /// dxgiDevice: (*(IDXGIDevice))
    IntPtr dxgiDevice
    /// creationProperties: (*(const D2D1_CREATION_PROPERTIES))
    , ref D2D1_CREATION_PROPERTIES creationProperties
    /// d2dDevice: (*(*(ID2D1Device)))
    , ref IntPtr d2dDevice
);

[DllImport("D2D1.dll")]
public static extern HRESULT D2D1CreateDeviceContext(
    /// dxgiSurface: (*(IDXGISurface))
    IntPtr dxgiSurface
    /// creationProperties: (*(const D2D1_CREATION_PROPERTIES))
    , ref D2D1_CREATION_PROPERTIES creationProperties
    /// d2dDeviceContext: (*(*(ID2D1DeviceContext)))
    , ref IntPtr d2dDeviceContext
);

[DllImport("D2D1.dll")]
public static extern Vector4 D2D1ConvertColorSpace(
    /// sourceColorSpace: (D2D1_COLOR_SPACE)
    D2D1_COLOR_SPACE sourceColorSpace
    /// destinationColorSpace: (D2D1_COLOR_SPACE)
    , D2D1_COLOR_SPACE destinationColorSpace
    /// color: (*(const D2D1_COLOR_F))
    , ref Vector4 color
);

[DllImport("D2D1.dll")]
public static extern void D2D1SinCos(
    /// angle: (FLOAT)
    Single angle
    /// s: (*(FLOAT))
    , ref Single s
    /// c: (*(FLOAT))
    , ref Single c
);

[DllImport("D2D1.dll")]
public static extern Single D2D1Tan(
    /// angle: (FLOAT)
    Single angle
);

[DllImport("D2D1.dll")]
public static extern Single D2D1Vec3Length(
    /// x: (FLOAT)
    Single x
    /// y: (FLOAT)
    , Single y
    /// z: (FLOAT)
    , Single z
);

}
}
