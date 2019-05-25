/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class ID3D11Predicate: ID3D11Query {

    static /*readonly*/ Guid s_uuid = new Guid("9eb576dd-9f77-4d86-81aa-8bab5fe490e2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
