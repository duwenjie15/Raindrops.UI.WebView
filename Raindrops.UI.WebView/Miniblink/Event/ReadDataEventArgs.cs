using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class AlertBoxEventArgs : EventArgs
    {
        public AlertBoxEventArgs()
        {

        }
        [Map(Name = "msg")]
        public string Message { get; set; }
    }
}
