using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsMultiSelect : CdsComponentBase
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
    /// <para><b>DefaultValue : "Total items selected: "</b></para>
    /// </summary>
    [Parameter]
    public string? ClearSelectionDescription { get; set; }

    /// <summary>
    /// Specify the text that should be read for screen readers to clear selection.
    /// <para><b>DefaultValue : "To clear selection, press Delete or Backspace."</b></para>
    /// </summary>
    [Parameter]
    public string? ClearSelectionText { get; set; }

    /// <summary>
    /// Specify the locale of the control. Used for the default compareItems used for sorting the list of items in the control.
    /// <para><b>DefaultValue : "en"</b></para>
    /// </summary>
    [Parameter]
    public string? Locale { get; set; }

    /// <summary>
    /// An assistive text for screen reader to announce, telling that an item is unselected.
    /// <para><b>DefaultValue : "Unselected an item."</b></para>
    /// </summary>
    [Parameter]
    public string? UnselectedItemAssistiveText { get; set; }

    /// <summary>
    /// An assistive text for screen reader to announce, telling that all items are unselected.
    /// <para><b>DefaultValue : "Unselected all items."</b></para>
    /// </summary>
    [Parameter]
    public string? UnselectedAllAssistiveText { get; set; }

    /// <summary>
    /// Specify feedback (mode) of the selection.
    /// `top`: selected item jumps to top
    /// `fixed`: selected item stays at it's position
    /// `top-after-reopen`: selected item jump to top after reopen dropdown
    /// <para><b>DefaultValue : "top-after-reopen"</b></para>
    /// </summary>
    [Parameter]
    public SELECTION_FEEDBACK_OPTION SelectionFeedback { get; set; } = SELECTION_FEEDBACK_OPTION.TOP_AFTER_REOPEN;

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
            .OpenElementAnd(0, "cds-multi-select")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "filterable", Filterable)
            .SetAttributeNotNull(8, "clear-selection-label", ClearSelectionLabel)
            .SetAttributeNotNull(9, "clear-selection-description", ClearSelectionDescription)
            .SetAttributeNotNull(10, "clear-selection-text", ClearSelectionText)
            .SetAttributeNotNull(11, "locale", Locale)
            .SetAttributeNotNull(12, "unselected-item-assistive-text", UnselectedItemAssistiveText)
            .SetAttributeNotNull(13, "unselected-all-assistive-text", UnselectedAllAssistiveText)
            .SetAttribute(14, "selection-feedback", SelectionFeedback)
            .SetAttribute(15, "direction", Direction)
            .SetAttributeNotNull(16, "disabled", Disabled)
            .SetAttributeNotNull(17, "helper-text", HelperText)
            .SetAttributeNotNull(18, "hide-label", HideLabel)
            .SetAttributeNotNull(19, "invalid-text", InvalidText)
            .SetAttributeNotNull(20, "title-text", TitleText)
            .SetAttributeNotNull(21, "name", Name)
            .SetAttributeNotNull(22, "open", Open)
            .SetAttributeNotNull(23, "read-only", ReadOnly)
            .SetAttributeNotNull(24, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttributeNotNull(25, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttribute(26, "size", Size)
            .SetAttributeNotNull(27, "toggle-label-closed", ToggleLabelClosed)
            .SetAttributeNotNull(28, "toggle-label-open", ToggleLabelOpen)
            .SetAttributeNotNull(29, "label", Label)
            .SetAttributeNotNull(30, "type", Type)
            .SetAttributeNotNull(31, "warn", Warn)
            .SetAttributeNotNull(32, "warn-text", WarnText)
            .SetAttributeNotNull(33, "trigger_keys", TRIGGER_KEYS)
            .SetAttributeNotNull(34, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(35, "styles", Styles)
            .SetAttributeNotNull(36, "invalid", Invalid)
            .SetAttributeNotNull(37, "required", Required)
            .SetAttributeNotNull(38, "aria-required", Required)
            .SetAttributeNotNull(39, "required-validity-message", RequiredValidityMessage)
            .SetAttributeNotNull(40, "validity-message", ValidityMessage)
            .SetAttributeNotNull(41, "value", Value)
            .SetReferenceCapture(42, CaptureReference)
            .SetContent(43, ChildContent)
            .CloseElement();
    }
}

