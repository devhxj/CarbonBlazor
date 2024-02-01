using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsNumberInput : BaseComponent
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
    /// </summary>
    [Parameter]
    public string IncrementButtonAssistiveText { get; set; } = "increase number input";

    /// <summary>
    /// Aria text for the button that decrements the value
    /// </summary>
    [Parameter]
    public string DecrementButtonAssistiveText { get; set; } = "decrease number input";

    /// <summary>
    /// Specify whether you want the steppers to be hidden
    /// </summary>
    [Parameter]
    public bool HideSteppers { get; set; }

    /// <summary>
    /// `true` to allow empty string.
    /// </summary>
    [Parameter]
    public bool AllowEmpty { get; set; }

    /// <summary>
    /// May be any of the standard HTML autocomplete options
    /// </summary>
    [Parameter]
    public string? Autocomplete { get; set; }

    /// <summary>
    /// Sets the input to be focussed automatically on page load. Defaults to false
    /// </summary>
    [Parameter]
    public bool Autofocus { get; set; }

    /// <summary>
    /// Controls the disabled state of the input
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Specify whether to display the character counter
    /// </summary>
    [Parameter]
    public bool EnableCounter { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the control is in warning state
    /// </summary>
    [Parameter]
    public string? WarnText { get; set; }

    /// <summary>
    /// Specify whether you want the underlying label to be visually hidden
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    /// <summary>
    /// "Hide password" tooltip text on password visibility toggle
    /// </summary>
    [Parameter]
    public string HidePasswordLabel { get; set; } = "Hide password";

    /// <summary>
    /// "Show password" tooltip text on password visibility toggle
    /// </summary>
    [Parameter]
    public string ShowPasswordLabel { get; set; } = "Show password";

    /// <summary>
    /// Boolean property to render password visibility toggle
    /// </summary>
    [Parameter]
    public bool ShowPasswordVisibilityToggle { get; set; }

    /// <summary>
    /// The input box size.
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// true to use the inline version.
    /// </summary>
    [Parameter]
    public bool Inline { get; set; }

    /// <summary>
    /// Specify the alignment of the tooltip to the icon-only button.
    /// Can be one of: start, center, or end.
    /// </summary>
    [Parameter]
    public INPUT_TOOLTIP_ALIGNMENT TooltipAlignment { get; set; } = INPUT_TOOLTIP_ALIGNMENT.CENTER;

    /// <summary>
    /// Specify the direction of the tooltip for icon-only buttons.
    /// Can be either top, right, bottom, or left.
    /// </summary>
    [Parameter]
    public INPUT_TOOLTIP_DIRECTION TooltipDirection { get; set; } = INPUT_TOOLTIP_DIRECTION.BOTTOM;

    /// <summary>
    /// The type of the input. Can be one of the types listed in the INPUT_TYPE enum
    /// </summary>
    [Parameter]
    public INPUT_TYPE Type { get; set; } = INPUT_TYPE.TEXT;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// Boolean property to set the required status
    /// </summary>
    [Parameter]
    public bool Required { get; set; }

    /// <summary>
    /// The special validity message for `required`.
    /// </summary>
    [Parameter]
    public string RequiredValidityMessage { get; set; } = "Please fill out this field.";

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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "min", Min)
            .SetAttributeNotNull(6, "max", Max)
            .SetAttributeNotNull(7, "step", Step)
            .SetAttribute(8, "increment-button-assistive-text", IncrementButtonAssistiveText)
            .SetAttribute(9, "decrement-button-assistive-text", DecrementButtonAssistiveText)
            .SetAttribute(10, "hide-steppers", HideSteppers)
            .SetAttribute(11, "allow-empty", AllowEmpty)
            .SetAttribute(12, "autocomplete", Autocomplete)
            .SetAttribute(13, "autofocus", Autofocus)
            .SetAttribute(14, "disabled", Disabled)
            .SetAttribute(15, "enable-counter", EnableCounter)
            .SetAttribute(16, "helper-text", HelperText)
            .SetAttribute(17, "invalid-text", InvalidText)
            .SetAttributeNotNull(18, "max-count", MaxCount)
            .SetAttribute(19, "warn", Warn)
            .SetAttribute(20, "warn-text", WarnText)
            .SetAttribute(21, "hide-label", HideLabel)
            .SetAttribute(22, "label", Label)
            .SetAttribute(23, "name", Name)
            .SetAttribute(24, "pattern", Pattern)
            .SetAttribute(25, "placeholder", Placeholder)
            .SetAttribute(26, "readonly", Readonly)
            .SetAttribute(27, "hidePasswordLabel", HidePasswordLabel)
            .SetAttribute(28, "showPasswordLabel", ShowPasswordLabel)
            .SetAttribute(29, "show-password-visibility-toggle", ShowPasswordVisibilityToggle)
            .SetAttribute(30, "size", Size)
            .SetAttribute(31, "inline", Inline)
            .SetAttribute(32, "tooltipAlignment", TooltipAlignment)
            .SetAttribute(33, "tooltipDirection", TooltipDirection)
            .SetAttribute(34, "type", Type)
            .SetAttributeNotNull(35, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(36, "styles", Styles)
            .SetAttribute(37, "invalid", Invalid)
            .SetAttribute(38, "required", Required)
            .SetAttribute(39, "required-validity-message", RequiredValidityMessage)
            .SetAttribute(40, "validity-message", ValidityMessage)
            .SetAttributeNotNull(41, "value", Value)
            .SetAttributes(42, AdditionalAttributes)
            .SetContent(43, ChildContent)
            .CloseElement();
    }
}

