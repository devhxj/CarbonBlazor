using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSliderInput : BaseComponent
{
    /// <summary>
    /// `true` if the input should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// true to specify if the control is invalid.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// true to specify if the control should display warn icon and text.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Warn { get; set; }

    /// <summary>
    /// The maximum value.
    /// </summary>
    [Parameter]
    public string? Max { get; set; }

    /// <summary>
    /// The minimum value.
    /// </summary>
    [Parameter]
    public string? Min { get; set; }

    /// <summary>
    /// The snapping step of the value.
    /// </summary>
    [Parameter]
    public string? Step { get; set; }

    /// <summary>
    /// The type of the `&lt;input&gt;`.
    /// <para><b>DefaultValue : "number"</b></para>
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public int? Value { get; set; }

    /// <summary>
    /// true` if the input should be readonly.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

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
            .OpenElementAnd(0, "cds-slider-input")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "invalid", Invalid)
            .SetAttributeNotNull(8, "warn", Warn)
            .SetAttributeNotNull(9, "max", Max)
            .SetAttributeNotNull(10, "min", Min)
            .SetAttributeNotNull(11, "step", Step)
            .SetAttributeNotNull(12, "type", Type)
            .SetAttributeNotNull(13, "value", Value)
            .SetAttributeNotNull(14, "readonly", Readonly)
            .SetAttributeNotNull(15, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetAttributes(17, AdditionalAttributes)
            .SetContent(18, ChildContent)
            .CloseElement();
    }
}

