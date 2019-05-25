/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_SHADER_RESOURCE_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_SRV_DIMENSION)
    public D3D_SRV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_SRV)
        public D3D11_BUFFER_SRV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_SRV)
        public D3D11_TEX1D_SRV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_SRV)
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_SRV)
        public D3D11_TEX2D_SRV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_SRV)
        public D3D11_TEX2D_ARRAY_SRV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_SRV)
        public D3D11_TEX2DMS_SRV Texture2DMS;

        [FieldOffset(8)]
        /// (D3D11_TEX2DMS_ARRAY_SRV)
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_SRV)
        public D3D11_TEX3D_SRV Texture3D;

        [FieldOffset(8)]
        /// (D3D11_TEXCUBE_SRV)
        public D3D11_TEXCUBE_SRV TextureCube;

        [FieldOffset(8)]
        /// (D3D11_TEXCUBE_ARRAY_SRV)
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;

        [FieldOffset(8)]
        /// (D3D11_BUFFEREX_SRV)
        public D3D11_BUFFEREX_SRV BufferEx;

    #endregion

}
}
