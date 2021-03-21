using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbWebUrlRequestPtr : IEquatable<mbWebUrlRequestPtr>
    {
        IntPtr _handle;
        public bool Equals(mbWebUrlRequestPtr other)
            => other._handle == _handle;
        public static implicit operator mbWebUrlRequestPtr(IntPtr ptr)
            => new mbWebUrlRequestPtr() { _handle = ptr };
        public static implicit operator IntPtr(mbWebUrlRequestPtr value)
            => value._handle;
    }
}
