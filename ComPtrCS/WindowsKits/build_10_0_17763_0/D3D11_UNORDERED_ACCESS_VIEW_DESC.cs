/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=20)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_UNORDERED_ACCESS_VIEW_DESC{
    [FieldOffset(0)]
    /// (DXGI_FORMAT)
    public DXGI_FORMAT Format;

    [FieldOffset(4)]
    /// (D3D11_UAV_DIMENSION)
    public D3D11_UAV_DIMENSION ViewDimension;

    #region union
        [FieldOffset(8)]
        /// (D3D11_BUFFER_UAV)
        public D3D11_BUFFER_UAV Buffer;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_UAV)
        public D3D11_TEX1D_UAV Texture1D;

        [FieldOffset(8)]
        /// (D3D11_TEX1D_ARRAY_UAV)
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_UAV)
        public D3D11_TEX2D_UAV Texture2D;

        [FieldOffset(8)]
        /// (D3D11_TEX2D_ARRAY_UAV)
        public D3D11_TEX2D_ARRAY_UAV Texture2DArray;

        [FieldOffset(8)]
        /// (D3D11_TEX3D_UAV)
        public D3D11_TEX3D_UAV Texture3D;

    #endregion

}
}
