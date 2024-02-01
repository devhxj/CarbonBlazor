using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelectableTile : BaseComponent
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
    public FORM_ELEMENT_COLOR_SCHEME ColorScheme { get; set; }

    /// <summary>
    /// Specify if the `SeletableTile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasRoundedCorners { get; set; }

    /// <summary>
    /// The form name.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// `true` to show the selected state.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Selected { get; set; }

    /// <summary>
    /// The form value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-selectable-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "checkmark-label", CheckmarkLabel)
            .SetAttributeNotNull(7, "color-scheme", ColorScheme)
            .SetAttributeNotNull(8, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(9, "name", Name)
            .SetAttributeNotNull(10, "selected", Selected)
            .SetAttributeNotNull(11, "value", Value)
            .SetAttributeNotNull(12, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

