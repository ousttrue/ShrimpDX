using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ComPtrCS;
using ComPtrCS.WindowsKits.build_10_0_17763_0;

namespace D2DSample
{
    class D2DApp : IDisposable
    {
        ID3D11Device m_device = new ID3D11Device();
        ID3D11DeviceContext m_context = new ID3D11DeviceContext();

        IDXGISwapChain1 m_swapchain = new IDXGISwapChain1();

        ID2D1DeviceContext m_d2dContext = new ID2D1DeviceContext();

        bool m_disposed;
        public void Dispose()
        {
            m_d2dContext.Dispose();
            m_swapchain.Dispose();
            m_device.Dispose();
            m_context.Dispose();
            m_disposed = true;
        }

        void EnsureDevice(HWND hWnd)
        {
            if (m_device)
            {
                return;
            }

            // D3D
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
            var flags =
            D3D11_CREATE_DEVICE_FLAG.DEBUG |
            D3D11_CREATE_DEVICE_FLAG.BGRA_SUPPORT;
            var level = default(D3D_FEATURE_LEVEL);

            d3d11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                d3d11.D3D11_SDK_VERSION,
                ref m_device.PtrForNew,
                ref level,
                ref m_context.PtrForNew).ThrowIfFailed();

            // D2D
            using (var dxgiDevice = new IDXGIDevice())
            {
                m_device.QueryInterface(dxgiDevice).ThrowIfFailed();

                using (var d2dFactory = new ID2D1Factory1())
                {
                    var factory_opt = new D2D1_FACTORY_OPTIONS
                    {
                    };
                    d2d1.D2D1CreateFactory(D2D1_FACTORY_TYPE.SINGLE_THREADED,
                    ref d2dFactory.IID, ref factory_opt, ref d2dFactory.PtrForNew).ThrowIfFailed();

                    float x = 0;
                    float y = 0;
                    d2dFactory.GetDesktopDpi(ref x, ref y);

                    using (var d2dDevice = new ID2D1Device())
                    {
                        var prop = new D2D1_CREATION_PROPERTIES
                        {

                        };
                        d2dFactory.CreateDevice(dxgiDevice.Ptr, ref d2dDevice.PtrForNew).ThrowIfFailed();
                        d2dDevice.CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS.NONE, ref m_d2dContext.PtrForNew).ThrowIfFailed();
                    }
                }

                // SWAPChain
                using (var adapter = new IDXGIAdapter())
                {
                    dxgiDevice.GetAdapter(ref adapter.PtrForNew).ThrowIfFailed();

                    using (var dxgiFactory = new IDXGIFactory2())
                    {
                        adapter.GetParent(ref dxgiFactory.IID, ref dxgiFactory.PtrForNew).ThrowIfFailed();

                        var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1();
                        swapChainDesc.Width = 0;
                        swapChainDesc.Height = 0;
                        swapChainDesc.Format = DXGI_FORMAT.B8G8R8A8_UNORM;
                        swapChainDesc.Stereo = 0;
                        swapChainDesc.SampleDesc.Count = 1;
                        swapChainDesc.SampleDesc.Quality = 0;
                        swapChainDesc.BufferUsage = new DXGI_USAGE { Value = dxgi.DXGI_USAGE_RENDER_TARGET_OUTPUT };
                        swapChainDesc.BufferCount = 2;
                        //swapChainDesc.Scaling = DXGI_SCALING_NONE;
                        swapChainDesc.Scaling = DXGI_SCALING.STRETCH;
                        //swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;
                        swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT.DISCARD;
                        swapChainDesc.AlphaMode = DXGI_ALPHA_MODE.UNSPECIFIED;

                        var fs = new DXGI_SWAP_CHAIN_FULLSCREEN_DESC
                        {
                            Windowed = 1,
                        };
                        dxgiFactory.CreateSwapChainForHwnd(
                          dxgiDevice.Ptr,
                          hWnd.Value,
                          ref swapChainDesc,
                          ref fs,
                          IntPtr.Zero,
                          ref m_swapchain.PtrForNew).ThrowIfFailed();

                        Console.Write("CreateSwapchain");
                    }
                }
            }
        }

        public void Resize(HWND hWnd, int w, int h)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            var desc = default(DXGI_SWAP_CHAIN_DESC);
            m_swapchain.GetDesc(ref desc);
            m_swapchain.ResizeBuffers(desc.BufferCount,
                (uint)w,
                (uint)h,
                desc.BufferDesc.Format, desc.Flags);
        }

        public void Draw(HWND hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            using (var backbuffer = new IDXGISurface2())
            {
                // setup backbuffer
                m_swapchain.GetBuffer(0, ref backbuffer.IID, ref backbuffer.PtrForNew).ThrowIfFailed();
                using (var bitmap = new ID2D1Bitmap1())
                {
                    var prop = new D2D1_BITMAP_PROPERTIES1
                    {
                        bitmapOptions = D2D1_BITMAP_OPTIONS.TARGET | D2D1_BITMAP_OPTIONS.CANNOT_DRAW,
                        pixelFormat = new D2D1_PIXEL_FORMAT
                        {
                            format = DXGI_FORMAT.B8G8R8A8_UNORM,
                            alphaMode = D2D1_ALPHA_MODE.IGNORE
                        }
                    };
                    m_d2dContext.CreateBitmapFromDxgiSurface(backbuffer.Ptr, ref prop, ref bitmap.PtrForNew).ThrowIfFailed();
                    m_d2dContext.SetTarget(bitmap.Ptr);

                    // draw
                    m_d2dContext.BeginDraw();
                    var color = new Vector4(0, 0.1f, 0, 0);
                    m_d2dContext.Clear(ref color);

                    using (var brush = new ID2D1SolidColorBrush())
                    {
                        var brushColor = new Vector4(1, 0, 0, 1);
                        var brushProp = new D2D1_BRUSH_PROPERTIES
                        {
                            opacity = 1.0f,
                            transform = new D2D_MATRIX_3X2_F
                            {
                                _11 = 1.0f,
                                _22 = 1.0f,
                            }
                        };
                        m_d2dContext.CreateSolidColorBrush(ref brushColor, ref brushProp, ref brush.PtrForNew).ThrowIfFailed();

                        var ellipse = new D2D1_ELLIPSE
                        {
                            point = new D2D_POINT_2F
                            {
                            },
                            radiusX = 50.0f,
                            radiusY = 50.0f,
                        };

                        m_d2dContext.DrawEllipse(ref ellipse, brush.Ptr, 10.0f, IntPtr.Zero);
                    }

                    var tag1 = new D2D1_TAG();
                    var tag2 = new D2D1_TAG();
                    m_d2dContext.EndDraw(ref tag1, ref tag2);
                }

                m_context.Flush();
                m_swapchain.Present(0, 0);
                m_d2dContext.SetTarget(IntPtr.Zero);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var window = Window.Create();
            if (window == null)
            {
                throw new Exception("fail to create window");
            }

            using (var d3d = new D2DApp())
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
