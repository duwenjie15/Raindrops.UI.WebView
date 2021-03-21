using System;
using Raindrops.UI.WebView.Miniblink.PInvoke;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink
{
    public class RetValue
    {
        public RetValue(mbWebView mbWebView, IntPtr param, mbJsExecState mbJsExecState, mbJsValue mbJsValue)
        {
            WebView = mbWebView;
            ValueType = NativeMethods.mbGetJsValueType(mbJsExecState, mbJsValue);
            switch (ValueType)
            {
                default:
                case mbJsType.kMbJsTypeUndefined:
                case mbJsType.kMbJsTypeNull:
                    Result = null;
                    break;
                case mbJsType.kMbJsTypeNumber:
                    Result = NativeMethods.mbJsToDouble(mbJsExecState, mbJsValue);
                    break;
                case mbJsType.kMbJsTypeBool:
                    Result = NativeMethods.mbJsToBoolean(mbJsExecState, mbJsValue);
                    break;
                case mbJsType.kMbJsTypeString:
                    Result = NativeMethods.mbJsToString(mbJsExecState, mbJsValue);
                    break;
            }
        }
        public mbWebView WebView { get; }
        public mbJsType ValueType { get; set; }
        public object Result { get; }
        public override string ToString()
        {
            return ValueType == mbJsType.kMbJsTypeUndefined ? "Undefined" :
                 Result?.ToString() ?? "null";
        }
    }
}
