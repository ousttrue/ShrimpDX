/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11ComputeShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("4f5b196e-c2bd-495e-bd01-1fded38e4969");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
