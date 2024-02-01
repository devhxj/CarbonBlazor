using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelectItem : BaseComponent
{
    /// <summary>
    /// `true` to disable this option.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The label. If this is not specified, the child text content is used.
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// `true` to select this option.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Selected { get; set; }

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
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "label", Label)
            .SetAttributeNotNull(8, "selected", Selected)
            .SetAttributeNotNull(9, "value", Value)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

