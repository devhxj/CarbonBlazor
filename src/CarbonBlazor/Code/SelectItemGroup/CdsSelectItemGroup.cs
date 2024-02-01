using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelectItemGroup : BaseComponent
{
    /// <summary>
    /// `true` to disable this option.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The label.
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-select-item-group")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttribute(6, "label", Label)
            .SetAttributes(7, AdditionalAttributes)
            .SetContent(8, ChildContent)
            .CloseElement();
    }
}

