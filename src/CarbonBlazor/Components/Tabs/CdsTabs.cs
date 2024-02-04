using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTabs : CdsComponentBase
{
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
    /// The content of the trigger button for narrow mode.
    /// </summary>
    [Parameter]
    public string? TriggerContent { get; set; }

    /// <summary>
    /// Tabs type.
    /// </summary>
    [Parameter]
    public TABS_TYPE Type { get; set; }

    /// <summary>
    /// Symbols of keys that triggers opening/closing menu and selecting/deselecting menu item.
    /// <para><b>DefaultValue : "new Set([' ', 'Enter'])"</b></para>
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
    public CONTENT_SWITCHER_SIZE Size { get; set; }

    /// <summary>
    /// Icon only.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IconOnly { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tabs")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "selecting-items-assistive-text", SelectingItemsAssistiveText)
            .SetAttributeNotNull(8, "selected-item-assistive-text", SelectedItemAssistiveText)
            .SetAttributeNotNull(9, "trigger-content", TriggerContent)
            .SetAttributeNotNull(10, "type", Type)
            .SetAttributeNotNull(11, "trigger_keys", TRIGGER_KEYS)
            .SetAttributeNotNull(12, "value", Value)
            .SetAttributeNotNull(13, "size", Size)
            .SetAttributeNotNull(14, "icon", IconOnly)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetReferenceCapture(16, CaptureReference)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

