/// dxgi1_2.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(Size=48)]
[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
public struct DXGI_OUTDUPL_FRAME_INFO{
    /// (LARGE_INTEGER)
    public Int64 LastPresentTime;

    /// (LARGE_INTEGER)
    public Int64 LastMouseUpdateTime;

    /// (UINT)
    public UInt32 AccumulatedFrames;

    /// (BOOL)
    public Int32 RectsCoalesced;

    /// (BOOL)
    public Int32 ProtectedContentMaskedOut;

    /// (DXGI_OUTDUPL_POINTER_POSITION)
    public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;

    /// (UINT)
    public UInt32 TotalMetadataBufferSize;

    /// (UINT)
    public UInt32 PointerShapeBufferSize;

}
}
