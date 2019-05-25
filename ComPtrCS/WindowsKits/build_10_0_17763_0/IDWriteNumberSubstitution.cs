/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

public class IDWriteNumberSubstitution : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("14885cc9-bab0-4f90-b6ed-5c366a2cd03d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;
}
}
