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

public class CdsSlider : BaseComponent<SliderContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "required", Required)
            .SetAttributeNotNull(8, "readonly", Readonly)
            .SetAttributeNotNull(9, "label-text", LabelText)
            .SetAttributeNotNull(10, "max-label", MaxLabel)
            .SetAttributeNotNull(11, "min-label", MinLabel)
            .SetAttributeNotNull(12, "formatmaxtext", FormatMaxText)
            .SetAttributeNotNull(13, "formatmintext", FormatMinText)
            .SetAttributeNotNull(14, "max", Max)
            .SetAttributeNotNull(15, "min", Min)
            .SetAttributeNotNull(16, "name", Name)
            .SetAttributeNotNull(17, "invalid", Invalid)
            .SetAttributeNotNull(18, "invalid-text", InvalidText)
            .SetAttributeNotNull(19, "warn", Warn)
            .SetAttributeNotNull(20, "warn-text", WarnText)
            .SetAttributeNotNull(21, "step", Step)
            .SetAttributeNotNull(22, "step-multiplier", StepMultiplier)
            .SetAttributeNotNull(23, "value", Value)
            .SetAttributeNotNull(24, "isValid", IsValid)
            .SetAttributeNotNull(25, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(26, "styles", Styles)
            .SetAttributes(27, AdditionalAttributes)
            .SetContent(28, ChildContent, new())
            .CloseElement();
    }
}

