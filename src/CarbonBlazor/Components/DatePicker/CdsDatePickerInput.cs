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
    public FORM_ELEMENT_COLOR_SCHEME ColorScheme { get; set; }

    /// <summary>
    /// `true` if the check box should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if the label should be hidden.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

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
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// Controls the invalid state and visibility of the `validityMessage`.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// Date picker input kind.
    /// <para><b>DefaultValue : "simple"</b></para>
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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

    /// <summary>
    /// `true` if the value is required.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Required { get; set; }

    /// <summary>
    /// Vertical size of this date picker input.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// true to use the short version.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Short { get; set; }

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
    /// <para><b>DefaultValue : "\\d{1,2}\\/\\d{1,2}\\/\\d{4}"</b></para>
    /// </summary>
    [Parameter]
    public string? DefaultPattern { get; set; }

    /// <summary>
    /// The default value for `type` property.
    /// <para><b>DefaultValue : "text"</b></para>
    /// </summary>
    [Parameter]
    public string? DefaultType { get; set; }

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
            .OpenElementAnd(0, "cds-date-picker-input")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "input", Input)
            .SetAttributeNotNull(7, "color-scheme", ColorScheme)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttributeNotNull(9, "hide-label", HideLabel)
            .SetAttributeNotNull(10, "warn", Warn)
            .SetAttributeNotNull(11, "warn-text", WarnText)
            .SetAttributeNotNull(12, "invalid-text", InvalidText)
            .SetAttributeNotNull(13, "invalid", Invalid)
            .SetAttribute(14, "kind", Kind)
            .SetAttributeNotNull(15, "label-text", LabelText)
            .SetAttributeNotNull(16, "pattern", Pattern)
            .SetAttributeNotNull(17, "placeholder", Placeholder)
            .SetAttributeNotNull(18, "readonly", Readonly)
            .SetAttributeNotNull(19, "required", Required)
            .SetAttribute(20, "size", Size)
            .SetAttributeNotNull(21, "short", Short)
            .SetAttributeNotNull(22, "type", Type)
            .SetAttributeNotNull(23, "value", Value)
            .SetAttributeNotNull(24, "defaultpattern", DefaultPattern)
            .SetAttributeNotNull(25, "defaulttype", DefaultType)
            .SetAttributeNotNull(26, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(27, "styles", Styles)
            .SetAttributes(28, AdditionalAttributes)
            .SetContent(29, ChildContent)
            .CloseElement();
    }
}

