using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class UrlChangeEventArgs : EventArgs
    {
        public UrlChangeEventArgs()
        {
        }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "canGoBack")]
        public bool CanGoBack { get; set; }
        [Map(Name = "canGoForward")]
        public bool CanGoForward { get; set; }
    }
}
