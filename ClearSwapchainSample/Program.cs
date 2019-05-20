using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsKits;
using WindowsKits.build_10_0_17763_0;

namespace ClearSwapchainSample
{
    class WindowEventDispatcher
    {
        ID3D11Device m_pDevice;

        ID3D11DeviceContext m_pContext;

        IDXGISwapChain m_swapChain;

        void OnWindowCreate(HWND hWnd)
        {
            var levels = new D3D_FEATURE_LEVEL[]
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

#if false
            RECT rect;
            User32.GetClientRect(hWnd, out rect);
            var desc = SwapchainDesc;
            desc.Windowed = 1;
            desc.OutputWindow = hWnd.Value;
            RECT rect;
            User32.GetClientRect(hWnd, out rect);
            desc.BufferDesc.Width = (uint)(rect.right.Value - rect.left.Value);
            desc.BufferDesc.Height = (uint)(rect.bottom.Value - rect.top.Value);

            if (d3d11.D3D11CreateDeviceAndSwapChain(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)D3D11_CREATE_DEVICE_FLAG.DEBUG,
                levels,
                (uint)levels.Length,
                d3d11.D3D11_SDK_VERSION,
                ref desc,
                ref m_swapChain,
                ref m_pDevice,
                ref level,
                ref m_pContext) != 0)
            {
                throw new Exception();
            }
#else
            if (d3d11.D3D11CreateDevice(
                null,
                D3D_DRIVER_TYPE.HARDWARE,
                IntPtr.Zero,
                (uint)D3D11_CREATE_DEVICE_FLAG.DEBUG,
                levels,
                (uint)levels.Length,
                d3d11.D3D11_SDK_VERSION,
                ref m_pDevice,
                ref level,
                ref m_pContext) != 0)
            {
                throw new Exception();
            }
#endif

            Console.Write("CreateDevice");
        }

        static Guid uuidof<T>()
        {
            var attr = typeof(T).GetCustomAttribute(typeof(GuidAttribute)) as GuidAttribute;
            var guid = new Guid(attr.Value);
            return guid;
        }

        static T QueryInterface<T>(object src)
        {
            var p = Marshal.GetIUnknownForObject(src);
            IntPtr dst;
            var guid = uuidof<T>();
            var hresult = Marshal.QueryInterface(p, ref guid, out dst);
            if (hresult != 0)
            {
                var x = (uint)hresult;
                throw new Exception();
            }
            return (T)Marshal.GetObjectForIUnknown(dst);
        }

