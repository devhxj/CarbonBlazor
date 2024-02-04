using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;

namespace CarbonBlazor;

public sealed class CdsSVG : CdsElementBase
{
    [Parameter]
    public bool? Focusable { get; init; } = false;

    [Parameter]
    public string? Xmlns { get; init; } = "http://www.w3.org/2000/svg";

    [Parameter]
    public string? Fill { get; init; } = "currentColor";

    [Parameter]
    public bool? AriaHidden { get; init; } = true;

    [Parameter]
    public string? PreserveAspectRatio { get; init; } = "xMidYMid meet";

    [Parameter]
    [NotNull]
    public int Height { get; init; } = 20;

    [Parameter]
    [NotNull]
    public int Width { get; init; } = 20;

    [Parameter]
    [NotNull]
    public ViewBox ViewBox { get; init; } = 32;

    [Parameter]
    public string? Slot { get; init; } = "icon";

    [Parameter]
    public string? Content { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var isNullContent = string.IsNullOrWhiteSpace(Content);
        if (isNullContent && ChildContent is null)
            return;

        builder
            .OpenElementAnd(0, "svg")
            .SetAttributeNotNull(1, "focusable", Focusable)
            .SetAttributeNotNull(2, "preserveAspectRatio", PreserveAspectRatio)
            .SetAttributeNotNull(3, "xmlns", Xmlns)
            .SetAttributeNotNull(4, "fill", Fill)
            .SetAttributeNotNull(5, "aria-hidden", AriaHidden)
            .SetAttribute(6, "width", Width)
            .SetAttribute(7, "height", Height)
            .SetAttribute(8, "viewBox", ViewBox.ToString())
            .SetAttributeNotNull(9, "slot", Slot)
            .SetAttributes(10, AdditionalAttributes)
            .SetContentIf(11, ChildContent, isNullContent)
            .SetContentIf(12, new MarkupString(Content!), !isNullContent)
            .CloseElement();
    }
}
