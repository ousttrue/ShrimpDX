// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    public class IWICPlanarFormatConverter: IWICBitmapSource
    {
        static Guid s_uuid = new Guid("bebee9cb-83b0-4dcc-8132-b0aaa55eac96");
        public static new ref Guid IID =>ref s_uuid;
        public override ref Guid GetIID(){ return ref s_uuid; }
                
        public virtual int Initialize(
            out IWICBitmapSource ppPlanes,
            uint cPlanes,
            ref Guid dstFormat,
            WICBitmapDitherType dither,
            IWICPalette pIPalette,
            double alphaThresholdPercent,
            WICBitmapPaletteType paletteTranslate
        ){
            var fp = GetFunctionPointer(8);
            if(m_InitializeFunc==null) m_InitializeFunc = (InitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InitializeFunc));
            ppPlanes = new IWICBitmapSource();
            return m_InitializeFunc(m_ptr, out ppPlanes.PtrForNew, cPlanes, ref dstFormat, dither, pIPalette!=null ? pIPalette.Ptr : IntPtr.Zero, alphaThresholdPercent, paletteTranslate);
        }
        delegate int InitializeFunc(IntPtr self, out IntPtr ppPlanes, uint cPlanes, ref Guid dstFormat, WICBitmapDitherType dither, IntPtr pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
        InitializeFunc m_InitializeFunc;

        public virtual int CanConvert(
            ref Guid pSrcPixelFormats,
            uint cSrcPlanes,
            ref Guid dstPixelFormat,
            out int pfCanConvert
        ){
            var fp = GetFunctionPointer(9);
            if(m_CanConvertFunc==null) m_CanConvertFunc = (CanConvertFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CanConvertFunc));
            
            return m_CanConvertFunc(m_ptr, ref pSrcPixelFormats, cSrcPlanes, ref dstPixelFormat, out pfCanConvert);
        }
        delegate int CanConvertFunc(IntPtr self, ref Guid pSrcPixelFormats, uint cSrcPlanes, ref Guid dstPixelFormat, out int pfCanConvert);
        CanConvertFunc m_CanConvertFunc;

    }
}