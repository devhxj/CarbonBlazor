using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class NumberInputContext
{
    /// <summary>
    /// The helper text.
    /// </summary>
    public string HelperTextSlot = "helper-text";

    /// <summary>
    /// The label text.
    /// </summary>
    public string LabelTextSlot = "label-text";

    /// <summary>
    /// The validity message. If present and non-empty, this input shows the UI of its invalid state.
    /// </summary>
    public string ValidityMessageSlot = "validity-message";
}

public class CdsNumberInput : CdsComponentBase<NumberInputContext>
{
    /// <summary>
    /// The minimum value allowed in the input
    /// </summary>
    [Parameter]
    public string? Min { get; set; }

    /// <summary>
    /// The maximum value allowed in the input
    /// </summary>
    [Parameter]
    public string? Max { get; set; }

    /// <summary>
    /// The amount the value should increase or decrease by
    /// </summary>
    [Parameter]
    public string? Step { get; set; }

    /// <summary>
    /// Aria text for the button that increments the value
    /// <para><b>DefaultValue : "increase number input"</b></para>
    /// </summary>
    [Parameter]
    public string? IncrementButtonAssistiveText { get; set; }

    /// <summary>
    /// Aria text for the button that decrements the value
    /// <para><b>DefaultValue : "decrease number input"</b></para>
    /// </summary>
    [Parameter]
    public string? DecrementButtonAssistiveText { get; set; }

    /// <summary>
    /// Specify whether you want the steppers to be hidden
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideSteppers { get; set; }

    /// <summary>
    /// `true` to allow empty string.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? AllowEmpty { get; set; }

    /// <summary>
    /// May be any of the standard HTML autocomplete options
    /// </summary>
    [Parameter]
    public string? Autocomplete { get; set; }

    /// <summary>
    /// Sets the input to be focussed automatically on page load. Defaults to false
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Autofocus { get; set; }

    /// <summary>
    /// Controls the disabled state of the input
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Specify whether to display the character counter
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? EnableCounter { get; set; }

    /// <summary>
    /// The helper text.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// Max character count allowed for input. This is needed in order for enableCounter to display
    /// </summary>
    [Parameter]
    public string? MaxCount { get; set; }

    /// <summary>
    /// Specify whether the control is currently in warning state
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
    /// Specify whether you want the underlying label to be visually hidden
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

    /// <summary>
    /// Generic label that will be used as the textual representation of what this field is for
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// Name for the input in the `FormData`
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// Pattern to validate the input against for HTML validity checking
    /// </summary>
    [Parameter]
    public string? Pattern { get; set; }

    /// <summary>
    /// Value to display when the input has an empty `value`
    /// </summary>
    [Parameter]
    public string? Placeholder { get; set; }

    /// <summary>
    /// Specify if the component should be read-only
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

    /// <summary>
    /// "Hide password" tooltip text on password visibility toggle
    /// <para><b>DefaultValue : "Hide password"</b></para>
    /// </summary>
    [Parameter]
    public string? HidePasswordLabel { get; set; }

    /// <summary>
    /// "Show password" tooltip text on password visibility toggle
    /// <para><b>DefaultValue : "Show password"</b></para>
    /// </summary>
    [Parameter]
    public string? ShowPasswordLabel { get; set; }

    /// <summary>
    /// Boolean property to render password visibility toggle
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ShowPasswordVisibilityToggle { get; set; }

    /// <summary>
    /// The input box size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// true to use the inline version.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inline { get; set; }

    /// <summary>
    /// Specify the alignment of the tooltip to the icon-only button.
    /// Can be one of: start, center, or end.
    /// <para><b>DefaultValue : "center"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_TOOLTIP_ALIGNMENT TooltipAlignment { get; set; } = INPUT_TOOLTIP_ALIGNMENT.CENTER;

    /// <summary>
    /// Specify the direction of the tooltip for icon-only buttons.
    /// Can be either top, right, bottom, or left.
    /// <para><b>DefaultValue : "bottom"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_TOOLTIP_DIRECTION TooltipDirection { get; set; } = INPUT_TOOLTIP_DIRECTION.BOTTOM;

    /// <summary>
    /// The type of the input. Can be one of the types listed in the INPUT_TYPE enum
    /// <para><b>DefaultValue : "text"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_TYPE Type { get; set; } = INPUT_TYPE.TEXT;

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

    /// <summary>
    /// Specify if the currently value is invalid.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// Boolean property to set the required status
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Required { get; set; }

    /// <summary>
    /// The special validity message for `required`.
    /// <para><b>DefaultValue : "Please fill out this field."</b></para>
    /// </summary>
    [Parameter]
    public string? RequiredValidityMessage { get; set; }

    /// <summary>
    /// The validity message. If present and non-empty, this input shows the UI of its invalid state.
    /// </summary>
    [Parameter]
    public string? ValidityMessage { get; set; }

    /// <summary>
    /// The value of the input.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-number-input")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "min", Min)
            .SetAttributeNotNull(8, "max", Max)
            .SetAttributeNotNull(9, "step", Step)
            .SetAttributeNotNull(10, "increment-button-assistive-text", IncrementButtonAssistiveText)
            .SetAttributeNotNull(11, "decrement-button-assistive-text", DecrementButtonAssistiveText)
            .SetAttributeNotNull(12, "hide-steppers", HideSteppers)
            .SetAttributeNotNull(13, "allow-empty", AllowEmpty)
            .SetAttributeNotNull(14, "autocomplete", Autocomplete)
            .SetAttributeNotNull(15, "autofocus", Autofocus)
            .SetAttributeNotNull(16, "disabled", Disabled)
            .SetAttributeNotNull(17, "enable-counter", EnableCounter)
            .SetAttributeNotNull(18, "helper-text", HelperText)
            .SetAttributeNotNull(19, "invalid-text", InvalidText)
            .SetAttributeNotNull(20, "max-count", MaxCount)
            .SetAttributeNotNull(21, "warn", Warn)
            .SetAttributeNotNull(22, "warn-text", WarnText)
            .SetAttributeNotNull(23, "hide-label", HideLabel)
            .SetAttributeNotNull(24, "label", Label)
            .SetAttributeNotNull(25, "name", Name)
            .SetAttributeNotNull(26, "pattern", Pattern)
            .SetAttributeNotNull(27, "placeholder", Placeholder)
            .SetAttributeNotNull(28, "readonly", Readonly)
            .SetAttributeNotNull(29, "hidePasswordLabel", HidePasswordLabel)
            .SetAttributeNotNull(30, "showPasswordLabel", ShowPasswordLabel)
            .SetAttributeNotNull(31, "show-password-visibility-toggle", ShowPasswordVisibilityToggle)
            .SetAttribute(32, "size", Size)
            .SetAttributeNotNull(33, "inline", Inline)
            .SetAttribute(34, "tooltipAlignment", TooltipAlignment)
            .SetAttribute(35, "tooltipDirection", TooltipDirection)
            .SetAttribute(36, "type", Type)
            .SetAttributeNotNull(37, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(38, "styles", Styles)
            .SetAttributeNotNull(39, "invalid", Invalid)
            .SetAttributeNotNull(40, "required", Required)
            .SetAttributeNotNull(41, "aria-required", Required)
            .SetAttributeNotNull(42, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(43, "validity-message", ValidityMessage)
            .SetAttributeNotNull(44, "value", Value)
            .SetReferenceCapture(45, CaptureReference)
            .SetContent(46, ChildContent, new())
            .CloseElement();
    }
}

