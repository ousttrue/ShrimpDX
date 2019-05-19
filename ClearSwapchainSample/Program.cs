using System;
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsKits;

namespace ClearSwapchainSample
{
    class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LRESULT WNDPROC(HWND hwnd, WM uMsg, WPARAM wParam, LPARAM lParam);

        static LRESULT WndProc(HWND hwnd, WM msg, WPARAM wParam, LPARAM lParam)
        {
            switch (msg)
            {
                case WM.DESTROY:
                    User32.PostQuitMessage(0);
                    return 0;
            }

            return User32.DefWindowProcW(hwnd, msg, wParam, lParam);
        }

        static void Main(string[] args)
        {
            var ms = Assembly.GetEntryAssembly().GetModules();
            var hInstance = Marshal.GetHINSTANCE(ms[0]);

            //var window = new Window(s_count++);

            var wndProcPtr = Marshal.GetFunctionPointerForDelegate(new WNDPROC(WndProc));

            var className = "CLASSNAME";
            var windowName = "WINDOWNAME";

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
