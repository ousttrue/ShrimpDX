/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11PixelShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("ea82e40d-51dc-4f33-93d4-db7c9125ae8c");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
