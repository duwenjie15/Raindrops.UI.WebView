using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbWebUrlResponsePtr : IEquatable<mbWebUrlResponsePtr>
    {
        IntPtr _handle;
        public bool Equals(mbWebUrlResponsePtr other)
            => other._handle == _handle;
        public static implicit operator mbWebUrlResponsePtr(IntPtr ptr)
            => new mbWebUrlResponsePtr() { _handle = ptr };
        public static implicit operator IntPtr(mbWebUrlResponsePtr value)
            => value._handle;
    }
}
