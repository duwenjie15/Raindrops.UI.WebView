using System;
using System.Runtime.InteropServices;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

using size_t = System.UIntPtr;

namespace Raindrops.UI.WebView.Miniblink.PInvoke
{
    public static partial class NativeConstants
    {
        public const CallingConvention MB_CALL_TYPE = CallingConvention.StdCall;
        public const string MbDllPath = "mb.dll";
        public const string NodeDllPath = "node.dll";
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbRect
    {
        public int x;
        public int y;
        public int w;
        public int h;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbPoint
    {
        public int x;
        public int y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbSize
    {
        public int w;
        public int h;
    }
    public enum mbMouseFlags
    {
        MB_LBUTTON = 1,
        MB_RBUTTON = 2,
        MB_SHIFT = 4,
        MB_CONTROL = 8,
        MB_MBUTTON = 16,
    }
    public enum mbKeyFlags
    {
        MB_EXTENDED = 256,
        MB_REPEAT = 16384,
    }
    public enum mbMouseMsg
    {
        MB_MSG_MOUSEMOVE = 512,
        MB_MSG_LBUTTONDOWN = 513,
        MB_MSG_LBUTTONUP = 514,
        MB_MSG_LBUTTONDBLCLK = 515,
        MB_MSG_RBUTTONDOWN = 516,
        MB_MSG_RBUTTONUP = 517,
        MB_MSG_RBUTTONDBLCLK = 518,
        MB_MSG_MBUTTONDOWN = 519,
        MB_MSG_MBUTTONUP = 520,
        MB_MSG_MBUTTONDBLCLK = 521,
        MB_MSG_MOUSEWHEEL = 522,
    }
    public enum mbProxyType
    {
        MB_PROXY_NONE,
        MB_PROXY_HTTP,
        MB_PROXY_SOCKS4,
        MB_PROXY_SOCKS4A,
        MB_PROXY_SOCKS5,
        MB_PROXY_SOCKS5HOSTNAME,
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct mbProxy
    {
        public mbProxyType type;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string hostname;
        public ushort port;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string username;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string password;
    }
    public enum mbSettingMask : uint
    {
        MB_SETTING_PROXY = 1,
        MB_SETTING_PAINTCALLBACK_IN_OTHER_THREAD = (1) << (2),
        MB_ENABLE_NODEJS = (1) << (3),
        MB_ENABLE_DISABLE_H5VIDEO = (1) << (4),
        MB_ENABLE_DISABLE_PDFVIEW = (1) << (5),
        MB_ENABLE_DISABLE_CC = (1) << (6),
    }

    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnBlinkThreadInitCallback(IntPtr param);


    [StructLayout(LayoutKind.Sequential)]
    public struct mbSettings
    {
        public mbProxy proxy;
        public mbSettingMask mask;
        public mbOnBlinkThreadInitCallback blinkThreadInitCallback;
        public IntPtr blinkThreadInitCallbackParam;
        public IntPtr version;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string mainDllPath;
        public IntPtr mainDllHanlde;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct mbViewSettings
    {
        public int size;
        public uint bgColor;
    }

    public delegate int mbCookieVisitor(IntPtr @params, [In, MarshalAs(UnmanagedType.LPStr)] string name, [In, MarshalAs(UnmanagedType.LPStr)] string value, [In, MarshalAs(UnmanagedType.LPStr)] string domain,
        [In, MarshalAs(UnmanagedType.LPStr)] string path,   // If |path| is non-empty only URLs at or below the path will get the cookie value.
        int secure,                                         // If |secure| is true the cookie will only be sent for HTTPS requests.
        int httpOnly,                                       // If |httponly| is true the cookie will only be sent for HTTP requests.
        ref int expires                                     // The cookie expiration date is only valid if |has_expires| is true.
        );
    public enum mbCookieCommand
    {
        mbCookieCommandClearAllCookies,
        mbCookieCommandClearSessionCookies,
        mbCookieCommandFlushCookiesToFile,
        mbCookieCommandReloadCookiesFromFile,
    }
    public enum mbNavigationType
    {
        MB_NAVIGATION_TYPE_LINKCLICK,
        MB_NAVIGATION_TYPE_FORMSUBMITTE,
        MB_NAVIGATION_TYPE_BACKFORWARD,
        MB_NAVIGATION_TYPE_RELOAD,
        MB_NAVIGATION_TYPE_FORMRESUBMITT,
        MB_NAVIGATION_TYPE_OTHER,
    }
    public enum mbCursorInfoType
    {
        kMbCursorInfoPointer,
        kMbCursorInfoCross,
        kMbCursorInfoHand,
        kMbCursorInfoIBeam,
        kMbCursorInfoWait,
        kMbCursorInfoHelp,
        kMbCursorInfoEastResize,
        kMbCursorInfoNorthResize,
        kMbCursorInfoNorthEastResize,
        kMbCursorInfoNorthWestResize,
        kMbCursorInfoSouthResize,
        kMbCursorInfoSouthEastResize,
        kMbCursorInfoSouthWestResize,
        kMbCursorInfoWestResize,
        kMbCursorInfoNorthSouthResize,
        kMbCursorInfoEastWestResize,
        kMbCursorInfoNorthEastSouthWestResize,
        kMbCursorInfoNorthWestSouthEastResize,
        kMbCursorInfoColumnResize,
        kMbCursorInfoRowResize,
        kMbCursorInfoMiddlePanning,
        kMbCursorInfoEastPanning,
        kMbCursorInfoNorthPanning,
        kMbCursorInfoNorthEastPanning,
        kMbCursorInfoNorthWestPanning,
        kMbCursorInfoSouthPanning,
        kMbCursorInfoSouthEastPanning,
        kMbCursorInfoSouthWestPanning,
        kMbCursorInfoWestPanning,
        kMbCursorInfoMove,
        kMbCursorInfoVerticalText,
        kMbCursorInfoCell,
        kMbCursorInfoContextMenu,
        kMbCursorInfoAlias,
        kMbCursorInfoProgress,
        kMbCursorInfoNoDrop,
        kMbCursorInfoCopy,
        kMbCursorInfoNone,
        kMbCursorInfoNotAllowed,
        kMbCursorInfoZoomIn,
        kMbCursorInfoZoomOut,
        kMbCursorInfoGrab,
        kMbCursorInfoGrabbing,
        kMbCursorInfoCustom,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbWindowFeatures
    {
        public int x;
        public int y;
        public int width;
        public int height;
        [MarshalAs(UnmanagedType.Bool)]
        public bool menuBarVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool statusBarVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool toolBarVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool locationBarVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool scrollbarsVisible;
        [MarshalAs(UnmanagedType.Bool)]
        public bool resizable;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fullscreen;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbPrintSettings
    {
        public int structSize;
        public int dpi;
        public int width;
        public int height;
        public int marginTop;
        public int marginBottom;
        public int marginLeft;
        public int marginRight;
        [MarshalAs(UnmanagedType.Bool)]
        public bool isPrintPageHeadAndFooter;
        [MarshalAs(UnmanagedType.Bool)]
        public bool isPrintBackgroud;
    }
    public enum StorageType
    {
        /// <summary>
        /// String data with an associated MIME type. Depending on the MIME type, there may be
        // optional metadata attributes as well.
        /// </summary>
        StorageTypeString,
        /// <summary>
        /// Stores the name of one file being dragged into the renderer.
        /// </summary>
        StorageTypeFilename,
        /// <summary>
        /// An image being dragged out of the renderer. Contains a buffer holding the image data
        //  as well as the suggested name for saving the image to.
        /// </summary>
        StorageTypeBinaryData,
        /// <summary>
        /// Stores the filesystem URL of one file being dragged into the renderer.
        /// </summary>
        StorageTypeFileSystemFile,
    }
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Item
    {
        public StorageType storageType;
        /// <summary>
        /// Only valid when storageType == StorageTypeString.
        /// </summary>
        public mbMemBuf* stringType;
        public mbMemBuf* stringData;

        /// <summary>
        /// Only valid when storageType == StorageTypeFilename.
        /// </summary>
        public mbMemBuf* filenameData;
        public mbMemBuf* displayNameData;

        /// <summary>
        /// Only valid when storageType == StorageTypeBinaryData.
        /// </summary>
        public mbMemBuf* binaryData;

        /// <summary>
        /// Title associated with a link when stringType == "text/uri-list".
        /// Filename when storageType == StorageTypeBinaryData.
        /// </summary>
        public mbMemBuf* title;

        /// <summary>
        /// Only valid when storageType == StorageTypeFileSystemFile.
        /// </summary>
        public mbMemBuf* fileSystemURL;
        public long fileSystemFileSize;


        /// <summary>
        /// Only valid when stringType == "text/html".
        /// </summary>
        public mbMemBuf baseURL;
    }
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct mbWebDragData
    {
        public Item* m_itemList;
        public int m_itemListLength;
        public int m_modifierKeyState;
        public mbMemBuf* m_filesystemId;
    }
    public enum mbWebDragOperationsMask
    {
        mbWebDragOperationNone = 0,
        mbWebDragOperationCopy = 1,
        mbWebDragOperationLink = 2,
        mbWebDragOperationGeneric = 4,
        mbWebDragOperationPrivate = 8,
        mbWebDragOperationMove = 16,
        mbWebDragOperationDelete = 32,
        mbWebDragOperationEvery = -1,
    }
    public enum mbResourceType
    {
        MB_RESOURCE_TYPE_MAIN_FRAME = 0,
        MB_RESOURCE_TYPE_SUB_FRAME = 1,
        MB_RESOURCE_TYPE_STYLESHEET = 2,
        MB_RESOURCE_TYPE_SCRIPT = 3,
        MB_RESOURCE_TYPE_IMAGE = 4,
        MB_RESOURCE_TYPE_FONT_RESOURCE = 5,
        MB_RESOURCE_TYPE_SUB_RESOURCE = 6,
        MB_RESOURCE_TYPE_OBJECT = 7,
        MB_RESOURCE_TYPE_MEDIA = 8,
        MB_RESOURCE_TYPE_WORKER = 9,
        MB_RESOURCE_TYPE_SHARED_WORKER = 10,
        MB_RESOURCE_TYPE_PREFETCH = 11,
        MB_RESOURCE_TYPE_FAVICON = 12,
        MB_RESOURCE_TYPE_XHR = 13,
        MB_RESOURCE_TYPE_PING = 14,
        MB_RESOURCE_TYPE_SERVICE_WORKER = 15,
        MB_RESOURCE_TYPE_LAST_TYPE,
    }
    public enum mbRequestType
    {
        kMbRequestTypeInvalidation,
        kMbRequestTypeGet,
        kMbRequestTypePost,
        kMbRequestTypePut,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbSlist
    {
        public IntPtr data;
        public IntPtr next;
        public string Data
        {
            get
            {
                return data == default ? null : Marshal.PtrToStringAnsi(data);
            }
        }
    }
    public enum mbMenuItemId
    {
        kMbMenuSelectedAllId = (1) << (1),
        kMbMenuSelectedTextId = (1) << (2),
        kMbMenuUndoId = (1) << (3),
        kMbMenuCopyImageId = (1) << (4),
        kMbMenuInspectElementAtId = (1) << (5),
        kMbMenuCutId = (1) << (6),
        kMbMenuPasteId = (1) << (7),
        kMbMenuPrintId = (1) << (8),
        kMbMenuGoForwardId = (1) << (9),
        kMbMenuGoBackId = (1) << (10),
        kMbMenuReloadId = (1) << (11),
    }

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr WndProcCallback(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate mbStringPtr onWillConnect(mbWebView webView, IntPtr param, mbWebSocketChannel channel, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, [MarshalAs(UnmanagedType.I1)] ref bool needHook);
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate int onConnected(mbWebView webView, IntPtr param, mbWebSocketChannel channel);
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate mbStringPtr onReceive(mbWebView webView, IntPtr param, mbWebSocketChannel channel, int opCpodem, IntPtr buf, size_t len, [MarshalAs(UnmanagedType.I1)] ref bool isContinue);
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate mbStringPtr onSend(mbWebView webView, IntPtr param, mbWebSocketChannel channel, int opCpodem, IntPtr buf, size_t len, [MarshalAs(UnmanagedType.I1)] ref bool isContinue);
    [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall)]
    public delegate void onError(mbWebView webView, IntPtr param, mbWebSocketChannel channel);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbWebsocketHookCallbacks
    {
        public onWillConnect onWillConnect;
        public onConnected onConnected;
        public onReceive onReceive;
        public onSend onSend;
        public onError onError;
        public bool CanUse => onWillConnect != null;
        public bool IsFill => onWillConnect != null && onConnected != null && onReceive != null && onSend != null && onError != null;
    }

    public enum mbJsType
    {
        kMbJsTypeNumber = 0,
        kMbJsTypeString = 1,
        kMbJsTypeBool = 2,
        kMbJsTypeUndefined = 5,
        kMbJsTypeNull = 7,
    }

    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnGetPdfPageDataCallback(mbWebView webview, IntPtr param, IntPtr data, IntPtr size);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbRunJsCallback(mbWebView webview, IntPtr param, mbJsExecState es, mbJsValue v);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbJsQueryCallback(mbWebView webview, IntPtr param, mbJsExecState es, long queryId, int customMsg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string request);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbTitleChangedCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string title);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbMouseOverUrlChangedCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbURLChangedCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, [MarshalAs(UnmanagedType.Bool)] bool canGoBack, [MarshalAs(UnmanagedType.Bool)] bool canGoForward);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbURLChangedCallback2(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbPaintUpdatedCallback(mbWebView webview, IntPtr param, IntPtr hdc, int x, int y, int cx, int cy);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbPaintBitUpdatedCallback(mbWebView webview, IntPtr param, IntPtr buffer, [In] ref mbRect r, int width, int height);



    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbAlertBoxCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string msg);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbConfirmBoxCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string msg);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate mbStringPtr mbPromptBoxCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string defaultResult);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]


    public delegate int mbNavigationCallback(mbWebView webview, IntPtr param, mbNavigationType navigationType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public unsafe delegate IntPtr mbCreateViewCallback(mbWebView webview, IntPtr param, mbNavigationType navigationType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, [In] ref mbWindowFeatures windowFeatures);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbDocumentReadyCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbCloseCallback(mbWebView webview, IntPtr param, IntPtr unuse);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbDestroyCallback(mbWebView webview, IntPtr param, IntPtr unuse);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnShowDevtoolsCallback(mbWebView webview, IntPtr param);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbDidCreateScriptContextCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, IntPtr context, int extensionGroup, int worldId);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbGetPluginListCallback([MarshalAs(UnmanagedType.Bool)] bool refresh, IntPtr pluginListBuilder, IntPtr param);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbNetResponseCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, mbNetJob job);
    public enum mbLoadingResult
    {
        MB_LOADING_SUCCEEDED,
        MB_LOADING_FAILED,
        MB_LOADING_CANCELED,
    }

    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbLoadingFinishCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, mbLoadingResult result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string failedReason);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbDownloadCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, [In, MarshalAs(UnmanagedType.LPStr)] string url, IntPtr downloadJob);
    public enum mbConsoleLevel
    {
        mbLevelDebug = 4,
        mbLevelLog = 1,
        mbLevelInfo = 5,
        mbLevelWarning = 2,
        mbLevelError = 3,
        mbLevelRevokedError = 6,
        mbLevelLast = mbConsoleLevel.mbLevelInfo,
    }

    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbConsoleCallback(mbWebView webview, IntPtr param, mbConsoleLevel level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string sourceName, uint sourceLine, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string stackTrace);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnCallUiThread(mbWebView webview, IntPtr paramOnInThread);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbCallUiThread(mbWebView webview, mbOnCallUiThread func, IntPtr param);


