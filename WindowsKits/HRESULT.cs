using System;
using System.Runtime.InteropServices;

namespace WindowsKits
{
    public class ComException : Exception
    {
        public readonly UInt32 ErrorCode;

        public ComException(int errorCode)
        {
            ErrorCode = (uint)errorCode;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct HRESULT
    {
        public readonly int Value;
        public bool Succeeded => Value == 0;

        public bool Failed => Value != 0;


        public HRESULT(int value)
        {
            Value = value;
        }

        public void ThrowIfFailed()
        {
            if (Value != 0)
            {
                throw new ComException(Value);
            }
        }
    }
}