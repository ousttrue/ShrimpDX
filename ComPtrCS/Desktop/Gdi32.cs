using System;
using System.Runtime.InteropServices;


namespace ComPtrCS
{
    public enum DIB : uint
    {
        RGB_COLORS = 0x00,
        PAL_COLORS = 0x01,
        PAL_INDICES = 0x02
    }

    public static class Gdi32
    {
        const string DLLNAME = "Gdi32.dll";

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-createcompatibledc
        /// </summary>
        /// <param name="hdc"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HDC CreateCompatibleDC(
            HDC hdc
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-createcompatiblebitmap
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern HBITMAP CreateCompatibleBitmap(
          HDC hdc,
          int cx,
          int cy
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-deletedc
        /// </summary>
        /// <param name="hdc"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL DeleteDC(
          HDC hdc
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-deleteobject
        /// </summary>
        /// <param name="ho"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern BOOL DeleteObject(
          IntPtr ho
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-selectobject
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern IntPtr SelectObject(
          HDC hdc,
          IntPtr h
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-getobject
        /// </summary>
        /// <param name="h"></param>
        /// <param name="c"></param>
        /// <param name="pv"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern int GetObject(
          IntPtr h,
          int c,
          ref BITMAP bitmap
        );

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-getdibits
        /// </summary>
        /// <param name="hdc"></param>
        /// <param name="hbm"></param>
        /// <param name="start"></param>
        /// <param name="cLines"></param>
        /// <param name="lpvBits"></param>
        /// <param name="lpbmi"></param>
        /// <param name="usage"></param>
        /// <returns></returns>
        [DllImport(DLLNAME, CharSet = CharSet.Unicode)]
        public static extern int GetDIBits(
          HDC hdc,
          HBITMAP hbm,
          UINT start,
          UINT cLines,
          byte[] lpvBits,
          ref BITMAPINFOHEADER lpbmi,
          DIB usage
        );
    }
}
