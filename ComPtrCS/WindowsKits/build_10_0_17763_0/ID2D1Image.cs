/// d2d1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID2D1Image: ID2D1Resource {

    static /*readonly*/ Guid s_uuid = new Guid("65019f75-8da2-497c-b32c-dfa34e48ede6");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
