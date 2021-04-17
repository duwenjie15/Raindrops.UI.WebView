﻿using Raindrops.UI.WebView.Miniblink.PInvoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raindrops.UI.WebView.TestWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            browser1 = new Browser() { Dock = DockStyle.Fill };
            tableLayoutPanel1.Controls.Add(browser1, 0, 1);
            browser1.WebView.SetHandle(browser1.Handle);
            browser1.TitleChanged.EventHandler += TitleChanged_EventHandler;
            browser1.LoadUrlBegin.EventHandler += LoadUrlBegin_EventHandler;
            browser1.WebSocketOnWillConnect.EventHandler += WebSocketOnWillConnect_EventHandler;
            browser1.WebSocketOnConnect.EventHandler += WebSocketOnConnect_EventHandler;
            browser1.WebSocketOnSend.EventHandler += WebSocketOnSend_EventHandler;
            browser1.WebSocketOnReceive.EventHandler += WebSocketOnReceive_EventHandler;
            browser1.WebSocketOnError.EventHandler += WebSocketOnError_EventHandler;
            browser1.WebView.LoadUrl("http://coolaf.com/tool/chattest");
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

        private void WebSocketOnError_EventHandler(object sender, Miniblink.Event.WebSocketErrorEventArgs eventArgs)
        {
            AppendLog($"OnError Channel:{eventArgs.Channel}");
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
            AppendLog($"OnConnect Channel:{eventArgs.Channel}");
        }

        private void WebSocketOnWillConnect_EventHandler(object sender, Miniblink.Event.WebSocketWillConnectEventArgs eventArgs)
        {
            //此处设置为true 才会继续后面流程
            eventArgs.NeedHook = true;
            AppendLog($"OnWillConnect{eventArgs.Url}");
        }
        
        private void LoadUrlBegin_EventHandler(object sender, Miniblink.Event.LoadUrlBeginEventArgs eventArgs)
        {
            if(eventArgs.Url.Contains("aaaaaa"))
                eventArgs.Job.ChangeRequestUrl("www.baidu.com");
            BeginInvoke(new Action(() => {
                textBox1.Text = eventArgs.Url;
            }));
            var postBody = eventArgs.Job.GetPostBody();
            if (postBody.elementSize.ToUInt32() > 0)
                foreach (var body in postBody.GetElements())
                {
                    var buffer = body.GetData().ToArray();
                    string value = Encoding.UTF8.GetString(buffer);
                    AppendLog($"Post {eventArgs.Url} -> StringLength:{value.Length}");
                }
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
                this.textBox1.Text = eventArgs.Title;
            }));
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        { 
            string script = textBox3.Text.Trim();
            object result = await browser1.WebView.RunJs(script, true);
            MessageBox.Show(result.ToString());
        }
    }
}
