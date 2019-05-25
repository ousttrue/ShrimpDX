/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=3)]
public class IDWriteGlyphRunAnalysis : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("7d97dbf7-e085-42d4-81e3-6a883bded118");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteGlyphRunAnalysis>.Value;
    public HRESULT GetAlphaTextureBounds(
        /// textureType: (DWRITE_TEXTURE_TYPE)
        DWRITE_TEXTURE_TYPE textureType
        /// textureBounds: (*(RECT))
        , ref RECT textureBounds
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (GetAlphaTextureBoundsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaTextureBoundsFunc));
        return callback(Self, textureType, ref textureBounds);
    }
    delegate HRESULT GetAlphaTextureBoundsFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, ref RECT textureBounds);
    public HRESULT CreateAlphaTexture(
        /// textureType: (DWRITE_TEXTURE_TYPE)
        DWRITE_TEXTURE_TYPE textureType
        /// textureBounds: (*(const RECT))
        , ref RECT textureBounds
        /// alphaValues: (*(BYTE))
        , ref Byte alphaValues
        /// bufferSize: (UINT32)
        , UInt32 bufferSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateAlphaTextureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateAlphaTextureFunc));
        return callback(Self, textureType, ref textureBounds, ref alphaValues, bufferSize);
    }
    delegate HRESULT CreateAlphaTextureFunc(IntPtr self, DWRITE_TEXTURE_TYPE textureType, ref RECT textureBounds, ref Byte alphaValues, UInt32 bufferSize);
    public HRESULT GetAlphaBlendParams(
        /// renderingParams: (*(IDWriteRenderingParams))
        IntPtr renderingParams
        /// blendGamma: (*(FLOAT))
        , ref Single blendGamma
        /// blendEnhancedContrast: (*(FLOAT))
        , ref Single blendEnhancedContrast
        /// blendClearTypeLevel: (*(FLOAT))
        , ref Single blendClearTypeLevel
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (GetAlphaBlendParamsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAlphaBlendParamsFunc));
        return callback(Self, renderingParams, ref blendGamma, ref blendEnhancedContrast, ref blendClearTypeLevel);
    }
    delegate HRESULT GetAlphaBlendParamsFunc(IntPtr self, IntPtr renderingParams, ref Single blendGamma, ref Single blendEnhancedContrast, ref Single blendClearTypeLevel);
}
}
