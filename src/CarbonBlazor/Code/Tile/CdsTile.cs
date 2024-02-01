using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTile : BaseComponent
{
    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME? ColorScheme { get; set; }

    /// <summary>
    /// Specify if the `Tile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// </summary>
    [Parameter]
    public bool HasRoundedCorners { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "color-scheme", ColorScheme)
            .SetAttribute(6, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

