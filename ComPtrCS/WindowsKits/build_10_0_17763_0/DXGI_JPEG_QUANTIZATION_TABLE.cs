/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=64)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_QUANTIZATION_TABLE{
    /// (BYTE)[64]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=64)]
    public Byte[] Elements;

}
}
