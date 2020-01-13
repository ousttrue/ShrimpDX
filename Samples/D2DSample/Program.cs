using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Sample;
using ShrimpDX;

namespace D2DSample
{
    class D2DApp : IDisposable
    {
        ID3D11Device m_device;
        ID3D11DeviceContext m_context;
        IDXGISwapChain1 m_swapchain;
        ID2D1DeviceContext m_d2dContext;
        IDWriteFactory m_dwriteFactory = new IDWriteFactory();
        bool m_disposed;
        public void Dispose()
        {
            m_dwriteFactory?.Dispose();
            m_d2dContext?.Dispose();
            m_swapchain?.Dispose();
            m_device?.Dispose();
            m_context?.Dispose();
            m_disposed = true;
        }

        void EnsureDevice(IntPtr hWnd)
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
            D3D11_CREATE_DEVICE_FLAG._DEBUG |
            D3D11_CREATE_DEVICE_FLAG._BGRA_SUPPORT;
            var level = default(D3D_FEATURE_LEVEL);

            d3d11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE._HARDWARE,
                IntPtr.Zero,
                (uint)flags,
                ref MemoryMarshal.GetReference(levels),
                (uint)levels.Length,
                Constants.D3D11_SDK_VERSION,
                out m_device,
                out level,
                out m_context).ThrowIfFailed();

            // D2D
            using (var dxgiDevice = new IDXGIDevice())
            {
                m_device.QueryInterface(ref IDXGIDevice.IID, out dxgiDevice.PtrForNew).ThrowIfFailed();

                using (var d2dFactory = new ID2D1Factory1())
                {
                    var factory_opt = new D2D1_FACTORY_OPTIONS
                    {
                    };
                    d2d1.D2D1CreateFactory(D2D1_FACTORY_TYPE._SINGLE_THREADED,
                    ref ID2D1Factory1.IID, ref factory_opt, out d2dFactory.PtrForNew).ThrowIfFailed();

                    d2dFactory.GetDesktopDpi(out float x, out float y);

                    // using (var d2dDevice = new ())
                    {
                        var prop = new D2D1_CREATION_PROPERTIES
                        {

                        };
                        d2dFactory.CreateDevice(dxgiDevice, out ID2D1Device d2dDevice).ThrowIfFailed();
                        using (d2dDevice)
                            d2dDevice.CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS._NONE, out m_d2dContext).ThrowIfFailed();
                    }
                }

