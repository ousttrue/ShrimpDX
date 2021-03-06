using System;
using System.Reflection;
using System.Runtime.InteropServices;
using ShrimpDX;

namespace Sample
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/learnwin32/creating-a-window
    /// </summary>
    public class Window
    {
        const string CLASS_NAME = "class";
        readonly WSTR m_title;

        IntPtr m_hwnd;
        public IntPtr WindowHandle => m_hwnd;

        public bool QuitWhenClose = true;

        public tagRECT Rect
        {
            get
            {
                winuser.GetClientRect(m_hwnd, out tagRECT rect);
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
        readonly WSTR m_className;
        Window(string title, int count)
        {
            m_title = new WSTR(title);
            m_delegate = new WNDPROC(WndProc);
            m_className = new WSTR($"{CLASS_NAME}{count}");
        }

        public static Window Create(string title = "window", int show = SW._SHOW, IntPtr parent = default)
        {
            var ms = Assembly.GetEntryAssembly().GetModules();
            // var hInstance = Marshal.GetHINSTANCE(ms[0]);
            var hInstance = default(IntPtr);

            var window = new Window(title, s_count++);

            var wc = new tagWNDCLASSEXW
            {
                cbSize = (uint)Marshal.SizeOf(typeof(tagWNDCLASSEXW)),
                style = CS._VREDRAW | CS._HREDRAW | CS._DBLCLKS,
                lpszClassName = window.m_className.ToString(),
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
                ref window.m_className.Data,
                ref window.m_title.Data,
                WS._OVERLAPPEDWINDOW,
                CW._USEDEFAULT,
                CW._USEDEFAULT,
                CW._USEDEFAULT,
                CW._USEDEFAULT,
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
                        var ps = default(tagPAINTSTRUCT);
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
            tagRECT rect = default;
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
            var window = Window.Create("modal", SW._HIDE, this.WindowHandle);

            var sw = winuser.GetSystemMetrics(SM._CXSCREEN);
            var sh = winuser.GetSystemMetrics(SM._CYSCREEN);
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
                window.Show(SW._HIDE);
                return false;
            };

            return window;
        }
    }
}
