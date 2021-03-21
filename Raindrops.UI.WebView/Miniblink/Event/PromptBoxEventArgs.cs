using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class PromptBoxEventArgs : EventArgs
    {
        public PromptBoxEventArgs()
        {

        }

        [Map(Name = "msg")]
        public string Message { get; set; }
        [Map(IsRet = true)]
        public string Result { get; set; }
        [Map(Name = "defaultResult")]
        public string DefaultResult { get; }
    }
}
