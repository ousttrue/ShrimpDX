using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace ClearSwapchainSample
{
    class D3DApp : IDisposable
    {
        ID3D11Device m_pDevice = new ID3D11Device();

        ID3D11DeviceContext m_pContext = new ID3D11DeviceContext();

        IDXGISwapChain m_swapChain = new IDXGISwapChain();

        bool m_disposed;

        public void Dispose()
        {
            m_disposed = true;
            m_swapChain.Dispose();
            m_pContext.Dispose();
            m_pDevice.Dispose();
        }

        void EnsureDevice(HWND hWnd)
        {
            if (m_pDevice)
            {
                return;
            }
            Span<D3D_FEATURE_LEVEL> levels = stackalloc D3D_FEATURE_LEVEL[]
            {
                D3D_FEATURE_LEVEL._11_1,
                D3D_FEATURE_LEVEL._11_0,
                D3D_FEATURE_LEVEL._10_1,
                D3D_FEATURE_LEVEL._10_0,
                D3D_FEATURE_LEVEL._9_3,
                D3D_FEATURE_LEVEL._9_2,
                D3D_FEATURE_LEVEL._9_1
            };
            var level = default(D3D_FEATURE_LEVEL);

            var desc = new DXGI_SWAP_CHAIN_DESC
            {
                BufferDesc = new DXGI_MODE_DESC
                {
                    Width = 0,
                    Height = 0,
                    RefreshRate = new DXGI_RATIONAL
                    {
                        Numerator = 60,
                        Denominator = 1,
                    },
                    Format = DXGI_FORMAT.R8G8B8A8_UNORM_SRGB,
                },
                SampleDesc = new DXGI_SAMPLE_DESC
                {
                    Count = 1,
                    Quality = 0,
                },
                BufferUsage = new DXGI_USAGE
                {
                    Value = dxgi.DXGI_USAGE_RENDER_TARGET_OUTPUT
                },
                BufferCount = 1,
                Windowed = 1,
                OutputWindow = hWnd.Value,
            };

            d3d11.D3D11CreateDeviceAndSwapChain(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)D3D11_CREATE_DEVICE_FLAG.DEBUG,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                d3d11.D3D11_SDK_VERSION,
                ref desc,
                ref m_swapChain.PtrForNew,
                ref m_pDevice.PtrForNew,
                ref level,
                ref m_pContext.PtrForNew).ThrowIfFailed();

            Console.Write("CreateDevice");
        }

        public void Resize(HWND hWnd, int w, int h)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            m_swapChain.ResizeBuffers(1, (uint)w, (uint)h, DXGI_FORMAT.R8G8B8A8_UNORM, 0);
        }

        public void Draw(HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            using (var texture = new ID3D11Texture2D())
            {
                m_swapChain.GetBuffer(0, ref texture.IID, ref texture.PtrForNew).ThrowIfFailed();

                // _rtv
                var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    Format = DXGI_FORMAT.R8G8B8A8_UNORM,
                    ViewDimension = D3D11_RTV_DIMENSION.TEXTURE2D
                };

                using (var pRTV = new ID3D11RenderTargetView())
                {
                    m_pDevice.CreateRenderTargetView(texture.Ptr, ref rtv_desc, ref pRTV.PtrForNew).ThrowIfFailed();
                    var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                    m_pContext.ClearRenderTargetView(pRTV.Ptr, ref clearColor);
                }
            }

            m_pContext.Flush();
            m_swapChain.Present(0, 0);
        }
    }

    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LRESULT WNDPROC(HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam);

        static void Main(string[] args)
        {
            var window = Window.Create();
            if (window == null)
            {
                throw new Exception("fail to create window");
            }

            using (var d3d = new D3DApp())
            {
                window.OnResize += (w, h) =>
                {
                    d3d.Resize(window.WindowHandle, w, h);
                };

                MessageLoop.Run(() =>
                {

                    d3d.Draw(window.WindowHandle);

                }, 30);
            }
        }
    }
}