                // SWAPChain
                // using (var adapter = new ())
                {
                    dxgiDevice.GetAdapter(out IDXGIAdapter adapter).ThrowIfFailed();
                    using (adapter)
                    using (var dxgiFactory = new IDXGIFactory2())
                    {
                        adapter.GetParent(ref IDXGIFactory2.IID, out dxgiFactory.PtrForNew).ThrowIfFailed();

                        var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1
                        {
                            Width = 0,
                            Height = 0,
                            Format = DXGI_FORMAT._B8G8R8A8_UNORM,
                            Stereo = 0
                        };
                        swapChainDesc.SampleDesc.Count = 1;
                        swapChainDesc.SampleDesc.Quality = 0;
                        swapChainDesc.BufferUsage = DXGI_USAGE._RENDER_TARGET_OUTPUT;
                        swapChainDesc.BufferCount = 2;
                        //swapChainDesc.Scaling = DXGI_SCALING_NONE;
                        swapChainDesc.Scaling = DXGI_SCALING._STRETCH;
                        //swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;
                        swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT._DISCARD;
                        swapChainDesc.AlphaMode = DXGI_ALPHA_MODE._UNSPECIFIED;

                        var fs = new DXGI_SWAP_CHAIN_FULLSCREEN_DESC
                        {
                            Windowed = 1,
                        };
                        dxgiFactory.CreateSwapChainForHwnd(
                          dxgiDevice,
                          hWnd,
                          ref swapChainDesc,
                          ref fs,
                          null,
                          out m_swapchain).ThrowIfFailed();

                        Console.Write("CreateSwapchain");
                    }
                }
            }

            // Dwrite
            dwrite.DWriteCreateFactory(DWRITE_FACTORY_TYPE._SHARED, ref IDWriteFactory.IID, out m_dwriteFactory.PtrForNew).ThrowIfFailed();
        }

        int m_width = 1000;
        int m_height = 1000;

        public void Resize(IntPtr hWnd, int w, int h)
        {
            m_width = w;
            m_height = h;
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

            m_swapchain.GetDesc(out DXGI_SWAP_CHAIN_DESC desc);
            m_swapchain.ResizeBuffers(desc.BufferCount,
                (uint)w,
                (uint)h,
                desc.BufferDesc.Format, desc.Flags);
        }

        public void Draw(IntPtr hWnd)
        {
            if (m_disposed)
            {
                return;
            }
            EnsureDevice(hWnd);

            using (var backbuffer = new IDXGISurface2())
            {
                // setup backbuffer
                m_swapchain.GetBuffer(0, ref IDXGISurface2.IID, out backbuffer.PtrForNew).ThrowIfFailed();
                backbuffer.GetDesc(out DXGI_SURFACE_DESC desc);


                var prop = new D2D1_BITMAP_PROPERTIES1
                {
                    bitmapOptions = D2D1_BITMAP_OPTIONS._TARGET | D2D1_BITMAP_OPTIONS._CANNOT_DRAW,
                    pixelFormat = new D2D1_PIXEL_FORMAT
                    {
                        format = DXGI_FORMAT._B8G8R8A8_UNORM,
                        alphaMode = D2D1_ALPHA_MODE._IGNORE
                    }
                };
                m_d2dContext.CreateBitmapFromDxgiSurface(backbuffer, ref prop, out ID2D1Bitmap1 bitmap).ThrowIfFailed();
                using (bitmap)
                {
                    m_d2dContext.SetTarget(bitmap);

                    // draw
                    m_d2dContext.BeginDraw();
                    var color = new Vector4(0, 0.1f, 0, 0);
                    m_d2dContext.Clear(ref color);

                    var brushColor = new Vector4(1, 0, 0, 1);
                    var brushProp = new D2D1_BRUSH_PROPERTIES
                    {
                        opacity = 1.0f,
                        transform = new Matrix3x2
                        {
                            M11 = 1.0f,
                            M22 = 1.0f,
                        }
                    };
                    m_d2dContext.CreateSolidColorBrush(ref brushColor, ref brushProp, out ID2D1SolidColorBrush brush).ThrowIfFailed();
                    using (brush)
                    {
                        var ellipse = new D2D1_ELLIPSE
                        {
                            radiusX = 50.0f,
                            radiusY = 50.0f,
                        };
                        m_d2dContext.DrawEllipse(ref ellipse, brush, 10.0f, null);
                    }
                }

                // dwrite
                var font = new WSTR("Consolas");
                var text = new WSTR("A0漢字B");
                var locale = new WSTR("ja-jp");

                m_dwriteFactory.CreateTextFormat(
                    ref font.Data,
                    null,
                    DWRITE_FONT_WEIGHT._REGULAR,
                    DWRITE_FONT_STYLE._NORMAL,
                    DWRITE_FONT_STRETCH._NORMAL,
                    144.0f,
                    ref locale.Data,
                    out IDWriteTextFormat pTextFormat
                ).ThrowIfFailed();
                using (pTextFormat)
                {
                    pTextFormat.SetTextAlignment(DWRITE_TEXT_ALIGNMENT._CENTER).ThrowIfFailed();
                    pTextFormat.SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT._CENTER).ThrowIfFailed();

                    var brushColor = new Vector4(0.7f, 0.7f, 1, 1);
                    var brushProp = new D2D1_BRUSH_PROPERTIES
                    {
                        opacity = 1.0f,
                        transform = new Matrix3x2
                        {
                            M11 = 1.0f,
                            M22 = 1.0f,
                        }
                    };
                    m_d2dContext.CreateSolidColorBrush(ref brushColor, ref brushProp, out ID2D1SolidColorBrush brush).ThrowIfFailed();
                    using (brush)
                    {

                        var rect = new Vector4
                        {
                            X = 0,
                            Y = 0,
                            Z = m_width,
                            W = m_height,
                        };

                        m_d2dContext.DrawText(
                            ref text.Data,
                            (uint)text.Length,    // The string's length.
                            pTextFormat,    // The text format.
                            ref rect,       // The region of the window where the text will be rendered.
                            brush,     // The brush used to draw the text.
                            D2D1_DRAW_TEXT_OPTIONS._NONE,
                            DWRITE_MEASURING_MODE._NATURAL
                            );
                    }

                }
                m_d2dContext.EndDraw(out ulong tag1, out ulong tag2);
                // }

                m_context.Flush();
                m_swapchain.Present(0, 0);
                m_d2dContext.SetTarget(null);
            }
        }
    }

    class Program
    {
        static void Main(string[] _)
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
