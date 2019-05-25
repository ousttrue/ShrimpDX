
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public static class dwrite{
public const int DWRITE_ALPHA_MAX = unchecked((int)255);
public const int FACILITY_DWRITE = unchecked((int)0x898);
public const int DWRITE_ERR_BASE = unchecked((int)0x5000);
[DllImport("Dwrite.dll")]
public static extern HRESULT DWriteCreateFactory(
    /// factoryType: (DWRITE_FACTORY_TYPE)
    DWRITE_FACTORY_TYPE factoryType
    /// iid: (&(const IID))
    , ref Guid iid
    /// factory: (*(*(IUnknown)))
    , ref IntPtr factory
);

}
}
