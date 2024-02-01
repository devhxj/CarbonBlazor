using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsModalFooter : BaseComponent
{
    /// <summary>
    /// `true` if this modal footer has more than two buttons.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasThreeButtons { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-modal-footer")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "has-three-buttons", HasThreeButtons)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

