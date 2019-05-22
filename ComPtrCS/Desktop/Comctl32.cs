using System;
using System.Runtime.InteropServices;


namespace ComPtrCS
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/controls/imagelistdrawflags
    /// </summary>
    public enum ILD : uint
    {
        NORMAL = 0x00000000,
    }

    public static class Comctl32
    {
        const string DLLNAME = "Comctl32.dll";

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/commctrl/nf-commctrl-imagelist_geticon
        /// </summary>
        /// <param name="himl"></param>
        /// <param name="i"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HICON ImageList_GetIcon(
            IntPtr himl,
            int i,
            ILD flags
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/commctrl/nf-commctrl-imagelist_geticonsize
        /// </summary>
        /// <param name="himl"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL ImageList_GetIconSize(
          IntPtr himl,
          ref int cx,
          ref int cy
        );

        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL ImageList_Draw(
          IntPtr himl,
          int i,
          HDC hdcDst,
          int x,
          int y,
          ILD fStyle
        );
    }
}
