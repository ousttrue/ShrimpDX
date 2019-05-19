using System;
using System.Runtime.InteropServices;


namespace WindowsKits
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/winmsg/window-styles
    /// </summary>
    [Flags]
    public enum WS : uint
    {
        OVERLAPPED = 0x00000000,
        MAXIMIZEBOX = 0x00010000,
        MINIMIZEBOX = 0x00020000,
        THICKFRAME = 0x00040000,
        SYSMENU = 0x00080000,
        CAPTION = 0x00C00000,
        OVERLAPPEDWINDOW = (OVERLAPPED | CAPTION | SYSMENU | THICKFRAME | MINIMIZEBOX | MAXIMIZEBOX)
    }

    public enum SW : int
    {
        HIDE = 0,
        SHOWNORMAL = 1,
        SHOWMINIMIZED = 2,
        MAXIMIZE = 3,
        SHOWNOACTIVATE = 4,
        SHOW = 5,
    }

    [Flags]
    public enum SWP : uint
    {
        NONE = 0x0000,
        NOMOVE = 0x0002,
    }

    [Flags]
    public enum MB : uint
    {
        ICONQUESTION = 0x00000020,
        ICONINFORMATION = 0x00000040,
    }

    public enum IDC : uint
    {
        ARROW = 32512,
    }

    public enum SM : int
    {
        CXSCREEN = 0,
        CYSCREEN = 1,
    }

    public enum PM : uint
    {
        NOREMOVE = 0x0000,
        REMOVE = 0x0001,
        NOYIELD = 0x0002,
    }

    public static class User32
    {
        const string DLLNAME = "User32.dll";

        public const int CW_USEDEFAULT = unchecked((int)0x80000000);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-createwindowexw
        /// </summary>
        /// <param name="dwExStyle"></param>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <param name="dwStyle"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="hWndParent"></param>
        /// <param name="hMenu"></param>
        /// <param name="hInstance"></param>
        /// <param name="lpParam"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowExW(
            DWORD dwExStyle,
            string lpClassName,
            string lpWindowName,
            WS dwStyle,
            int X,
            int Y,
            int nWidth,
            int nHeight,
            HWND hWndParent,
            HMENU hMenu,
            HINSTANCE hInstance,
            LPVOID lpParam
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-defwindowprocw
        /// </summary>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern LRESULT DefWindowProcW(
          HWND hWnd,
          WM Msg,
          WPARAM wParam,
          LPARAM lParam
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-dispatchmessagew
        /// </summary>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern LRESULT DispatchMessage(ref MSG lpMsg);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getclientrect
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL GetClientRect(
          HWND hWnd,
          out RECT lpRect
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getmessage
        /// </summary>
        /// <param name="lpMsg"></param>
        /// <param name="hWnd"></param>
        /// <param name="wMsgFilterMin"></param>
        /// <param name="wMsgFilterMax"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL GetMessageW(
          ref MSG lpMsg,
          HWND hWnd,
          UINT wMsgFilterMin,
          UINT wMsgFilterMax
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-messageboxw
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpText"></param>
        /// <param name="lpCaption"></param>
        /// <param name="uType"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern int MessageBoxW(
          HWND hWnd,
          string lpText,
          string lpCaption,
          MB uType
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-postquitmessage
        /// </summary>
        /// <param name="nExitCode"></param>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern void PostQuitMessage(int nExitCode);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-registerclassexw
        /// </summary>
        /// <param name="Arg1"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern uint RegisterClassExW(ref WNDCLASSEXW Arg1);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-showwindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nCmdShow"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL ShowWindow(
          HWND hWnd,
          SW nCmdShow
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-translatemessage
        /// </summary>
        /// <param name="lpMsg"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL TranslateMessage(ref MSG lpMsg);

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-beginpaint
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpPaint"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HDC BeginPaint(
          HWND hWnd,
          ref PAINTSTRUCT lpPaint
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-endpaint
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL EndPaint(
          HWND hWnd,
          ref PAINTSTRUCT lpPaint
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-invalidaterect
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL InvalidateRect(
          HWND hWnd,
          IntPtr lpRect,
          BOOL bErase
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-loadcursorw
        /// </summary>
        /// <param name="hInstance"></param>
        /// <param name="lpCursorName"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HCURSOR LoadCursorW(
          HINSTANCE hInstance,
          IDC lpCursorName
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-destroyicon
        /// </summary>
        /// <param name="hIcon"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL DestroyIcon(
          HICON hIcon
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getdc
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HDC GetDC(
          HWND hWnd
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-releasedc
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hDC"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern int ReleaseDC(
          HWND hWnd,
          HDC hDC
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-enablewindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="bEnable"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL EnableWindow(
          HWND hWnd,
          BOOL bEnable
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-setwindowpos
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hWndInsertAfter"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="uFlags"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL SetWindowPos(
          HWND hWnd,
          HWND hWndInsertAfter,
          int X,
          int Y,
          int cx,
          int cy,
          SWP uFlags
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getsystemmetrics
        /// </summary>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern int GetSystemMetrics(
          SM nIndex
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-closewindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL CloseWindow(
          HWND hWnd
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-destroywindow
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL DestroyWindow(
          HWND hWnd
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-postmessagew
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL PostMessageW(
          HWND hWnd,
          WM Msg,
          WPARAM wParam,
          LPARAM lParam
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-peekmessagew
        /// </summary>
        /// <param name="lpMsg"></param>
        /// <param name="hWnd"></param>
        /// <param name="wMsgFilterMin"></param>
        /// <param name="wMsgFilterMax"></param>
        /// <param name="wRemoveMsg"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL PeekMessageW(
          ref MSG lpMsg,
          HWND hWnd,
          UINT wMsgFilterMin,
          UINT wMsgFilterMax,
          PM wRemoveMsg
        );
    }
}
