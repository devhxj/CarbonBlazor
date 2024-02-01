using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsComboBoxItem : BaseComponent
{
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
            .OpenElementAnd(0, "cds-combo-box-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttribute(6, "size", Size)
            .SetAttribute(7, "value", Value)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

