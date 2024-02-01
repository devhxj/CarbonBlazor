using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTabs : BaseComponent
{
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
    /// The content of the trigger button for narrow mode.
    /// </summary>
    [Parameter]
    public string? TriggerContent { get; set; }

    /// <summary>
    /// Tabs type.
    /// </summary>
    [Parameter]
    public TABS_TYPE? Type { get; set; }

    /// <summary>
    /// Symbols of keys that triggers opening/closing menu and selecting/deselecting menu item.
    /// </summary>
    [Parameter]
    public string[] TRIGGER_KEYS { get; set; } = [" ", "Enter"];

    /// <summary>
    /// The value of the selected item.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// Content switcher size.
    /// </summary>
    [Parameter]
    public CONTENT_SWITCHER_SIZE? Size { get; set; }

    /// <summary>
    /// Icon only.
    /// </summary>
    [Parameter]
    public bool IconOnly { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tabs")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttribute(6, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttribute(7, "trigger-content", TriggerContent)
            .SetAttribute(8, "type", Type)
            .SetAttribute(9, "", TRIGGER_KEYS)
            .SetAttribute(10, "value", Value)
            .SetAttribute(11, "size", Size)
            .SetAttribute(12, "icon", IconOnly)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

