using System;

namespace Raindrops.UI.WebView.Miniblink.PInvoke.Handle
{
    public struct mbJsExecState : IEquatable<mbJsExecState>
    {
        IntPtr _handle;
        public bool Equals(mbJsExecState other)
            => other._handle == _handle;
        public static implicit operator mbJsExecState(IntPtr ptr)
            => new mbJsExecState() { _handle = ptr };
        public static implicit operator IntPtr(mbJsExecState value)
            => value._handle;
    }
}
