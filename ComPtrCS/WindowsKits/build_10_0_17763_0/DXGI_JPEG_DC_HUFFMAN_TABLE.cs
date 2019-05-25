/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=24)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_DC_HUFFMAN_TABLE{
    /// (BYTE)[12]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]
    public Byte[] CodeCounts;

    /// (BYTE)[12]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=12)]
    public Byte[] CodeValues;

}
}
