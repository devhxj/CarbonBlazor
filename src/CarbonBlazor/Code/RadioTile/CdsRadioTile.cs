using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioTile : BaseComponent
{
    /// <summary>
    /// The a11y text for the checkmark icon of the selected state.
    /// </summary>
    [Parameter]
    public string? CheckmarkLabel { get; set; }

    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME? ColorScheme { get; set; }

    /// <summary>
    /// Specify if the `SeletableTile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// </summary>
    [Parameter]
    public bool HasRoundedCorners { get; set; }

    /// <summary>
    /// The form name.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// `true` to show the selected state.
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    /// <summary>
    /// The form value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-radio-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "checkmark-label", CheckmarkLabel)
            .SetAttribute(6, "color-scheme", ColorScheme)
            .SetAttribute(7, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(8, "name", Name)
            .SetAttribute(9, "selected", Selected)
            .SetAttributeNotNull(10, "value", Value)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

