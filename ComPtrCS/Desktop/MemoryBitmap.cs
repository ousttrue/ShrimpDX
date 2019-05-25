using System;
using System.Runtime.InteropServices;

namespace ComPtrCS
{
    public class MemoryBitmap : IDisposable
    {
        HDC m_hDC;
        HBITMAP m_bmp;
        public HDC DC
        {
            get;
            private set;
        }

        readonly IntPtr m_hOrgBMP;

        public void Dispose()
        {
            Gdi32.SelectObject(DC, m_hOrgBMP);
            Gdi32.DeleteDC(DC);
            Gdi32.DeleteObject(m_bmp.Value);
            User32.ReleaseDC(default, m_hDC);
        }

        public MemoryBitmap(int w, int h)
        {
            m_hDC = User32.GetDC(default);
            m_bmp = Gdi32.CreateCompatibleBitmap(m_hDC, w, h);
            DC = Gdi32.CreateCompatibleDC(m_hDC);
            m_hOrgBMP = Gdi32.SelectObject(DC, m_bmp.Value);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/windows/desktop/gdi/capturing-an-image
        /// </summary>
        public byte[] GetBitmap()
        {
            var bmpScreen = default(BITMAP);
            if (Gdi32.GetObject(m_bmp.Value, Marshal.SizeOf<BITMAP>(), ref bmpScreen) == 0)
            {
                return null;
            }

            //var bmfHeader = default(BITMAPFILEHEADER);

            var bi = default(BITMAPINFOHEADER);
            bi.biSize = Marshal.SizeOf<BITMAPINFOHEADER>();
            bi.biWidth = bmpScreen.bmWidth;
            bi.biHeight = -bmpScreen.bmHeight.Value;
            bi.biPlanes = 1;
            bi.biBitCount = 32;
            bi.biCompression = BI.RGB;
            bi.biSizeImage = 0;
            bi.biXPelsPerMeter = 0;
            bi.biYPelsPerMeter = 0;
            bi.biClrUsed = 0;
            bi.biClrImportant = 0;

            DWORD dwBmpSize = ((bmpScreen.bmWidth.Value * bi.biBitCount.Value + 31) / 32) * 4 * bmpScreen.bmHeight.Value;

            // Starting with 32-bit Windows, GlobalAlloc and LocalAlloc are implemented as wrapper functions that 
            // call HeapAlloc using a handle to the process's default heap. Therefore, GlobalAlloc and LocalAlloc 
            // have greater overhead than HeapAlloc.
            //HANDLE hDIB = GlobalAlloc(GHND, dwBmpSize);
            var lpbitmap = new byte[dwBmpSize.Value];

            // Gets the "bits" from the bitmap and copies them into a buffer 
            // which is pointed to by lpbitmap.
            if (Gdi32.GetDIBits(DC, m_bmp,
                0, bmpScreen.bmHeight.Value,
                lpbitmap,
                ref bi, DIB.RGB_COLORS) == 0)
            {
                return null;
            }

            return lpbitmap;
        }
    }
}
