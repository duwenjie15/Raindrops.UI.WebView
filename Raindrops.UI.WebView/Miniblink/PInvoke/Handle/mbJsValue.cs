using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbJsValue : IEquatable<mbJsValue>
    {
        long _handle;
        public bool Equals(mbJsValue other)
            => other._handle == _handle;
        public static implicit operator mbJsValue(long ptr)
            => new mbJsValue() { _handle = ptr };
        public static implicit operator long(mbJsValue value)
            => value._handle;
    }
}
