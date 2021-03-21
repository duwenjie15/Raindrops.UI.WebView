using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class DidCreateScriptContextEventArgs : EventArgs
    {
        [Map(Name = "webView")]
        public mbWebView WebView { get; set; }
        [Map(Name = "param")]
        public IntPtr Param { get; set; }
        [Map(Name = "frameId")]
        public mbWebFrameHandle FrameId { get; set; }
        [Map(Name = "context")]
        public IntPtr Context { get; set; }
        [Map(Name = "extensionGroup")]
        public int ExtensionGroup { get; set; }
        [Map(Name = "worldId")]
        public int WorldId { get; set; }
    }
}
