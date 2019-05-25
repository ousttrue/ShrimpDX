/// dwrite.h
using System;
using System.Runtime.InteropServices;
using System.Numerics;

namespace ComPtrCS.WindowsKits.build_10_0_17763_0 {

[Annotation(MethodCount=4)]
public class IDWriteTextRenderer: IDWritePixelSnapping {

    static /*readonly*/ Guid s_uuid = new Guid("ef8a8135-5cc6-45fe-8825-c5a0724eb819");
    public override ref /*readonly*/ Guid IID => ref s_uuid;

    int VTableIndexBase => VTableIndexBase<IDWriteTextRenderer>.Value;
    public HRESULT DrawGlyphRun(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// measuringMode: (DWRITE_MEASURING_MODE)
        , DWRITE_MEASURING_MODE measuringMode
        /// glyphRun: (*(const DWRITE_GLYPH_RUN))
        , ref DWRITE_GLYPH_RUN glyphRun
        /// glyphRunDescription: (*(const DWRITE_GLYPH_RUN_DESCRIPTION))
        , ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 0);
        var callback = (DrawGlyphRunFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawGlyphRunFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, ref glyphRun, ref glyphRunDescription, clientDrawingEffect);
    }
    delegate HRESULT DrawGlyphRunFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, DWRITE_MEASURING_MODE measuringMode, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, IntPtr clientDrawingEffect);
    public HRESULT DrawUnderline(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// underline: (*(const DWRITE_UNDERLINE))
        , ref DWRITE_UNDERLINE underline
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 1);
        var callback = (DrawUnderlineFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawUnderlineFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, ref underline, clientDrawingEffect);
    }
    delegate HRESULT DrawUnderlineFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, ref DWRITE_UNDERLINE underline, IntPtr clientDrawingEffect);
    public HRESULT DrawStrikethrough(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// baselineOriginX: (FLOAT)
        , Single baselineOriginX
        /// baselineOriginY: (FLOAT)
        , Single baselineOriginY
        /// strikethrough: (*(const DWRITE_STRIKETHROUGH))
        , ref DWRITE_STRIKETHROUGH strikethrough
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 2);
        var callback = (DrawStrikethroughFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawStrikethroughFunc));
        return callback(Self, clientDrawingContext, baselineOriginX, baselineOriginY, ref strikethrough, clientDrawingEffect);
    }
    delegate HRESULT DrawStrikethroughFunc(IntPtr self, IntPtr clientDrawingContext, Single baselineOriginX, Single baselineOriginY, ref DWRITE_STRIKETHROUGH strikethrough, IntPtr clientDrawingEffect);
    public HRESULT DrawInlineObject(
        /// clientDrawingContext: (*(void))
        IntPtr clientDrawingContext
        /// originX: (FLOAT)
        , Single originX
        /// originY: (FLOAT)
        , Single originY
        /// inlineObject: (*(IDWriteInlineObject))
        , IntPtr inlineObject
        /// isSideways: (BOOL)
        , Int32 isSideways
        /// isRightToLeft: (BOOL)
        , Int32 isRightToLeft
        /// clientDrawingEffect: (*(IUnknown))
        , IntPtr clientDrawingEffect
    )
    {
        var fp = GetFunctionPointer(VTableIndexBase + 3);
        var callback = (DrawInlineObjectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawInlineObjectFunc));
        return callback(Self, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
    }
    delegate HRESULT DrawInlineObjectFunc(IntPtr self, IntPtr clientDrawingContext, Single originX, Single originY, IntPtr inlineObject, Int32 isSideways, Int32 isRightToLeft, IntPtr clientDrawingEffect);
}
}
