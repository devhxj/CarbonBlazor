using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsDropdown : BaseComponent
{
    /// <summary>
    /// Specify the direction of the dropdown. Can be either top or bottom.
    /// <para><b>DefaultValue : "bottom"</b></para>
    /// </summary>
    [Parameter]
    public DROPDOWN_DIRECTION Direction { get; set; } = DROPDOWN_DIRECTION.BOTTOM;

    /// <summary>
    /// `true` if this dropdown should be disabled.
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
    /// Specify whether the title text should be hidden or not
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// Provide the title text that will be read by a screen reader when visiting this control
    /// </summary>
    [Parameter]
    public string? TitleText { get; set; }

    /// <summary>
    /// Name for the dropdown in the `FormData`
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// `true` if this dropdown should be open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

    /// <summary>
    /// Whether or not the Dropdown is readonly
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// An assistive text for screen reader to announce, telling the open state.
    /// <para><b>DefaultValue : "Selecting items. Use up and down arrow keys to navigate."</b></para>
    /// </summary>
    [Parameter]
    public string? SelectingItemsAssistiveText { get; set; }

    /// <summary>
    /// An assistive text for screen reader to announce, telling that an item is selected.
    /// <para><b>DefaultValue : "Selected an item."</b></para>
    /// </summary>
    [Parameter]
    public string? SelectedItemAssistiveText { get; set; }

    /// <summary>
    /// Dropdown size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public DROPDOWN_SIZE Size { get; set; } = DROPDOWN_SIZE.MD;

    /// <summary>
    /// The `aria-label` attribute for the UI indicating the closed state.
    /// </summary>
    [Parameter]
    public string? ToggleLabelClosed { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the UI indicating the open state.
    /// </summary>
    [Parameter]
    public string? ToggleLabelOpen { get; set; }

    /// <summary>
    /// Generic label that will be used as the textual representation of what this field is for
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// `true` if this dropdown should use the inline UI variant.
    /// </summary>
    [Parameter]
    public DROPDOWN_TYPE Type { get; set; }

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
    /// Symbols of keys that triggers opening/closing menu and selecting/deselecting menu item.
    /// <para><b>DefaultValue : "new Set([' ', 'Enter'])"</b></para>
    /// </summary>
    [Parameter]
    public string[] TRIGGER_KEYS { get; set; } = [" ", "Enter"];

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
    /// `true` to show the UI of the invalid state.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// `true` if the value is required.
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
    /// The validity message.
    /// </summary>
    [Parameter]
    public string? ValidityMessage { get; set; }

    /// <summary>
    /// The value of the selected item.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-dropdown")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttribute(6, "direction", Direction)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "helper-text", HelperText)
            .SetAttributeNotNull(9, "hide-label", HideLabel)
            .SetAttributeNotNull(10, "invalid-text", InvalidText)
            .SetAttributeNotNull(11, "title-text", TitleText)
            .SetAttributeNotNull(12, "name", Name)
            .SetAttributeNotNull(13, "open", Open)
            .SetAttributeNotNull(14, "read-only", ReadOnly)
            .SetAttributeNotNull(15, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttributeNotNull(16, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttribute(17, "size", Size)
            .SetAttributeNotNull(18, "toggle-label-closed", ToggleLabelClosed)
            .SetAttributeNotNull(19, "toggle-label-open", ToggleLabelOpen)
            .SetAttributeNotNull(20, "label", Label)
            .SetAttributeNotNull(21, "type", Type)
            .SetAttributeNotNull(22, "warn", Warn)
            .SetAttributeNotNull(23, "warn-text", WarnText)
            .SetAttributeNotNull(24, "trigger_keys", TRIGGER_KEYS)
            .SetAttributeNotNull(25, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(26, "styles", Styles)
            .SetAttributeNotNull(27, "invalid", Invalid)
            .SetAttributeNotNull(28, "required", Required)
            .SetAttributeNotNull(29, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(30, "validity-message", ValidityMessage)
            .SetAttributeNotNull(31, "value", Value)
            .SetAttributes(32, AdditionalAttributes)
            .SetContent(33, ChildContent)
            .CloseElement();
    }
}

