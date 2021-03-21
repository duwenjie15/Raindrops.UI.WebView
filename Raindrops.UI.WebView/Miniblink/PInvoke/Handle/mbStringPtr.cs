using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbStringPtr : IEquatable<mbStringPtr>
    {
        IntPtr _handle;
        public bool Equals(mbStringPtr other)
            => other._handle == _handle;
        public static implicit operator mbStringPtr(IntPtr ptr)
            => new mbStringPtr() { _handle = ptr };
        public static implicit operator IntPtr(mbStringPtr value)
            => value._handle;
        public string GetString() => NativeMethods.mbGetString(_handle);
    }
}
