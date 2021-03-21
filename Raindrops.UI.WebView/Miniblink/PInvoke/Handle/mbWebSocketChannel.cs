using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbWebSocketChannel : IEquatable<mbWebSocketChannel>
    {
        IntPtr _handle;
        public bool Equals(mbWebSocketChannel other)
            => other._handle == _handle;
        public static implicit operator mbWebSocketChannel(IntPtr ptr)
            => new mbWebSocketChannel() { _handle = ptr };
        public static implicit operator IntPtr(mbWebSocketChannel value)
            => value._handle;
    }
}
