using System;
using System.Reflection;
using System.Reflection.Emit;
using Raindrops.Shared.InvokeST;
using Raindrops.UI.WebView.Miniblink.PInvoke.Handle;

namespace Raindrops.UI.WebView.Miniblink
{
    public class EventAdapter<TEventArgs, TCallback> : IDisposable where TEventArgs : EventArgs where TCallback : Delegate
    {
        public delegate void Handler(object sender, TEventArgs eventArgs);
        private static readonly object _synRoot = new object();
        private static DynamicMethod _bridgeMethod = null;
        private readonly Func<mbWebView, TCallback, IntPtr, bool> _func;
        private readonly IMiniblinkProxy _miniblinkProxy;
        private TCallback _callback;
        private Handler _handler;
        private bool disposedValue;
        public EventAdapter(IMiniblinkProxy miniblinkProxy, Action<mbWebView, TCallback, IntPtr> action)
        {
            _func = (a, b, c) => { action(a, b, c); return true; };
            _miniblinkProxy = miniblinkProxy;
        }
        public EventAdapter(IMiniblinkProxy miniblinkProxy, Func<mbWebView, TCallback, IntPtr, bool> func)
        {
            _func = func;
            _miniblinkProxy = miniblinkProxy;
        }
        public event Handler EventHandler
        {
            add
            {
                TCallback callback;
                lock (this)
                {
                    if (_callback == null)
                    {
                        _callback = BuildDynamicMethods();
                    }
                    callback = _callback;
                }
                if (_func(_miniblinkProxy.WebView, callback, IntPtr.Zero))
                {
                    _handler += value;
                    GC.KeepAlive(_callback);
                }
            }
            remove
            {
                _handler -= value;
                if (_handler == null)
                {
                    _func(_miniblinkProxy.WebView, null, IntPtr.Zero);
                }
            }
        }
        private TCallback BuildDynamicMethods()
        {
            DynamicMethod dynamicMethod = null;
            lock (_synRoot)
            {
                dynamicMethod = _bridgeMethod ?? (_bridgeMethod = BuildBridge());
            }
            return (TCallback)dynamicMethod.CreateDelegate(typeof(TCallback), this);
        }
        private DynamicMethod BuildBridge()
        {
            MethodInfo methodInfo = typeof(TCallback).GetMethod("Invoke");
            ParameterInfo[] parameterInfos = methodInfo.GetParameters();

            //Get parameterTyps
            Type[] parameterTypes = new Type[parameterInfos.Length + 1];
            parameterTypes[0] = GetType();
            for (int i = 0; i < parameterInfos.Length; i++) parameterTypes[i + 1] = parameterInfos[i].ParameterType;

            DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, parameterTypes, GetType(), true);
            ILGenerator iLGenerator = dynamicMethod.GetILGenerator();


            LocalBuilder handler = iLGenerator.DeclareLocal(typeof(Handler));
            LocalBuilder eventObj = iLGenerator.DeclareLocal(typeof(TEventArgs));

            //LabelEnd
            Label end = iLGenerator.DefineLabel();
            //Read handler
            //Push this to stack
            iLGenerator.PushThisRef(this.GetType(), out _);
            iLGenerator.PushField(GetType().GetField(nameof(_handler), BindingFlags.NonPublic | BindingFlags.Instance));
            iLGenerator.PopLocal(handler);
            iLGenerator.PushLocal(handler);
            iLGenerator.Emit(OpCodes.Brfalse_S, end);

            //New eventObj
            Type eventType = typeof(TEventArgs);
            iLGenerator.Emit(OpCodes.Newobj, eventType.GetConstructor(new Type[0]));

            //Stacktop eventObj
            //Map
            Map retMap = null;
            Map[] maps = MappingCache.GetMap(eventType, parameterInfos);
            foreach (Map map in maps)
            {
                if (map.IsRet)
                {
                    retMap = map;
                    continue;
                }
                //Copy stacktop
                iLGenerator.Emit(OpCodes.Dup);
                //+1 because first parameter is this
                iLGenerator.PushArgument(map.ParameterIndex + 1);
                Type sType = map.ParameterInfo.ParameterType;
                if (sType.IsByRef)
                {
                    iLGenerator.UnRef(sType);
                    sType = sType.GetElementType();
                }

                if (map.MemberInfo is PropertyInfo propertyInfo)
                {
                    iLGenerator.Convert(sType, propertyInfo.PropertyType);
                    iLGenerator.Call(propertyInfo.GetSetMethod());
                }
                else if (map.MemberInfo is FieldInfo fieldInfo)
                {
                    iLGenerator.Convert(sType, fieldInfo.FieldType);
                    iLGenerator.PopField(fieldInfo);
                }
            }

            iLGenerator.PopLocal(eventObj);

            iLGenerator.PushLocal(handler);
            iLGenerator.PushThisRef(this.GetType(), out _);
            iLGenerator.PushField(GetType().GetField(nameof(_miniblinkProxy), BindingFlags.NonPublic | BindingFlags.Instance));
            iLGenerator.PushLocal(eventObj);
            iLGenerator.Call(typeof(Handler).GetMethod(nameof(Handler.Invoke)));

            foreach (Map map in maps)
            {
                if (map.IsRef)
                {
                    iLGenerator.PushArgument(map.ParameterIndex + 1);
                    iLGenerator.PushLocal(eventObj);

                    if (map.MemberInfo is PropertyInfo propertyInfo)
                    {
                        iLGenerator.Emit(OpCodes.Callvirt, propertyInfo.GetGetMethod());
                        iLGenerator.Convert(propertyInfo.PropertyType, map.ParameterInfo.ParameterType.GetElementType());
                    }
                    else if (map.MemberInfo is FieldInfo fieldInfo)
                    {
                        iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
                        iLGenerator.Convert(fieldInfo.FieldType, map.ParameterInfo.ParameterType.GetElementType());
                    }
                    iLGenerator.TransferRef(map.ParameterInfo.ParameterType);
                }
            }

            if (retMap != null && methodInfo.ReturnType != typeof(void))
            {
                iLGenerator.PushLocal(eventObj);
                if (retMap.MemberInfo is PropertyInfo propertyInfo)
                {
                    iLGenerator.Call(propertyInfo.GetGetMethod());
                    iLGenerator.Convert(propertyInfo.PropertyType, methodInfo.ReturnType);
                }
                else if (retMap.MemberInfo is FieldInfo fieldInfo)
                {
                    iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
                    iLGenerator.Convert(fieldInfo.FieldType, methodInfo.ReturnType);
                }
                iLGenerator.Ret();
            }

            iLGenerator.MarkLabel(end);
            //Default Ret
            if (methodInfo.ReturnType != typeof(void))
                iLGenerator.CreateDefault(methodInfo.ReturnType);
            iLGenerator.Ret();
            return dynamicMethod;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                _func(_miniblinkProxy.WebView, null, IntPtr.Zero);
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
