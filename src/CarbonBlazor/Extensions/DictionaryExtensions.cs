using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace CarbonBlazor;

internal static class DictionaryExtensions
{
    public static T? ValueOf<T>(this IReadOnlyDictionary<string, object>? dictionary, string? key, CultureInfo? culture)
    {
        if (string.IsNullOrWhiteSpace(key))
            return default;

        if (dictionary is null || !dictionary.TryGetValue(key, out var value))
        {
            return default;
        }

        if (BindConverter.TryConvertTo<T>(value, culture, out T? result))
        {
            return result;
        }

        return default;
    }

    public static T ValueOf<T>(this IReadOnlyDictionary<string, object>? dictionary, string? key, T nullValue, CultureInfo? culture)
    {
        return ValueOf<T>(dictionary, key, culture) ?? nullValue;
    }

    public static string? CombineClassNames(this IReadOnlyDictionary<string, object>? additionalAttributes, string? classNames)
    {
        if (additionalAttributes is null || !additionalAttributes.TryGetValue("class", out var @class))
        {
            return classNames;
        }

        var classAttributeValue = Convert.ToString(@class, CultureInfo.InvariantCulture);

        if (string.IsNullOrEmpty(classAttributeValue))
        {
            return classNames;
        }

        if (string.IsNullOrEmpty(classNames))
        {
            return classAttributeValue;
        }

        return $"{classAttributeValue} {classNames}";
    }
}
