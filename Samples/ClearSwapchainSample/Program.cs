using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using ShrimpDX;
using ComPtrCS;

namespace ClearSwapchainSample
{
    class D3DApp : IDisposable
    {
        ID3D11Device m_pDevice;
        ID3D11DeviceContext m_pContext;
        IDXGISwapChain m_swapChain;

        bool m_disposed;

        public void Dispose()
        {
            m_disposed = true;
        }

        void EnsureDevice(ComPtrCS.HWND hWnd)
        {
            if (m_pDevice != null)
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
                    Format = DXGI_FORMAT._R8G8B8A8_UNORM_SRGB,
                },
                SampleDesc = new DXGI_SAMPLE_DESC
                {
                    Count = 1,
                    Quality = 0,
                },
                BufferUsage = (uint)Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT,
                BufferCount = 1,
                Windowed = 1,
                OutputWindow = hWnd.Value,
            };

            var hr = d3d11.D3D11CreateDeviceAndSwapChain(
                null,
                D3D_DRIVER_TYPE._HARDWARE,
                default,
                (uint)D3D11_CREATE_DEVICE_FLAG._DEBUG,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                Constants.D3D11_SDK_VERSION,
                ref desc,
                out m_swapChain,
                out m_pDevice,
                out level,
                out m_pContext);

            if (m_pDevice.GetFeatureLevel() != level)
            {
                throw new Exception("feature level");
            }

            Console.WriteLine("CreateDevice: {0}, D3D_FEATURE_LEVEL = {1}", hr, level);
        }

        public void Resize(ComPtrCS.HWND hWnd, int w, int h)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            m_swapChain.ResizeBuffers(1, (uint)w, (uint)h, DXGI_FORMAT._R8G8B8A8_UNORM, 0);
        }

        public void Draw(ComPtrCS.HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            using (var texture = new ID3D11Texture2D())
            {
                m_swapChain.GetDesc(out DXGI_SWAP_CHAIN_DESC desc);

                var hr = m_swapChain.GetBuffer(0, ref ID3D11Texture2D.IID, out texture.PtrForNew);

                // _rtv
                var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                {
                    Format = DXGI_FORMAT._R8G8B8A8_UNORM,
                    ViewDimension = D3D11_RTV_DIMENSION._TEXTURE2D
                };

                {
                    m_pDevice.CreateRenderTargetView(texture, ref rtv_desc, out ID3D11RenderTargetView pRTV);
                    using (pRTV)
                    {
                        var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                        m_pContext.ClearRenderTargetView(pRTV, ref clearColor.X);
                    }
                }
            }

            m_pContext.Flush();
            m_swapChain.Present(0, 0);
        }
    }

    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LRESULT WNDPROC(ComPtrCS.HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam);

        [STAThread]
        static void Main(string[] _)
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