    //mbNet--------------------------------------------------------------------------------------
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate bool mbLoadUrlBeginCallback(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string url, mbNetJob job);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbLoadUrlEndCallback(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string url, mbNetJob job, IntPtr buf, int len);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbLoadUrlFailCallback(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string url, mbNetJob job);


    //[UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    //public delegate void mbDidCreateScriptContextCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, IntPtr context, int extensionGroup, int worldId);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbWillReleaseScriptContextCallback(mbWebView webview, IntPtr param, mbWebFrameHandle frameId, IntPtr context, int worldId);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public unsafe delegate void mbNetGetFaviconCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, mbMemBuf* buf);
    public enum MbAsynRequestState
    {
        kMbAsynRequestStateOk = 0,
        kMbAsynRequestStateFail = 1,
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbCanGoBackForwardCallback(mbWebView webview, IntPtr param, MbAsynRequestState state, [MarshalAs(UnmanagedType.Bool)] bool b);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbGetCookieCallback(mbWebView webview, IntPtr param, MbAsynRequestState state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string cookie);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbGetSourceCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string mhtml);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbGetContentAsMarkupCallback(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string content, IntPtr size);


    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnUrlRequestWillRedirectCallback(mbWebView webview, IntPtr param, mbWebUrlRequestPtr oldRequest, mbWebUrlRequestPtr request, mbWebUrlResponsePtr redirectResponse);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnUrlRequestDidReceiveResponseCallback(mbWebView webview, IntPtr param, mbWebUrlRequestPtr request, mbWebUrlResponsePtr response);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnUrlRequestDidReceiveDataCallback(mbWebView webview, IntPtr param, mbWebUrlRequestPtr request, [In, MarshalAs(UnmanagedType.LPStr)] string data, int dataLength);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnUrlRequestDidFailCallback(mbWebView webview, IntPtr param, mbWebUrlRequestPtr request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string error);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnUrlRequestDidFinishLoadingCallback(mbWebView webview, IntPtr param, mbWebUrlRequestPtr request, double finishTime);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbUrlRequestCallbacks
    {
        public mbOnUrlRequestWillRedirectCallback willRedirectCallback;
        public mbOnUrlRequestDidReceiveResponseCallback didReceiveResponseCallback;
        public mbOnUrlRequestDidReceiveDataCallback didReceiveDataCallback;
        public mbOnUrlRequestDidFailCallback didFailCallback;
        public mbOnUrlRequestDidFinishLoadingCallback didFinishLoadingCallback;
    }

