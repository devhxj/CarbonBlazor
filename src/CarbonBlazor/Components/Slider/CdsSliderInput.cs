using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSliderInput : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "invalid", Invalid)
            .SetAttributeNotNull(9, "warn", Warn)
            .SetAttributeNotNull(10, "max", Max)
            .SetAttributeNotNull(11, "min", Min)
            .SetAttributeNotNull(12, "step", Step)
            .SetAttributeNotNull(13, "type", Type)
            .SetAttributeNotNull(14, "value", Value)
            .SetAttributeNotNull(15, "readonly", Readonly)
            .SetAttributeNotNull(16, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(17, "styles", Styles)
            .SetReferenceCapture(18, CaptureReference)
            .SetContent(19, ChildContent)
            .CloseElement();
    }
}

