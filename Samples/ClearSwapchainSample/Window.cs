using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using ShrimpDX;

namespace Sample
{
    static class WindowsAPIExtensions
    {
        public static ushort[] ToLPWSTR(this string src)
        {
            return src
                .Select(x => (ushort)x)
                // terminate
                .Concat(new ushort[] { 0 })
                .ToArray();
        }
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/learnwin32/creating-a-window
    /// </summary>
    public class Window
    {
        const string CLASS_NAME = "class";
        readonly ushort[] m_title;

        IntPtr m_hwnd;
        public IntPtr WindowHandle => m_hwnd;

        public bool QuitWhenClose = true;

        public RECT Rect
        {
            get
            {
                winuser.GetClientRect(m_hwnd, out RECT rect);
                return rect;
            }
        }

        public int Width
        {
            get
            {
                var rect = Rect;
                return rect.right - rect.left;
            }
        }
        public int Height
        {
            get
            {
                var rect = Rect;
                return rect.bottom - rect.top;
            }
        }

        readonly WNDPROC m_delegate;

        static int s_count;
        readonly ushort[] m_className;
        Window(string title, int count)
        {
            m_title = title.ToLPWSTR();
            m_delegate = new WNDPROC(WndProc);
            m_className = $"{CLASS_NAME}{count}".ToLPWSTR();
        }

        public static Window Create(string title = "window", int show = Constants.SW_SHOW, IntPtr parent = default)
        {
            var ms = Assembly.GetEntryAssembly().GetModules();
            var hInstance = Marshal.GetHINSTANCE(ms[0]);

            var window = new Window(title, s_count++);

            var wc = new WNDCLASSEXW
            {
                cbSize = (uint)Marshal.SizeOf(typeof(WNDCLASSEXW)),
                style = Constants.CS_VREDRAW | Constants.CS_HREDRAW | Constants.CS_DBLCLKS,
                lpszClassName = Encoding.Unicode.GetString(MemoryMarshal.Cast<ushort, byte>(window.m_className.AsSpan())),
                lpfnWndProc = window.m_delegate,
                hInstance = hInstance,
                hCursor = winuser.LoadCursorW(default, IDC._ARROW),
            };
            var register = winuser.RegisterClassExW(ref wc);
            if (register == 0)
            {
                return null;
            }

            var hwnd = winuser.CreateWindowExW(0,
                ref window.m_className[0],
                ref window.m_title[0],
                WS._OVERLAPPEDWINDOW,
                Constants.CW_USEDEFAULT,
                Constants.CW_USEDEFAULT,
                Constants.CW_USEDEFAULT,
                Constants.CW_USEDEFAULT,
                parent,
                IntPtr.Zero, hInstance, IntPtr.Zero);
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }

            window.m_hwnd = hwnd;

            window.Show(show);

            return window;
        }

        long WndProc(IntPtr hwnd, uint msg, ulong wParam, long lParam)
        {
            switch (msg)
            {
                case WM._CLOSE:
                    OnClose?.Invoke();
                    if (DestroyWhenClose == null || DestroyWhenClose())
                    {
                        winuser.DestroyWindow(hwnd);
                    }
                    if (QuitWhenClose)
                    {
                        winuser.PostQuitMessage(0);
                    }
                    return 0;

                case WM._ENABLE:
                    OnEnable?.Invoke(wParam != 0);
                    break;

                case WM._SHOWWINDOW:
                    OnShow?.Invoke(wParam != 0);
                    break;

                case WM._DESTROY:
                    OnDestroy?.Invoke();
                    return 0;

                case WM._MOUSEMOVE:
                    OnMouseMove?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;

                case WM._LBUTTONDOWN:
                    OnMouseLeftDown?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._LBUTTONUP:
                    OnMouseLeftUp?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._LBUTTONDBLCLK:
                    OnMouseLeftDoubleClicked?.Invoke();
                    return 0;
                case WM._RBUTTONDOWN:
                    OnMouseRightDown?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._RBUTTONUP:
                    OnMouseRightUp?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._MBUTTONDOWN:
                    OnMouseMiddleDown?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._MBUTTONUP:
                    OnMouseMiddleUp?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;
                case WM._MOUSEWHEEL:
                    OnMouseWheel?.Invoke(wParam.HIWORD());
                    return 0;

                case WM._SIZE:
                    OnResize?.Invoke(lParam.LOWORD(), lParam.HIWORD());
                    return 0;

                case WM._PAINT:
                    {
                        var ps = default(PAINTSTRUCT);
                        winuser.BeginPaint(hwnd, out ps);
                        OnPaint?.Invoke();
                        winuser.EndPaint(hwnd, ref ps);
                    }
                    return 0;
            }
            return winuser.DefWindowProcW(hwnd, msg, wParam, lParam);
        }

        public event Action<int, int> OnMouseLeftDown;
        public event Action<int, int> OnMouseLeftUp;
        public event Action<int, int> OnMouseRightDown;
        public event Action<int, int> OnMouseRightUp;
        public event Action<int, int> OnMouseMiddleDown;
        public event Action<int, int> OnMouseMiddleUp;
        public event Action<int, int> OnMouseMove;
        public event Action<int> OnMouseWheel;
        public event Action OnMouseLeftDoubleClicked;

        public event Action<int, int> OnResize;
        public event Action OnPaint;
        public event Action OnDestroy;
        public event Action OnClose;
        public event Action<bool> OnShow;
        public event Action<bool> OnEnable;
        public Func<bool> DestroyWhenClose; // return false if not destroy

        public void Show(int sw)
        {
            winuser.ShowWindow(m_hwnd, sw);
        }

        public void Invalidate()
        {
            RECT rect = default;
            winuser.InvalidateRect(m_hwnd, ref rect, 1);
        }

        public void Enable()
        {
            winuser.EnableWindow(m_hwnd, 1);
        }

        public void Close()
        {
            //winuser.ShowWindow(m_hwnd, SW.HIDE);
            //winuser.CloseWindow(m_hwnd);
            winuser.PostMessageW(m_hwnd, WM._CLOSE, 0, 0);
        }

        public Window CreateModal(int w, int h)
        {
            var window = Window.Create("modal", Constants.SW_HIDE, this.WindowHandle);

            var sw = winuser.GetSystemMetrics(Constants.SM_CXSCREEN);
            var sh = winuser.GetSystemMetrics(Constants.SM_CYSCREEN);
            winuser.SetWindowPos(window.WindowHandle, default,
                 (sw - w) / 2,
                 (sh - h) / 2,
                w, h, 0);

            window.OnShow = show =>
            {
                // disable parent
                if (show)
                {
                    var result = winuser.EnableWindow(this.WindowHandle, 0);
                }
            };

            window.DestroyWhenClose = () =>
            {
                // enable parent
                var result = winuser.EnableWindow(this.WindowHandle, 1);
                // hide dialog
                window.Show(Constants.SW_HIDE);
                return false;
            };

            return window;
        }
    }
}
