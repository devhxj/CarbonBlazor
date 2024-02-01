using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsMultiSelect : BaseComponent
{
    [Parameter]
    public string? Filterable { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the icon to clear selection.
    /// </summary>
    [Parameter]
    public string? ClearSelectionLabel { get; set; }

    /// <summary>
    /// Specify the text that should be read for screen readers that describes total items selected
    /// </summary>
    [Parameter]
    public string ClearSelectionDescription { get; set; } = "Total items selected: ";

    /// <summary>
    /// Specify the text that should be read for screen readers to clear selection.
    /// </summary>
    [Parameter]
    public string ClearSelectionText { get; set; } = "To clear selection, press Delete or Backspace.";

    /// <summary>
    /// Specify the locale of the control. Used for the default compareItems used for sorting the list of items in the control.
    /// </summary>
    [Parameter]
    public string Locale { get; set; } = "en";

    /// <summary>
    /// An assistive text for screen reader to announce, telling that an item is unselected.
    /// </summary>
    [Parameter]
    public string UnselectedItemAssistiveText { get; set; } = "Unselected an item.";

    /// <summary>
    /// An assistive text for screen reader to announce, telling that all items are unselected.
    /// </summary>
    [Parameter]
    public string UnselectedAllAssistiveText { get; set; } = "Unselected all items.";

    /// <summary>
    /// Specify feedback (mode) of the selection.
    /// `top`: selected item jumps to top
    /// `fixed`: selected item stays at it's position
    /// `top-after-reopen`: selected item jump to top after reopen dropdown
    /// </summary>
    [Parameter]
    public SELECTION_FEEDBACK_OPTION SelectionFeedback { get; set; } = SELECTION_FEEDBACK_OPTION.TOPAFTERREOPEN;

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
            .OpenElementAnd(0, "cds-multi-select")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "filterable", Filterable)
            .SetAttribute(6, "clear-selection-label", ClearSelectionLabel)
            .SetAttribute(7, "clear-selection-description", ClearSelectionDescription)
            .SetAttribute(8, "clear-selection-text", ClearSelectionText)
            .SetAttribute(9, "locale", Locale)
            .SetAttribute(10, "unselected-item-assistive-text", UnselectedItemAssistiveText)
            .SetAttribute(11, "unselected-all-assistive-text", UnselectedAllAssistiveText)
            .SetAttribute(12, "selection-feedback", SelectionFeedback)
            .SetAttribute(13, "direction", Direction)
            .SetAttribute(14, "disabled", Disabled)
            .SetAttribute(15, "helper-text", HelperText)
            .SetAttribute(16, "hide-label", HideLabel)
            .SetAttribute(17, "invalid-text", InvalidText)
            .SetAttribute(18, "title-text", TitleText)
            .SetAttribute(19, "name", Name)
            .SetAttribute(20, "open", Open)
            .SetAttribute(21, "read-only", ReadOnly)
            .SetAttribute(22, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttribute(23, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttribute(24, "size", Size)
            .SetAttribute(25, "toggle-label-closed", ToggleLabelClosed)
            .SetAttribute(26, "toggle-label-open", ToggleLabelOpen)
            .SetAttribute(27, "label", Label)
            .SetAttribute(28, "type", Type)
            .SetAttribute(29, "warn", Warn)
            .SetAttribute(30, "warn-text", WarnText)
            .SetAttribute(31, "", TRIGGER_KEYS)
            .SetAttributeNotNull(32, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(33, "styles", Styles)
            .SetAttribute(34, "invalid", Invalid)
            .SetAttribute(35, "required", Required)
            .SetAttribute(36, "required-validity-message", RequiredValidityMessage)
            .SetAttribute(37, "validity-message", ValidityMessage)
            .SetAttribute(38, "value", Value)
            .SetAttributes(39, AdditionalAttributes)
            .SetContent(40, ChildContent)
            .CloseElement();
    }
}

