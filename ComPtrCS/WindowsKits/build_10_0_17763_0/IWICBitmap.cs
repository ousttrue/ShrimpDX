/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class IWICBitmap : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("None");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
