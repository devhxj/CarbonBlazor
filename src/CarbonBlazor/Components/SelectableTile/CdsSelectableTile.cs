using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelectableTile : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "checkmark-label", CheckmarkLabel)
            .SetAttributeNotNull(8, "color-scheme", ColorScheme)
            .SetAttributeNotNull(9, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(10, "name", Name)
            .SetAttributeNotNull(11, "selected", Selected)
            .SetAttributeNotNull(12, "value", Value)
            .SetAttributeNotNull(13, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetReferenceCapture(15, CaptureReference)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

