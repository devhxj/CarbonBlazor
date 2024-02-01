using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsModalFooter : BaseComponent
{
    /// <summary>
    /// `true` if this modal footer has more than two buttons.
    /// </summary>
    [Parameter]
    public bool HasThreeButtons { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-modal-footer")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "has-three-buttons", HasThreeButtons)
            .SetAttributeNotNull(6, "styles", Styles)
            .SetAttributes(7, AdditionalAttributes)
            .SetContent(8, ChildContent)
            .CloseElement();
    }
}

