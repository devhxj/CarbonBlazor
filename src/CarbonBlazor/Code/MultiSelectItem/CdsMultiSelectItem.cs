using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsMultiSelectItem : BaseComponent
{
    /// <summary>
    /// The property to hide when item is filtered from input
    /// </summary>
    [Parameter]
    public string? Filtered { get; set; }

    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// `true` if this dropdown item should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Dropdown size.
    /// </summary>
    [Parameter]
    public DROPDOWN_SIZE Size { get; set; } = DROPDOWN_SIZE.MD;

    /// <summary>
    /// The `value` attribute that is set to the parent `&lt;cds-dropdown&gt;` when this dropdown item is selected.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-multi-select-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "filtered", Filtered)
            .SetAttribute(6, "selection-name", SelectionName)
            .SetAttribute(7, "disabled", Disabled)
            .SetAttribute(8, "size", Size)
            .SetAttribute(9, "value", Value)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

