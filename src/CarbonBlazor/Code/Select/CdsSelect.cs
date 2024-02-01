using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSelect : BaseComponent
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
    public HTMLOptionsCollection? Options { get; set; }

    /// <summary>
    /// This form control's type.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// Sets the select to be focussed automatically on page load. Defaults to false
    /// </summary>
    [Parameter]
    public bool Autofocus { get; set; }

    /// <summary>
    /// Controls the disabled state of the select
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The helper text.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the label should be hidden, or not
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

    /// <summary>
    /// ID to link the `label` and `select`
    /// </summary>
    [Parameter]
    public string? Id { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// Specify if the currently value is warn.
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Inline { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

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
    /// The selected index.
    /// </summary>
    [Parameter]
    public int? SelectedIndex { get; set; }

    /// <summary>
    /// The input box size.
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

    /// <summary>
    /// The value of the text area.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-select")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "length", Length)
            .SetAttributeNotNull(6, "options", Options)
            .SetAttributeNotNull(7, "type", Type)
            .SetAttribute(8, "autofocus", Autofocus)
            .SetAttribute(9, "disabled", Disabled)
            .SetAttribute(10, "helper-text", HelperText)
            .SetAttribute(11, "hide-label", HideLabel)
            .SetAttribute(12, "id", Id)
            .SetAttribute(13, "invalid", Invalid)
            .SetAttribute(14, "invalid-text", InvalidText)
            .SetAttribute(15, "warn", Warn)
            .SetAttribute(16, "warn-text", WarnText)
            .SetAttribute(17, "label-text", LabelText)
            .SetAttribute(18, "inline", Inline)
            .SetAttributeNotNull(19, "multiple", Multiple)
            .SetAttribute(20, "name", Name)
            .SetAttribute(21, "pattern", Pattern)
            .SetAttribute(22, "placeholder", Placeholder)
            .SetAttribute(23, "readonly", Readonly)
            .SetAttribute(24, "required", Required)
            .SetAttribute(25, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(26, "selectedIndex", SelectedIndex)
            .SetAttribute(27, "size", Size)
            .SetAttribute(28, "value", Value)
            .SetAttributeNotNull(29, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(30, "styles", Styles)
            .SetAttributes(31, AdditionalAttributes)
            .SetContent(32, ChildContent)
            .CloseElement();
    }
}

