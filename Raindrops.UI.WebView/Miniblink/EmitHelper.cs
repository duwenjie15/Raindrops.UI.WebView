using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

internal static class EmitHelper
{
    private const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
    private static readonly Lazy<ConstructorInfo> s_decimalConstructor = new Lazy<ConstructorInfo>(() => typeof(decimal).GetConstructor(new Type[] { typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte) }));
    private static readonly Lazy<ConstructorInfo> s_timeSpanConstructor = new Lazy<ConstructorInfo>(() => typeof(TimeSpan).GetConstructor(new Type[] { typeof(long) }));
    private static readonly Lazy<MethodInfo> s_dateTimeFromBinary = new Lazy<MethodInfo>(() => typeof(DateTime).GetMethod(nameof(DateTime.FromBinary)));
    private static readonly Lazy<MethodInfo> s_dateTimeNow = new Lazy<MethodInfo>(() => typeof(DateTime).GetProperty(nameof(DateTime.Now)).GetGetMethod());
    internal static void ReadPointerValue(this ILGenerator il, Type type)
    {
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Empty:
                return;
            case TypeCode.DBNull:
            case TypeCode.String:
                il.Emit(OpCodes.Ldind_Ref);
                break;
            case TypeCode.SByte:
                il.Emit(OpCodes.Ldind_I1);
                break;
            case TypeCode.Int16:
                il.Emit(OpCodes.Ldind_I2);
                break;
            case TypeCode.Int32:
                il.Emit(OpCodes.Ldind_I4);
                break;
            case TypeCode.Int64:
                il.Emit(OpCodes.Ldind_I8);
                break;
            case TypeCode.Byte:
            case TypeCode.Boolean:
                il.Emit(OpCodes.Ldind_U1);
                break;
            case TypeCode.UInt16:
            case TypeCode.Char:
                il.Emit(OpCodes.Ldind_U2);
                break;
            case TypeCode.UInt32:
                il.Emit(OpCodes.Ldind_U4);
                break;
            case TypeCode.UInt64:
                //***
                il.Emit(OpCodes.Ldind_I8);
                break;
            case TypeCode.Single:
                il.Emit(OpCodes.Ldind_R4);
                break;
            case TypeCode.Double:
                il.Emit(OpCodes.Ldind_R8);
                break;
            case TypeCode.Decimal:
            case TypeCode.DateTime:
                il.Emit(OpCodes.Ldobj, type);
                break;
            case TypeCode.Object:
                if (type == typeof(IntPtr) || type == typeof(UIntPtr))
                {
                    il.Emit(OpCodes.Ldind_I);
                    break;
                }
                else if (type.IsValueType)
                {
                    il.Emit(OpCodes.Ldobj, type);
                }
                else
                {
                    il.Emit(OpCodes.Ldind_Ref);
                }
                break;
        }
    }
    internal static void WritePointerValue(this ILGenerator il, Type type)
    {
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Empty:
                return;
            case TypeCode.DBNull:
            case TypeCode.String:
                il.Emit(OpCodes.Stind_Ref);
                break;
            case TypeCode.Boolean:
            case TypeCode.SByte:
            case TypeCode.Byte:
                il.Emit(OpCodes.Stind_I1);
                break;
            case TypeCode.Int16:
            case TypeCode.UInt16:
            case TypeCode.Char:
                il.Emit(OpCodes.Stind_I2);
                break;
            case TypeCode.Int32:
            case TypeCode.UInt32:
                il.Emit(OpCodes.Stind_I4);
                break;
            case TypeCode.Int64:
            case TypeCode.UInt64:
                il.Emit(OpCodes.Stind_I8);
                break;
            case TypeCode.Single:
                il.Emit(OpCodes.Stind_R4);
                break;
            case TypeCode.Double:
                il.Emit(OpCodes.Stind_R8);
                break;
            case TypeCode.Decimal:
            case TypeCode.DateTime:
                il.Emit(OpCodes.Stobj, type);
                break;
            case TypeCode.Object:
                if (type == typeof(IntPtr) || type == typeof(UIntPtr))
                {
                    il.Emit(OpCodes.Stind_I);
                    break;
                }
                else if (type.IsValueType)
                {
                    il.Emit(OpCodes.Stobj, type);
                }
                else
                {
                    il.Emit(OpCodes.Stind_Ref);
                }
                break;
        }
    }
    internal static void Push(this ILGenerator il, bool value)
    {
        Push(il, value ? 1 : 0);
    }
    internal static void Push(this ILGenerator il, sbyte value)
    {
        Push(il, (int)value);
    }
    internal static void Push(this ILGenerator il, short value)
    {
        Push(il, (int)value);
    }
    internal static void Push(this ILGenerator il, int value)
    {
        switch (value)
        {
            case -1:
                il.Emit(OpCodes.Ldc_I4_M1);
                return;
            case 0:
                il.Emit(OpCodes.Ldc_I4_0);
                return;
            case 1:
                il.Emit(OpCodes.Ldc_I4_1);
                return;
            case 2:
                il.Emit(OpCodes.Ldc_I4_2);
                return;
            case 3:
                il.Emit(OpCodes.Ldc_I4_3);
                return;
            case 4:
                il.Emit(OpCodes.Ldc_I4_4);
                return;
            case 5:
                il.Emit(OpCodes.Ldc_I4_5);
                return;
            case 6:
                il.Emit(OpCodes.Ldc_I4_6);
                return;
            case 7:
                il.Emit(OpCodes.Ldc_I4_7);
                return;
            case 8:
                il.Emit(OpCodes.Ldc_I4_8);
                return;
        }
        if (value > -129 && value < 128)
        {
            il.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
        }
        else
        {
            il.Emit(OpCodes.Ldc_I4, value);
        }
    }
    internal static void Push(this ILGenerator il, long value)
    {
        if (value >= int.MinValue && value <= int.MaxValue)
        {
            Push(il, (int)value);
            il.Emit(OpCodes.Conv_I8);
        }
        else
        {
            il.Emit(OpCodes.Ldc_I8, value);
        }
    }
    internal static void Push(this ILGenerator il, byte value)
    {
        Push(il, (int)value);
    }
    internal static void Push(this ILGenerator il, ushort value)
    {
        Push(il, (int)value);
    }
    internal static void Push(this ILGenerator il, uint value)
    {
        Push(il, (int)value);
    }
    internal static void Push(this ILGenerator il, ulong value)
    {
        Push(il, (long)value);
    }
    internal static void Push(this ILGenerator il, float value)
    {
        il.Emit(OpCodes.Ldc_R4, value);
    }
    internal static void Push(this ILGenerator il, double value)
    {
        il.Emit(OpCodes.Ldc_R8, value);
    }
    internal static void Push(this ILGenerator il, decimal value)
    {
        if (value == default)
        {
            CreateDefault(il, typeof(decimal));
            return;
        }
        int[] bits = decimal.GetBits(value);
        il.Push(bits[0]);
        il.Push(bits[1]);
        il.Push(bits[2]);
        int flags = bits[3];
        bool isNegative = (flags & int.MinValue) == int.MinValue;
        byte scale = (byte)((flags &= ~ int.MinValue) >> 16);
        il.Push(isNegative);
        il.Push(scale);
        il.Emit(OpCodes.Newobj, s_decimalConstructor.Value);
    }
    internal static void Push(this ILGenerator il, DateTime dateTime)
    {
        if (dateTime == default)
        {
            CreateDefault(il, typeof(DateTime));
            return;
        }
        long binary = dateTime.ToBinary();
        il.Push(binary);
        il.Call(s_dateTimeFromBinary.Value);
    }
    internal static void PushDateTimeNow(this ILGenerator il)
    {
        il.Call(s_dateTimeNow.Value);
    }
    internal static void Push(this ILGenerator il, TimeSpan timeSpan)
    {
        if (timeSpan == default)
        {
            CreateDefault(il, typeof(TimeSpan));
            return;
        }
        long tick = timeSpan.Ticks;
        il.Push(tick);
        il.Emit(OpCodes.Newobj, s_timeSpanConstructor.Value);
    }
    internal static void Push(this ILGenerator il, IntPtr intPtr)
    {
        if (IntPtr.Size == sizeof(int))
        {
            Push(il, intPtr.ToInt32());
        }
        else
        {
            Push(il, intPtr.ToInt64());
        }
    }
    internal static void Push(this ILGenerator il, string value)
    {
        il.Emit(OpCodes.Ldstr, value);
    }
    internal static void Push(this ILGenerator il, Enum value)
    {
        if (value == null)
        {
            Push(il, 0);
            return;
        }
        switch (Type.GetTypeCode(value.GetType()))
        {
            case TypeCode.Byte:
                Push(il, System.Convert.ToByte(value));
                break;
            case TypeCode.SByte:
                Push(il, System.Convert.ToSByte(value));
                break;
            case TypeCode.UInt16:
                Push(il, System.Convert.ToUInt16(value));
                break;
            case TypeCode.UInt32:
                Push(il, System.Convert.ToUInt32(value));
                break;
            case TypeCode.UInt64:
                Push(il, System.Convert.ToUInt64(value));
                break;
            case TypeCode.Int16:
                Push(il, System.Convert.ToInt16(value));
                break;
            case TypeCode.Int32:
                Push(il, System.Convert.ToInt32(value));
                break;
            case TypeCode.Int64:
                Push(il, System.Convert.ToInt64(value));
                break;
        }
    }
    internal static void PushArgument(this ILGenerator il, int index)
    {
        if (index == 0)
        {
            il.Emit(OpCodes.Ldarg_0);
        }
        else if (index == 1)
        {
            il.Emit(OpCodes.Ldarg_1);
        }
        else if (index == 2)
        {
            il.Emit(OpCodes.Ldarg_2);
        }
        else if (index == 3)
        {
            il.Emit(OpCodes.Ldarg_3);
        }
        else if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Ldarg_S, (byte)index);
        }
        else
        {
            il.Emit(OpCodes.Ldarg, index);
        }
    }
    internal static void PushArgumentRef(this ILGenerator il, int index)
    {
        if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Ldarga_S, (byte)index);
        }
        else
        {
            il.Emit(OpCodes.Ldarga, index);
        }
    }
    internal static void PopArgument(this ILGenerator il,int index)
    {
        if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Starg_S, (byte)index);
        }
        else
        {
            il.Emit(OpCodes.Starg, index);
        }
    }
    internal static void PushLocal(this ILGenerator il, int index)
    {
        if (index == 0)
        {
            il.Emit(OpCodes.Ldloc_0);
        }
        else if (index == 1)
        {
            il.Emit(OpCodes.Ldloc_1);
        }
        else if (index == 2)
        {
            il.Emit(OpCodes.Ldloc_2);
        }
        else if (index == 3)
        {
            il.Emit(OpCodes.Ldloc_3);
        }
        else if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Ldarg_S, (byte)index);
        }
        else
        {
            il.Emit(OpCodes.Ldarg, index);
        }
    }
    internal static void PopLocal(this ILGenerator il, int index)
    {
        if (index == 0)
        {
            il.Emit(OpCodes.Stloc_0);
        }
        else if (index == 1)
        {
            il.Emit(OpCodes.Stloc_1);
        }
        else if (index == 2)
        {
            il.Emit(OpCodes.Stloc_2);
        }
        else if (index == 3)
        {
            il.Emit(OpCodes.Stloc_3);
        }
        else if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Stloc_S, (byte)index);
        }
        else
        {
            il.Emit(OpCodes.Stloc, index);
        }
    }
    internal static void PushLocalAddress(this ILGenerator il, int index)
    {
        if (index <= byte.MaxValue)
        {
            il.Emit(OpCodes.Ldloca_S, index);
        }
        else
        {
            il.Emit(OpCodes.Ldloca, index);
        }
    }
    internal static void Push(this ILGenerator il, LocalBuilder localBuilder)
    {
        PushLocal(il, localBuilder.LocalIndex);
    }
    internal static void Pop(this ILGenerator il, LocalBuilder localBuilder)
    {
        PopLocal(il, localBuilder.LocalIndex);
    }
    internal static void UnRef(this ILGenerator il, Type reftype)
    {
        if (reftype.IsByRef)
        {
            Type elementType = reftype.GetElementType();
            ReadPointerValue(il, elementType);
        }
    }
    internal static void TransferRef(this ILGenerator il, Type refType)
    {
        if (refType.IsByRef)
        {
            Type elementType = refType.GetElementType();
            WritePointerValue(il, elementType);
        }
    }
    internal static void UnBox(this ILGenerator il, Type type)
    {
        if (type.IsValueType)
        {
            il.Emit(OpCodes.Unbox_Any, type);
        }
        else
        {
            il.Emit(OpCodes.Castclass, type);
        }
    }
    internal static void UnBoxRef(this ILGenerator il, Type type)
    {
        if (type.IsValueType)
            il.Emit(OpCodes.Unbox, type);
        //LocalBuilder fixedloc = il.DeclareLocal(typeof(object), true);
        //il.Pop(fixedloc);
        //il.Push(fixedloc);
        //il.Push(IntPtr.Size);
        //MethodInfo addition = typeof(IntPtr).GetMethod(nameof(IntPtr.Add), BindingFlags.Public | BindingFlags.Static);
        //il.Call(addition);
    }
    internal static void CreateDefault(this ILGenerator il, Type type)
    {
        if (type == typeof(void))
            return;
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Empty:
                return;
            case TypeCode.DBNull:
            case TypeCode.String:
                il.Emit(OpCodes.Ldnull);
                break;
            case TypeCode.Boolean:
            case TypeCode.Char:
            case TypeCode.SByte:
            case TypeCode.Int16:
            case TypeCode.UInt16:
            case TypeCode.Int32:
            case TypeCode.UInt32:
                il.Emit(OpCodes.Ldc_I4_0);
                break;
            case TypeCode.Int64:
            case TypeCode.UInt64:
                il.Emit(OpCodes.Ldc_I4_0);
                il.Emit(OpCodes.Conv_I8);
                break;
            case TypeCode.Single:
                il.Emit(OpCodes.Ldc_R4);
                break;
            case TypeCode.Double:
                il.Emit(OpCodes.Ldc_R8);
                break;
            case TypeCode.Decimal:
            case TypeCode.DateTime:
            case TypeCode.Object:
                if (type == typeof(IntPtr))
                {
                    il.Emit(OpCodes.Ldc_I4_0);
                    il.Emit(OpCodes.Conv_I);
                }
                else if (type.IsValueType)
                {
                    if (TryGetFieldInfo(type, nameof(decimal.Zero), out FieldInfo fieldInfo) && fieldInfo.IsStatic)
                    {
                        il.Emit(OpCodes.Ldsfld, fieldInfo);
                    }
                    else
                    {
                        LocalBuilder temp = il.DeclareLocal(type);
                        il.Emit(OpCodes.Ldloca_S, temp.LocalIndex);
                        il.Emit(OpCodes.Initobj, type);
                        il.Emit(OpCodes.Ldloc, temp.LocalIndex);
                    }
                }
                else
                {
                    il.Emit(OpCodes.Ldnull);
                }
                break;
        }
    }
    internal static void Convert(this ILGenerator il, ConvertItem convertItem)
    {
        if (convertItem == null) throw new ArgumentNullException(nameof(convertItem));
        if (convertItem.OpCode.HasValue)
        {
            il.Emit(convertItem.OpCode.Value);
        }
        else
        {
            convertItem.Action(il);
        }
    }
    internal static void Convert(this ILGenerator il, Type source, Type target)
    {
        if (source.FullName == target.FullName)
            return;

        if (source == typeof(object) || target == typeof(object))
        {
            if (EmitConvertMap.SearchConvertItem(source, target, out ConvertItem convertItem))
            {
                il.Convert(convertItem);
            }
            else
            {
                if (source == typeof(object))
                {
                    if (target != typeof(object))
                    {
                        il.UnBox(target);
                    }
                }
                else
                {
                    il.BoxIfNeeded(source);
                }
            }
            return;
        }

        if (target.IsAssignableFrom(source))
            return;

        if (!source.IsEnum)
        {
            //double Check
            if (!EmitConvertMap.s_map.ContainsKey(source))
            {
                lock (EmitConvertMap.s_map)
                {
                    if (!EmitConvertMap.s_map.ContainsKey(source))
                    {
                        EmitConvertMap.AnalyzeConverter(source);
                    }
                }
            }
        }

        if (EmitConvertMap.SearchConvertPath(source, target, out SearchResult searchResult))
        {
            foreach (ConvertItem convertItem in searchResult.Items.Select(x => x.Value))
            {
                il.Convert(convertItem);
            }
            return;
        }

        throw new InvalidCastException($"{source.Assembly.Location}/{source.FullName}-{target.Assembly.Location}/{target.FullName}");
    }
    internal static bool TryGetFieldInfo(Type type, string name, out FieldInfo fieldInfo)
    {
        foreach (FieldInfo info in type.GetFields(AllFlags))
            if (info.Name == name)
            {
                fieldInfo = info;
                return true;
            }
        fieldInfo = default;
        return false;
    }
    internal static void BoxIfNeeded(this ILGenerator il, Type type)
    {
        if (type.IsValueType)
            il.Emit(OpCodes.Box, type);
    }
    internal static void BoxIfNeeded(this ILGenerator il, LocalBuilder localBuilder)
        => BoxIfNeeded(il, localBuilder.LocalType);
    internal static void New(this ILGenerator il, ConstructorInfo constructorInfo)
    {
        if (!constructorInfo.IsConstructor) throw new ArgumentException(nameof(constructorInfo));
        il.Emit(OpCodes.Newobj, constructorInfo);
    }
    internal static void Call(this ILGenerator il, ConstructorInfo constructorInfo)
    {
        if (constructorInfo.DeclaringType.IsValueType)
        {
            il.Emit(OpCodes.Call, constructorInfo);
        }
        else
            throw new ArgumentException(nameof(constructorInfo));
    }
    internal static void Call(this ILGenerator il, MethodInfo methodInfo)
    {
        if (methodInfo.IsStatic || methodInfo.DeclaringType.IsValueType)
            il.Emit(OpCodes.Call, methodInfo);
        else
            il.Emit(OpCodes.Callvirt, methodInfo);
    }
    internal static void Push(this ILGenerator il, FieldInfo fieldInfo)
    {
        if (fieldInfo.IsStatic)
        {
            il.Emit(OpCodes.Ldsfld, fieldInfo);
        }
        else
        {
            il.Emit(OpCodes.Ldfld, fieldInfo);
        }
    }
    internal static void PushRef(this ILGenerator il, FieldInfo fieldInfo)
    {
        if (fieldInfo.IsStatic)
        {
            il.Emit(OpCodes.Ldsflda, fieldInfo);
        }
        else
        {
            il.Emit(OpCodes.Ldflda, fieldInfo);
        }
    }
    internal static void Pop(this ILGenerator il, FieldInfo fieldInfo)
    {
        if (fieldInfo.IsStatic)
        {
            il.Emit(OpCodes.Stsfld, fieldInfo);
        }
        else
        {
            il.Emit(OpCodes.Stfld, fieldInfo);
        }
    }
    internal static void Ret(this ILGenerator il)
        => il.Emit(OpCodes.Ret);
    /// <summary>
    /// 必须是来自object装箱的参数
    /// 如果是引用类型 推送引用到堆栈
    /// 如果是值类型,创建一个本地变量存储值,并将本地变量的引用推送到堆栈
    /// </summary>
    /// <param name="il"></param>
    /// <param name="objType"></param>
    /// <returns></returns>
    internal static void PushThisCallRefWithObject(this ILGenerator il, Type objType)
    {
        il.PushArgument(0);
        if (objType.IsValueType)
        {
            il.Emit(OpCodes.Unbox, objType);
        }
    }
    internal static void PushThisCallRefWithObjectUnsafe(this ILGenerator il, Type objType)
    {
        il.PushArgument(0);
        il.UnBoxRef(objType);
    }
    internal static void PushThisCallRefWithObjectUnsafe(this ILGenerator il)
    {
        MethodInfo m1 = typeof(object).GetMethod(nameof(object.GetType));
        MethodInfo m2 = typeof(Type).GetProperty(nameof(Type.IsValueType)).GetGetMethod();

        il.PushArgument(0);
        il.Emit(OpCodes.Dup);
        il.Call(m1);
        il.Call(m2);

        Label end = il.DefineLabel();
        il.Emit(OpCodes.Brfalse_S, end);
        il.Emit(OpCodes.Unbox);
        il.MarkLabel(end);
    }
    /// <summary>
    /// 对于值类型加载其值的地址
    /// 对于引用类型加载其引用的地址
    /// </summary>
    /// <param name="il"></param>
    /// <param name="objType"></param>
    /// <param name="localBuilder"></param>
    internal static void PushThisAddressWithObject(this ILGenerator il, Type objType)
    {
        if (objType.IsValueType)
        {
            il.PushArgument(0);
            il.Emit(OpCodes.Unbox, objType);
        }
        else
        {
            il.PushArgumentRef(0);
        }
    }
    /// <summary>
    /// 对于值类型加载其值
    /// 对于引用类型加载其引用
    /// </summary>
    /// <param name="il"></param>
    /// <param name="objType"></param>
    internal static void PushThisValueWithObject(this ILGenerator il, Type objType)
    {
        il.PushArgument(0);
        if (objType.IsValueType) 
            il.UnBox(objType);
    }
}
