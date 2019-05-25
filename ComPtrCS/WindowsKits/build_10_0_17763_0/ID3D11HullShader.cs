/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11HullShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("8e5c6061-628a-4c8e-8264-bbe45cb3d5dd");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
