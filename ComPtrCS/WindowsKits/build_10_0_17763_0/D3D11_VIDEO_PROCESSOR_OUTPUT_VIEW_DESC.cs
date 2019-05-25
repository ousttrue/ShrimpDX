/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (D3D11_VPOV_DIMENSION)
    public D3D11_VPOV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(4)]
        /// (D3D11_TEX2D_VPOV)
        public D3D11_TEX2D_VPOV Texture2D;

        [FieldOffset(4)]
        /// (D3D11_TEX2D_ARRAY_VPOV)
        public D3D11_TEX2D_ARRAY_VPOV Texture2DArray;

    #endregion

}
}
