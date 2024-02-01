using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSlider : BaseComponent
{
    /// <summary>
    /// `true` if the check box should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// true to specify if the control is required.
    /// </summary>
    [Parameter]
    public bool Required { get; set; }

    /// <summary>
    /// Whether the slider should be read-only
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    /// <summary>
    /// The label text.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// The label associated with the maximum value.
    /// </summary>
    [Parameter]
    public string? MaxLabel { get; set; }

    /// <summary>
    /// The label associated with the minimum value.
    /// </summary>
    [Parameter]
    public string? MinLabel { get; set; }

    /// <summary>
    /// The formatter for the text for maximum value.
    /// Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : (max: string, maxLabel: string | undefined) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatMaxText { get; set; } = "(max: string, maxLabel: string | undefined) =>\n    `${max}${maxLabel}`";

    /// <summary>
    /// The formatter for the text for min/max value.
    /// Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : (min: string, minLabel: string | undefined) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatMinText { get; set; } = "(min: string, minLabel: string | undefined) =>\n    `${min}${minLabel}`";

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
    /// The form name.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// true to specify if the control is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// true to specify if the control should display warn icon and text.
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the control is in warning state
    /// </summary>
    [Parameter]
    public string? WarnText { get; set; }

    /// <summary>
    /// The snapping step of the value.
    /// </summary>
    [Parameter]
    public string? Step { get; set; }

    /// <summary>
    /// A value determining how much the value should increase/decrease by Shift+arrow keys,
    /// which will be `(max - min) / stepMultiplier`.
    /// </summary>
    [Parameter]
    public string? StepMultiplier { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// is slide input valid
    /// </summary>
    [Parameter]
    public string? IsValid { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-slider")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttribute(6, "required", Required)
            .SetAttribute(7, "readonly", Readonly)
            .SetAttribute(8, "label-text", LabelText)
            .SetAttribute(9, "max-label", MaxLabel)
            .SetAttribute(10, "min-label", MinLabel)
            .SetAttribute(11, "", FormatMaxText)
            .SetAttribute(12, "", FormatMinText)
            .SetAttributeNotNull(13, "max", Max)
            .SetAttributeNotNull(14, "min", Min)
            .SetAttributeNotNull(15, "name", Name)
            .SetAttribute(16, "invalid", Invalid)
            .SetAttribute(17, "invalid-text", InvalidText)
            .SetAttribute(18, "warn", Warn)
            .SetAttribute(19, "warn-text", WarnText)
            .SetAttributeNotNull(20, "step", Step)
            .SetAttributeNotNull(21, "step-multiplier", StepMultiplier)
            .SetAttributeNotNull(22, "value", Value)
            .SetAttributeNotNull(23, "isValid", IsValid)
            .SetAttributeNotNull(24, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(25, "styles", Styles)
            .SetAttributes(26, AdditionalAttributes)
            .SetContent(27, ChildContent)
            .CloseElement();
    }
}

