using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsExpandableTile : BaseComponent
{
    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME ColorScheme { get; set; }

    /// <summary>
    /// `true` to expand this expandable tile.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// Specify if the `ExpandableTile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasRoundedCorners { get; set; }

    /// <summary>
    /// `true` to expand this expandable tile.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? WithInteractive { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-expandable-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "color-scheme", ColorScheme)
            .SetAttributeNotNull(7, "expanded", Expanded)
            .SetAttributeNotNull(8, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(9, "with-interactive", WithInteractive)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

