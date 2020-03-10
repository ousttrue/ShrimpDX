// This source code was generated by regenerator"
using System;
using System.Runtime.InteropServices;

namespace ShrimpDX {
    [StructLayout(LayoutKind.Explicit)]
    public struct tagPROPVARIANT__anonymous_3 // 1
    {
       // anonymous struct __param__;
        [FieldOffset(0)]
        public tagDEC decVal;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPROPVARIANT___anonymous_4 // 1
    {
        public ushort vt;
        public ushort wReserved1;
        public ushort wReserved2;
        public ushort wReserved3;
        // anonymous union
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct tagPROPVARIANT____anonymous_8 // 1
    {
        [FieldOffset(0)]
        public sbyte cVal;
        [FieldOffset(0)]
        public byte bVal;
        [FieldOffset(0)]
        public short iVal;
        [FieldOffset(0)]
        public ushort uiVal;
        [FieldOffset(0)]
        public int lVal;
        [FieldOffset(0)]
        public uint ulVal;
        [FieldOffset(0)]
        public int intVal;
        [FieldOffset(0)]
        public uint uintVal;
        [FieldOffset(0)]
        public _LARGE_INTEGER hVal;
        [FieldOffset(0)]
        public _ULARGE_INTEGER uhVal;
        [FieldOffset(0)]
        public float fltVal;
        [FieldOffset(0)]
        public double dblVal;
        [FieldOffset(0)]
        public short boolVal;
        [FieldOffset(0)]
        public short __OBSOLETE__VARIANT_BOOL;
        [FieldOffset(0)]
        public int scode;
        [FieldOffset(0)]
        public tagCY cyVal;
        [FieldOffset(0)]
        public double date;
        [FieldOffset(0)]
        public _FILETIME filetime;
        [FieldOffset(0)]
        public IntPtr puuid;
        [FieldOffset(0)]
        public IntPtr pclipdata;
        [FieldOffset(0)]
        public IntPtr bstrVal;
        [FieldOffset(0)]
        public tagBSTRBLOB bstrblobVal;
        [FieldOffset(0)]
        public tagBLOB blob;
        [FieldOffset(0)]
        public IntPtr pszVal;
        [FieldOffset(0)]
        public IntPtr pwszVal;
        [FieldOffset(0)]
        public IUnknown punkVal;
        [FieldOffset(0)]
        public IDispatch pdispVal;
        [FieldOffset(0)]
        public IStream pStream;
        [FieldOffset(0)]
        public IStorage pStorage;
        [FieldOffset(0)]
        public IntPtr pVersionedStream;
        [FieldOffset(0)]
        public IntPtr parray;
        [FieldOffset(0)]
        public tagCAC cac;
        [FieldOffset(0)]
        public tagCAUB caub;
        [FieldOffset(0)]
        public tagCAI cai;
        [FieldOffset(0)]
        public tagCAUI caui;
        [FieldOffset(0)]
        public tagCAL cal;
        [FieldOffset(0)]
        public tagCAUL caul;
        [FieldOffset(0)]
        public tagCAH cah;
        [FieldOffset(0)]
        public tagCAUH cauh;
        [FieldOffset(0)]
        public tagCAFLT caflt;
        [FieldOffset(0)]
        public tagCADBL cadbl;
        [FieldOffset(0)]
        public tagCABOOL cabool;
        [FieldOffset(0)]
        public tagCASCODE cascode;
        [FieldOffset(0)]
        public tagCACY cacy;
        [FieldOffset(0)]
        public tagCADATE cadate;
        [FieldOffset(0)]
        public tagCAFILETIME cafiletime;
        [FieldOffset(0)]
        public tagCACLSID cauuid;
        [FieldOffset(0)]
        public tagCACLIPDATA caclipdata;
        [FieldOffset(0)]
        public tagCABSTR cabstr;
        [FieldOffset(0)]
        public tagCABSTRBLOB cabstrblob;
        [FieldOffset(0)]
        public tagCALPSTR calpstr;
        [FieldOffset(0)]
        public tagCALPWSTR calpwstr;
        [FieldOffset(0)]
        public tagCAPROPVARIANT capropvar;
        [FieldOffset(0)]
        public IntPtr pcVal;
        [FieldOffset(0)]
        public IntPtr pbVal;
        [FieldOffset(0)]
        public IntPtr piVal;
        [FieldOffset(0)]
        public IntPtr puiVal;
        [FieldOffset(0)]
        public IntPtr plVal;
        [FieldOffset(0)]
        public IntPtr pulVal;
        [FieldOffset(0)]
        public IntPtr pintVal;
        [FieldOffset(0)]
        public IntPtr puintVal;
        [FieldOffset(0)]
        public IntPtr pfltVal;
        [FieldOffset(0)]
        public IntPtr pdblVal;
        [FieldOffset(0)]
        public IntPtr pboolVal;
        [FieldOffset(0)]
        public IntPtr pdecVal;
        [FieldOffset(0)]
        public IntPtr pscode;
        [FieldOffset(0)]
        public IntPtr pcyVal;
        [FieldOffset(0)]
        public IntPtr pdate;
        [FieldOffset(0)]
        public IntPtr pbstrVal;
        [FieldOffset(0)]
        public IntPtr ppunkVal;
        [FieldOffset(0)]
        public IntPtr ppdispVal;
        [FieldOffset(0)]
        public IntPtr pparray;
        [FieldOffset(0)]
        public IntPtr pvarVal;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPROPVARIANT // 1
    {
        public tagPROPVARIANT__anonymous_3 __param__1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVersionedStream // 2
    {
        public Guid guidVersion;
        public IStream pStream;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAC // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUB // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAI // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUI // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAL // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUL // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAH // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUH // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAFLT // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCADBL // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABOOL // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCASCODE // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACY // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCADATE // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAFILETIME // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACLSID // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACLIPDATA // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABSTR // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABSTRBLOB // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCALPSTR // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCALPWSTR // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAPROPVARIANT // 1
    {
        public uint cElems;
        public IntPtr pElems;
    }
}
