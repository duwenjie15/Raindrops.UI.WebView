using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class TitleChangeEventArgs : EventArgs
    {
        public TitleChangeEventArgs()
        {
        }
        [Map(Name = "title")]
        public string Title { get; set; }
    }
}
