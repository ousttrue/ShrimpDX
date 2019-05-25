/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=40)]
public class ID3D11Device : ComPtr{

    static /*readonly*/ Guid s_uuid = new Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11Device>.Value;
    public HRESULT CreateBuffer(
        /// pDesc: (*(const D3D11_BUFFER_DESC))
        ref D3D11_BUFFER_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppBuffer: (*(*(ID3D11Buffer)))
        , ref IntPtr ppBuffer
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (CreateBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBufferFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppBuffer);
    }
    delegate HRESULT CreateBufferFunc(IntPtr self, ref D3D11_BUFFER_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppBuffer);
    public HRESULT CreateTexture1D(
        /// pDesc: (*(const D3D11_TEXTURE1D_DESC))
        ref D3D11_TEXTURE1D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture1D: (*(*(ID3D11Texture1D)))
        , ref IntPtr ppTexture1D
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (CreateTexture1DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture1DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture1D);
    }
    delegate HRESULT CreateTexture1DFunc(IntPtr self, ref D3D11_TEXTURE1D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture1D);
    public HRESULT CreateTexture2D(
        /// pDesc: (*(const D3D11_TEXTURE2D_DESC))
        ref D3D11_TEXTURE2D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture2D: (*(*(ID3D11Texture2D)))
        , ref IntPtr ppTexture2D
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (CreateTexture2DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture2DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture2D);
    }
    delegate HRESULT CreateTexture2DFunc(IntPtr self, ref D3D11_TEXTURE2D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture2D);
    public HRESULT CreateTexture3D(
        /// pDesc: (*(const D3D11_TEXTURE3D_DESC))
        ref D3D11_TEXTURE3D_DESC pDesc
        /// pInitialData: (*(const D3D11_SUBRESOURCE_DATA))
        , ref D3D11_SUBRESOURCE_DATA pInitialData
        /// ppTexture3D: (*(*(ID3D11Texture3D)))
        , ref IntPtr ppTexture3D
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (CreateTexture3DFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTexture3DFunc));
        return callback(Self, ref pDesc, ref pInitialData, ref ppTexture3D);
    }
    delegate HRESULT CreateTexture3DFunc(IntPtr self, ref D3D11_TEXTURE3D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, ref IntPtr ppTexture3D);
    public HRESULT CreateShaderResourceView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_SHADER_RESOURCE_VIEW_DESC))
        , ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc
        /// ppSRView: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppSRView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (CreateShaderResourceViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateShaderResourceViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppSRView);
    }
    delegate HRESULT CreateShaderResourceViewFunc(IntPtr self, IntPtr pResource, ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc, ref IntPtr ppSRView);
    public HRESULT CreateUnorderedAccessView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_UNORDERED_ACCESS_VIEW_DESC))
        , ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc
        /// ppUAView: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUAView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (CreateUnorderedAccessViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateUnorderedAccessViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppUAView);
    }
    delegate HRESULT CreateUnorderedAccessViewFunc(IntPtr self, IntPtr pResource, ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc, ref IntPtr ppUAView);
    public HRESULT CreateRenderTargetView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_RENDER_TARGET_VIEW_DESC))
        , ref D3D11_RENDER_TARGET_VIEW_DESC pDesc
        /// ppRTView: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRTView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (CreateRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRenderTargetViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppRTView);
    }
    delegate HRESULT CreateRenderTargetViewFunc(IntPtr self, IntPtr pResource, ref D3D11_RENDER_TARGET_VIEW_DESC pDesc, ref IntPtr ppRTView);
    public HRESULT CreateDepthStencilView(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// pDesc: (*(const D3D11_DEPTH_STENCIL_VIEW_DESC))
        , ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (CreateDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDepthStencilViewFunc));
        return callback(Self, pResource, ref pDesc, ref ppDepthStencilView);
    }
    delegate HRESULT CreateDepthStencilViewFunc(IntPtr self, IntPtr pResource, ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc, ref IntPtr ppDepthStencilView);
    public HRESULT CreateInputLayout(
        /// pInputElementDescs: (*(const D3D11_INPUT_ELEMENT_DESC))
        ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs
        /// NumElements: (UINT)
        , UInt32 NumElements
        /// pShaderBytecodeWithInputSignature: (*(const void))
        , IntPtr pShaderBytecodeWithInputSignature
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        , ref IntPtr ppInputLayout
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (CreateInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateInputLayoutFunc));
        return callback(Self, ref pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ref ppInputLayout);
    }
    delegate HRESULT CreateInputLayoutFunc(IntPtr self, ref D3D11_INPUT_ELEMENT_DESC pInputElementDescs, UInt32 NumElements, IntPtr pShaderBytecodeWithInputSignature, UIntPtr BytecodeLength, ref IntPtr ppInputLayout);
    public HRESULT CreateVertexShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        , ref IntPtr ppVertexShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (CreateVertexShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateVertexShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppVertexShader);
    }
    delegate HRESULT CreateVertexShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppVertexShader);
    public HRESULT CreateGeometryShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        , ref IntPtr ppGeometryShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (CreateGeometryShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppGeometryShader);
    }
    delegate HRESULT CreateGeometryShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppGeometryShader);
    public HRESULT CreateGeometryShaderWithStreamOutput(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pSODeclaration: (*(const D3D11_SO_DECLARATION_ENTRY))
        , ref D3D11_SO_DECLARATION_ENTRY pSODeclaration
        /// NumEntries: (UINT)
        , UInt32 NumEntries
        /// pBufferStrides: (*(const UINT))
        , ref UInt32 pBufferStrides
        /// NumStrides: (UINT)
        , UInt32 NumStrides
        /// RasterizedStream: (UINT)
        , UInt32 RasterizedStream
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        , ref IntPtr ppGeometryShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (CreateGeometryShaderWithStreamOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGeometryShaderWithStreamOutputFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, ref pSODeclaration, NumEntries, ref pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ref ppGeometryShader);
    }
    delegate HRESULT CreateGeometryShaderWithStreamOutputFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, ref D3D11_SO_DECLARATION_ENTRY pSODeclaration, UInt32 NumEntries, ref UInt32 pBufferStrides, UInt32 NumStrides, UInt32 RasterizedStream, IntPtr pClassLinkage, ref IntPtr ppGeometryShader);
    public HRESULT CreatePixelShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        , ref IntPtr ppPixelShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (CreatePixelShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePixelShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppPixelShader);
    }
    delegate HRESULT CreatePixelShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppPixelShader);
    public HRESULT CreateHullShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppHullShader: (*(*(ID3D11HullShader)))
        , ref IntPtr ppHullShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (CreateHullShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateHullShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppHullShader);
    }
    delegate HRESULT CreateHullShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppHullShader);
    public HRESULT CreateDomainShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        , ref IntPtr ppDomainShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (CreateDomainShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDomainShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppDomainShader);
    }
    delegate HRESULT CreateDomainShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppDomainShader);
    public HRESULT CreateComputeShader(
        /// pShaderBytecode: (*(const void))
        IntPtr pShaderBytecode
        /// BytecodeLength: (SIZE_T)
        , UIntPtr BytecodeLength
        /// pClassLinkage: (*(ID3D11ClassLinkage))
        , IntPtr pClassLinkage
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        , ref IntPtr ppComputeShader
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (CreateComputeShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateComputeShaderFunc));
        return callback(Self, pShaderBytecode, BytecodeLength, pClassLinkage, ref ppComputeShader);
    }
    delegate HRESULT CreateComputeShaderFunc(IntPtr self, IntPtr pShaderBytecode, UIntPtr BytecodeLength, IntPtr pClassLinkage, ref IntPtr ppComputeShader);
    public HRESULT CreateClassLinkage(
        /// ppLinkage: (*(*(ID3D11ClassLinkage)))
        ref IntPtr ppLinkage
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (CreateClassLinkageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassLinkageFunc));
        return callback(Self, ref ppLinkage);
    }
    delegate HRESULT CreateClassLinkageFunc(IntPtr self, ref IntPtr ppLinkage);
    public HRESULT CreateBlendState(
        /// pBlendStateDesc: (*(const D3D11_BLEND_DESC))
        ref D3D11_BLEND_DESC pBlendStateDesc
        /// ppBlendState: (*(*(ID3D11BlendState)))
        , ref IntPtr ppBlendState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (CreateBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBlendStateFunc));
        return callback(Self, ref pBlendStateDesc, ref ppBlendState);
    }
    delegate HRESULT CreateBlendStateFunc(IntPtr self, ref D3D11_BLEND_DESC pBlendStateDesc, ref IntPtr ppBlendState);
    public HRESULT CreateDepthStencilState(
        /// pDepthStencilDesc: (*(const D3D11_DEPTH_STENCIL_DESC))
        ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        , ref IntPtr ppDepthStencilState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (CreateDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDepthStencilStateFunc));
        return callback(Self, ref pDepthStencilDesc, ref ppDepthStencilState);
    }
    delegate HRESULT CreateDepthStencilStateFunc(IntPtr self, ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, ref IntPtr ppDepthStencilState);
    public HRESULT CreateRasterizerState(
        /// pRasterizerDesc: (*(const D3D11_RASTERIZER_DESC))
        ref D3D11_RASTERIZER_DESC pRasterizerDesc
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        , ref IntPtr ppRasterizerState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (CreateRasterizerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRasterizerStateFunc));
        return callback(Self, ref pRasterizerDesc, ref ppRasterizerState);
    }
    delegate HRESULT CreateRasterizerStateFunc(IntPtr self, ref D3D11_RASTERIZER_DESC pRasterizerDesc, ref IntPtr ppRasterizerState);
    public HRESULT CreateSamplerState(
        /// pSamplerDesc: (*(const D3D11_SAMPLER_DESC))
        ref D3D11_SAMPLER_DESC pSamplerDesc
        /// ppSamplerState: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplerState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (CreateSamplerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSamplerStateFunc));
        return callback(Self, ref pSamplerDesc, ref ppSamplerState);
    }
    delegate HRESULT CreateSamplerStateFunc(IntPtr self, ref D3D11_SAMPLER_DESC pSamplerDesc, ref IntPtr ppSamplerState);
    public HRESULT CreateQuery(
        /// pQueryDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pQueryDesc
        /// ppQuery: (*(*(ID3D11Query)))
        , ref IntPtr ppQuery
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (CreateQueryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateQueryFunc));
        return callback(Self, ref pQueryDesc, ref ppQuery);
    }
    delegate HRESULT CreateQueryFunc(IntPtr self, ref D3D11_QUERY_DESC pQueryDesc, ref IntPtr ppQuery);
    public HRESULT CreatePredicate(
        /// pPredicateDesc: (*(const D3D11_QUERY_DESC))
        ref D3D11_QUERY_DESC pPredicateDesc
        /// ppPredicate: (*(*(ID3D11Predicate)))
        , ref IntPtr ppPredicate
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (CreatePredicateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePredicateFunc));
        return callback(Self, ref pPredicateDesc, ref ppPredicate);
    }
    delegate HRESULT CreatePredicateFunc(IntPtr self, ref D3D11_QUERY_DESC pPredicateDesc, ref IntPtr ppPredicate);
    public HRESULT CreateCounter(
        /// pCounterDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pCounterDesc
        /// ppCounter: (*(*(ID3D11Counter)))
        , ref IntPtr ppCounter
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (CreateCounterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCounterFunc));
        return callback(Self, ref pCounterDesc, ref ppCounter);
    }
    delegate HRESULT CreateCounterFunc(IntPtr self, ref D3D11_COUNTER_DESC pCounterDesc, ref IntPtr ppCounter);
    public HRESULT CreateDeferredContext(
        /// ContextFlags: (UINT)
        UInt32 ContextFlags
        /// ppDeferredContext: (*(*(ID3D11DeviceContext)))
        , ref IntPtr ppDeferredContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (CreateDeferredContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDeferredContextFunc));
        return callback(Self, ContextFlags, ref ppDeferredContext);
    }
    delegate HRESULT CreateDeferredContextFunc(IntPtr self, UInt32 ContextFlags, ref IntPtr ppDeferredContext);
    public HRESULT OpenSharedResource(
        /// hResource: (HANDLE)
        IntPtr hResource
        /// ReturnedInterface: (&(const IID))
        , ref Guid ReturnedInterface
        /// ppResource: (*(*(void)))
        , ref IntPtr ppResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (OpenSharedResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenSharedResourceFunc));
        return callback(Self, hResource, ref ReturnedInterface, ref ppResource);
    }
    delegate HRESULT OpenSharedResourceFunc(IntPtr self, IntPtr hResource, ref Guid ReturnedInterface, ref IntPtr ppResource);
    public HRESULT CheckFormatSupport(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// pFormatSupport: (*(UINT))
        , ref UInt32 pFormatSupport
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (CheckFormatSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckFormatSupportFunc));
        return callback(Self, Format, ref pFormatSupport);
    }
    delegate HRESULT CheckFormatSupportFunc(IntPtr self, DXGI_FORMAT Format, ref UInt32 pFormatSupport);
    public HRESULT CheckMultisampleQualityLevels(
        /// Format: (DXGI_FORMAT)
        DXGI_FORMAT Format
        /// SampleCount: (UINT)
        , UInt32 SampleCount
        /// pNumQualityLevels: (*(UINT))
        , ref UInt32 pNumQualityLevels
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (CheckMultisampleQualityLevelsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckMultisampleQualityLevelsFunc));
        return callback(Self, Format, SampleCount, ref pNumQualityLevels);
    }
    delegate HRESULT CheckMultisampleQualityLevelsFunc(IntPtr self, DXGI_FORMAT Format, UInt32 SampleCount, ref UInt32 pNumQualityLevels);
    public void CheckCounterInfo(
        /// pCounterInfo: (*(D3D11_COUNTER_INFO))
        ref D3D11_COUNTER_INFO pCounterInfo
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (CheckCounterInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCounterInfoFunc));
        callback(Self, ref pCounterInfo);
    }
    delegate void CheckCounterInfoFunc(IntPtr self, ref D3D11_COUNTER_INFO pCounterInfo);
    public HRESULT CheckCounter(
        /// pDesc: (*(const D3D11_COUNTER_DESC))
        ref D3D11_COUNTER_DESC pDesc
        /// pType: (*(D3D11_COUNTER_TYPE))
        , ref D3D11_COUNTER_TYPE pType
        /// pActiveCounters: (*(UINT))
        , ref UInt32 pActiveCounters
        /// szName: (LPSTR)
        , IntPtr szName
        /// pNameLength: (*(UINT))
        , ref UInt32 pNameLength
        /// szUnits: (LPSTR)
        , IntPtr szUnits
        /// pUnitsLength: (*(UINT))
        , ref UInt32 pUnitsLength
        /// szDescription: (LPSTR)
        , IntPtr szDescription
        /// pDescriptionLength: (*(UINT))
        , ref UInt32 pDescriptionLength
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (CheckCounterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckCounterFunc));
        return callback(Self, ref pDesc, ref pType, ref pActiveCounters, szName, ref pNameLength, szUnits, ref pUnitsLength, szDescription, ref pDescriptionLength);
    }
    delegate HRESULT CheckCounterFunc(IntPtr self, ref D3D11_COUNTER_DESC pDesc, ref D3D11_COUNTER_TYPE pType, ref UInt32 pActiveCounters, IntPtr szName, ref UInt32 pNameLength, IntPtr szUnits, ref UInt32 pUnitsLength, IntPtr szDescription, ref UInt32 pDescriptionLength);
    public HRESULT CheckFeatureSupport(
        /// Feature: (D3D11_FEATURE)
        D3D11_FEATURE Feature
        /// pFeatureSupportData: (*(void))
        , IntPtr pFeatureSupportData
        /// FeatureSupportDataSize: (UINT)
        , UInt32 FeatureSupportDataSize
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (CheckFeatureSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckFeatureSupportFunc));
        return callback(Self, Feature, pFeatureSupportData, FeatureSupportDataSize);
    }
    delegate HRESULT CheckFeatureSupportFunc(IntPtr self, D3D11_FEATURE Feature, IntPtr pFeatureSupportData, UInt32 FeatureSupportDataSize);
    public HRESULT GetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pDataSize: (*(UINT))
        , ref UInt32 pDataSize
        /// pData: (*(void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
        return callback(Self, ref guid, ref pDataSize, pData);
    }
    delegate HRESULT GetPrivateDataFunc(IntPtr self, ref Guid guid, ref UInt32 pDataSize, IntPtr pData);
    public HRESULT SetPrivateData(
        /// guid: (&(const GUID))
        ref Guid guid
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// pData: (*(const void))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
        return callback(Self, ref guid, DataSize, pData);
    }
    delegate HRESULT SetPrivateDataFunc(IntPtr self, ref Guid guid, UInt32 DataSize, IntPtr pData);
    public HRESULT SetPrivateDataInterface(
        /// guid: (&(const GUID))
        ref Guid guid
        /// pData: (*(const IUnknown))
        , IntPtr pData
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
        return callback(Self, ref guid, pData);
    }
    delegate HRESULT SetPrivateDataInterfaceFunc(IntPtr self, ref Guid guid, IntPtr pData);
    public D3D_FEATURE_LEVEL GetFeatureLevel(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (GetFeatureLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFeatureLevelFunc));
        return callback(Self);
    }
    delegate D3D_FEATURE_LEVEL GetFeatureLevelFunc(IntPtr self);
    public UInt32 GetCreationFlags(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 35);
        var callback = (GetCreationFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCreationFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetCreationFlagsFunc(IntPtr self);
    public HRESULT GetDeviceRemovedReason(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 36);
        var callback = (GetDeviceRemovedReasonFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceRemovedReasonFunc));
        return callback(Self);
    }
    delegate HRESULT GetDeviceRemovedReasonFunc(IntPtr self);
    public void GetImmediateContext(
        /// ppImmediateContext: (*(*(ID3D11DeviceContext)))
        ref IntPtr ppImmediateContext
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 37);
        var callback = (GetImmediateContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetImmediateContextFunc));
        callback(Self, ref ppImmediateContext);
    }
    delegate void GetImmediateContextFunc(IntPtr self, ref IntPtr ppImmediateContext);
    public HRESULT SetExceptionMode(
        /// RaiseFlags: (UINT)
        UInt32 RaiseFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 38);
        var callback = (SetExceptionModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExceptionModeFunc));
        return callback(Self, RaiseFlags);
    }
    delegate HRESULT SetExceptionModeFunc(IntPtr self, UInt32 RaiseFlags);
    public UInt32 GetExceptionMode(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 39);
        var callback = (GetExceptionModeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExceptionModeFunc));
        return callback(Self);
    }
    delegate UInt32 GetExceptionModeFunc(IntPtr self);
}
}
