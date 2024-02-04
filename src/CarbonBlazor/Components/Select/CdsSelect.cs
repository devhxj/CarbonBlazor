using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class SelectContext
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

public class CdsSelect : CdsComponentBase<SelectContext>
{
    /// <summary>
    /// The count of child `&lt;option&gt;`s.
    /// If the placeholder is in effect, it includes the `&lt;option&gt;` for the placeholder.
    /// </summary>
    [Parameter]
    public int? Length { get; set; }

    /// <summary>
    /// The child `&lt;option&gt;`s.
    /// </summary>
    [Parameter]
    public HTMLOptionsCollection Options { get; set; }

    /// <summary>
    /// This form control's type.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// Sets the select to be focussed automatically on page load. Defaults to false
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Autofocus { get; set; }

    /// <summary>
    /// Controls the disabled state of the select
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The helper text.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the label should be hidden, or not
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
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
    /// Specify if the currently value is warn.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Warn { get; set; }

    /// <summary>
    /// Message which is displayed if the value is warn.
    /// </summary>
    [Parameter]
    public string? WarnText { get; set; }

    /// <summary>
    /// The label text.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// Specify whether you want the inline version of this control
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inline { get; set; }

    /// <summary>
    /// `true` to enable multiple selection.
    /// </summary>
    [Parameter]
    public bool? Multiple { get; set; }

    /// <summary>
    /// Name for the select in the `FormData`
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// Pattern to validate the select against for HTML validity checking
    /// </summary>
    [Parameter]
    public string? Pattern { get; set; }

    /// <summary>
    /// Value to display when the select has an empty `value`
    /// </summary>
    [Parameter]
    public string? Placeholder { get; set; }

    /// <summary>
    /// Controls the readonly state of the select
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

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
    /// The selected index.
    /// </summary>
    [Parameter]
    public int? SelectedIndex { get; set; }

    /// <summary>
    /// The input box size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// The value of the text area.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

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
            .OpenElementAnd(0, "cds-select")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "length", Length)
            .SetAttributeNotNull(8, "options", Options)
            .SetAttributeNotNull(9, "type", Type)
            .SetAttributeNotNull(10, "autofocus", Autofocus)
            .SetAttributeNotNull(11, "disabled", Disabled)
            .SetAttributeNotNull(12, "helper-text", HelperText)
            .SetAttributeNotNull(13, "hide-label", HideLabel)
            .SetAttributeNotNull(14, "invalid", Invalid)
            .SetAttributeNotNull(15, "invalid-text", InvalidText)
            .SetAttributeNotNull(16, "warn", Warn)
            .SetAttributeNotNull(17, "warn-text", WarnText)
            .SetAttributeNotNull(18, "label-text", LabelText)
            .SetAttributeNotNull(19, "inline", Inline)
            .SetAttributeNotNull(20, "multiple", Multiple)
            .SetAttributeNotNull(21, "name", Name)
            .SetAttributeNotNull(22, "pattern", Pattern)
            .SetAttributeNotNull(23, "placeholder", Placeholder)
            .SetAttributeNotNull(24, "readonly", Readonly)
            .SetAttributeNotNull(25, "required", Required)
            .SetAttributeNotNull(26, "aria-required", Required)
            .SetAttributeNotNull(27, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(28, "selectedIndex", SelectedIndex)
            .SetAttribute(29, "size", Size)
            .SetAttributeNotNull(30, "value", Value)
            .SetAttributeNotNull(31, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(32, "styles", Styles)
            .SetReferenceCapture(33, CaptureReference)
            .SetContent(34, ChildContent, new())
            .CloseElement();
    }
}

