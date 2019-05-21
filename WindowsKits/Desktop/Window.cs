using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsKits
{
    /// <summary>
    /// * https://docs.microsoft.com/en-us/windows/desktop/winmsg/window-notifications
    /// * https://docs.microsoft.com/en-us/windows/desktop/inputdev/mouse-input-notifications
    /// </summary>
    public enum WM : uint
    {
        CREATE = 0x0001,
        DESTROY = 0x0002,
        MOVE = 0x0003,
        RESIZE = 0x0005,
        ENABLE = 0x000A,
        PAINT = 0x000F,
        CLOSE = 0x0010,
        QUIT = 0x0012,
        SHOWWINDOW = 0x0018,
        MOUSEMOVE = 0x0200,
        LBUTTONDOWN = 0x0201,
        LBUTTONUP = 0x0202,
        LBUTTONDBLCLK = 0x0203,
        RBUTTONDOWN = 0x0204,
        RBUTTONUP = 0x0205,
        MBUTTONDOWN = 0x0207,
        MBUTTONUP = 0x0208,
        MOUSEWHEEL = 0x020A,
    }

    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/learnwin32/creating-a-window
    /// </summary>
    public class Window
    {
        const string CLASS_NAME = "class";
        const string WINDOW_NAME = "window";

        HWND m_hwnd;
        public IntPtr WindowHandle
        {
            get { return m_hwnd.Value; }
        }

        public bool QuitWhenClose = true;

        public RECT Rect
        {
            get
            {
                RECT rect;
                User32.GetClientRect(m_hwnd, out rect);
                return rect;
            }
        }

        public int Width
        {
            get
            {
                var rect = Rect;
                return rect.right.Value - rect.left.Value;
            }
        }
        public int Height
        {
            get
            {
                var rect = Rect;
                return rect.bottom.Value - rect.top.Value;
            }
        }

        WNDPROC m_delegate;
        IntPtr Callback
        {
            get
            {
                return Marshal.GetFunctionPointerForDelegate(m_delegate);
            }
        }

        static int s_count;
        string m_className;
        Window(int count)
        {
            m_delegate = new WNDPROC(WndProc);
            m_className = $"{CLASS_NAME}{count}";
        }

        public static Window Create(SW show = SW.SHOW, HWND parent = default(HWND))
        {
            var ms = Assembly.GetEntryAssembly().GetModules();
            var hInstance = Marshal.GetHINSTANCE(ms[0]);

            var window = new Window(s_count++);

            var wc = new WNDCLASSEXW
            {
                cbSize = (uint)Marshal.SizeOf(typeof(WNDCLASSEXW)),
                style = CS.VREDRAW | CS.HREDRAW | CS.DBLCLKS,
                lpszClassName = window.m_className,
                lpfnWndProc = window.Callback,
                hInstance = hInstance,
                hCursor = User32.LoadCursorW(default(HINSTANCE), IDC.ARROW),
            };
            var register = User32.RegisterClassExW(ref wc);
            if (register == 0)
            {
                return null;
            }

            var hwnd = User32.CreateWindowExW(0, window.m_className, WINDOW_NAME, WS.OVERLAPPEDWINDOW,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
                User32.CW_USEDEFAULT,
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

        LRESULT WndProc(HWND hwnd, WM msg, WPARAM wParam, LPARAM lParam)
        {
            switch (msg)
            {
                case WM.CLOSE:
                    OnClose?.Invoke();
                    if (DestroyWhenClose == null || DestroyWhenClose())
                    {
                        User32.DestroyWindow(hwnd);
                    }
                    if (QuitWhenClose)
                    {
                        User32.PostQuitMessage(0);
                    }
                    return 0;

                case WM.ENABLE:
                    OnEnable?.Invoke(wParam);
                    break;

                case WM.SHOWWINDOW:
                    OnShow?.Invoke(wParam);
                    break;

                case WM.DESTROY:
                    OnDestroy?.Invoke();
                    return 0;

                case WM.MOUSEMOVE:
                    OnMouseMove?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;

                case WM.LBUTTONDOWN:
                    OnMouseLeftDown?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.LBUTTONUP:
                    OnMouseLeftUp?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.LBUTTONDBLCLK:
                    OnMouseLeftDoubleClicked?.Invoke();
                    return 0;
                case WM.RBUTTONDOWN:
                    OnMouseRightDown?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.RBUTTONUP:
                    OnMouseRightUp?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.MBUTTONDOWN:
                    OnMouseMiddleDown?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.MBUTTONUP:
                    OnMouseMiddleUp?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;
                case WM.MOUSEWHEEL:
                    OnMouseWheel?.Invoke(wParam.HiWord);
                    return 0;

                case WM.RESIZE:
                    OnResize?.Invoke(lParam.LowWord, lParam.HiWord);
                    return 0;

                case WM.PAINT:
                    {
                        var ps = default(PAINTSTRUCT);
                        User32.BeginPaint(hwnd, ref ps);
                        OnPaint?.Invoke();
                        User32.EndPaint(hwnd, ref ps);
                    }
                    return 0;
            }
            return User32.DefWindowProcW(hwnd, msg, wParam, lParam);
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

        public void Show(SW sw)
        {
            User32.ShowWindow(m_hwnd, sw);
        }

        public void Invalidate()
        {
            User32.InvalidateRect(m_hwnd, IntPtr.Zero, true);
        }

        public void Enable()
        {
            User32.EnableWindow(m_hwnd, true);
        }

        public void Close()
        {
            //User32.ShowWindow(m_hwnd, SW.HIDE);
            //User32.CloseWindow(m_hwnd);
            User32.PostMessageW(m_hwnd, WM.CLOSE, 0, 0);
        }

        public Window CreateModal(int w, int h)
        {
            var window = Window.Create(SW.HIDE, this.WindowHandle);

            var sw = User32.GetSystemMetrics(SM.CXSCREEN);
            var sh = User32.GetSystemMetrics(SM.CYSCREEN);
            User32.SetWindowPos(window.WindowHandle, default(HWND),
                 (sw - w) / 2,
                 (sh - h) / 2,
                w, h, SWP.NONE);

            window.OnShow = show =>
            {
                // disable parent
                if (show)
                {
                    var result = User32.EnableWindow(this.WindowHandle, false);
                }
            };

            window.DestroyWhenClose = () =>
            {
                // enable parent
                var result = User32.EnableWindow(this.WindowHandle, true);
                // hide dialog
                window.Show(SW.HIDE);
                return false;
            };

            return window;
        }
    }
}
