using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelectItem : BaseComponent
{
    /// <summary>
    /// `true` to disable this option.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The label. If this is not specified, the child text content is used.
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// `true` to select this option.
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-select-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttribute(6, "label", Label)
            .SetAttribute(7, "selected", Selected)
            .SetAttribute(8, "value", Value)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

