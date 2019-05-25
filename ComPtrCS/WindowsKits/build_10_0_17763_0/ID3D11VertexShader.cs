/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11VertexShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("3b301d64-d678-4289-8897-22f8928b72f3");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
