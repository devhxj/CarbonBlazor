using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderNav : CdsComponentBase
{
    /// <summary>
    /// The `aria-label` attribute for the menu bar UI.
    /// </summary>
    [Parameter]
    public string? MenuBarLabel { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-nav")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "menu-bar-label", MenuBarLabel)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetReferenceCapture(9, CaptureReference)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

