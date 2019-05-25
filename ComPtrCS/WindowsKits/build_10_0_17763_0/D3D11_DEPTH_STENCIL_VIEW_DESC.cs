/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_DEPTH_STENCIL_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_DSV_DIMENSION)
    public D3D11_DSV_DIMENSION ViewDimension;

    [FieldOffset(8)]
    /// (UINT)
    public UInt32 Flags;

    #region union
        [FieldOffset(12)]
        /// (D3D11_TEX1D_DSV)
        public D3D11_TEX1D_DSV Texture1D;

        [FieldOffset(12)]
        /// (D3D11_TEX1D_ARRAY_DSV)
        public D3D11_TEX1D_ARRAY_DSV Texture1DArray;

        [FieldOffset(12)]
        /// (D3D11_TEX2D_DSV)
        public D3D11_TEX2D_DSV Texture2D;

        [FieldOffset(12)]
        /// (D3D11_TEX2D_ARRAY_DSV)
        public D3D11_TEX2D_ARRAY_DSV Texture2DArray;

        [FieldOffset(12)]
        /// (D3D11_TEX2DMS_DSV)
        public D3D11_TEX2DMS_DSV Texture2DMS;

        [FieldOffset(12)]
        /// (D3D11_TEX2DMS_ARRAY_DSV)
        public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;

    #endregion

}
}
