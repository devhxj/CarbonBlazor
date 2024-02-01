using OneOf;
using System.Text;

namespace CarbonBlazor;

internal static class StyleBuilderExtensions
{
    public static StringBuilder AddClass(this StringBuilder builder, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            if (builder.Length > 0)
            {
                builder.Append(' ');
            }
            builder.Append(value);
        }
        return builder;
    }

    public static StringBuilder AddClass(this StringBuilder builder, string? value, bool when = true)
        => when ? AddClass(builder, value) : builder;

    public static StringBuilder AddClass(this StringBuilder builder, string? value, Func<bool> when)
        => AddClass(builder, value, when());

    public static StringBuilder AddClass(this StringBuilder builder, Func<string?> value, bool when = true)
        => when ? AddClass(builder, value()) : builder;

    public static StringBuilder AddClass(this StringBuilder builder, Func<string?> value, Func<bool> when)
        => AddClass(builder, value, when());

    public static StringBuilder AddClass(this StringBuilder builder, string? trueValue, string falseValue, bool when)
    {
        if (when)
            return AddClass(builder, trueValue);
        else
            return AddClass(builder, falseValue);
    }

    public static StringBuilder AddClassFromAttributes(this StringBuilder builder, IDictionary<string, object>? additionalAttributes)
    {
        if (additionalAttributes is not null && additionalAttributes.TryGetValue("class", out var @class))
            AddClass(builder, @class?.ToString());

        return builder;
    }



    public static StringBuilder AddStyle(this StringBuilder builder, string? style)
    {
        if (!string.IsNullOrWhiteSpace(style))
        {
            if (builder.Length > 0)
            {
                builder.Append(';');
            }
            builder.Append(style);
        }
        return builder;
    }

    public static StringBuilder AddStyle(this StringBuilder builder, string? name, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            if (builder.Length > 0)
            {
                builder.Append(';');
            }
            builder.AppendFormat("{0}:{1}", name, value);
        }
        return builder;
    }

    public static StringBuilder AddStyle(this StringBuilder builder, string? name, OneOf<int, string>? value, string unit = "px")
    {
        if (value.HasValue)
        {
            if (builder.Length > 0)
            {
                builder.Append(';');
            }
            builder.Append(value.Value.Match(x => $"{name}:{x}{unit}", x => $"{name}:{x}"));
        }
        return builder;
    }


    public static StringBuilder AddStyle(this StringBuilder builder, string? style, bool when = true)
        => when ? AddStyle(builder, style) : builder;

    public static StringBuilder AddStyle(this StringBuilder builder, string? style, Func<bool> when)
        => AddStyle(builder, style, when());

    public static StringBuilder AddStyle(this StringBuilder builder, Func<string?> style, bool when = true)
        => when ? AddStyle(builder, style()) : builder;

    public static StringBuilder AddStyle(this StringBuilder builder, Func<string?> style, Func<bool> when)
        => AddStyle(builder, style, when());

    public static StringBuilder AddStyle(this StringBuilder builder, string? trueStyle, string falseStyle, bool when)
    {
        if (when)
        {
            return AddStyle(builder, trueStyle);
        }
        else
        {
            return AddStyle(builder, falseStyle);
        }
    }

    public static StringBuilder AddStyleFromAttributes(this StringBuilder builder, IReadOnlyDictionary<string, object>? additionalAttributes)
    {
        if (additionalAttributes is not null && additionalAttributes.TryGetValue("style", out var style))
            AddStyle(builder, style?.ToString());

        return builder;
    }
}
