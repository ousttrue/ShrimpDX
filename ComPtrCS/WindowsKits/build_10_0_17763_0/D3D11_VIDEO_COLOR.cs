/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=16)]
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public struct D3D11_VIDEO_COLOR{
    #region union
        [FieldOffset(0)]
        /// (D3D11_VIDEO_COLOR_YCbCrA)
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr;

        [FieldOffset(0)]
        /// (D3D11_VIDEO_COLOR_RGBA)
        public D3D11_VIDEO_COLOR_RGBA RGBA;

    #endregion

}
}
