/// d3d11.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=108)]
public class ID3D11DeviceContext: ID3D11DeviceChild {

    static /*readonly*/ Guid s_uuid = new Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<ID3D11DeviceContext>.Value;
    public void VSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (VSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void VSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void PSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (PSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void PSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void PSSetShader(
        /// pPixelShader: (*(ID3D11PixelShader))
        IntPtr pPixelShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (PSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetShaderFunc));
        callback(Self, pPixelShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void PSSetShaderFunc(IntPtr self, IntPtr pPixelShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void PSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (PSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void PSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void VSSetShader(
        /// pVertexShader: (*(ID3D11VertexShader))
        IntPtr pVertexShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 4);
        var callback = (VSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetShaderFunc));
        callback(Self, pVertexShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void VSSetShaderFunc(IntPtr self, IntPtr pVertexShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void DrawIndexed(
        /// IndexCount: (UINT)
        UInt32 IndexCount
        /// StartIndexLocation: (UINT)
        , UInt32 StartIndexLocation
        /// BaseVertexLocation: (INT)
        , Int32 BaseVertexLocation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 5);
        var callback = (DrawIndexedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedFunc));
        callback(Self, IndexCount, StartIndexLocation, BaseVertexLocation);
    }
    delegate void DrawIndexedFunc(IntPtr self, UInt32 IndexCount, UInt32 StartIndexLocation, Int32 BaseVertexLocation);
    public void Draw(
        /// VertexCount: (UINT)
        UInt32 VertexCount
        /// StartVertexLocation: (UINT)
        , UInt32 StartVertexLocation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 6);
        var callback = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
        callback(Self, VertexCount, StartVertexLocation);
    }
    delegate void DrawFunc(IntPtr self, UInt32 VertexCount, UInt32 StartVertexLocation);
    public HRESULT Map(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// Subresource: (UINT)
        , UInt32 Subresource
        /// MapType: (D3D11_MAP)
        , D3D11_MAP MapType
        /// MapFlags: (UINT)
        , UInt32 MapFlags
        /// pMappedResource: (*(D3D11_MAPPED_SUBRESOURCE))
        , ref D3D11_MAPPED_SUBRESOURCE pMappedResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 7);
        var callback = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
        return callback(Self, pResource, Subresource, MapType, MapFlags, ref pMappedResource);
    }
    delegate HRESULT MapFunc(IntPtr self, IntPtr pResource, UInt32 Subresource, D3D11_MAP MapType, UInt32 MapFlags, ref D3D11_MAPPED_SUBRESOURCE pMappedResource);
    public void Unmap(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// Subresource: (UINT)
        , UInt32 Subresource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 8);
        var callback = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
        callback(Self, pResource, Subresource);
    }
    delegate void UnmapFunc(IntPtr self, IntPtr pResource, UInt32 Subresource);
    public void PSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 9);
        var callback = (PSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void PSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void IASetInputLayout(
        /// pInputLayout: (*(ID3D11InputLayout))
        IntPtr pInputLayout
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 10);
        var callback = (IASetInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetInputLayoutFunc));
        callback(Self, pInputLayout);
    }
    delegate void IASetInputLayoutFunc(IntPtr self, IntPtr pInputLayout);
    public void IASetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppVertexBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppVertexBuffers
        /// pStrides: (*(const UINT))
        , ref UInt32 pStrides
        /// pOffsets: (*(const UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 11);
        var callback = (IASetVertexBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetVertexBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides, ref pOffsets);
    }
    delegate void IASetVertexBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppVertexBuffers, ref UInt32 pStrides, ref UInt32 pOffsets);
    public void IASetIndexBuffer(
        /// pIndexBuffer: (*(ID3D11Buffer))
        IntPtr pIndexBuffer
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
        /// Offset: (UINT)
        , UInt32 Offset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 12);
        var callback = (IASetIndexBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetIndexBufferFunc));
        callback(Self, pIndexBuffer, Format, Offset);
    }
    delegate void IASetIndexBufferFunc(IntPtr self, IntPtr pIndexBuffer, DXGI_FORMAT Format, UInt32 Offset);
    public void DrawIndexedInstanced(
        /// IndexCountPerInstance: (UINT)
        UInt32 IndexCountPerInstance
        /// InstanceCount: (UINT)
        , UInt32 InstanceCount
        /// StartIndexLocation: (UINT)
        , UInt32 StartIndexLocation
        /// BaseVertexLocation: (INT)
        , Int32 BaseVertexLocation
        /// StartInstanceLocation: (UINT)
        , UInt32 StartInstanceLocation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 13);
        var callback = (DrawIndexedInstancedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedInstancedFunc));
        callback(Self, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }
    delegate void DrawIndexedInstancedFunc(IntPtr self, UInt32 IndexCountPerInstance, UInt32 InstanceCount, UInt32 StartIndexLocation, Int32 BaseVertexLocation, UInt32 StartInstanceLocation);
    public void DrawInstanced(
        /// VertexCountPerInstance: (UINT)
        UInt32 VertexCountPerInstance
        /// InstanceCount: (UINT)
        , UInt32 InstanceCount
        /// StartVertexLocation: (UINT)
        , UInt32 StartVertexLocation
        /// StartInstanceLocation: (UINT)
        , UInt32 StartInstanceLocation
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 14);
        var callback = (DrawInstancedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInstancedFunc));
        callback(Self, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }
    delegate void DrawInstancedFunc(IntPtr self, UInt32 VertexCountPerInstance, UInt32 InstanceCount, UInt32 StartVertexLocation, UInt32 StartInstanceLocation);
    public void GSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 15);
        var callback = (GSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void GSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void GSSetShader(
        /// pShader: (*(ID3D11GeometryShader))
        IntPtr pShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 16);
        var callback = (GSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetShaderFunc));
        callback(Self, pShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void GSSetShaderFunc(IntPtr self, IntPtr pShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void IASetPrimitiveTopology(
        /// Topology: (D3D11_PRIMITIVE_TOPOLOGY)
        D3D_PRIMITIVE_TOPOLOGY Topology
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 17);
        var callback = (IASetPrimitiveTopologyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IASetPrimitiveTopologyFunc));
        callback(Self, Topology);
    }
    delegate void IASetPrimitiveTopologyFunc(IntPtr self, D3D_PRIMITIVE_TOPOLOGY Topology);
    public void VSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 18);
        var callback = (VSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void VSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void VSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 19);
        var callback = (VSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void VSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void Begin(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 20);
        var callback = (BeginFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(BeginFunc));
        callback(Self, pAsync);
    }
    delegate void BeginFunc(IntPtr self, IntPtr pAsync);
    public void End(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 21);
        var callback = (EndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EndFunc));
        callback(Self, pAsync);
    }
    delegate void EndFunc(IntPtr self, IntPtr pAsync);
    public HRESULT GetData(
        /// pAsync: (*(ID3D11Asynchronous))
        IntPtr pAsync
        /// pData: (*(void))
        , IntPtr pData
        /// DataSize: (UINT)
        , UInt32 DataSize
        /// GetDataFlags: (UINT)
        , UInt32 GetDataFlags
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 22);
        var callback = (GetDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataFunc));
        return callback(Self, pAsync, pData, DataSize, GetDataFlags);
    }
    delegate HRESULT GetDataFunc(IntPtr self, IntPtr pAsync, IntPtr pData, UInt32 DataSize, UInt32 GetDataFlags);
    public void SetPredication(
        /// pPredicate: (*(ID3D11Predicate))
        IntPtr pPredicate
        /// PredicateValue: (BOOL)
        , Int32 PredicateValue
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 23);
        var callback = (SetPredicationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPredicationFunc));
        callback(Self, pPredicate, PredicateValue);
    }
    delegate void SetPredicationFunc(IntPtr self, IntPtr pPredicate, Int32 PredicateValue);
    public void GSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 24);
        var callback = (GSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void GSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void GSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 25);
        var callback = (GSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void GSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void OMSetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        , IntPtr pDepthStencilView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 26);
        var callback = (OMSetRenderTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetRenderTargetsFunc));
        callback(Self, NumViews, ref ppRenderTargetViews, pDepthStencilView);
    }
    delegate void OMSetRenderTargetsFunc(IntPtr self, UInt32 NumViews, ref IntPtr ppRenderTargetViews, IntPtr pDepthStencilView);
    public void OMSetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs
        /// ppRenderTargetViews: (*(const *(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        , IntPtr pDepthStencilView
        /// UAVStartSlot: (UINT)
        , UInt32 UAVStartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
        /// pUAVInitialCounts: (*(const UINT))
        , ref UInt32 pUAVInitialCounts
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 27);
        var callback = (OMSetRenderTargetsAndUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetRenderTargetsAndUnorderedAccessViewsFunc));
        callback(Self, NumRTVs, ref ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }
    delegate void OMSetRenderTargetsAndUnorderedAccessViewsFunc(IntPtr self, UInt32 NumRTVs, ref IntPtr ppRenderTargetViews, IntPtr pDepthStencilView, UInt32 UAVStartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews, ref UInt32 pUAVInitialCounts);
    public void OMSetBlendState(
        /// pBlendState: (*(ID3D11BlendState))
        IntPtr pBlendState
        /// BlendFactor: (const FLOAT)[4]
        , ref Vector4 BlendFactor
        /// SampleMask: (UINT)
        , UInt32 SampleMask
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 28);
        var callback = (OMSetBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetBlendStateFunc));
        callback(Self, pBlendState, ref BlendFactor, SampleMask);
    }
    delegate void OMSetBlendStateFunc(IntPtr self, IntPtr pBlendState, ref Vector4 BlendFactor, UInt32 SampleMask);
    public void OMSetDepthStencilState(
        /// pDepthStencilState: (*(ID3D11DepthStencilState))
        IntPtr pDepthStencilState
        /// StencilRef: (UINT)
        , UInt32 StencilRef
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 29);
        var callback = (OMSetDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMSetDepthStencilStateFunc));
        callback(Self, pDepthStencilState, StencilRef);
    }
    delegate void OMSetDepthStencilStateFunc(IntPtr self, IntPtr pDepthStencilState, UInt32 StencilRef);
    public void SOSetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers
        /// ppSOTargets: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppSOTargets
        /// pOffsets: (*(const UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 30);
        var callback = (SOSetTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SOSetTargetsFunc));
        callback(Self, NumBuffers, ref ppSOTargets, ref pOffsets);
    }
    delegate void SOSetTargetsFunc(IntPtr self, UInt32 NumBuffers, ref IntPtr ppSOTargets, ref UInt32 pOffsets);
    public void DrawAuto(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 31);
        var callback = (DrawAutoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawAutoFunc));
        callback(Self);
    }
    delegate void DrawAutoFunc(IntPtr self);
    public void DrawIndexedInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 32);
        var callback = (DrawIndexedInstancedIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawIndexedInstancedIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DrawIndexedInstancedIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void DrawInstancedIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 33);
        var callback = (DrawInstancedIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInstancedIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DrawInstancedIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void Dispatch(
        /// ThreadGroupCountX: (UINT)
        UInt32 ThreadGroupCountX
        /// ThreadGroupCountY: (UINT)
        , UInt32 ThreadGroupCountY
        /// ThreadGroupCountZ: (UINT)
        , UInt32 ThreadGroupCountZ
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 34);
        var callback = (DispatchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DispatchFunc));
        callback(Self, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }
    delegate void DispatchFunc(IntPtr self, UInt32 ThreadGroupCountX, UInt32 ThreadGroupCountY, UInt32 ThreadGroupCountZ);
    public void DispatchIndirect(
        /// pBufferForArgs: (*(ID3D11Buffer))
        IntPtr pBufferForArgs
        /// AlignedByteOffsetForArgs: (UINT)
        , UInt32 AlignedByteOffsetForArgs
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 35);
        var callback = (DispatchIndirectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DispatchIndirectFunc));
        callback(Self, pBufferForArgs, AlignedByteOffsetForArgs);
    }
    delegate void DispatchIndirectFunc(IntPtr self, IntPtr pBufferForArgs, UInt32 AlignedByteOffsetForArgs);
    public void RSSetState(
        /// pRasterizerState: (*(ID3D11RasterizerState))
        IntPtr pRasterizerState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 36);
        var callback = (RSSetStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetStateFunc));
        callback(Self, pRasterizerState);
    }
    delegate void RSSetStateFunc(IntPtr self, IntPtr pRasterizerState);
    public void RSSetViewports(
        /// NumViewports: (UINT)
        UInt32 NumViewports
        /// pViewports: (*(const D3D11_VIEWPORT))
        , ref D3D11_VIEWPORT pViewports
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 37);
        var callback = (RSSetViewportsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetViewportsFunc));
        callback(Self, NumViewports, ref pViewports);
    }
    delegate void RSSetViewportsFunc(IntPtr self, UInt32 NumViewports, ref D3D11_VIEWPORT pViewports);
    public void RSSetScissorRects(
        /// NumRects: (UINT)
        UInt32 NumRects
        /// pRects: (*(const D3D11_RECT))
        , ref D3D11_RECT pRects
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 38);
        var callback = (RSSetScissorRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSSetScissorRectsFunc));
        callback(Self, NumRects, ref pRects);
    }
    delegate void RSSetScissorRectsFunc(IntPtr self, UInt32 NumRects, ref D3D11_RECT pRects);
    public void CopySubresourceRegion(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// DstX: (UINT)
        , UInt32 DstX
        /// DstY: (UINT)
        , UInt32 DstY
        /// DstZ: (UINT)
        , UInt32 DstZ
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
        /// SrcSubresource: (UINT)
        , UInt32 SrcSubresource
        /// pSrcBox: (*(const D3D11_BOX))
        , ref D3D11_BOX pSrcBox
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 39);
        var callback = (CopySubresourceRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopySubresourceRegionFunc));
        callback(Self, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, ref pSrcBox);
    }
    delegate void CopySubresourceRegionFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, UInt32 DstX, UInt32 DstY, UInt32 DstZ, IntPtr pSrcResource, UInt32 SrcSubresource, ref D3D11_BOX pSrcBox);
    public void CopyResource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 40);
        var callback = (CopyResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyResourceFunc));
        callback(Self, pDstResource, pSrcResource);
    }
    delegate void CopyResourceFunc(IntPtr self, IntPtr pDstResource, IntPtr pSrcResource);
    public void UpdateSubresource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// pDstBox: (*(const D3D11_BOX))
        , ref D3D11_BOX pDstBox
        /// pSrcData: (*(const void))
        , IntPtr pSrcData
        /// SrcRowPitch: (UINT)
        , UInt32 SrcRowPitch
        /// SrcDepthPitch: (UINT)
        , UInt32 SrcDepthPitch
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 41);
        var callback = (UpdateSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UpdateSubresourceFunc));
        callback(Self, pDstResource, DstSubresource, ref pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }
    delegate void UpdateSubresourceFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, ref D3D11_BOX pDstBox, IntPtr pSrcData, UInt32 SrcRowPitch, UInt32 SrcDepthPitch);
    public void CopyStructureCount(
        /// pDstBuffer: (*(ID3D11Buffer))
        IntPtr pDstBuffer
        /// DstAlignedByteOffset: (UINT)
        , UInt32 DstAlignedByteOffset
        /// pSrcView: (*(ID3D11UnorderedAccessView))
        , IntPtr pSrcView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 42);
        var callback = (CopyStructureCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyStructureCountFunc));
        callback(Self, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }
    delegate void CopyStructureCountFunc(IntPtr self, IntPtr pDstBuffer, UInt32 DstAlignedByteOffset, IntPtr pSrcView);
    public void ClearRenderTargetView(
        /// pRenderTargetView: (*(ID3D11RenderTargetView))
        IntPtr pRenderTargetView
        /// ColorRGBA: (const FLOAT)[4]
        , ref Vector4 ColorRGBA
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 43);
        var callback = (ClearRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearRenderTargetViewFunc));
        callback(Self, pRenderTargetView, ref ColorRGBA);
    }
    delegate void ClearRenderTargetViewFunc(IntPtr self, IntPtr pRenderTargetView, ref Vector4 ColorRGBA);
    public void ClearUnorderedAccessViewUint(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        IntPtr pUnorderedAccessView
        /// Values: (const UINT)[4]
        , ref UInt32 Values
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 44);
        var callback = (ClearUnorderedAccessViewUintFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearUnorderedAccessViewUintFunc));
        callback(Self, pUnorderedAccessView, ref Values);
    }
    delegate void ClearUnorderedAccessViewUintFunc(IntPtr self, IntPtr pUnorderedAccessView, ref UInt32 Values);
    public void ClearUnorderedAccessViewFloat(
        /// pUnorderedAccessView: (*(ID3D11UnorderedAccessView))
        IntPtr pUnorderedAccessView
        /// Values: (const FLOAT)[4]
        , ref Vector4 Values
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 45);
        var callback = (ClearUnorderedAccessViewFloatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearUnorderedAccessViewFloatFunc));
        callback(Self, pUnorderedAccessView, ref Values);
    }
    delegate void ClearUnorderedAccessViewFloatFunc(IntPtr self, IntPtr pUnorderedAccessView, ref Vector4 Values);
    public void ClearDepthStencilView(
        /// pDepthStencilView: (*(ID3D11DepthStencilView))
        IntPtr pDepthStencilView
        /// ClearFlags: (UINT)
        , UInt32 ClearFlags
        /// Depth: (FLOAT)
        , Single Depth
        /// Stencil: (UINT8)
        , Byte Stencil
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 46);
        var callback = (ClearDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearDepthStencilViewFunc));
        callback(Self, pDepthStencilView, ClearFlags, Depth, Stencil);
    }
    delegate void ClearDepthStencilViewFunc(IntPtr self, IntPtr pDepthStencilView, UInt32 ClearFlags, Single Depth, Byte Stencil);
    public void GenerateMips(
        /// pShaderResourceView: (*(ID3D11ShaderResourceView))
        IntPtr pShaderResourceView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 47);
        var callback = (GenerateMipsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GenerateMipsFunc));
        callback(Self, pShaderResourceView);
    }
    delegate void GenerateMipsFunc(IntPtr self, IntPtr pShaderResourceView);
    public void SetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
        /// MinLOD: (FLOAT)
        , Single MinLOD
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 48);
        var callback = (SetResourceMinLODFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetResourceMinLODFunc));
        callback(Self, pResource, MinLOD);
    }
    delegate void SetResourceMinLODFunc(IntPtr self, IntPtr pResource, Single MinLOD);
    public Single GetResourceMinLOD(
        /// pResource: (*(ID3D11Resource))
        IntPtr pResource
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 49);
        var callback = (GetResourceMinLODFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceMinLODFunc));
        return callback(Self, pResource);
    }
    delegate Single GetResourceMinLODFunc(IntPtr self, IntPtr pResource);
    public void ResolveSubresource(
        /// pDstResource: (*(ID3D11Resource))
        IntPtr pDstResource
        /// DstSubresource: (UINT)
        , UInt32 DstSubresource
        /// pSrcResource: (*(ID3D11Resource))
        , IntPtr pSrcResource
        /// SrcSubresource: (UINT)
        , UInt32 SrcSubresource
        /// Format: (DXGI_FORMAT)
        , DXGI_FORMAT Format
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 50);
        var callback = (ResolveSubresourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResolveSubresourceFunc));
        callback(Self, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }
    delegate void ResolveSubresourceFunc(IntPtr self, IntPtr pDstResource, UInt32 DstSubresource, IntPtr pSrcResource, UInt32 SrcSubresource, DXGI_FORMAT Format);
    public void ExecuteCommandList(
        /// pCommandList: (*(ID3D11CommandList))
        IntPtr pCommandList
        /// RestoreContextState: (BOOL)
        , Int32 RestoreContextState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 51);
        var callback = (ExecuteCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ExecuteCommandListFunc));
        callback(Self, pCommandList, RestoreContextState);
    }
    delegate void ExecuteCommandListFunc(IntPtr self, IntPtr pCommandList, Int32 RestoreContextState);
    public void HSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 52);
        var callback = (HSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void HSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void HSSetShader(
        /// pHullShader: (*(ID3D11HullShader))
        IntPtr pHullShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 53);
        var callback = (HSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetShaderFunc));
        callback(Self, pHullShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void HSSetShaderFunc(IntPtr self, IntPtr pHullShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void HSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 54);
        var callback = (HSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void HSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void HSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 55);
        var callback = (HSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void HSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void DSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 56);
        var callback = (DSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void DSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void DSSetShader(
        /// pDomainShader: (*(ID3D11DomainShader))
        IntPtr pDomainShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 57);
        var callback = (DSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetShaderFunc));
        callback(Self, pDomainShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void DSSetShaderFunc(IntPtr self, IntPtr pDomainShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void DSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 58);
        var callback = (DSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void DSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void DSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 59);
        var callback = (DSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void DSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void CSSetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(const *(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 60);
        var callback = (CSSetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void CSSetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void CSSetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(const *(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
        /// pUAVInitialCounts: (*(const UINT))
        , ref UInt32 pUAVInitialCounts
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 61);
        var callback = (CSSetUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetUnorderedAccessViewsFunc));
        callback(Self, StartSlot, NumUAVs, ref ppUnorderedAccessViews, ref pUAVInitialCounts);
    }
    delegate void CSSetUnorderedAccessViewsFunc(IntPtr self, UInt32 StartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews, ref UInt32 pUAVInitialCounts);
    public void CSSetShader(
        /// pComputeShader: (*(ID3D11ComputeShader))
        IntPtr pComputeShader
        /// ppClassInstances: (*(const *(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// NumClassInstances: (UINT)
        , UInt32 NumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 62);
        var callback = (CSSetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetShaderFunc));
        callback(Self, pComputeShader, ref ppClassInstances, NumClassInstances);
    }
    delegate void CSSetShaderFunc(IntPtr self, IntPtr pComputeShader, ref IntPtr ppClassInstances, UInt32 NumClassInstances);
    public void CSSetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(const *(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 63);
        var callback = (CSSetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void CSSetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void CSSetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(const *(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 64);
        var callback = (CSSetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSSetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void CSSetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void VSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 65);
        var callback = (VSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void VSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void PSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 66);
        var callback = (PSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void PSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void PSGetShader(
        /// ppPixelShader: (*(*(ID3D11PixelShader)))
        ref IntPtr ppPixelShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 67);
        var callback = (PSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetShaderFunc));
        callback(Self, ref ppPixelShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void PSGetShaderFunc(IntPtr self, ref IntPtr ppPixelShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void PSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 68);
        var callback = (PSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void PSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void VSGetShader(
        /// ppVertexShader: (*(*(ID3D11VertexShader)))
        ref IntPtr ppVertexShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 69);
        var callback = (VSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetShaderFunc));
        callback(Self, ref ppVertexShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void VSGetShaderFunc(IntPtr self, ref IntPtr ppVertexShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void PSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 70);
        var callback = (PSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void PSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void IAGetInputLayout(
        /// ppInputLayout: (*(*(ID3D11InputLayout)))
        ref IntPtr ppInputLayout
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 71);
        var callback = (IAGetInputLayoutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetInputLayoutFunc));
        callback(Self, ref ppInputLayout);
    }
    delegate void IAGetInputLayoutFunc(IntPtr self, ref IntPtr ppInputLayout);
    public void IAGetVertexBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppVertexBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppVertexBuffers
        /// pStrides: (*(UINT))
        , ref UInt32 pStrides
        /// pOffsets: (*(UINT))
        , ref UInt32 pOffsets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 72);
        var callback = (IAGetVertexBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetVertexBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppVertexBuffers, ref pStrides, ref pOffsets);
    }
    delegate void IAGetVertexBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppVertexBuffers, ref UInt32 pStrides, ref UInt32 pOffsets);
    public void IAGetIndexBuffer(
        /// pIndexBuffer: (*(*(ID3D11Buffer)))
        ref IntPtr pIndexBuffer
        /// Format: (*(DXGI_FORMAT))
        , ref DXGI_FORMAT Format
        /// Offset: (*(UINT))
        , ref UInt32 Offset
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 73);
        var callback = (IAGetIndexBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetIndexBufferFunc));
        callback(Self, ref pIndexBuffer, ref Format, ref Offset);
    }
    delegate void IAGetIndexBufferFunc(IntPtr self, ref IntPtr pIndexBuffer, ref DXGI_FORMAT Format, ref UInt32 Offset);
    public void GSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 74);
        var callback = (GSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void GSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void GSGetShader(
        /// ppGeometryShader: (*(*(ID3D11GeometryShader)))
        ref IntPtr ppGeometryShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 75);
        var callback = (GSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetShaderFunc));
        callback(Self, ref ppGeometryShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void GSGetShaderFunc(IntPtr self, ref IntPtr ppGeometryShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void IAGetPrimitiveTopology(
        /// pTopology: (*(D3D11_PRIMITIVE_TOPOLOGY))
        ref D3D_PRIMITIVE_TOPOLOGY pTopology
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 76);
        var callback = (IAGetPrimitiveTopologyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IAGetPrimitiveTopologyFunc));
        callback(Self, ref pTopology);
    }
    delegate void IAGetPrimitiveTopologyFunc(IntPtr self, ref D3D_PRIMITIVE_TOPOLOGY pTopology);
    public void VSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 77);
        var callback = (VSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void VSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void VSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 78);
        var callback = (VSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(VSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void VSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void GetPredication(
        /// ppPredicate: (*(*(ID3D11Predicate)))
        ref IntPtr ppPredicate
        /// pPredicateValue: (*(BOOL))
        , IntPtr pPredicateValue
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 79);
        var callback = (GetPredicationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPredicationFunc));
        callback(Self, ref ppPredicate, pPredicateValue);
    }
    delegate void GetPredicationFunc(IntPtr self, ref IntPtr ppPredicate, IntPtr pPredicateValue);
    public void GSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 80);
        var callback = (GSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void GSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void GSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 81);
        var callback = (GSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void GSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void OMGetRenderTargets(
        /// NumViews: (UINT)
        UInt32 NumViews
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 82);
        var callback = (OMGetRenderTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetRenderTargetsFunc));
        callback(Self, NumViews, ref ppRenderTargetViews, ref ppDepthStencilView);
    }
    delegate void OMGetRenderTargetsFunc(IntPtr self, UInt32 NumViews, ref IntPtr ppRenderTargetViews, ref IntPtr ppDepthStencilView);
    public void OMGetRenderTargetsAndUnorderedAccessViews(
        /// NumRTVs: (UINT)
        UInt32 NumRTVs
        /// ppRenderTargetViews: (*(*(ID3D11RenderTargetView)))
        , ref IntPtr ppRenderTargetViews
        /// ppDepthStencilView: (*(*(ID3D11DepthStencilView)))
        , ref IntPtr ppDepthStencilView
        /// UAVStartSlot: (UINT)
        , UInt32 UAVStartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 83);
        var callback = (OMGetRenderTargetsAndUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetRenderTargetsAndUnorderedAccessViewsFunc));
        callback(Self, NumRTVs, ref ppRenderTargetViews, ref ppDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }
    delegate void OMGetRenderTargetsAndUnorderedAccessViewsFunc(IntPtr self, UInt32 NumRTVs, ref IntPtr ppRenderTargetViews, ref IntPtr ppDepthStencilView, UInt32 UAVStartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews);
    public void OMGetBlendState(
        /// ppBlendState: (*(*(ID3D11BlendState)))
        ref IntPtr ppBlendState
        /// BlendFactor: (FLOAT)[4]
        , ref Vector4 BlendFactor
        /// pSampleMask: (*(UINT))
        , ref UInt32 pSampleMask
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 84);
        var callback = (OMGetBlendStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetBlendStateFunc));
        callback(Self, ref ppBlendState, ref BlendFactor, ref pSampleMask);
    }
    delegate void OMGetBlendStateFunc(IntPtr self, ref IntPtr ppBlendState, ref Vector4 BlendFactor, ref UInt32 pSampleMask);
    public void OMGetDepthStencilState(
        /// ppDepthStencilState: (*(*(ID3D11DepthStencilState)))
        ref IntPtr ppDepthStencilState
        /// pStencilRef: (*(UINT))
        , ref UInt32 pStencilRef
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 85);
        var callback = (OMGetDepthStencilStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OMGetDepthStencilStateFunc));
        callback(Self, ref ppDepthStencilState, ref pStencilRef);
    }
    delegate void OMGetDepthStencilStateFunc(IntPtr self, ref IntPtr ppDepthStencilState, ref UInt32 pStencilRef);
    public void SOGetTargets(
        /// NumBuffers: (UINT)
        UInt32 NumBuffers
        /// ppSOTargets: (*(*(ID3D11Buffer)))
        , ref IntPtr ppSOTargets
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 86);
        var callback = (SOGetTargetsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SOGetTargetsFunc));
        callback(Self, NumBuffers, ref ppSOTargets);
    }
    delegate void SOGetTargetsFunc(IntPtr self, UInt32 NumBuffers, ref IntPtr ppSOTargets);
    public void RSGetState(
        /// ppRasterizerState: (*(*(ID3D11RasterizerState)))
        ref IntPtr ppRasterizerState
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 87);
        var callback = (RSGetStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetStateFunc));
        callback(Self, ref ppRasterizerState);
    }
    delegate void RSGetStateFunc(IntPtr self, ref IntPtr ppRasterizerState);
    public void RSGetViewports(
        /// pNumViewports: (*(UINT))
        ref UInt32 pNumViewports
        /// pViewports: (*(D3D11_VIEWPORT))
        , ref D3D11_VIEWPORT pViewports
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 88);
        var callback = (RSGetViewportsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetViewportsFunc));
        callback(Self, ref pNumViewports, ref pViewports);
    }
    delegate void RSGetViewportsFunc(IntPtr self, ref UInt32 pNumViewports, ref D3D11_VIEWPORT pViewports);
    public void RSGetScissorRects(
        /// pNumRects: (*(UINT))
        ref UInt32 pNumRects
        /// pRects: (*(D3D11_RECT))
        , ref D3D11_RECT pRects
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 89);
        var callback = (RSGetScissorRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RSGetScissorRectsFunc));
        callback(Self, ref pNumRects, ref pRects);
    }
    delegate void RSGetScissorRectsFunc(IntPtr self, ref UInt32 pNumRects, ref D3D11_RECT pRects);
    public void HSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 90);
        var callback = (HSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void HSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void HSGetShader(
        /// ppHullShader: (*(*(ID3D11HullShader)))
        ref IntPtr ppHullShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 91);
        var callback = (HSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetShaderFunc));
        callback(Self, ref ppHullShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void HSGetShaderFunc(IntPtr self, ref IntPtr ppHullShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void HSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 92);
        var callback = (HSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void HSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void HSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 93);
        var callback = (HSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void HSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void DSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 94);
        var callback = (DSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void DSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void DSGetShader(
        /// ppDomainShader: (*(*(ID3D11DomainShader)))
        ref IntPtr ppDomainShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 95);
        var callback = (DSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetShaderFunc));
        callback(Self, ref ppDomainShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void DSGetShaderFunc(IntPtr self, ref IntPtr ppDomainShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void DSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 96);
        var callback = (DSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void DSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void DSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 97);
        var callback = (DSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void DSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void CSGetShaderResources(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumViews: (UINT)
        , UInt32 NumViews
        /// ppShaderResourceViews: (*(*(ID3D11ShaderResourceView)))
        , ref IntPtr ppShaderResourceViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 98);
        var callback = (CSGetShaderResourcesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetShaderResourcesFunc));
        callback(Self, StartSlot, NumViews, ref ppShaderResourceViews);
    }
    delegate void CSGetShaderResourcesFunc(IntPtr self, UInt32 StartSlot, UInt32 NumViews, ref IntPtr ppShaderResourceViews);
    public void CSGetUnorderedAccessViews(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumUAVs: (UINT)
        , UInt32 NumUAVs
        /// ppUnorderedAccessViews: (*(*(ID3D11UnorderedAccessView)))
        , ref IntPtr ppUnorderedAccessViews
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 99);
        var callback = (CSGetUnorderedAccessViewsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetUnorderedAccessViewsFunc));
        callback(Self, StartSlot, NumUAVs, ref ppUnorderedAccessViews);
    }
    delegate void CSGetUnorderedAccessViewsFunc(IntPtr self, UInt32 StartSlot, UInt32 NumUAVs, ref IntPtr ppUnorderedAccessViews);
    public void CSGetShader(
        /// ppComputeShader: (*(*(ID3D11ComputeShader)))
        ref IntPtr ppComputeShader
        /// ppClassInstances: (*(*(ID3D11ClassInstance)))
        , ref IntPtr ppClassInstances
        /// pNumClassInstances: (*(UINT))
        , ref UInt32 pNumClassInstances
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 100);
        var callback = (CSGetShaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetShaderFunc));
        callback(Self, ref ppComputeShader, ref ppClassInstances, ref pNumClassInstances);
    }
    delegate void CSGetShaderFunc(IntPtr self, ref IntPtr ppComputeShader, ref IntPtr ppClassInstances, ref UInt32 pNumClassInstances);
    public void CSGetSamplers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumSamplers: (UINT)
        , UInt32 NumSamplers
        /// ppSamplers: (*(*(ID3D11SamplerState)))
        , ref IntPtr ppSamplers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 101);
        var callback = (CSGetSamplersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetSamplersFunc));
        callback(Self, StartSlot, NumSamplers, ref ppSamplers);
    }
    delegate void CSGetSamplersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumSamplers, ref IntPtr ppSamplers);
    public void CSGetConstantBuffers(
        /// StartSlot: (UINT)
        UInt32 StartSlot
        /// NumBuffers: (UINT)
        , UInt32 NumBuffers
        /// ppConstantBuffers: (*(*(ID3D11Buffer)))
        , ref IntPtr ppConstantBuffers
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 102);
        var callback = (CSGetConstantBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CSGetConstantBuffersFunc));
        callback(Self, StartSlot, NumBuffers, ref ppConstantBuffers);
    }
    delegate void CSGetConstantBuffersFunc(IntPtr self, UInt32 StartSlot, UInt32 NumBuffers, ref IntPtr ppConstantBuffers);
    public void ClearState(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 103);
        var callback = (ClearStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ClearStateFunc));
        callback(Self);
    }
    delegate void ClearStateFunc(IntPtr self);
    public void Flush(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 104);
        var callback = (FlushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FlushFunc));
        callback(Self);
    }
    delegate void FlushFunc(IntPtr self);
    public D3D11_DEVICE_CONTEXT_TYPE GetType(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 105);
        var callback = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
        return callback(Self);
    }
    delegate D3D11_DEVICE_CONTEXT_TYPE GetTypeFunc(IntPtr self);
    public UInt32 GetContextFlags(
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 106);
        var callback = (GetContextFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContextFlagsFunc));
        return callback(Self);
    }
    delegate UInt32 GetContextFlagsFunc(IntPtr self);
    public HRESULT FinishCommandList(
        /// RestoreDeferredContextState: (BOOL)
        Int32 RestoreDeferredContextState
        /// ppCommandList: (*(*(ID3D11CommandList)))
        , ref IntPtr ppCommandList
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 107);
        var callback = (FinishCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FinishCommandListFunc));
        return callback(Self, RestoreDeferredContextState, ref ppCommandList);
    }
    delegate HRESULT FinishCommandListFunc(IntPtr self, Int32 RestoreDeferredContextState, ref IntPtr ppCommandList);
}
}
