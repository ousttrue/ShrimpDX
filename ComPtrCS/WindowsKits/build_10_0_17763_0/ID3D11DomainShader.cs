/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11DomainShader: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("f582c508-0f36-490c-9977-31eece268cfa");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
