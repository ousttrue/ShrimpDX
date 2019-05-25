/// d2d1_1.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=10)]
public class ID2D1Factory1: ID2D1Factory {

    static /*readonly*/ Guid s_uuid = new Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID2D1Factory1>.Value;
    public HRESULT CreateDevice(
        /// dxgiDevice: (*(IDXGIDevice))
        IntPtr dxgiDevice
        /// d2dDevice: (*(*(ID2D1Device)))
        , ref IntPtr d2dDevice
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateDeviceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeviceFunc));
        return callback(Self, dxgiDevice, ref d2dDevice);
    }
    delegate HRESULT CreateDeviceFunc(IntPtr self, IntPtr dxgiDevice, ref IntPtr d2dDevice);
    public HRESULT CreateStrokeStyle(
        /// strokeStyleProperties: (*(const D2D1_STROKE_STYLE_PROPERTIES1))
        ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties
        /// dashes: (*(const FLOAT))
        , ref Single dashes
        /// dashesCount: (UINT32)
        , UInt32 dashesCount
        /// strokeStyle: (*(*(ID2D1StrokeStyle1)))
        , ref IntPtr strokeStyle
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateStrokeStyleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStrokeStyleFunc));
        return callback(Self, ref strokeStyleProperties, ref dashes, dashesCount, ref strokeStyle);
    }
    delegate HRESULT CreateStrokeStyleFunc(IntPtr self, ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, ref Single dashes, UInt32 dashesCount, ref IntPtr strokeStyle);
    public HRESULT CreatePathGeometry(
        /// pathGeometry: (*(*(ID2D1PathGeometry1)))
        ref IntPtr pathGeometry
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreatePathGeometryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePathGeometryFunc));
        return callback(Self, ref pathGeometry);
    }
    delegate HRESULT CreatePathGeometryFunc(IntPtr self, ref IntPtr pathGeometry);
    public HRESULT CreateDrawingStateBlock(
        /// drawingStateDescription: (*(const D2D1_DRAWING_STATE_DESCRIPTION1))
        ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription
        /// textRenderingParams: (*(IDWriteRenderingParams))
        , IntPtr textRenderingParams
        /// drawingStateBlock: (*(*(ID2D1DrawingStateBlock1)))
        , ref IntPtr drawingStateBlock
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateDrawingStateBlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDrawingStateBlockFunc));
        return callback(Self, ref drawingStateDescription, textRenderingParams, ref drawingStateBlock);
    }
    delegate HRESULT CreateDrawingStateBlockFunc(IntPtr self, ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription, IntPtr textRenderingParams, ref IntPtr drawingStateBlock);
    public HRESULT CreateGdiMetafile(
        /// metafileStream: (*(IStream))
        IntPtr metafileStream
        /// metafile: (*(*(ID2D1GdiMetafile)))
        , ref IntPtr metafile
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateGdiMetafileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGdiMetafileFunc));
        return callback(Self, metafileStream, ref metafile);
    }
    delegate HRESULT CreateGdiMetafileFunc(IntPtr self, IntPtr metafileStream, ref IntPtr metafile);
    public HRESULT RegisterEffectFromStream(
        /// classId: (&(const IID))
        ref Guid classId
        /// propertyXml: (*(IStream))
        , IntPtr propertyXml
        /// bindings: (*(const D2D1_PROPERTY_BINDING))
        , ref D2D1_PROPERTY_BINDING bindings
        /// bindingsCount: (UINT32)
        , UInt32 bindingsCount
        /// effectFactory: (const PD2D1_EFFECT_FACTORY)
        , IntPtr effectFactory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (RegisterEffectFromStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStreamFunc));
        return callback(Self, ref classId, propertyXml, ref bindings, bindingsCount, effectFactory);
    }
    delegate HRESULT RegisterEffectFromStreamFunc(IntPtr self, ref Guid classId, IntPtr propertyXml, ref D2D1_PROPERTY_BINDING bindings, UInt32 bindingsCount, IntPtr effectFactory);
    public HRESULT RegisterEffectFromString(
        /// classId: (&(const IID))
        ref Guid classId
        /// propertyXml: (PCWSTR)
        , IntPtr propertyXml
        /// bindings: (*(const D2D1_PROPERTY_BINDING))
        , ref D2D1_PROPERTY_BINDING bindings
        /// bindingsCount: (UINT32)
        , UInt32 bindingsCount
        /// effectFactory: (const PD2D1_EFFECT_FACTORY)
        , IntPtr effectFactory
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (RegisterEffectFromStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterEffectFromStringFunc));
        return callback(Self, ref classId, propertyXml, ref bindings, bindingsCount, effectFactory);
    }
    delegate HRESULT RegisterEffectFromStringFunc(IntPtr self, ref Guid classId, IntPtr propertyXml, ref D2D1_PROPERTY_BINDING bindings, UInt32 bindingsCount, IntPtr effectFactory);
    public HRESULT UnregisterEffect(
        /// classId: (&(const IID))
        ref Guid classId
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (UnregisterEffectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterEffectFunc));
        return callback(Self, ref classId);
    }
    delegate HRESULT UnregisterEffectFunc(IntPtr self, ref Guid classId);
    public HRESULT GetRegisteredEffects(
        /// effects: (*(CLSID))
        ref Guid effects
        /// effectsCount: (UINT32)
        , UInt32 effectsCount
        /// effectsReturned: (*(UINT32))
        , ref UInt32 effectsReturned
        /// effectsRegistered: (*(UINT32))
        , ref UInt32 effectsRegistered
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (GetRegisteredEffectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRegisteredEffectsFunc));
        return callback(Self, ref effects, effectsCount, ref effectsReturned, ref effectsRegistered);
    }
    delegate HRESULT GetRegisteredEffectsFunc(IntPtr self, ref Guid effects, UInt32 effectsCount, ref UInt32 effectsReturned, ref UInt32 effectsRegistered);
    public HRESULT GetEffectProperties(
        /// effectId: (&(const IID))
        ref Guid effectId
        /// properties: (*(*(ID2D1Properties)))
        , ref IntPtr properties
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (GetEffectPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEffectPropertiesFunc));
        return callback(Self, ref effectId, ref properties);
    }
    delegate HRESULT GetEffectPropertiesFunc(IntPtr self, ref Guid effectId, ref IntPtr properties);
}
}
