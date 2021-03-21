using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbWebFrameHandle : IEquatable<mbWebFrameHandle>
    {
        IntPtr _handle;
        public bool Equals(mbWebFrameHandle other)
            => other._handle == _handle;
        public static implicit operator mbWebFrameHandle(IntPtr ptr)
            => new mbWebFrameHandle() { _handle = ptr };
        public static implicit operator IntPtr(mbWebFrameHandle value)
            => value._handle;
    }
}
