using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsDropdown : BaseComponent
{
    /// <summary>
    /// Specify the direction of the dropdown. Can be either top or bottom.
    /// </summary>
    [Parameter]
    public DROPDOWN_DIRECTION Direction { get; set; } = DROPDOWN_DIRECTION.BOTTOM;

    /// <summary>
    /// `true` if this dropdown should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The helper text.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the title text should be hidden or not
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Open { get; set; }

    /// <summary>
    /// Whether or not the Dropdown is readonly
    /// </summary>
    [Parameter]
    public bool ReadOnly { get; set; }

    /// <summary>
    /// An assistive text for screen reader to announce, telling the open state.
    /// </summary>
    [Parameter]
    public string SelectingItemsAssistiveText { get; set; } = "Selecting items. Use up and down arrow keys to navigate.";

    /// <summary>
    /// An assistive text for screen reader to announce, telling that an item is selected.
    /// </summary>
    [Parameter]
    public string SelectedItemAssistiveText { get; set; } = "Selected an item.";

    /// <summary>
    /// Dropdown size.
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
    public DROPDOWN_TYPE? Type { get; set; }

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
    /// Symbols of keys that triggers opening/closing menu and selecting/deselecting menu item.
    /// </summary>
    [Parameter]
    public string[] TRIGGER_KEYS { get; set; } = [" ", "Enter"];

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// `true` to show the UI of the invalid state.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// `true` if the value is required.
    /// </summary>
    [Parameter]
    public bool Required { get; set; }

    /// <summary>
    /// The special validity message for `required`.
    /// </summary>
    [Parameter]
    public string RequiredValidityMessage { get; set; } = "Please fill out this field.";

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
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "direction", Direction)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "helper-text", HelperText)
            .SetAttribute(8, "hide-label", HideLabel)
            .SetAttribute(9, "invalid-text", InvalidText)
            .SetAttribute(10, "title-text", TitleText)
            .SetAttribute(11, "name", Name)
            .SetAttribute(12, "open", Open)
            .SetAttribute(13, "read-only", ReadOnly)
            .SetAttribute(14, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttribute(15, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttribute(16, "size", Size)
            .SetAttribute(17, "toggle-label-closed", ToggleLabelClosed)
            .SetAttribute(18, "toggle-label-open", ToggleLabelOpen)
            .SetAttribute(19, "label", Label)
            .SetAttribute(20, "type", Type)
            .SetAttribute(21, "warn", Warn)
            .SetAttribute(22, "warn-text", WarnText)
            .SetAttribute(23, "", TRIGGER_KEYS)
            .SetAttributeNotNull(24, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(25, "styles", Styles)
            .SetAttribute(26, "invalid", Invalid)
            .SetAttribute(27, "required", Required)
            .SetAttribute(28, "required-validity-message", RequiredValidityMessage)
            .SetAttribute(29, "validity-message", ValidityMessage)
            .SetAttribute(30, "value", Value)
            .SetAttributes(31, AdditionalAttributes)
            .SetContent(32, ChildContent)
            .CloseElement();
    }
}

