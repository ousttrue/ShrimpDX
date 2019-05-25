using System;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace ComPtrCS.Utilities
{
    public class DXGISwapChainForHWND : IDisposable
    {
        readonly IDXGISwapChain1 m_swapChain = new IDXGISwapChain1();
        public void Dispose()
        {
            m_swapChain.Dispose();
        }

        public void Resize(int w, int h)
        {
            if (m_swapChain)
            {
                DXGI_SWAP_CHAIN_DESC desc = new DXGI_SWAP_CHAIN_DESC();
                m_swapChain.GetDesc(ref desc).ThrowIfFailed();
                m_swapChain.ResizeBuffers(desc.BufferCount,
                (uint)w,
                (uint)h,
                desc.BufferDesc.Format, desc.Flags);
            }
        }


        public ID3D11Texture2D GetBackbuffer(ID3D11Device device, IntPtr hWnd)
        {
            if (!m_swapChain)
            {
                using (var dxgiDevice = new IDXGIDevice2())
                {
                    device.QueryInterface(dxgiDevice).ThrowIfFailed();

                    using (var dxgiAdapter = new IDXGIAdapter())
                    {
                        dxgiDevice.GetAdapter(ref dxgiAdapter.PtrForNew).ThrowIfFailed();

                        using (var dxgiFactory = new IDXGIFactory2())
                        {
                            dxgiAdapter.GetParent(ref dxgiFactory.IID, ref dxgiFactory.PtrForNew).ThrowIfFailed();

                            var desc = new DXGI_SWAP_CHAIN_DESC1
                            {
                                Format = DXGI_FORMAT.B8G8R8A8_UNORM,
                                AlphaMode = DXGI_ALPHA_MODE.UNSPECIFIED,
                                BufferUsage = new DXGI_USAGE { Value = DXGI.DXGI_USAGE_RENDER_TARGET_OUTPUT },
                                Scaling = DXGI_SCALING.NONE,
                                BufferCount = 2,
                                SwapEffect = DXGI_SWAP_EFFECT.FLIP_SEQUENTIAL,
                                SampleDesc = new DXGI_SAMPLE_DESC
                                {
                                    Count = 1,
                                    Quality = 0,
                                },

                            };

                            var fs_desc = new DXGI_SWAP_CHAIN_FULLSCREEN_DESC
                            {
                                Windowed = 1,
                            };

                            dxgiFactory.CreateSwapChainForHwnd(device.Ptr, hWnd, ref desc, ref fs_desc, IntPtr.Zero, ref m_swapChain.PtrForNew).ThrowIfFailed();
                        }
                    }
                }
            }

            var texture = new ID3D11Texture2D();
            m_swapChain.GetBuffer(0, ref texture.IID, ref texture.PtrForNew).ThrowIfFailed();
            return texture;
        }

        public void Present()
        {
            m_swapChain.Present(0, 0);
        }
    }
}