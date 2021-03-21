using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationEventArgs()
        {

        }
        [Map(IsRet = true)]
        public bool Continue { get; set; }
        [Map(Name = "mbNavigationType")]
        public mbNavigationType NavigationType { get; set; }
        [Map(Name = "url")]
        public string Url { get; set; }
    }
}
