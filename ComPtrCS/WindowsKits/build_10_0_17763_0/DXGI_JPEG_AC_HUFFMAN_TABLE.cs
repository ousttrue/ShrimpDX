/// dxgitype.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=178)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_JPEG_AC_HUFFMAN_TABLE{
    /// (BYTE)[16]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public Byte[] CodeCounts;

    /// (BYTE)[162]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=162)]
    public Byte[] CodeValues;

}
}
