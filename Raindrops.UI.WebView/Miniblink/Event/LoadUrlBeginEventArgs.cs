using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class LoadUrlBeginEventArgs : EventArgs
    {
        public LoadUrlBeginEventArgs()
        {

        }
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "job")]
        public mbNetJob Job { get; set; }
        [Map(IsRet = true)]
        public bool Result { get; set; }
    }
}
