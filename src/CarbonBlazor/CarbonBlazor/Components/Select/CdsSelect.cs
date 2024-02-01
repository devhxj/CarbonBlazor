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

public class CdsSelect : BaseComponent<SelectContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "length", Length)
            .SetAttributeNotNull(7, "options", Options)
            .SetAttributeNotNull(8, "type", Type)
            .SetAttributeNotNull(9, "autofocus", Autofocus)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "helper-text", HelperText)
            .SetAttributeNotNull(12, "hide-label", HideLabel)
            .SetAttributeNotNull(13, "invalid", Invalid)
            .SetAttributeNotNull(14, "invalid-text", InvalidText)
            .SetAttributeNotNull(15, "warn", Warn)
            .SetAttributeNotNull(16, "warn-text", WarnText)
            .SetAttributeNotNull(17, "label-text", LabelText)
            .SetAttributeNotNull(18, "inline", Inline)
            .SetAttributeNotNull(19, "multiple", Multiple)
            .SetAttributeNotNull(20, "name", Name)
            .SetAttributeNotNull(21, "pattern", Pattern)
            .SetAttributeNotNull(22, "placeholder", Placeholder)
            .SetAttributeNotNull(23, "readonly", Readonly)
            .SetAttributeNotNull(24, "required", Required)
            .SetAttributeNotNull(25, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(26, "selectedIndex", SelectedIndex)
            .SetAttribute(27, "size", Size)
            .SetAttributeNotNull(28, "value", Value)
            .SetAttributeNotNull(29, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(30, "styles", Styles)
            .SetAttributes(31, AdditionalAttributes)
            .SetContent(32, ChildContent, new())
            .CloseElement();
    }
}

