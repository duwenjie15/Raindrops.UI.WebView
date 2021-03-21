using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class NewWindowEventArgs : EventArgs
    {
        public NewWindowEventArgs()
        {

        }
        [Map(IsRet = true)]
        public mbWebView WebView { get; set; }
        [Map(Name = "navigationType")]
        public mbNavigationType NavigationType { get; set; }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "windowFeatures")]
        public mbWindowFeatures WindowFeatures { get; set; }
    }
}