        DXGI_SWAP_CHAIN_DESC SwapchainDesc
        {
            get
            {
                return new DXGI_SWAP_CHAIN_DESC
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
                        //ScanlineOrdering = DXGI_MODE_SCANLINE_ORDER.UNSPECIFIED,
                        //Scaling = DXGI_MODE_SCALING.CENTERED,
                        //Scaling = DXGI_MODE_SCALING.STRETCHED,
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
                    //OutputWindow = hWnd.Value,
                    //SwapEffect = DXGI_SWAP_EFFECT.DISCARD,
                    //Flags = (uint)DXGI_SWAP_CHAIN_FLAG.ALLOW_MODE_SWITCH,
                };
            }
        }

        void ClearSwapchain(HWND hWnd)
        {
            if (m_swapChain == null)
            {
                var dxgiDevice = QueryInterface<IDXGIDevice>(m_pDevice);
                var adapter = default(IDXGIAdapter);
                if (dxgiDevice.GetAdapter(ref adapter) != 0)
                {
                    throw new Exception();
                }
                var adapter_desc = default(DXGI_ADAPTER_DESC);
                adapter.GetDesc(ref adapter_desc);
                Console.WriteLine(adapter_desc.Description);

                // Get Factory
                var guid = uuidof<IDXGIFactory>();
                var p = default(IntPtr);
                if (adapter.GetParent(ref guid, ref p) != 0)
                {
                    throw new Exception();
                }
                var factory = (IDXGIFactory)Marshal.GetObjectForIUnknown(p);

                // Create swapchain
                var desc = SwapchainDesc;
                desc.Windowed = 1;
                desc.OutputWindow = hWnd.Value;
                RECT rect;
                User32.GetClientRect(hWnd, out rect);
                desc.BufferDesc.Width = (uint)(rect.right.Value - rect.left.Value);
                desc.BufferDesc.Height = (uint)(rect.bottom.Value - rect.top.Value);

                var pDevice = Marshal.GetIUnknownForObject(dxgiDevice);
                if (factory.CreateSwapChain(pDevice, ref desc, ref m_swapChain) != 0)
                {
                    throw new Exception();
                }

                Console.WriteLine("CreateSwapchain");
                //ComPtr<ID3D11Texture2D> backBuffer;
            }

            /*
                        var texture_ptr = default(IntPtr);
                        var texture_guid = uuidof<ID3D11Texture2D>();
                        if (m_swapChain.GetBuffer(0, ref texture_guid, ref texture_ptr) != 0)
                        {
                            throw new Exception();
                        }
                        var texture = (ID3D11Texture2D)Marshal.GetObjectForIUnknown(texture_ptr);

                        // _rtv
                        var rtv_desc = new D3D11_RENDER_TARGET_VIEW_DESC
                        {

                        };

                        var pRTV = default(ID3D11RenderTargetView);
                        if (m_pDevice.CreateRenderTargetView(texture, ref rtv_desc, ref pRTV) != 0)
                        {
                            throw new Exception();
                        }

                        var clearColor = new Vector4(0.0f, 0.125f, 0.3f, 1.0f);
                        m_pContext.ClearRenderTargetView(pRTV, ref clearColor);
                        */

            m_pContext.Flush();
            m_swapChain.Present(0, 0);
        }


        public LRESULT WndProc(HWND hWnd, WM msg, WPARAM wParam, LPARAM lParam)
        {
            switch (msg)
            {
                case WM.DESTROY:
                    User32.PostQuitMessage(0);
                    return 0;

                case WM.CREATE:
                    OnWindowCreate(hWnd);
                    return 0;

                case WM.PAINT:
                    {
                        var ps = default(PAINTSTRUCT);
                        User32.BeginPaint(hWnd, ref ps);
                        ClearSwapchain(hWnd);
                        User32.EndPaint(hWnd, ref ps);
                    }
                    return 0;

            }

            return User32.DefWindowProcW(hWnd, msg, wParam, lParam);
        }
    }

    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LRESULT WNDPROC(HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam);

        static void Main(string[] args)
        {
            var ms = Assembly.GetEntryAssembly().GetModules();
            var hInstance = Marshal.GetHINSTANCE(ms[0]);

            //var window = new Window(s_count++);


            var className = "CLASSNAME";
            var windowName = "WINDOWNAME";

            var d = new WindowEventDispatcher();
            var wndProcPtr = Marshal.GetFunctionPointerForDelegate(new WNDPROC(d.WndProc));

            var wc = new WNDCLASSEXW
            {
                cbSize = (uint)Marshal.SizeOf(typeof(WNDCLASSEXW)),
                style = CS.VREDRAW | CS.HREDRAW | CS.DBLCLKS,
                lpszClassName = className,
                lpfnWndProc = wndProcPtr,
                hInstance = hInstance,
                hCursor = User32.LoadCursorW(default(HINSTANCE), IDC.ARROW),
            };
            var register = User32.RegisterClassExW(ref wc);
            if (register == 0)
            {
                return;
            }

            var hWnd = User32.CreateWindowExW(0, className, windowName, WS.OVERLAPPEDWINDOW,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
                default(HWND),
                IntPtr.Zero, hInstance, IntPtr.Zero);
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            User32.ShowWindow(hWnd, SW.SHOW);

            // https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getmessage
            var msg = default(MSG);
            while (true)
            {
                var bRet = User32.GetMessageW(ref msg, hWnd, 0, 0);
                if (bRet.Value == 0)
                {
                    break;
                }
                if (bRet.Value == -1)
                {
                    // handle the error and possibly exit
                }
                else
                {
                    User32.TranslateMessage(ref msg);
                    User32.DispatchMessage(ref msg);
                }
            }
        }
    }
}
