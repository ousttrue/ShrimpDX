/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_RENDER_TARGET_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_RTV_DIMENSION)
    public D3D11_RTV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_RTV)
        public D3D11_BUFFER_RTV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_RTV)
        public D3D11_TEX1D_RTV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_RTV)
        public D3D11_TEX1D_ARRAY_RTV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_RTV)
        public D3D11_TEX2D_RTV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_RTV)
        public D3D11_TEX2D_ARRAY_RTV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_RTV)
        public D3D11_TEX2DMS_RTV Texture2DMS;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_ARRAY_RTV)
        public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_RTV)
        public D3D11_TEX3D_RTV Texture3D;

    #endregion

}
}
