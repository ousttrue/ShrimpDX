/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=8)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_BUFFER_SRV{
    #region union
        [FieldOffset(0)]
        /// (UINT)
        public UInt32 FirstElement;

        [FieldOffset(0)]
        /// (UINT)
        public UInt32 ElementOffset;

    #endregion

    #region union
        [FieldOffset(4)]
        /// (UINT)
        public UInt32 NumElements;

        [FieldOffset(4)]
        /// (UINT)
        public UInt32 ElementWidth;

    #endregion

}
}
