using System;
using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.PInvoke;

namespace Raindrops.UI.WebView.Miniblink.Event
{
    public class ConsoleMessageEventArgs : EventArgs
    {
        public ConsoleMessageEventArgs()
        {

        }
        [Map(Name = "level")]
        public mbConsoleLevel ConsoleLevel { get; set; }
        [Map(Name = "message")]
        public string Message { get; set; }
        [Map(Name = "sourceName")]
        public string SourceName { get; set; }
        [Map(Name = "stackTrace")]
        public string StackTrace { get; set; }
        [Map(Name = "sourceLine")]
        public int SourceLine { get; set; }
    }
}
