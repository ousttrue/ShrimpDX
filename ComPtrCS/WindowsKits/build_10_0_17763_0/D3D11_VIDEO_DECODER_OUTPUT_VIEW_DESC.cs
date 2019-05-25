/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC{
    [FieldOffset(0)]
    /// (GUID)
    public Guid DecodeProfile;

    [FieldOffset(4)]
    /// (D3D11_VDOV_DIMENSION)
    public D3D11_VDOV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_TEX2D_VDOV)
        public D3D11_TEX2D_VDOV Texture2D;

    #endregion

}
}
