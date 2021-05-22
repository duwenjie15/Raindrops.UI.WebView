using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace Raindrops.UI.WebView.Miniblink
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MapAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsRef { get; set; }
        public bool IsRet { get; set; }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MapIgnoreAttribute : Attribute
    {

    }
    public class Map
    {
        public string Name { get; set; }
        public MemberInfo MemberInfo { get; set; }
        public ParameterInfo ParameterInfo { get; set; }
        public int ParameterIndex { get; set; }
        public bool IsRef { get; set; }
        public bool IsRet { get; set; }
    }
    public static class MappingCache
    {
        private static object GetCustomAttribute(this MemberInfo memberInfo,Type type,bool inherit)
        {
            object[] objs = memberInfo.GetCustomAttributes(type, inherit);
            return objs.Length > 0 ? objs[0] : null;
        }
        private static readonly BindingFlags _flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
        private static readonly ConcurrentDictionary<Type, Map[]> _mapsDict = new ConcurrentDictionary<Type, Map[]>();
        private static IEnumerable<MemberInfo> GetMemberInfos(Type type)
        {
            foreach (PropertyInfo p in type.GetProperties(_flags))
            {
                if (p.CanWrite)
                {
                    if (p.GetCustomAttribute(typeof(MapIgnoreAttribute), false) is MapIgnoreAttribute)
                        continue;
                    yield return p;
                }
            }
            foreach (FieldInfo d in type.GetFields(_flags))
            {
                if (d.GetCustomAttribute(typeof(MapIgnoreAttribute), false) is MapIgnoreAttribute)
                    continue;
                yield return d;
            }
        }
        public static Map[] GetMap(this Type type, ParameterInfo[] parameterInfos)
        {
            bool FindParameter(string name,out int index)
            {
                for(int i = 0; i < parameterInfos.Length; i++)
                {
                    if (parameterInfos[i].Name.Equals(name, StringComparison.Ordinal))
                    {
                        index = i;
                        return true;
                    }
                }
                index = 0;
                return false;
            }
            if (_mapsDict.TryGetValue(type, out Map[] value))
                return value;
            List<Map> maps = new List<Map>();
            foreach (MemberInfo memberInfo in GetMemberInfos(type))
            {
                string name = memberInfo.Name;
                bool isRef = true;
                bool isRet = false;
                if (memberInfo.GetCustomAttribute(typeof(MapAttribute), false) is MapAttribute mapAttribute)
                {
                    if (!string.IsNullOrEmpty(mapAttribute.Name))
                        name = mapAttribute.Name;
                    isRef = mapAttribute.IsRef;
                    isRet = mapAttribute.IsRet;
                }
                if (FindParameter(name, out int index) || isRet)
                {
                    ParameterInfo parameterInfo = parameterInfos[index];
                    Map map = new Map()
                    {
                        Name = name,
                        MemberInfo = memberInfo,
                        ParameterInfo = parameterInfo,
                        ParameterIndex = index,
                        IsRef = parameterInfo.ParameterType.IsByRef && isRef,
                        IsRet = isRet
                    };
                    maps.Add(map);
                }
            }
            Map[] result = maps.ToArray();
            _mapsDict.AddOrUpdate(type, result, (k, v) => v);
            return result;
        }
    }
}
