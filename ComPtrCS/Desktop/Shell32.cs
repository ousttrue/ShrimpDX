using System;
using System.Runtime.InteropServices;


namespace ComPtrCS
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/api/shellapi/ns-shellapi-shfileinfow
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct SHFILEINFOW
    {
        public HICON hIcon;
        public int iIcon;
        public DWORD dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260/*MAX_PATH*/)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    [Flags]
    public enum SHGFI : uint
    {
        SMALLICON = 0x000000001,
        PIDL = 0x000000008,
        ADDOVERLAYS = 0x000000020,
        SHGFI_ICON = 0x000000100,
        DISPLAYNAME = 0x000000200,
        TYPENAME = 0x000000400,
        SYSICONINDEX = 0x000004000,
    }

    public static class Shell32
    {
        const string DllName = "shell32.dll";
        [DllImport(DllName, CharSet = CharSet.Unicode)]
        public static extern IntPtr SHGetFileInfoW(
            string pszPath,
            DWORD dwFileAttributes,
            ref SHFILEINFOW psfi,
            UINT cbFileInfo,
            SHGFI uFlags
        );
    }
}
