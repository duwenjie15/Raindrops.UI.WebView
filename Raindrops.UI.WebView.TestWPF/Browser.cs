using Raindrops.UI.WebView.Miniblink;
using Raindrops.UI.WebView.Miniblink.Event;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Controls.Primitives;

namespace Raindrops.UI.WebView.TestWPF
{
    [TemplatePart(Name = "PART_ContentHost", Type = typeof(FrameworkElement))]
    public class Browser : FrameworkElement, IMiniblinkProxy, IDisposable
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);
        //Draw
        private WriteableBitmap _image;
        private Size _drawSize;
        static Browser()
        {
            SetDllDirectory(System.IO.Path.Combine(Directory.GetCurrentDirectory(), Environment.Is64BitProcess ? "x64\\" : "x86\\"));
        }
        private mbWebsocketHookCallbacks mbWebsocketHookCallbacks;
        private mbPaintBitUpdatedCallback mbPaintBitUpdatedCallback;

        public EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback> LoadUrlBegin;
        public EventAdapter<TitleChangeEventArgs, mbTitleChangedCallback> TitleChanged;
        public EventAdapter<UrlChangeEventArgs, mbURLChangedCallback> UrlChanged;
        public EventAdapter<NewWindowEventArgs, mbCreateViewCallback> NewWindow;
        public EventAdapter<WebSocketWillConnectEventArgs, onWillConnect> WebSocketOnWillConnect;
        public EventAdapter<WebSocketConnectedEventArgs, onConnected> WebSocketOnConnect;
        public EventAdapter<WebSocketDataEventArgs, onReceive> WebSocketOnReceive;
        public EventAdapter<WebSocketDataEventArgs, onSend> WebSocketOnSend;
        public EventAdapter<WebSocketErrorEventArgs, onError> WebSocketOnError;
        public EventAdapter<LoadUrlEndEventArgs, mbLoadUrlEndCallback> LoadUrlEnd;
        public EventAdapter<DocumentReadyEventArgs, mbDocumentReadyCallback> DocumentReady;
        public Browser()
        {
            if (IsDesignMode) return;

            WebView = mbWebView.Create();
            TitleChanged = new EventAdapter<TitleChangeEventArgs, mbTitleChangedCallback>(this, NativeMethods.mbOnTitleChanged);
            UrlChanged = new EventAdapter<UrlChangeEventArgs, mbURLChangedCallback>(this, NativeMethods.mbOnURLChanged);
            NewWindow = new EventAdapter<NewWindowEventArgs, mbCreateViewCallback>(this, NativeMethods.mbOnCreateView);
            LoadUrlBegin = new EventAdapter<LoadUrlBeginEventArgs, mbLoadUrlBeginCallback>(this, NativeMethods.mbOnLoadUrlBegin);
            WebSocketOnWillConnect = new EventAdapter<WebSocketWillConnectEventArgs, onWillConnect>(this, RegSocketOnWillConnect);
            WebSocketOnConnect = new EventAdapter<WebSocketConnectedEventArgs, onConnected>(this, RegSocketOnConnected);
            WebSocketOnReceive = new EventAdapter<WebSocketDataEventArgs, onReceive>(this, RegSocketOnReceive);
            WebSocketOnSend = new EventAdapter<WebSocketDataEventArgs, onSend>(this, RegSocketOnSend);
            WebSocketOnError = new EventAdapter<WebSocketErrorEventArgs, onError>(this, RegSocketOnError);
            LoadUrlEnd = new EventAdapter<LoadUrlEndEventArgs, mbLoadUrlEndCallback>(this, NativeMethods.mbOnLoadUrlEnd);
            DocumentReady = new EventAdapter<DocumentReadyEventArgs, mbDocumentReadyCallback>(this, NativeMethods.mbOnDocumentReady);

            mbPaintBitUpdatedCallback = new mbPaintBitUpdatedCallback(mbPaintBitUpdated);
            NativeMethods.mbOnPaintBitUpdated(WebView, mbPaintBitUpdatedCallback, IntPtr.Zero);
            ClipToBounds = true;
            Focusable = true;
            IsEnabled = true;
            InputMethod.SetIsInputMethodEnabled(this, true);
            InputMethod.SetIsInputMethodSuspended(this, false);
            InputMethod.Current.ImeState = InputMethodState.Off;
        }

        public void mbPaintBitUpdated(mbWebView webview, IntPtr param, IntPtr buffer, ref mbRect r, int width, int height)
        {
            int stride = width * 4;
            if (_image == null || _image.PixelWidth < width || _image.PixelHeight < height)
            {
                _image = new WriteableBitmap(width, height, 96, 96, PixelFormats.Pbgra32, BitmapPalettes.WebPaletteTransparent);
                InvalidateVisual();
            }
            //计算更新区域
            var rect = new Int32Rect();
            rect.X = r.x >= width ? width - 1 : r.x;
            rect.Y = r.y >= height ? height - 1 : r.y;
            rect.Width = rect.X + r.w > width ? width - rect.X : r.w;
            rect.Height = rect.Y + r.h > height ? height - rect.Y : r.h;

            _image.WritePixels(rect, buffer, stride * (rect.Height + rect.Y), stride, r.x, r.y);
            _drawSize = new Size(width, height);
        }
        public mbWebView WebView { get; private set; }
        public bool Simulate { get; set; }
        public bool IsDesignMode
        {
            get
            {
                string processName = Process.GetCurrentProcess().ProcessName;
                return System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) || processName.Contains("devenv") || processName.Contains("DesignToolsServer");
            }
        }
        protected override void OnRender(DrawingContext dc)
        {
            if (IsDesignMode)
            {
                DrawString(dc, "Browser");
                return;
            }
            if (_image != null)
                dc.DrawImage(_image, new Rect(0, 0, _image.Width, _image.Height));
        }
        protected void DrawString(DrawingContext dc, string message)
        {
            FormattedText formattedText = new FormattedText(
               message,
               CultureInfo.CurrentUICulture,
               FlowDirection.LeftToRight,
               new Typeface("Arial"),
               32,
               Brushes.Gray, 1);
            dc.DrawText(formattedText, new Point(0, 0));
        }
        public bool RegSocketOnWillConnect(mbWebView mbWebView, onWillConnect onWillConnect, IntPtr param)
        {
            mbWebsocketHookCallbacks.onWillConnect = onWillConnect;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegWebsocketHookCallbacks(mbWebView mbWebView, ref mbWebsocketHookCallbacks mbWebsocketHookCallbacks, IntPtr param)
        {
            if (mbWebsocketHookCallbacks.CanUse)
                NativeMethods.mbNetSetWebsocketCallback(mbWebView, ref mbWebsocketHookCallbacks, param);
            return true;
        }
        public bool RegSocketOnConnected(mbWebView mbWebView, onConnected onConnected, IntPtr param)
        {
            mbWebsocketHookCallbacks.onConnected = onConnected;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnReceive(mbWebView mbWebView, onReceive onReceive, IntPtr param)
        {
            mbWebsocketHookCallbacks.onReceive = onReceive;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param); ;
        }
        public bool RegSocketOnSend(mbWebView mbWebView, onSend onSend, IntPtr param)
        {
            mbWebsocketHookCallbacks.onSend = onSend;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        public bool RegSocketOnError(mbWebView mbWebView, onError onError, IntPtr param)
        {
            mbWebsocketHookCallbacks.onError = onError;
            return RegWebsocketHookCallbacks(mbWebView, ref mbWebsocketHookCallbacks, param);
        }
        protected override void OnGotFocus(RoutedEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.SetFocus();
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(RoutedEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.KillFocus();
            }
            base.OnLostFocus(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point point = e.GetPosition(this);
            if (WebView.HaveValue && !Simulate)
            {
                WebView.FireMouseEvent((uint)mbMouseMsg.MB_MSG_MOUSEMOVE, (int)point.X, (int)point.Y, (uint)GetMouseFlags(e));
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            Focus();
            Point point = e.GetPosition(this);
            if (WebView.HaveValue && !Simulate)
                WebView.FireMouseEvent((uint)GetmbMouseMsg(e), (int)point.X, (int)point.Y, (uint)GetMouseFlags(e));
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(this);
            if (WebView.HaveValue && !Simulate)
                WebView.FireMouseEvent((uint)GetmbMouseMsg(e), (int)point.X, (int)point.Y, (uint)GetMouseFlags(e));
            base.OnMouseDown(e);
        }
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                Point point = e.GetPosition(this);
                WebView.FireMouseWheelEvent((int)point.X, (int)point.Y, e.Delta, (uint)GetMouseFlags(e));
            }
            base.OnMouseWheel(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                WebView.FireKeyDownEvent((uint)KeyInterop.VirtualKeyFromKey(e.Key), 0, false);
            }
            base.OnKeyDown(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                 WebView.FireKeyUpEvent((uint)KeyInterop.VirtualKeyFromKey(e.Key), 0, false);
            }
            base.OnKeyUp(e);
        }
        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            if (WebView.HaveValue && !Simulate)
            {
                if (!string.IsNullOrEmpty(e.Text))
                    foreach (char wchar in e.Text)
                        WebView.FireKeyPressEvent((uint)wchar, 0, false);
            }
            base.OnTextInput(e);
        }
        private static mbMouseMsg GetmbMouseMsg(MouseButtonEventArgs e)
        {
            mbMouseMsg flags = 0;
            switch (e.ChangedButton)
            {
                case MouseButton.Left:
                    flags |= e.LeftButton == MouseButtonState.Pressed ? mbMouseMsg.MB_MSG_LBUTTONDOWN : mbMouseMsg.MB_MSG_LBUTTONUP;
                    break;
                case MouseButton.Right:
                    flags |= e.LeftButton == MouseButtonState.Released ? mbMouseMsg.MB_MSG_RBUTTONDOWN : mbMouseMsg.MB_MSG_RBUTTONUP;
                    break;
                case MouseButton.Middle:
                    flags |= e.LeftButton == MouseButtonState.Released ? mbMouseMsg.MB_MSG_MBUTTONDOWN : mbMouseMsg.MB_MSG_MBUTTONUP;
                    break;
            }
            return flags;
        }
        private static mbMouseFlags GetMouseFlags(MouseEventArgs e)
        {
            mbMouseFlags flags = 0;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                flags |= mbMouseFlags.MB_LBUTTON;
            }
            if (e.RightButton == MouseButtonState.Pressed)
            {
                flags |= mbMouseFlags.MB_RBUTTON;
            }
            if (e.MiddleButton == MouseButtonState.Pressed)
            {
                flags |= mbMouseFlags.MB_MBUTTON;
            }
            return flags;
        }
        private Window _window;
        private HwndSource _hwndSource;
        private HwndSourceHook _hwndSourceHook;
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (WebView.HaveValue)
            {
                int width = (int)sizeInfo.NewSize.Width;
                int height = (int)sizeInfo.NewSize.Height;

                _window = Window.GetWindow(this);
                if (_hwndSource == null)
                {
                    _hwndSource = HwndSource.FromHwnd(new WindowInteropHelper(_window).Handle);
                    Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Debug.WriteLine(_hwndSource.Handle);
                    _hwndSourceHook = new HwndSourceHook(HwndSourceHook);
                    _hwndSource.AddHook(HwndSourceHook);
                    WebView.SetHandle(_hwndSource.Handle);
                }
                Point location = TransformToVisual(_window).Transform(new Point(0, 0));
                WebView.SetHandleOffset((int)location.X, (int)location.Y);
                WebView.Resize(width, height);
                if (_image != null)
                {
                    if (_drawSize.Width <= 100 || _drawSize.Height <= 100 || sizeInfo.NewSize.Width <= 100 || sizeInfo.NewSize.Height <= 100)
                    {
                        _drawSize = sizeInfo.NewSize;
                    }
                    else
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        while (_drawSize != sizeInfo.NewSize && stopwatch.ElapsedMilliseconds < 500)
                        {
                            WebView.Wake();
                        }
                        stopwatch.Stop();
                    }
                }
            }
            base.OnRenderSizeChanged(sizeInfo);
        }
        private IntPtr HwndSourceHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            IntPtr r = IntPtr.Zero;

            if (WebView.HaveValue && WebView.FireWindowsMessage(hwnd, (uint)msg, wParam, lParam, ref r))
            {
                handled = true;
                return r;
            }

            return IntPtr.Zero;
        }
        public void Dispose()
        {
            if (_hwndSource != null)
            {
                _hwndSource.Dispose();
            }
            WebView.SetHandle(IntPtr.Zero);
            WebView.Destroy();
        }
    }
}
