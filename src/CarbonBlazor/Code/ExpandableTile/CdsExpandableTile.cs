using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsExpandableTile : BaseComponent
{
    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME? ColorScheme { get; set; }

    /// <summary>
    /// `true` to expand this expandable tile.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    /// <summary>
    /// Specify if the `ExpandableTile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// </summary>
    [Parameter]
    public bool HasRoundedCorners { get; set; }

    /// <summary>
    /// `true` to expand this expandable tile.
    /// </summary>
    [Parameter]
    public bool WithInteractive { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-expandable-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "color-scheme", ColorScheme)
            .SetAttribute(6, "expanded", Expanded)
            .SetAttribute(7, "has-rounded-corners", HasRoundedCorners)
            .SetAttribute(8, "with-interactive", WithInteractive)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