    public enum mbDownloadOpt
    {
        kMbDownloadOptCancel,
        kMbDownloadOptCacheData,
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbNetJobDataRecvCallback(IntPtr ptr, mbNetJob job, [In, MarshalAs(UnmanagedType.LPStr)] string data, int length);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbNetJobDataFinishCallback(IntPtr ptr, mbNetJob job, mbLoadingResult result);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbNetJobDataBind
    {
        public IntPtr param;
        public mbNetJobDataRecvCallback recvCallback;
        public mbNetJobDataFinishCallback finishCallback;
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbPopupDialogSaveNameCallback(IntPtr ptr, [In, MarshalAs(UnmanagedType.LPWStr)] string filePath);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbDownloadBind
    {
        public IntPtr param;
        public mbNetJobDataRecvCallback recvCallback;
        public mbNetJobDataFinishCallback finishCallback;
        public mbPopupDialogSaveNameCallback saveNameCallback;
    }

    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate mbDownloadOpt mbDownloadInBlinkThreadCallback(mbWebView webview, IntPtr param, IntPtr expectedContentLength, [In, MarshalAs(UnmanagedType.LPStr)] string url, [In, MarshalAs(UnmanagedType.LPStr)] string mime, [In, MarshalAs(UnmanagedType.LPStr)] string disposition, mbNetJob job, [In] ref mbNetJobDataBind dataBind);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbPdfDatas
    {
        public int count;
        public IntPtr sizes;
        public IntPtr datas;
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbPrintPdfDataCallback(mbWebView webview, IntPtr param, [In] ref mbPdfDatas datas);
    [StructLayout(LayoutKind.Sequential)]
    public struct mbScreenshotSettings
    {
        public int structSize;
        public int width;
        public int height;
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbPrintBitmapCallback(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string data, IntPtr size);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbOnScreenshot(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string data, IntPtr size);
    public enum mbHttBodyElementType
    {
        mbHttBodyElementTypeData,
        mbHttBodyElementTypeFile,
    }
    public enum mbWindowType
    {
        MB_WINDOW_TYPE_POPUP,
        MB_WINDOW_TYPE_TRANSPARENT,
        MB_WINDOW_TYPE_CONTROL,
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbWindowClosingCallback(mbWebView webview, IntPtr param);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbWindowDestroyCallback(mbWebView webview, IntPtr param);


    [StructLayout(LayoutKind.Sequential)]
    public struct mbDraggableRegion
    {
        public tagRECT bounds;
        [MarshalAs(UnmanagedType.Bool)]
        public bool draggable;
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate void mbDraggableRegionsChangedCallback(mbWebView webview, IntPtr param, [In] ref mbDraggableRegion rects, int rectCount);
    public enum mbPrintintStep
    {
        kPrintintStepStart,
        kPrintintStepPreview,
        kPrintintStepPrinting,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct mbPrintintSettings
    {
        public int dpi;
        public int width;
        public int height;
        public float scale;
    }
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate int mbPrintingCallback(mbWebView webview, IntPtr param, mbPrintintStep step, IntPtr hDC, [In] ref mbPrintintSettings settings, int pageCount);
    [UnmanagedFunctionPointer(NativeConstants.MB_CALL_TYPE)]
    public delegate mbStringPtr mbImageBufferToDataURLCallback(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPStr)] string data, size_t size);
    [StructLayout(LayoutKind.Sequential)]
    public struct tagRECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
    public partial class NativeMethods
    {
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE)]
        public static extern unsafe void mbInit([In] ref mbSettings mbSettings);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUninit")]
        public static extern void mbUninit();
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateWebView")]
        public static extern mbWebView mbCreateWebView();
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbDestroyWebView")]
        public static extern void mbDestroyWebView(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateWebWindow")]
        public static extern mbWebView mbCreateWebWindow(mbWindowType type, IntPtr parent, int x, int y, int width, int height);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateWebCustomWindow")]
        public static extern mbWebView mbCreateWebCustomWindow(IntPtr parent, uint style, uint styleEx, int x, int y, int width, int height);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbMoveToCenter")]
        public static extern void mbMoveToCenter(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetAutoDrawToHwnd")]
        public static extern void mbSetAutoDrawToHwnd(mbWebView webview, bool b);




        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateString")]
        public static extern mbStringPtr mbCreateString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string str, size_t length);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateStringWithoutNullTermination")]
        public static extern mbStringPtr mbCreateStringWithoutNullTermination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string str, size_t length);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbDeleteString")]
        public static extern void mbDeleteString(mbStringPtr stringPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetStringLen")]
        public static extern size_t mbGetStringLen(mbStringPtr stringPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetString")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbGetString(mbStringPtr stringPtr);




        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetProxy")]
        public static extern void mbSetProxy(mbWebView webview, ref mbProxy proxy);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDebugConfig")]
        public static extern void mbSetDebugConfig(mbWebView webview, [In, MarshalAs(UnmanagedType.LPStr)] string debugString, [In, MarshalAs(UnmanagedType.LPStr)] string param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSetData")]


        public static extern void mbNetSetData(mbNetJob jobPtr, byte[] buf, int len);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetHookRequest")]
        public static extern void mbNetHookRequest(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetChangeRequestUrl")]
        public static extern void mbNetChangeRequestUrl(mbNetJob jobPtr, [In, MarshalAs(UnmanagedType.LPStr)] string url);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetContinueJob")]
        public static extern void mbNetContinueJob(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetRawHttpHeadInBlinkThread")]
        public static extern unsafe mbSlist* mbNetGetRawHttpHeadInBlinkThread(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetRawResponseHeadInBlinkThread")]
        public static extern unsafe mbSlist* mbNetGetRawResponseHeadInBlinkThread(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetHoldJobToAsynCommit")]
        public static extern bool mbNetHoldJobToAsynCommit(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetCancelRequest")]
        public static extern void mbNetCancelRequest(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetOnResponse")]
        public static extern void mbNetOnResponse(mbWebView webview, mbNetResponseCallback callback, IntPtr param);


        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSetWebsocketCallback")]
        public static extern void mbNetSetWebsocketCallback(mbWebView webview, ref mbWebsocketHookCallbacks callbacks, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSendWsText")]
        public static extern void mbNetSendWsText(IntPtr channel, [In, MarshalAs(UnmanagedType.LPStr)] string buf, size_t len);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSendWsBlob")]
        public static extern void mbNetSendWsBlob(IntPtr channel, IntPtr buf, size_t len);




        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetPostBody")]
        public static extern unsafe IntPtr mbNetGetPostBody(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetCreatePostBodyElements")]
        public static extern unsafe IntPtr mbNetCreatePostBodyElements(mbWebView webview, size_t length);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetFreePostBodyElements")]
        public static extern unsafe void mbNetFreePostBodyElements(IntPtr elements);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetCreatePostBodyElement")]
        public static extern unsafe IntPtr mbNetCreatePostBodyElement(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetFreePostBodyElement")]
        public static extern unsafe void mbNetFreePostBodyElement(IntPtr element);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetCreateWebUrlRequest")]
        public static extern mbWebUrlRequestPtr mbNetCreateWebUrlRequest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string method, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string mime);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetAddHTTPHeaderFieldToUrlRequest")]
        public static extern void mbNetAddHTTPHeaderFieldToUrlRequest(mbWebUrlRequestPtr request, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string value);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetStartUrlRequest")]
        public static extern int mbNetStartUrlRequest(mbWebView webview, mbWebUrlRequestPtr request, IntPtr param, ref mbUrlRequestCallbacks callbacks);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetHttpStatusCode")]
        public static extern int mbNetGetHttpStatusCode(mbWebUrlResponsePtr response);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetRequestMethod")]
        public static extern mbRequestType mbNetGetRequestMethod(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetExpectedContentLength")]
        public static extern long mbNetGetExpectedContentLength(mbWebUrlResponsePtr response);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetResponseUrl")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbNetGetResponseUrl(mbWebUrlResponsePtr response);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetCancelWebUrlRequest")]
        public static extern void mbNetCancelWebUrlRequest(int requestId);
        //new 
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetViewProxy")]
        public static extern void mbSetViewProxy(mbWebView webview, ref mbProxy mbProxy);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSetMIMEType")]
        public static extern void mbNetSetMIMEType(mbNetJob jobPtr, [In, MarshalAs(UnmanagedType.LPStr)] string type);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetMIMEType")]
        public static extern IntPtr mbNetGetMIMEType(mbNetJob jobPtr);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetGetHTTPHeaderField")]
        public static extern IntPtr mbNetGetHTTPHeaderField(mbNetJob job, [In, MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.Bool)] bool fromRequestOrResponse);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbNetSetHTTPHeaderField")]
        public static extern void mbNetSetHTTPHeaderField(mbNetJob jobPtr, [In, MarshalAs(UnmanagedType.LPWStr)] string key, [In, MarshalAs(UnmanagedType.LPWStr)] string value, [MarshalAs(UnmanagedType.Bool)] bool response);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetMouseEnabled")]
        public static extern void mbSetMouseEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetTouchEnabled")]
        public static extern void mbSetTouchEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetContextMenuEnabled")]
        public static extern void mbSetContextMenuEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetNavigationToNewWindowEnable")]
        public static extern void mbSetNavigationToNewWindowEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetHeadlessEnabled")]
        public static extern void mbSetHeadlessEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDragDropEnable")]
        public static extern void mbSetDragDropEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDragEnable")]
        public static extern void mbSetDragEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetContextMenuItemShow")]
        public static extern void mbSetContextMenuItemShow(mbWebView webview, mbMenuItemId item, [MarshalAs(UnmanagedType.Bool)] bool isShow);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetHandle")]
        public static extern void mbSetHandle(mbWebView webview, IntPtr wnd);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetHandleOffset")]
        public static extern void mbSetHandleOffset(mbWebView webview, int x, int y);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetHostHWND")]
        public static extern IntPtr mbGetHostHWND(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetTransparent")]
        public static extern void mbSetTransparent(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetViewSettings")]
        public static extern void mbSetViewSettings(mbWebView webview, ref mbViewSettings mbViewSettings);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetCspCheckEnable")]
        public static extern void mbSetCspCheckEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetNpapiPluginsEnabled")]
        public static extern void mbSetNpapiPluginsEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetMemoryCacheEnable")]
        public static extern void mbSetMemoryCacheEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetCookie")]
        public static extern void mbSetCookie(mbWebView webview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string cookie);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetCookieEnabled")]
        public static extern void mbSetCookieEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetCookieJarPath")]
        public static extern void mbSetCookieJarPath(mbWebView webview, [In, MarshalAs(UnmanagedType.LPWStr)] string path);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetCookieJarFullPath")]
        public static extern void mbSetCookieJarFullPath(mbWebView webview, [In, MarshalAs(UnmanagedType.LPWStr)] string path);

        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetLocalStorageFullPath")]
        public static extern void mbSetLocalStorageFullPath(mbWebView webview, [In, MarshalAs(UnmanagedType.LPWStr)] string path);

        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetTitle")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbGetTitle(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetUrl")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbGetUrl(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbAddPluginDirectory")]
        public static extern void mbAddPluginDirectory(mbWebView webview, [In, MarshalAs(UnmanagedType.LPWStr)] string path);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetUserAgent")]
        public static extern void mbSetUserAgent(mbWebView webview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string userAgent);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetZoomFactor")]
        public static extern void mbSetZoomFactor(mbWebView webview, float factor);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetZoomFactor")]
        public static extern float mbGetZoomFactor(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDiskCacheEnabled")]
        public static extern void mbSetDiskCacheEnabled(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool enable);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDiskCachePath")]
        public static extern void mbSetDiskCachePath(mbWebView webview, [In, MarshalAs(UnmanagedType.LPWStr)] string path);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDiskCacheLimit")]
        public static extern void mbSetDiskCacheLimit(mbWebView webview, [MarshalAs(UnmanagedType.SysUInt)] uint limit);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDiskCacheLimitDisk")]
        public static extern void mbSetDiskCacheLimitDisk(mbWebView webview, [MarshalAs(UnmanagedType.SysUInt)] uint limit);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDiskCacheLevel")]
        public static extern void mbSetDiskCacheLevel(mbWebView webview, int Level);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetResourceGc")]
        public static extern void mbSetResourceGc(mbWebView webview, int intervalSec);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCanGoForward")]
        public static extern void mbCanGoForward(mbWebView webview, mbCanGoBackForwardCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCanGoBack")]
        public static extern void mbCanGoBack(mbWebView webview, mbCanGoBackForwardCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetCookie")]
        public static extern void mbGetCookie(mbWebView webview, mbGetCookieCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetCookieOnBlinkThread")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbGetCookieOnBlinkThread(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbClearCookie")]
        public static extern void mbClearCookie(mbWebView webview);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbResize")]
        public static extern void mbResize(mbWebView webview, int w, int h);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnNavigation")]
        public static extern void mbOnNavigation(mbWebView webview, mbNavigationCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnNavigationSync")]
        public static extern void mbOnNavigationSync(mbWebView webview, mbNavigationCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnCreateView")]
        public static extern void mbOnCreateView(mbWebView webview, mbCreateViewCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnDocumentReady")]
        public static extern void mbOnDocumentReady(mbWebView webview, mbDocumentReadyCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnPaintUpdated")]
        public static extern void mbOnPaintUpdated(mbWebView webview, mbPaintUpdatedCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnPaintBitUpdated")]
        public static extern void mbOnPaintBitUpdated(mbWebView webview, mbPaintBitUpdatedCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnLoadUrlBegin")]
        public static extern void mbOnLoadUrlBegin(mbWebView webview, mbLoadUrlBeginCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnLoadUrlEnd")]
        public static extern void mbOnLoadUrlEnd(mbWebView webview, mbLoadUrlEndCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnTitleChanged")]
        public static extern void mbOnTitleChanged(mbWebView webview, mbTitleChangedCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnURLChanged")]
        public static extern void mbOnURLChanged(mbWebView webview, mbURLChangedCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnLoadingFinish")]
        public static extern void mbOnLoadingFinish(mbWebView webview, mbLoadingFinishCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnDownload")]
        public static extern void mbOnDownload(mbWebView webview, mbDownloadCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnDownloadInBlinkThread")]
        public static extern void mbOnDownloadInBlinkThread(mbWebView webview, mbDownloadInBlinkThreadCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnAlertBox")]
        public static extern void mbOnAlertBox(mbWebView webview, mbAlertBoxCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnConfirmBox")]
        public static extern void mbOnConfirmBox(mbWebView webview, mbConfirmBoxCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnPromptBox")]
        public static extern void mbOnPromptBox(mbWebView webview, mbPromptBoxCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnNetGetFavicon")]
        public static extern void mbOnNetGetFavicon(mbWebView webview, mbNetGetFaviconCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnConsole")]
        public static extern void mbOnConsole(mbWebView webview, mbConsoleCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnClose")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbOnClose(mbWebView webview, mbCloseCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnDestroy")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbOnDestroy(mbWebView webview, mbDestroyCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnPrinting")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbOnPrinting(mbWebView webview, mbPrintingCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnDidCreateScriptContext")]
        public static extern void mbOnDidCreateScriptContext(mbWebView webview, mbDidCreateScriptContextCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnPluginList")]
        public static extern void mbOnPluginList(mbWebView webview, mbGetPluginListCallback callback, IntPtr callbackParam);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnImageBufferToDataURL")]
        public static extern void mbOnImageBufferToDataURL(mbWebView webview, mbImageBufferToDataURLCallback callback, IntPtr callbackParam);


        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGoBack")]
        public static extern void mbGoBack(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGoForward")]
        public static extern void mbGoForward(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbStopLoading")]
        public static extern void mbStopLoading(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbReload")]
        public static extern void mbReload(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPerformCookieCommand")]
        public static extern void mbPerformCookieCommand(mbWebView webview, mbCookieCommand command);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorSelectAll")]
        public static extern void mbEditorSelectAll(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorCopy")]
        public static extern void mbEditorCopy(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorCut")]
        public static extern void mbEditorCut(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorPaste")]
        public static extern void mbEditorPaste(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorDelete")]
        public static extern void mbEditorDelete(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEditorUndo")]
        public static extern void mbEditorUndo(mbWebView webview);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireMouseEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireMouseEvent(mbWebView webview, uint message, int x, int y, uint flags);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireContextMenuEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireContextMenuEvent(mbWebView webview, int x, int y, uint flags);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireMouseWheelEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireMouseWheelEvent(mbWebView webview, int x, int y, int delta, uint flags);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireKeyUpEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireKeyUpEvent(mbWebView webview, uint virtualKeyCode, uint flags, [MarshalAs(UnmanagedType.Bool)] bool systemKey);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireKeyDownEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireKeyDownEvent(mbWebView webview, uint virtualKeyCode, uint flags, [MarshalAs(UnmanagedType.Bool)] bool systemKey);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireKeyPressEvent")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireKeyPressEvent(mbWebView webview, uint charCode, uint flags, [MarshalAs(UnmanagedType.Bool)] bool systemKey);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFireWindowsMessage")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbFireWindowsMessage(mbWebView webview, IntPtr hWnd, uint message, IntPtr wParam, IntPtr lParam, ref IntPtr result);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetFocus")]
        public static extern void mbSetFocus(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbKillFocus")]
        public static extern void mbKillFocus(mbWebView webview);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbShowWindow")]
        public static extern void mbShowWindow(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool show);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbLoadURL")]
        public static extern void mbLoadURL(mbWebView webview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbLoadHtmlWithBaseUrl")]
        public static extern void mbLoadHtmlWithBaseUrl(mbWebView webview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string html, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string baseUrl);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPostURL")]
        public static extern void mbPostURL(mbWebView webview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url, string postData, int postLen);


        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetLockedViewDC")]
        public static extern IntPtr mbGetLockedViewDC(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUnlockViewDC")]
        public static extern void mbUnlockViewDC(mbWebView webview);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbWake")]
        public static extern void mbWake(mbWebView webview);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbJsToDouble")]
        public static extern double mbJsToDouble(IntPtr es, mbJsValue v);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbJsToBoolean")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbJsToBoolean(IntPtr es, mbJsValue v);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbJsToString")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbJsToString(IntPtr es, mbJsValue v);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetJsValueType")]
        public static extern mbJsType mbGetJsValueType(IntPtr es, mbJsValue mbJsValue);


        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbOnJsQuery")]
        public static extern void mbOnJsQuery(mbWebView webview, mbJsQueryCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbResponseQuery")]
        public static extern void mbResponseQuery(mbWebView webview, long queryId, int customMsg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string response);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbRunJs")]
        public static extern void mbRunJs(mbWebView webview, IntPtr frameId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string script, bool isInClosure, mbRunJsCallback callback, IntPtr param, IntPtr unuse);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbRunJsSync")]
        public static extern mbJsValue mbRunJsSync(mbWebView webview, mbWebFrameHandle frameId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string script, [MarshalAs(UnmanagedType.Bool)] bool isInClosure);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbWebFrameGetMainFrame")]
        public static extern IntPtr mbWebFrameGetMainFrame(mbWebView webview);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbIsMainFrame")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbIsMainFrame(mbWebView webview, mbWebFrameHandle frameId);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetNodeJsEnable")]
        public static extern void mbSetNodeJsEnable(mbWebView webview, [MarshalAs(UnmanagedType.Bool)] bool b);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbSetDeviceParameter")]
        public static extern void mbSetDeviceParameter(mbWebView webview, [In, MarshalAs(UnmanagedType.LPStr)] string device, [In, MarshalAs(UnmanagedType.LPStr)] string paramStr, int paramInt, float paramFloat);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetContentAsMarkup")]
        public static extern void mbGetContentAsMarkup(mbWebView webview, mbGetContentAsMarkupCallback calback, IntPtr param, mbWebFrameHandle frameId);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetSource")]
        public static extern void mbGetSource(mbWebView webview, mbGetSourceCallback calback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilSerializeToMHTML")]
        public static extern void mbUtilSerializeToMHTML(mbWebView webview, mbGetSourceCallback calback, IntPtr param);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilCreateRequestCode")]
        public static extern IntPtr mbUtilCreateRequestCode([In, MarshalAs(UnmanagedType.LPStr)] string registerInfo);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilIsRegistered")]
        public static extern void mbUtilIsRegistered([In, MarshalAs(UnmanagedType.LPWStr)] string defaultPath);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilPrint")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbUtilPrint(mbWebView webview, mbWebFrameHandle frameId, ref mbPrintSettings printParams);


        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilBase64Encode")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbUtilBase64Encode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string str);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilBase64Decode")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbUtilBase64Decode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string str);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilDecodeURLEscape")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbUtilDecodeURLEscape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilEncodeURLEscape")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))]
        public static extern string mbUtilEncodeURLEscape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string url);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilCreateV8Snapshot")]
        public static extern IntPtr mbUtilCreateV8Snapshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string str);




        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilPrintToPdf")]
        public static extern void mbUtilPrintToPdf(mbWebView webview, mbWebFrameHandle frameId, ref mbPrintSettings settings, mbPrintPdfDataCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilPrintToBitmap")]
        public static extern void mbUtilPrintToBitmap(mbWebView webview, mbWebFrameHandle frameId, ref mbScreenshotSettings settings, mbPrintBitmapCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbUtilScreenshot")]
        public static extern void mbUtilScreenshot(mbWebView webview, ref mbScreenshotSettings settings, mbOnScreenshot callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPopupDownloadMgr")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool mbPopupDownloadMgr(mbWebView webview, [In, MarshalAs(UnmanagedType.LPStr)] string url, IntPtr downloadJob);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPopupDialogAndDownload")]
        public static extern mbDownloadOpt mbPopupDialogAndDownload(mbWebView webview, IntPtr param, [MarshalAs(UnmanagedType.SysUInt)] uint contentLength, [In, MarshalAs(UnmanagedType.LPStr)] string url, [In, MarshalAs(UnmanagedType.LPStr)] string mime, [In, MarshalAs(UnmanagedType.LPStr)] string disposition, IntPtr job, ref mbNetJobDataBind dataBind, ref mbDownloadBind callbackBind);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbDownloadByPath")]
        public static extern mbDownloadOpt mbDownloadByPath(mbWebView webview, IntPtr param, [In, MarshalAs(UnmanagedType.LPWStr)] string path, [MarshalAs(UnmanagedType.SysUInt)] uint contentLength, [In, MarshalAs(UnmanagedType.LPStr)] string url, [In, MarshalAs(UnmanagedType.LPStr)] string mime, [In, MarshalAs(UnmanagedType.LPStr)] string disposition, IntPtr job, ref mbNetJobDataBind dataBind, ref mbDownloadBind callbackBind);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbGetPdfPageData")]
        public static extern void mbGetPdfPageData(mbWebView webview, mbOnGetPdfPageDataCallback callback, IntPtr param);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbCreateMemBuf")]
        public static extern unsafe IntPtr mbCreateMemBuf(mbWebView webview, mbMemBuf* buf, size_t length);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbFreeMemBuf")]
        public static extern unsafe void mbFreeMemBuf(mbMemBuf* buf);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPluginListBuilderAddPlugin")]
        public static extern void mbPluginListBuilderAddPlugin(IntPtr builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string description, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string fileName);
        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPluginListBuilderAddMediaTypeToLastPlugin")]
        public static extern void mbPluginListBuilderAddMediaTypeToLastPlugin(IntPtr builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string description);

        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbPluginListBuilderAddFileExtensionToLastMediaType")]
        public static extern void mbPluginListBuilderAddFileExtensionToLastMediaType(IntPtr builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8Marshaler))] string fileExtension);



        [DllImport(NativeConstants.MbDllPath, CallingConvention = NativeConstants.MB_CALL_TYPE, EntryPoint = "mbEnableHighDPISupport")]
        public static extern void mbEnableHighDPISupport();
    }
}
