using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsDatePickerInput : BaseComponent
{
    /// <summary>
    /// The `&lt;input&gt;`, used for Flatpickr to grab.
    /// <para><b>Type : HTMLInputElement</b></para>
    /// </summary>
    [Parameter]
    public ElementRef? Input { get; set; }

    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME? ColorScheme { get; set; }

    /// <summary>
    /// `true` if the check box should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if the label should be hidden.
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

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
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// Controls the invalid state and visibility of the `validityMessage`.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// Date picker input kind.
    /// </summary>
    [Parameter]
    public DATE_PICKER_INPUT_KIND Kind { get; set; } = DATE_PICKER_INPUT_KIND.SIMPLE;

    /// <summary>
    /// The label text.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// The `pattern` attribute for the `&lt;input&gt;` in the shadow DOM.
    /// </summary>
    [Parameter]
    public string? Pattern { get; set; }

    /// <summary>
    /// The placeholder text.
    /// </summary>
    [Parameter]
    public string? Placeholder { get; set; }

    /// <summary>
    /// Specify if the component should be read-only
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    /// <summary>
    /// `true` if the value is required.
    /// </summary>
    [Parameter]
    public bool Required { get; set; }

    /// <summary>
    /// Vertical size of this date picker input.
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// true to use the short version.
    /// </summary>
    [Parameter]
    public bool Short { get; set; }

    /// <summary>
    /// The `type` attribute for the `&lt;input&gt;` in the shadow DOM.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// The default value for `pattern` property.
    /// </summary>
    [Parameter]
    public string DefaultPattern { get; set; } = "\\d{1,2}\\/\\d{1,2}\\/\\d{4}";

    /// <summary>
    /// The default value for `type` property.
    /// </summary>
    [Parameter]
    public string DefaultType { get; set; } = "text";

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-date-picker-input")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "input", Input)
            .SetAttribute(6, "color-scheme", ColorScheme)
            .SetAttribute(7, "disabled", Disabled)
            .SetAttribute(8, "hide-label", HideLabel)
            .SetAttribute(9, "warn", Warn)
            .SetAttribute(10, "warn-text", WarnText)
            .SetAttribute(11, "invalid-text", InvalidText)
            .SetAttribute(12, "invalid", Invalid)
            .SetAttribute(13, "kind", Kind)
            .SetAttributeNotNull(14, "label-text", LabelText)
            .SetAttributeNotNull(15, "pattern", Pattern)
            .SetAttributeNotNull(16, "placeholder", Placeholder)
            .SetAttribute(17, "readonly", Readonly)
            .SetAttribute(18, "required", Required)
            .SetAttribute(19, "size", Size)
            .SetAttribute(20, "short", Short)
            .SetAttributeNotNull(21, "type", Type)
            .SetAttributeNotNull(22, "value", Value)
            .SetAttribute(23, "", DefaultPattern)
            .SetAttribute(24, "", DefaultType)
            .SetAttributeNotNull(25, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(26, "styles", Styles)
            .SetAttributes(27, AdditionalAttributes)
            .SetContent(28, ChildContent)
            .CloseElement();
    }
}

