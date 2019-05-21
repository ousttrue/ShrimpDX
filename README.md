# WindowsSDKImport

Import com interface DXGI, D3D11, D2D1, DirectWrite etc...

Avoid using RCW, not use `[Guid]` and `[ComImport]`.
Instead of that, get IntPtr and call method from VTable directly.

## Implementation

Generate code like below to all com methods by https://github.com/ousttrue/pycpptool.

```cs
// ComPtr.cs
    Int32 QueryInterface(
            ref Guid iid
            , ref IntPtr ppvObject
            )
    {
        var fp = GetFunctionPointer(0);
        var callback = (QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInterfaceFunc));
        return callback(Self, ref iid, ref ppvObject);
    }
    delegate Int32 QueryInterfaceFunc(IntPtr self, ref Guid iid, ref IntPtr ppvObject);
```

## d3d11

OK

## d2d1_1

OK

## DirectWrite

ToDo

## WIC

ToDo
