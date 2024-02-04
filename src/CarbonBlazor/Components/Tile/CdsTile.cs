using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTile : CdsComponentBase
{
    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME ColorScheme { get; set; }

    /// <summary>
    /// Specify if the `Tile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasRoundedCorners { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tile")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "color-scheme", ColorScheme)
            .SetAttributeNotNull(8, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

