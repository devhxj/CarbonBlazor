using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using shortid.Configuration;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.Json;

namespace CarbonBlazor;

internal static class RenderTreeBuilderExtensions
{
    static readonly ConcurrentDictionary<Enum, string> Values = new();

    public static readonly GenerationOptions IdGenerator = new(false, false, 8);

    static string GetDescription(Enum value)
    {
        if (Values.TryGetValue(value, out var cache))
        {
            return cache;
        }

        var stringValue = value.ToString();
        var fieldInfo = value.GetType().GetField(stringValue);
        if (fieldInfo is not null)
        {
            stringValue = (fieldInfo.GetCustomAttribute<DescriptionAttribute>(true)?.Description ?? stringValue).ToLower();
        }
        else
        {
            stringValue = stringValue.ToLower();
        }

        Values.TryAdd(value, stringValue);
        return stringValue;
    }

    public static RenderTreeBuilder OpenElementAnd(this RenderTreeBuilder builder, int sequence, string elementName)
    {
        builder.OpenElement(sequence, elementName);
        return builder;
    }

    public static RenderTreeBuilder OpenComponentAnd<TComponent>(this RenderTreeBuilder builder, int sequence) where TComponent : ComponentBase
    {
        builder.OpenComponent<TComponent>(sequence);
        return builder;
    }

    public static RenderTreeBuilder CloseElementAnd(this RenderTreeBuilder builder)
    {
        builder.CloseElement();
        return builder;
    }

    public static RenderTreeBuilder SetAttribute(this RenderTreeBuilder builder, int sequence, string name)
    {
        builder.AddAttribute(sequence, name);
        return builder;
    }

    public static RenderTreeBuilder SetAttribute<TValue>(this RenderTreeBuilder builder, int sequence, string name, TValue? value)
    {
        if (value is Enum e)
            builder.AddAttribute(sequence, name, GetDescription(e));

        else if (value is bool b)
        {
            if (b)
                builder.AddAttribute(sequence, name, "true");
            else
                builder.AddAttribute(sequence, name, "false");
        }

        else if (value is Array a && a.Length > 0)
            builder.AddAttribute(sequence, name,new MarkupString(JsonSerializer.Serialize(a)));

        else if (value is CultureInfo c)
            builder.AddAttribute(sequence, name, c.Name);

        else
            builder.AddAttribute(sequence, name, value);

        return builder;
    }

    public static RenderTreeBuilder SetAttributeNotNull<TValue>(this RenderTreeBuilder builder, int sequence, string name, TValue? value)
    {
        if (value is not null)
            SetAttribute(builder, sequence, name, value);

        return builder;
    }

    public static RenderTreeBuilder SetAttributeIf(this RenderTreeBuilder builder, int sequence, string name, bool where)
    {
        if (where)
            builder.AddAttribute(sequence, name);

        return builder;
    }

    public static RenderTreeBuilder SetAttributeIf(this RenderTreeBuilder builder, int sequence, string name, Func<string> value, bool where)
    {
        if (where)
        {
            SetAttributeNotNull(builder, sequence, name, value());
        }
        return builder;
    }

    public static RenderTreeBuilder SetAttributeIf<TValue>(this RenderTreeBuilder builder, int sequence, string name, TValue? value, Func<TValue?, bool> where)
    {
        if (where(value))
        {
            SetAttributeNotNull(builder, sequence, name, value);
        }
        return builder;
    }

    public static RenderTreeBuilder SetAttributeIf<TValue>(this RenderTreeBuilder builder, int sequence, string name, TValue? value, bool where)
    {
        if (where)
        {
            SetAttributeNotNull(builder, sequence, name, value);
        }
        return builder;
    }

    public static RenderTreeBuilder SetAttributeCase<TValue>(this RenderTreeBuilder builder, int sequence, string name, TValue? trueValue, TValue? falseValue, bool where)
    {
        if (where)
        {
            SetAttributeNotNull(builder, sequence, name, trueValue);
        }
        else
        {
            SetAttributeNotNull(builder, sequence, name, falseValue);
        }
        return builder;
    }

    public static RenderTreeBuilder SetAttributes(this RenderTreeBuilder builder, int sequence, IEnumerable<KeyValuePair<string, object>>? attributes)
    {
        builder.AddMultipleAttributes(sequence, attributes);
        return builder;
    }

    public static RenderTreeBuilder SetContent(this RenderTreeBuilder builder, int sequence, MarkupString markupContent)
    {
            builder.AddContent(sequence, markupContent);

        return builder;
    }

    public static RenderTreeBuilder SetContentIf(this RenderTreeBuilder builder, int sequence, MarkupString markupContent, bool where)
    {
        if (where)
            builder.AddContent(sequence, markupContent);

        return builder;
    }

    public static RenderTreeBuilder SetContent(this RenderTreeBuilder builder, int sequence, string? textContent)
    {
        if (!string.IsNullOrWhiteSpace(textContent))
            builder.AddContent(sequence, textContent);

        return builder;
    }

    public static RenderTreeBuilder SetContentIf(this RenderTreeBuilder builder, int sequence, string? textContent, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, textContent);
        }
        return builder;
    }

    public static RenderTreeBuilder SetContentCase(this RenderTreeBuilder builder, int sequence, string? trueTextContent, string? falseTextContent, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, trueTextContent);
        }
        else
        {
            SetContent(builder, sequence, falseTextContent);
        }
        return builder;
    }


    public static RenderTreeBuilder SetContent(this RenderTreeBuilder builder, int sequence, RenderFragment? fragment)
    {
        if (fragment is not null)
            builder.AddContent(sequence, fragment);

        return builder;
    }

    public static RenderTreeBuilder SetContentIf(this RenderTreeBuilder builder, int sequence, RenderFragment? fragment, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, fragment);
        }
        return builder;
    }

    public static RenderTreeBuilder SetContentCase(this RenderTreeBuilder builder, int sequence, RenderFragment? trueFragment, RenderFragment? falseFragment, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, trueFragment);
        }
        else
        {
            SetContent(builder, sequence, falseFragment);
        }
        return builder;
    }



    public static RenderTreeBuilder SetContent<TValue>(this RenderTreeBuilder builder, int sequence, RenderFragment<TValue>? fragment, TValue value)
    {
        if (fragment is not null)
            builder.AddContent(sequence, fragment, value);

        return builder;
    }

    public static RenderTreeBuilder SetContentIf<TValue>(this RenderTreeBuilder builder, int sequence, RenderFragment<TValue>? fragment, TValue value, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, fragment, value);
        }
        return builder;
    }

    public static RenderTreeBuilder SetContentCase<TValue>(this RenderTreeBuilder builder, int sequence, RenderFragment<TValue>? trueFragment, RenderFragment<TValue>? falseFragment, TValue value, bool where)
    {
        if (where)
        {
            SetContent(builder, sequence, trueFragment, value);
        }
        else
        {
            SetContent(builder, sequence, falseFragment, value);
        }
        return builder;
    }

}
