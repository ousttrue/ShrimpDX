/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=11)]
public class ID2D1Properties : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Properties>.Value;
    public UInt32 GetPropertyCount(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetPropertyCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyCountFunc));
        return callback(Self);
    }
    delegate UInt32 GetPropertyCountFunc(IntPtr self);
    public HRESULT GetPropertyName(
        /// index: (UINT32)
        UInt32 index
        /// name: (PWSTR)
        , IntPtr name
        /// nameCount: (UINT32)
        , UInt32 nameCount
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (GetPropertyNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyNameFunc));
        return callback(Self, index, name, nameCount);
    }
    delegate HRESULT GetPropertyNameFunc(IntPtr self, UInt32 index, IntPtr name, UInt32 nameCount);
    public UInt32 GetPropertyNameLength(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetPropertyNameLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyNameLengthFunc));
        return callback(Self, index);
    }
    delegate UInt32 GetPropertyNameLengthFunc(IntPtr self, UInt32 index);
    public D2D1_PROPERTY_TYPE GetType(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        return callback(Self, index);
    }
    delegate D2D1_PROPERTY_TYPE GetTypeFunc(IntPtr self, UInt32 index);
    public UInt32 GetPropertyIndex(
        /// name: (PCWSTR)
        IntPtr name
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (GetPropertyIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyIndexFunc));
        return callback(Self, name);
    }
    delegate UInt32 GetPropertyIndexFunc(IntPtr self, IntPtr name);
    public HRESULT SetValueByName(
        /// name: (PCWSTR)
        IntPtr name
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(const BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (SetValueByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetValueByNameFunc));
        return callback(Self, name, type, ref data, dataSize);
    }
    delegate HRESULT SetValueByNameFunc(IntPtr self, IntPtr name, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT SetValue(
        /// index: (UINT32)
        UInt32 index
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(const BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (SetValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetValueFunc));
        return callback(Self, index, type, ref data, dataSize);
    }
    delegate HRESULT SetValueFunc(IntPtr self, UInt32 index, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT GetValueByName(
        /// name: (PCWSTR)
        IntPtr name
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (GetValueByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueByNameFunc));
        return callback(Self, name, type, ref data, dataSize);
    }
    delegate HRESULT GetValueByNameFunc(IntPtr self, IntPtr name, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public HRESULT GetValue(
        /// index: (UINT32)
        UInt32 index
        /// type: (D2D1_PROPERTY_TYPE)
        , D2D1_PROPERTY_TYPE type
        /// data: (*(BYTE))
        , ref Byte data
        /// dataSize: (UINT32)
        , UInt32 dataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetValueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueFunc));
        return callback(Self, index, type, ref data, dataSize);
    }
    delegate HRESULT GetValueFunc(IntPtr self, UInt32 index, D2D1_PROPERTY_TYPE type, ref Byte data, UInt32 dataSize);
    public UInt32 GetValueSize(
        /// index: (UINT32)
        UInt32 index
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetValueSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetValueSizeFunc));
        return callback(Self, index);
    }
    delegate UInt32 GetValueSizeFunc(IntPtr self, UInt32 index);
    public HRESULT GetSubProperties(
        /// index: (UINT32)
        UInt32 index
        /// subProperties: (*(*(ID2D1Properties)))
        , ref IntPtr subProperties
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (GetSubPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSubPropertiesFunc));
        return callback(Self, index, ref subProperties);
    }
    delegate HRESULT GetSubPropertiesFunc(IntPtr self, UInt32 index, ref IntPtr subProperties);
}
}
