using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSliderInput : BaseComponent
{
    /// <summary>
    /// `true` if the input should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// true to specify if the control is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// true to specify if the control should display warn icon and text.
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

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
    /// </summary>
    [Parameter]
    public string Type { get; set; } = "number";

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public int? Value { get; set; }

    /// <summary>
    /// true` if the input should be readonly.
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-slider-input")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttribute(6, "invalid", Invalid)
            .SetAttribute(7, "warn", Warn)
            .SetAttributeNotNull(8, "max", Max)
            .SetAttributeNotNull(9, "min", Min)
            .SetAttributeNotNull(10, "step", Step)
            .SetAttribute(11, "type", Type)
            .SetAttributeNotNull(12, "value", Value)
            .SetAttribute(13, "readonly", Readonly)
            .SetAttributeNotNull(14, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetAttributes(16, AdditionalAttributes)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

