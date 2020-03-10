// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class ID3D12Device: ID3D12Object
    {
        static Guid s_uuid = new Guid("189819f1-1db6-4b57-be54-1821339b85f7");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual uint GetNodeCount(
        ){
            var fp = GetFunctionPointer(7);
            if(m_GetNodeCountFunc==null) m_GetNodeCountFunc = (GetNodeCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNodeCountFunc));
            
            return m_GetNodeCountFunc(m_ptr);
        }
        delegate uint GetNodeCountFunc(IntPtr self);
        GetNodeCountFunc m_GetNodeCountFunc;

        public virtual int CreateCommandQueue(
            ref D3D12_COMMAND_QUEUE_DESC pDesc,
            ref Guid riid,
            out IntPtr ppCommandQueue
        ){
            var fp = GetFunctionPointer(8);
            if(m_CreateCommandQueueFunc==null) m_CreateCommandQueueFunc = (CreateCommandQueueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommandQueueFunc));
            
            return m_CreateCommandQueueFunc(m_ptr, ref pDesc, ref riid, out ppCommandQueue);
        }
        delegate int CreateCommandQueueFunc(IntPtr self, ref D3D12_COMMAND_QUEUE_DESC pDesc, ref Guid riid, out IntPtr ppCommandQueue);
        CreateCommandQueueFunc m_CreateCommandQueueFunc;

        public virtual int CreateCommandAllocator(
            D3D12_COMMAND_LIST_TYPE type,
            ref Guid riid,
            out IntPtr ppCommandAllocator
        ){
            var fp = GetFunctionPointer(9);
            if(m_CreateCommandAllocatorFunc==null) m_CreateCommandAllocatorFunc = (CreateCommandAllocatorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommandAllocatorFunc));
            
            return m_CreateCommandAllocatorFunc(m_ptr, type, ref riid, out ppCommandAllocator);
        }
        delegate int CreateCommandAllocatorFunc(IntPtr self, D3D12_COMMAND_LIST_TYPE type, ref Guid riid, out IntPtr ppCommandAllocator);
        CreateCommandAllocatorFunc m_CreateCommandAllocatorFunc;

        public virtual int CreateGraphicsPipelineState(
            ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc,
            ref Guid riid,
            out IntPtr ppPipelineState
        ){
            var fp = GetFunctionPointer(10);
            if(m_CreateGraphicsPipelineStateFunc==null) m_CreateGraphicsPipelineStateFunc = (CreateGraphicsPipelineStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateGraphicsPipelineStateFunc));
            
            return m_CreateGraphicsPipelineStateFunc(m_ptr, ref pDesc, ref riid, out ppPipelineState);
        }
        delegate int CreateGraphicsPipelineStateFunc(IntPtr self, ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, ref Guid riid, out IntPtr ppPipelineState);
        CreateGraphicsPipelineStateFunc m_CreateGraphicsPipelineStateFunc;

        public virtual int CreateComputePipelineState(
            ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc,
            ref Guid riid,
            out IntPtr ppPipelineState
        ){
            var fp = GetFunctionPointer(11);
            if(m_CreateComputePipelineStateFunc==null) m_CreateComputePipelineStateFunc = (CreateComputePipelineStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateComputePipelineStateFunc));
            
            return m_CreateComputePipelineStateFunc(m_ptr, ref pDesc, ref riid, out ppPipelineState);
        }
        delegate int CreateComputePipelineStateFunc(IntPtr self, ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, ref Guid riid, out IntPtr ppPipelineState);
        CreateComputePipelineStateFunc m_CreateComputePipelineStateFunc;

        public virtual int CreateCommandList(
            uint nodeMask,
            D3D12_COMMAND_LIST_TYPE type,
            ID3D12CommandAllocator pCommandAllocator,
            ID3D12PipelineState pInitialState,
            ref Guid riid,
            out IntPtr ppCommandList
        ){
            var fp = GetFunctionPointer(12);
            if(m_CreateCommandListFunc==null) m_CreateCommandListFunc = (CreateCommandListFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommandListFunc));
            
            return m_CreateCommandListFunc(m_ptr, nodeMask, type, pCommandAllocator!=null ? pCommandAllocator.Ptr : IntPtr.Zero, pInitialState!=null ? pInitialState.Ptr : IntPtr.Zero, ref riid, out ppCommandList);
        }
        delegate int CreateCommandListFunc(IntPtr self, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, IntPtr pCommandAllocator, IntPtr pInitialState, ref Guid riid, out IntPtr ppCommandList);
        CreateCommandListFunc m_CreateCommandListFunc;

        public virtual int CheckFeatureSupport(
            D3D12_FEATURE Feature,
            IntPtr pFeatureSupportData,
            uint FeatureSupportDataSize
        ){
            var fp = GetFunctionPointer(13);
            if(m_CheckFeatureSupportFunc==null) m_CheckFeatureSupportFunc = (CheckFeatureSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckFeatureSupportFunc));
            
            return m_CheckFeatureSupportFunc(m_ptr, Feature, pFeatureSupportData, FeatureSupportDataSize);
        }
        delegate int CheckFeatureSupportFunc(IntPtr self, D3D12_FEATURE Feature, IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        CheckFeatureSupportFunc m_CheckFeatureSupportFunc;

        public virtual int CreateDescriptorHeap(
            ref D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc,
            ref Guid riid,
            out IntPtr ppvHeap
        ){
            var fp = GetFunctionPointer(14);
            if(m_CreateDescriptorHeapFunc==null) m_CreateDescriptorHeapFunc = (CreateDescriptorHeapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDescriptorHeapFunc));
            
            return m_CreateDescriptorHeapFunc(m_ptr, ref pDescriptorHeapDesc, ref riid, out ppvHeap);
        }
        delegate int CreateDescriptorHeapFunc(IntPtr self, ref D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc, ref Guid riid, out IntPtr ppvHeap);
        CreateDescriptorHeapFunc m_CreateDescriptorHeapFunc;

        public virtual uint GetDescriptorHandleIncrementSize(
            D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType
        ){
            var fp = GetFunctionPointer(15);
            if(m_GetDescriptorHandleIncrementSizeFunc==null) m_GetDescriptorHandleIncrementSizeFunc = (GetDescriptorHandleIncrementSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptorHandleIncrementSizeFunc));
            
            return m_GetDescriptorHandleIncrementSizeFunc(m_ptr, DescriptorHeapType);
        }
        delegate uint GetDescriptorHandleIncrementSizeFunc(IntPtr self, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);
        GetDescriptorHandleIncrementSizeFunc m_GetDescriptorHandleIncrementSizeFunc;

        public virtual int CreateRootSignature(
            uint nodeMask,
            IntPtr pBlobWithRootSignature,
            ulong blobLengthInBytes,
            ref Guid riid,
            out IntPtr ppvRootSignature
        ){
            var fp = GetFunctionPointer(16);
            if(m_CreateRootSignatureFunc==null) m_CreateRootSignatureFunc = (CreateRootSignatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRootSignatureFunc));
            
            return m_CreateRootSignatureFunc(m_ptr, nodeMask, pBlobWithRootSignature, blobLengthInBytes, ref riid, out ppvRootSignature);
        }
        delegate int CreateRootSignatureFunc(IntPtr self, uint nodeMask, IntPtr pBlobWithRootSignature, ulong blobLengthInBytes, ref Guid riid, out IntPtr ppvRootSignature);
        CreateRootSignatureFunc m_CreateRootSignatureFunc;

        public virtual void CreateConstantBufferView(
            ref D3D12_CONSTANT_BUFFER_VIEW_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(17);
            if(m_CreateConstantBufferViewFunc==null) m_CreateConstantBufferViewFunc = (CreateConstantBufferViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateConstantBufferViewFunc));
            
            m_CreateConstantBufferViewFunc(m_ptr, ref pDesc, DestDescriptor);
        }
        delegate void CreateConstantBufferViewFunc(IntPtr self, ref D3D12_CONSTANT_BUFFER_VIEW_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateConstantBufferViewFunc m_CreateConstantBufferViewFunc;

        public virtual void CreateShaderResourceView(
            ID3D12Resource pResource,
            ref D3D12_SHADER_RESOURCE_VIEW_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(18);
            if(m_CreateShaderResourceViewFunc==null) m_CreateShaderResourceViewFunc = (CreateShaderResourceViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateShaderResourceViewFunc));
            
            m_CreateShaderResourceViewFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero, ref pDesc, DestDescriptor);
        }
        delegate void CreateShaderResourceViewFunc(IntPtr self, IntPtr pResource, ref D3D12_SHADER_RESOURCE_VIEW_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateShaderResourceViewFunc m_CreateShaderResourceViewFunc;

        public virtual void CreateUnorderedAccessView(
            ID3D12Resource pResource,
            ID3D12Resource pCounterResource,
            ref D3D12_UNORDERED_ACCESS_VIEW_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(19);
            if(m_CreateUnorderedAccessViewFunc==null) m_CreateUnorderedAccessViewFunc = (CreateUnorderedAccessViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateUnorderedAccessViewFunc));
            
            m_CreateUnorderedAccessViewFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero, pCounterResource!=null ? pCounterResource.Ptr : IntPtr.Zero, ref pDesc, DestDescriptor);
        }
        delegate void CreateUnorderedAccessViewFunc(IntPtr self, IntPtr pResource, IntPtr pCounterResource, ref D3D12_UNORDERED_ACCESS_VIEW_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateUnorderedAccessViewFunc m_CreateUnorderedAccessViewFunc;

        public virtual void CreateRenderTargetView(
            ID3D12Resource pResource,
            ref D3D12_RENDER_TARGET_VIEW_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(20);
            if(m_CreateRenderTargetViewFunc==null) m_CreateRenderTargetViewFunc = (CreateRenderTargetViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateRenderTargetViewFunc));
            
            m_CreateRenderTargetViewFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero, ref pDesc, DestDescriptor);
        }
        delegate void CreateRenderTargetViewFunc(IntPtr self, IntPtr pResource, ref D3D12_RENDER_TARGET_VIEW_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateRenderTargetViewFunc m_CreateRenderTargetViewFunc;

        public virtual void CreateDepthStencilView(
            ID3D12Resource pResource,
            ref D3D12_DEPTH_STENCIL_VIEW_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(21);
            if(m_CreateDepthStencilViewFunc==null) m_CreateDepthStencilViewFunc = (CreateDepthStencilViewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateDepthStencilViewFunc));
            
            m_CreateDepthStencilViewFunc(m_ptr, pResource!=null ? pResource.Ptr : IntPtr.Zero, ref pDesc, DestDescriptor);
        }
        delegate void CreateDepthStencilViewFunc(IntPtr self, IntPtr pResource, ref D3D12_DEPTH_STENCIL_VIEW_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateDepthStencilViewFunc m_CreateDepthStencilViewFunc;

        public virtual void CreateSampler(
            ref D3D12_SAMPLER_DESC pDesc,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        ){
            var fp = GetFunctionPointer(22);
            if(m_CreateSamplerFunc==null) m_CreateSamplerFunc = (CreateSamplerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSamplerFunc));
            
            m_CreateSamplerFunc(m_ptr, ref pDesc, DestDescriptor);
        }
        delegate void CreateSamplerFunc(IntPtr self, ref D3D12_SAMPLER_DESC pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        CreateSamplerFunc m_CreateSamplerFunc;

        public virtual void CopyDescriptors(
            uint NumDestDescriptorRanges,
            ref D3D12_CPU_DESCRIPTOR_HANDLE pDestDescriptorRangeStarts,
            ref uint pDestDescriptorRangeSizes,
            uint NumSrcDescriptorRanges,
            ref D3D12_CPU_DESCRIPTOR_HANDLE pSrcDescriptorRangeStarts,
            ref uint pSrcDescriptorRangeSizes,
            D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        ){
            var fp = GetFunctionPointer(23);
            if(m_CopyDescriptorsFunc==null) m_CopyDescriptorsFunc = (CopyDescriptorsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyDescriptorsFunc));
            
            m_CopyDescriptorsFunc(m_ptr, NumDestDescriptorRanges, ref pDestDescriptorRangeStarts, ref pDestDescriptorRangeSizes, NumSrcDescriptorRanges, ref pSrcDescriptorRangeStarts, ref pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
        delegate void CopyDescriptorsFunc(IntPtr self, uint NumDestDescriptorRanges, ref D3D12_CPU_DESCRIPTOR_HANDLE pDestDescriptorRangeStarts, ref uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, ref D3D12_CPU_DESCRIPTOR_HANDLE pSrcDescriptorRangeStarts, ref uint pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        CopyDescriptorsFunc m_CopyDescriptorsFunc;

        public virtual void CopyDescriptorsSimple(
            uint NumDescriptors,
            D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart,
            D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart,
            D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        ){
            var fp = GetFunctionPointer(24);
            if(m_CopyDescriptorsSimpleFunc==null) m_CopyDescriptorsSimpleFunc = (CopyDescriptorsSimpleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyDescriptorsSimpleFunc));
            
            m_CopyDescriptorsSimpleFunc(m_ptr, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }
        delegate void CopyDescriptorsSimpleFunc(IntPtr self, uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        CopyDescriptorsSimpleFunc m_CopyDescriptorsSimpleFunc;

        public virtual D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(
            uint visibleMask,
            uint numResourceDescs,
            ref D3D12_RESOURCE_DESC pResourceDescs
        ){
            var fp = GetFunctionPointer(25);
            if(m_GetResourceAllocationInfoFunc==null) m_GetResourceAllocationInfoFunc = (GetResourceAllocationInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceAllocationInfoFunc));
            
            return m_GetResourceAllocationInfoFunc(m_ptr, visibleMask, numResourceDescs, ref pResourceDescs);
        }
        delegate D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfoFunc(IntPtr self, uint visibleMask, uint numResourceDescs, ref D3D12_RESOURCE_DESC pResourceDescs);
        GetResourceAllocationInfoFunc m_GetResourceAllocationInfoFunc;

        public virtual D3D12_HEAP_PROPERTIES GetCustomHeapProperties(
            uint nodeMask,
            D3D12_HEAP_TYPE heapType
        ){
            var fp = GetFunctionPointer(26);
            if(m_GetCustomHeapPropertiesFunc==null) m_GetCustomHeapPropertiesFunc = (GetCustomHeapPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCustomHeapPropertiesFunc));
            
            return m_GetCustomHeapPropertiesFunc(m_ptr, nodeMask, heapType);
        }
        delegate D3D12_HEAP_PROPERTIES GetCustomHeapPropertiesFunc(IntPtr self, uint nodeMask, D3D12_HEAP_TYPE heapType);
        GetCustomHeapPropertiesFunc m_GetCustomHeapPropertiesFunc;

        public virtual int CreateCommittedResource(
            ref D3D12_HEAP_PROPERTIES pHeapProperties,
            D3D12_HEAP_FLAGS HeapFlags,
            ref D3D12_RESOURCE_DESC pDesc,
            D3D12_RESOURCE_STATES InitialResourceState,
            ref D3D12_CLEAR_VALUE pOptimizedClearValue,
            ref Guid riidResource,
            out IntPtr ppvResource
        ){
            var fp = GetFunctionPointer(27);
            if(m_CreateCommittedResourceFunc==null) m_CreateCommittedResourceFunc = (CreateCommittedResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommittedResourceFunc));
            
            return m_CreateCommittedResourceFunc(m_ptr, ref pHeapProperties, HeapFlags, ref pDesc, InitialResourceState, ref pOptimizedClearValue, ref riidResource, out ppvResource);
        }
        delegate int CreateCommittedResourceFunc(IntPtr self, ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, ref D3D12_CLEAR_VALUE pOptimizedClearValue, ref Guid riidResource, out IntPtr ppvResource);
        CreateCommittedResourceFunc m_CreateCommittedResourceFunc;

        public virtual int CreateHeap(
            ref D3D12_HEAP_DESC pDesc,
            ref Guid riid,
            out IntPtr ppvHeap
        ){
            var fp = GetFunctionPointer(28);
            if(m_CreateHeapFunc==null) m_CreateHeapFunc = (CreateHeapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateHeapFunc));
            
            return m_CreateHeapFunc(m_ptr, ref pDesc, ref riid, out ppvHeap);
        }
        delegate int CreateHeapFunc(IntPtr self, ref D3D12_HEAP_DESC pDesc, ref Guid riid, out IntPtr ppvHeap);
        CreateHeapFunc m_CreateHeapFunc;

        public virtual int CreatePlacedResource(
            ID3D12Heap pHeap,
            ulong HeapOffset,
            ref D3D12_RESOURCE_DESC pDesc,
            D3D12_RESOURCE_STATES InitialState,
            ref D3D12_CLEAR_VALUE pOptimizedClearValue,
            ref Guid riid,
            out IntPtr ppvResource
        ){
            var fp = GetFunctionPointer(29);
            if(m_CreatePlacedResourceFunc==null) m_CreatePlacedResourceFunc = (CreatePlacedResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreatePlacedResourceFunc));
            
            return m_CreatePlacedResourceFunc(m_ptr, pHeap!=null ? pHeap.Ptr : IntPtr.Zero, HeapOffset, ref pDesc, InitialState, ref pOptimizedClearValue, ref riid, out ppvResource);
        }
        delegate int CreatePlacedResourceFunc(IntPtr self, IntPtr pHeap, ulong HeapOffset, ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, ref D3D12_CLEAR_VALUE pOptimizedClearValue, ref Guid riid, out IntPtr ppvResource);
        CreatePlacedResourceFunc m_CreatePlacedResourceFunc;

        public virtual int CreateReservedResource(
            ref D3D12_RESOURCE_DESC pDesc,
            D3D12_RESOURCE_STATES InitialState,
            ref D3D12_CLEAR_VALUE pOptimizedClearValue,
            ref Guid riid,
            out IntPtr ppvResource
        ){
            var fp = GetFunctionPointer(30);
            if(m_CreateReservedResourceFunc==null) m_CreateReservedResourceFunc = (CreateReservedResourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateReservedResourceFunc));
            
            return m_CreateReservedResourceFunc(m_ptr, ref pDesc, InitialState, ref pOptimizedClearValue, ref riid, out ppvResource);
        }
        delegate int CreateReservedResourceFunc(IntPtr self, ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, ref D3D12_CLEAR_VALUE pOptimizedClearValue, ref Guid riid, out IntPtr ppvResource);
        CreateReservedResourceFunc m_CreateReservedResourceFunc;

        public virtual int CreateSharedHandle(
            ID3D12DeviceChild pObject,
            ref _SECURITY_ATTRIBUTES pAttributes,
            uint Access,
            ref ushort Name,
            out IntPtr pHandle
        ){
            var fp = GetFunctionPointer(31);
            if(m_CreateSharedHandleFunc==null) m_CreateSharedHandleFunc = (CreateSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSharedHandleFunc));
            
            return m_CreateSharedHandleFunc(m_ptr, pObject!=null ? pObject.Ptr : IntPtr.Zero, ref pAttributes, Access, ref Name, out pHandle);
        }
        delegate int CreateSharedHandleFunc(IntPtr self, IntPtr pObject, ref _SECURITY_ATTRIBUTES pAttributes, uint Access, ref ushort Name, out IntPtr pHandle);
        CreateSharedHandleFunc m_CreateSharedHandleFunc;

        public virtual int OpenSharedHandle(
            IntPtr NTHandle,
            ref Guid riid,
            out IntPtr ppvObj
        ){
            var fp = GetFunctionPointer(32);
            if(m_OpenSharedHandleFunc==null) m_OpenSharedHandleFunc = (OpenSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenSharedHandleFunc));
            
            return m_OpenSharedHandleFunc(m_ptr, NTHandle, ref riid, out ppvObj);
        }
        delegate int OpenSharedHandleFunc(IntPtr self, IntPtr NTHandle, ref Guid riid, out IntPtr ppvObj);
        OpenSharedHandleFunc m_OpenSharedHandleFunc;

        public virtual int OpenSharedHandleByName(
            ref ushort Name,
            uint Access,
            out IntPtr pNTHandle
        ){
            var fp = GetFunctionPointer(33);
            if(m_OpenSharedHandleByNameFunc==null) m_OpenSharedHandleByNameFunc = (OpenSharedHandleByNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenSharedHandleByNameFunc));
            
            return m_OpenSharedHandleByNameFunc(m_ptr, ref Name, Access, out pNTHandle);
        }
        delegate int OpenSharedHandleByNameFunc(IntPtr self, ref ushort Name, uint Access, out IntPtr pNTHandle);
        OpenSharedHandleByNameFunc m_OpenSharedHandleByNameFunc;

        public virtual int MakeResident(
            uint NumObjects,
            ref IntPtr ppObjects
        ){
            var fp = GetFunctionPointer(34);
            if(m_MakeResidentFunc==null) m_MakeResidentFunc = (MakeResidentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MakeResidentFunc));
            
            return m_MakeResidentFunc(m_ptr, NumObjects, ref ppObjects);
        }
        delegate int MakeResidentFunc(IntPtr self, uint NumObjects, ref IntPtr ppObjects);
        MakeResidentFunc m_MakeResidentFunc;

        public virtual int Evict(
            uint NumObjects,
            ref IntPtr ppObjects
        ){
            var fp = GetFunctionPointer(35);
            if(m_EvictFunc==null) m_EvictFunc = (EvictFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EvictFunc));
            
            return m_EvictFunc(m_ptr, NumObjects, ref ppObjects);
        }
        delegate int EvictFunc(IntPtr self, uint NumObjects, ref IntPtr ppObjects);
        EvictFunc m_EvictFunc;

        public virtual int CreateFence(
            ulong InitialValue,
            D3D12_FENCE_FLAGS Flags,
            ref Guid riid,
            out IntPtr ppFence
        ){
            var fp = GetFunctionPointer(36);
            if(m_CreateFenceFunc==null) m_CreateFenceFunc = (CreateFenceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFenceFunc));
            
            return m_CreateFenceFunc(m_ptr, InitialValue, Flags, ref riid, out ppFence);
        }
        delegate int CreateFenceFunc(IntPtr self, ulong InitialValue, D3D12_FENCE_FLAGS Flags, ref Guid riid, out IntPtr ppFence);
        CreateFenceFunc m_CreateFenceFunc;

        public virtual int GetDeviceRemovedReason(
        ){
            var fp = GetFunctionPointer(37);
            if(m_GetDeviceRemovedReasonFunc==null) m_GetDeviceRemovedReasonFunc = (GetDeviceRemovedReasonFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDeviceRemovedReasonFunc));
            
            return m_GetDeviceRemovedReasonFunc(m_ptr);
        }
        delegate int GetDeviceRemovedReasonFunc(IntPtr self);
        GetDeviceRemovedReasonFunc m_GetDeviceRemovedReasonFunc;

        public virtual void GetCopyableFootprints(
            ref D3D12_RESOURCE_DESC pResourceDesc,
            uint FirstSubresource,
            uint NumSubresources,
            ulong BaseOffset,
            out D3D12_PLACED_SUBRESOURCE_FOOTPRINT pLayouts,
            out uint pNumRows,
            out ulong pRowSizeInBytes,
            out ulong pTotalBytes
        ){
            var fp = GetFunctionPointer(38);
            if(m_GetCopyableFootprintsFunc==null) m_GetCopyableFootprintsFunc = (GetCopyableFootprintsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCopyableFootprintsFunc));
            
            m_GetCopyableFootprintsFunc(m_ptr, ref pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, out pLayouts, out pNumRows, out pRowSizeInBytes, out pTotalBytes);
        }
        delegate void GetCopyableFootprintsFunc(IntPtr self, ref D3D12_RESOURCE_DESC pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, out D3D12_PLACED_SUBRESOURCE_FOOTPRINT pLayouts, out uint pNumRows, out ulong pRowSizeInBytes, out ulong pTotalBytes);
        GetCopyableFootprintsFunc m_GetCopyableFootprintsFunc;

        public virtual int CreateQueryHeap(
            ref D3D12_QUERY_HEAP_DESC pDesc,
            ref Guid riid,
            out IntPtr ppvHeap
        ){
            var fp = GetFunctionPointer(39);
            if(m_CreateQueryHeapFunc==null) m_CreateQueryHeapFunc = (CreateQueryHeapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateQueryHeapFunc));
            
            return m_CreateQueryHeapFunc(m_ptr, ref pDesc, ref riid, out ppvHeap);
        }
        delegate int CreateQueryHeapFunc(IntPtr self, ref D3D12_QUERY_HEAP_DESC pDesc, ref Guid riid, out IntPtr ppvHeap);
        CreateQueryHeapFunc m_CreateQueryHeapFunc;

        public virtual int SetStablePowerState(
            int Enable
        ){
            var fp = GetFunctionPointer(40);
            if(m_SetStablePowerStateFunc==null) m_SetStablePowerStateFunc = (SetStablePowerStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStablePowerStateFunc));
            
            return m_SetStablePowerStateFunc(m_ptr, Enable);
        }
        delegate int SetStablePowerStateFunc(IntPtr self, int Enable);
        SetStablePowerStateFunc m_SetStablePowerStateFunc;

        public virtual int CreateCommandSignature(
            ref D3D12_COMMAND_SIGNATURE_DESC pDesc,
            ID3D12RootSignature pRootSignature,
            ref Guid riid,
            out IntPtr ppvCommandSignature
        ){
            var fp = GetFunctionPointer(41);
            if(m_CreateCommandSignatureFunc==null) m_CreateCommandSignatureFunc = (CreateCommandSignatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCommandSignatureFunc));
            
            return m_CreateCommandSignatureFunc(m_ptr, ref pDesc, pRootSignature!=null ? pRootSignature.Ptr : IntPtr.Zero, ref riid, out ppvCommandSignature);
        }
        delegate int CreateCommandSignatureFunc(IntPtr self, ref D3D12_COMMAND_SIGNATURE_DESC pDesc, IntPtr pRootSignature, ref Guid riid, out IntPtr ppvCommandSignature);
        CreateCommandSignatureFunc m_CreateCommandSignatureFunc;

        public virtual void GetResourceTiling(
            ID3D12Resource pTiledResource,
            out uint pNumTilesForEntireResource,
            out D3D12_PACKED_MIP_INFO pPackedMipDesc,
            out D3D12_TILE_SHAPE pStandardTileShapeForNonPackedMips,
            out uint pNumSubresourceTilings,
            uint FirstSubresourceTilingToGet,
            out D3D12_SUBRESOURCE_TILING pSubresourceTilingsForNonPackedMips
        ){
            var fp = GetFunctionPointer(42);
            if(m_GetResourceTilingFunc==null) m_GetResourceTilingFunc = (GetResourceTilingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetResourceTilingFunc));
            
            m_GetResourceTilingFunc(m_ptr, pTiledResource!=null ? pTiledResource.Ptr : IntPtr.Zero, out pNumTilesForEntireResource, out pPackedMipDesc, out pStandardTileShapeForNonPackedMips, out pNumSubresourceTilings, FirstSubresourceTilingToGet, out pSubresourceTilingsForNonPackedMips);
        }
        delegate void GetResourceTilingFunc(IntPtr self, IntPtr pTiledResource, out uint pNumTilesForEntireResource, out D3D12_PACKED_MIP_INFO pPackedMipDesc, out D3D12_TILE_SHAPE pStandardTileShapeForNonPackedMips, out uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, out D3D12_SUBRESOURCE_TILING pSubresourceTilingsForNonPackedMips);
        GetResourceTilingFunc m_GetResourceTilingFunc;

        public virtual _LUID GetAdapterLuid(
        ){
            var fp = GetFunctionPointer(43);
            if(m_GetAdapterLuidFunc==null) m_GetAdapterLuidFunc = (GetAdapterLuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAdapterLuidFunc));
            
            return m_GetAdapterLuidFunc(m_ptr);
        }
        delegate _LUID GetAdapterLuidFunc(IntPtr self);
        GetAdapterLuidFunc m_GetAdapterLuidFunc;

    }
}
