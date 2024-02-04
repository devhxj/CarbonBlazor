using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class SliderContext
{
    /// <summary>
    /// The label text.
    /// </summary>
    public string LabelTextSlot = "label-text";

    /// <summary>
    /// The text for maximum value.
    /// </summary>
    public string MaxTextSlot = "max-text";

    /// <summary>
    /// The text for minimum value.
    /// </summary>
    public string MinTextSlot = "min-text";
}

public class CdsSlider : CdsComponentBase<SliderContext>
{
    /// <summary>
    /// `true` if the check box should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// true to specify if the control is required.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Required { get; set; }

    /// <summary>
    /// Whether the slider should be read-only
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

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
    /// <para><b>DefaultValue : "(max: string, maxLabel: string | undefined) =>\n    `${max}${maxLabel}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatMaxText { get; set; }

    /// <summary>
    /// The formatter for the text for min/max value.
    /// Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : (min: string, minLabel: string | undefined) => string</b></para>
    /// <para><b>DefaultValue : "(min: string, minLabel: string | undefined) =>\n    `${min}${minLabel}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatMinText { get; set; }

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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// true to specify if the control should display warn icon and text.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Warn { get; set; }

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
            .OpenElementAnd(0, "cds-slider")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "required", Required)
            .SetAttributeNotNull(9, "aria-required", Required)
            .SetAttributeNotNull(10, "readonly", Readonly)
            .SetAttributeNotNull(11, "label-text", LabelText)
            .SetAttributeNotNull(12, "max-label", MaxLabel)
            .SetAttributeNotNull(13, "min-label", MinLabel)
            .SetAttributeNotNull(14, "formatmaxtext", FormatMaxText)
            .SetAttributeNotNull(15, "formatmintext", FormatMinText)
            .SetAttributeNotNull(16, "max", Max)
            .SetAttributeNotNull(17, "min", Min)
            .SetAttributeNotNull(18, "name", Name)
            .SetAttributeNotNull(19, "invalid", Invalid)
            .SetAttributeNotNull(20, "invalid-text", InvalidText)
            .SetAttributeNotNull(21, "warn", Warn)
            .SetAttributeNotNull(22, "warn-text", WarnText)
            .SetAttributeNotNull(23, "step", Step)
            .SetAttributeNotNull(24, "step-multiplier", StepMultiplier)
            .SetAttributeNotNull(25, "value", Value)
            .SetAttributeNotNull(26, "isValid", IsValid)
            .SetAttributeNotNull(27, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(28, "styles", Styles)
            .SetReferenceCapture(29, CaptureReference)
            .SetContent(30, ChildContent, new())
            .CloseElement();
    }
}

