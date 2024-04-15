﻿
using System.Reflection;

namespace SmartEnum;
public abstract class Enumeration<TEnum>
    where TEnum : Enumeration<TEnum>
{
    private static readonly Dictionary<int, TEnum> Enumerations = CreateEnumerations();
    protected Enumeration(int value,string name) 
    {
        Value = value;
        Name = name;
    }

    public int Value { get; protected init; }  
    public string Name { get; protected init; } = string.Empty;
    public static TEnum? FromValue(int value)
    {
        return Enumerations.TryGetValue(value,out TEnum? enumeration) ? enumeration : default;
    }

    public static TEnum? FromName(string name)
    {
        return Enumerations
            .Values.SingleOrDefault(e=>e.Name == name); 
    }
    private static Dictionary<int, TEnum> CreateEnumerations()
    {
        var enumerationType = typeof(TEnum);
        var fieldsForType = enumerationType.GetFields(
            BindingFlags.Public |
            BindingFlags.Static |
            BindingFlags.FlattenHierarchy).Where(fieldInfo =>
            enumerationType.IsAssignableFrom(fieldInfo.FieldType))
            .Select(fieldInfo =>
            (TEnum)fieldInfo.GetValue(default)!);

        return fieldsForType.ToDictionary(x => x.Value);
    }


}
