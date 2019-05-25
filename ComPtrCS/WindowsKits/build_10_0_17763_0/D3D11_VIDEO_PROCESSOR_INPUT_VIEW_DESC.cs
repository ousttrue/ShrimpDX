/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (UINT)
    public UInt32 FourCC;

    [FieldOffset(4)]
    /// (D3D11_VPIV_DIMENSION)
    public D3D11_VPIV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_TEX2D_VPIV)
        public D3D11_TEX2D_VPIV Texture2D;

    #endregion

}
}
