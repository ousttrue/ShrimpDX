/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteLocalFontFileLoader: IDWriteFontFileLoader {

    static /*readonly*/ Guid s_uuid = new Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteLocalFontFileLoader>.Value;
    public HRESULT GetFilePathLengthFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// filePathLength: (*(UINT32))
        , ref UInt32 filePathLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetFilePathLengthFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathLengthFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref filePathLength);
    }
    delegate HRESULT GetFilePathLengthFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref UInt32 filePathLength);
    public HRESULT GetFilePathFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// filePath: (*(WCHAR))
        , [MarshalAs(UnmanagedType.LPWStr)]string filePath
        /// filePathSize: (UINT32)
        , UInt32 filePathSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetFilePathFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFilePathFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
    }
    delegate HRESULT GetFilePathFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, [MarshalAs(UnmanagedType.LPWStr)]string filePath, UInt32 filePathSize);
    public HRESULT GetLastWriteTimeFromKey(
        /// fontFileReferenceKey: (*(const void))
        IntPtr fontFileReferenceKey
        /// fontFileReferenceKeySize: (UINT32)
        , UInt32 fontFileReferenceKeySize
        /// lastWriteTime: (*(FILETIME))
        , ref FILETIME lastWriteTime
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetLastWriteTimeFromKeyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastWriteTimeFromKeyFunc));
        return callback(Self, fontFileReferenceKey, fontFileReferenceKeySize, ref lastWriteTime);
    }
    delegate HRESULT GetLastWriteTimeFromKeyFunc(IntPtr self, IntPtr fontFileReferenceKey, UInt32 fontFileReferenceKeySize, ref FILETIME lastWriteTime);
}
}
