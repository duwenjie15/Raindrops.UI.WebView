using Raindrops.UI.WebView.Miniblink;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Raindrops.UI.WebView.TestWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            LoadUrl(url);
        }
        private void LoadUrl(string url)
        {
            url = url.Trim();
            browser1.WebView.LoadUrl(url);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            browser1 = new Browser() { Dock = DockStyle.Fill };
            browser1.KeyUp += browser1_KeyUp;
            //var browser2 = new Browser() { Dock = DockStyle.Fill };
            tableLayoutPanel1.Controls.Add(browser1, 0, 1);
            //tableLayoutPanel1.Controls.Add(browser2, 0, 2);
            browser1.TitleChanged.EventHandler += TitleChanged_EventHandler;
            browser1.LoadUrlBegin.EventHandler += LoadUrlBegin_EventHandler;
            browser1.WebSocketOnWillConnect.EventHandler += WebSocketOnWillConnect_EventHandler;
            browser1.WebSocketOnConnect.EventHandler += WebSocketOnConnect_EventHandler;
            browser1.WebSocketOnSend.EventHandler += WebSocketOnSend_EventHandler;
            browser1.WebSocketOnReceive.EventHandler += WebSocketOnReceive_EventHandler;
            browser1.WebSocketOnError.EventHandler += WebSocketOnError_EventHandler;
            //browser1.WebView.LoadUrl("app://./login.html");
            browser1.WebView.LoadUrl("http://www.baidu.com");
        }

        private void WebSocketOnError_EventHandler(object sender, Miniblink.Event.WebSocketErrorEventArgs eventArgs)
        {
            AppendLog($"OnError Channel:{eventArgs?.Channel}");
        }

        private void WebSocketOnReceive_EventHandler(object sender, Miniblink.Event.WebSocketDataEventArgs eventArgs)
        {
            AppendLog($"OnReceive Channel:{eventArgs.Channel} DataSize:{eventArgs.GetBuffer()?.Length ?? 0}");
        }

        private void WebSocketOnSend_EventHandler(object sender, Miniblink.Event.WebSocketDataEventArgs eventArgs)
        {
            AppendLog($"OnSend Channel:{eventArgs.Channel} DataSize:{eventArgs.GetBuffer()?.Length ?? 0}");
        }

        private void WebSocketOnConnect_EventHandler(object sender, Miniblink.Event.WebSocketConnectedEventArgs eventArgs)
        {
            AppendLog($"OnConnect Channel:{eventArgs?.Channel}");
        }

        private void WebSocketOnWillConnect_EventHandler(object sender, Miniblink.Event.WebSocketWillConnectEventArgs eventArgs)
        {
            //此处设置为true 才会继续后面流程
            eventArgs.NeedHook = true;
            AppendLog($"OnWillConnect{eventArgs.Url}");
        }

        private void browser1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("front_end");
                if (directoryInfo.Exists)
                {
                    browser1.WebView.SetDebugConfig("showDevTools", Path.Combine(directoryInfo.FullName, "inspector.html"));
                }
            }
        }
        private void LoadUrlBegin_EventHandler(object sender, Miniblink.Event.LoadUrlBeginEventArgs eventArgs)
        {
            string url = eventArgs.Url;
            DirectoryInfo directoryInfo = new DirectoryInfo("app");
            if (url.StartsWith("app://") && directoryInfo.Exists)
            {
                var fmd = url.Replace("app://", null).Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                string[] filePaths = new string[fmd.Length + 1];
                filePaths[0] = directoryInfo.FullName;
                Array.Copy(fmd, 0, filePaths, 1, fmd.Length);
                string fileName = Path.Combine(filePaths);
                if (File.Exists(fileName))
                {
                    eventArgs.Job.SetData(File.ReadAllBytes(fileName));
                    return;
                }
            }
            AppendLog($"未知Url" + url);
            //eventArgs.Result = true;
            //AppendLog($"OnLoadUrlBegin{eventArgs.Url}");
            //if(eventArgs.Url.Contains("aaaaaa"))
            //    eventArgs.Job.ChangeRequestUrl("www.baidu.com");
            //BeginInvoke(new Action(() => {
            //    textBox1.Text = eventArgs.Url;
            //}));
            //Miniblink.PInvoke.Handle.mbPostBodyElements postBody = eventArgs.Job.GetPostBody();
            //if (postBody.elementSize.ToUInt32() > 0)
            //    foreach (Miniblink.PInvoke.Handle.mbPostBodyElement body in postBody.GetElements())
            //    {
            //        //var buffer = body.GetData().ToArray();
            //        //string value = Encoding.UTF8.GetString(buffer);
            //        //AppendLog($"Post {eventArgs.Url} -> StringLength:{value.Length}");
            //    }
        }
        private void AppendLog(string message)
        {
            BeginInvoke(new Action(() => {
                textBox2.AppendText($"{DateTime.Now.ToShortTimeString()} : {message}{Environment.NewLine}");
            }));
        }

        private void TitleChanged_EventHandler(object sender, Miniblink.Event.TitleChangeEventArgs eventArgs)
        {
            BeginInvoke(new Action(() => {
                Text = eventArgs.Title;
            }));
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string script = textBox3.Text.Trim();
            browser1.RunJs(script, true).ContinueWith((x) => {
                MessageBox.Show(x.Result.ToString());
            });
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
