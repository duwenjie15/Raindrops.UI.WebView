
# Welcome to Raindrops.UI.WebView
 miniblink vip版本封装使用 QQ:744257911
使用它你可以很轻松将miniblink引入你的任何C#项目
所有的P/Invoke代码位于NativeMethods内部
所有的事件位于 Miniblink/Event目录下

已封装好常用功能以及WebSocket接口,详细使用方法请看Raindrops.UI.WebView.TestWinForm

## 使用前需要
1、来自miniblink的 mb.dll node.dll
2、引入 
        using Raindrops.UI.WebView.Miniblink;
        using Raindrops.UI.WebView.Miniblink.Event;
        using Raindrops.UI.WebView.Miniblink.PInvoke;
        using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
3、继承IMiniblinkProxy接口

## 使用EventAdapterr<TEventArgs, TCallback> 它将自动寻找TCallback回调和TEventArgs属性、字段之间的对应关系,并自动封装成事件。
## EventAdapterr<TEventArgs, TCallback> 内部使用ILEmit构造代码,无需担心性能问题。

## 例子：
    public class LoadUrlBeginEventArgs : EventArgs
    {
        [Map(Name = "url")]
        public string Url { get; set; }
        [Map(Name = "job")]
        public mbNetJob Job { get; set; }
        [Map(IsRet = true)]
        public bool Result { get; set; }
    }

public partial class Browser : UserControl, IMiniblinkProxy
{
     public EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback> LoadUrlBegin;
     public Browser()
     {
         LoadUrlBegin = new EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback>(this, NativeMethods.mbOnLoadUrlBegin);
         LoadUrlBegin.EventHandler += LoadUrlBegin_EventHandler;
     }
     private void LoadUrlBegin_EventHandler(object sender, Miniblink.Event.LoadUrlBeginEventArgs eventArgs)
      {
          if(eventArgs.Url.Contains("aaaaaa"))  eventArgs.Job.ChangeRequestUrl("www.baidu.com");

          var postBody = eventArgs.Job.GetPostBody();
          if (postBody.elementSize.ToUInt32() > 0)
          {
              foreach (var body in postBody.GetElements())
              {
                  var buffer = body.GetData().ToArray();
                  string value = Encoding.UTF8.GetString(buffer);
                  AppendLog($"Post {eventArgs.Url} -> StringLength:{value.Length}");
              }
           }
      }
}
 So Easy
# Welcome to Raindrops.UI.WebView
 miniblink vip版本封装使用 QQ:744257911
使用它你可以很轻松将miniblink引入你的任何C#项目
所有的P/Invoke代码位于NativeMethods内部
所有的事件位于 Miniblink/Event目录下

已封装好常用功能以及WebSocket接口,详细使用方法请看Raindrops.UI.WebView.TestWinForm

## 使用前需要
1、来自miniblink的 mb.dll node.dll
2、引入 
        using Raindrops.UI.WebView.Miniblink;
        using Raindrops.UI.WebView.Miniblink.Event;
        using Raindrops.UI.WebView.Miniblink.PInvoke;
        using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
3、继承IMiniblinkProxy接口

## 使用EventAdapterr<TEventArgs, TCallback> 它将自动寻找TCallback回调和TEventArgs属性、字段之间的对应关系,并自动封装成事件。
## EventAdapterr<TEventArgs, TCallback> 内部使用ILEmit构造代码,无需担心性能问题。

## 例子：
	  public class LoadUrlBeginEventArgs : EventArgs
	  {
	      [Map(Name = "url")]
	      public string Url { get; set; }
	      [Map(Name = "job")]
	      public mbNetJob Job { get; set; }
	      [Map(IsRet = true)]
	      public bool Result { get; set; }
	  }

	public partial class Browser : UserControl, IMiniblinkProxy
	{
	     public EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback> LoadUrlBegin;
	     public Browser()
	     {
	         LoadUrlBegin = new EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback>(this, NativeMethods.mbOnLoadUrlBegin);
	         LoadUrlBegin.EventHandler += LoadUrlBegin_EventHandler;
	     }
	     private void LoadUrlBegin_EventHandler(object sender, Miniblink.Event.LoadUrlBeginEventArgs eventArgs)
	      {
	          if(eventArgs.Url.Contains("aaaaaa"))  eventArgs.Job.ChangeRequestUrl("www.baidu.com");

	          var postBody = eventArgs.Job.GetPostBody();
	          if (postBody.elementSize.ToUInt32() > 0)
	          {
	              foreach (var body in postBody.GetElements())
	              {
	                  var buffer = body.GetData().ToArray();
	                  string value = Encoding.UTF8.GetString(buffer);
	                  AppendLog($"Post {eventArgs.Url} -> StringLength:{value.Length}");
	              }
	           }
	      }
	}
 So Easy
