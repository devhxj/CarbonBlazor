using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableCell : BaseComponent
{
    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// </summary>
    [Parameter]
    public bool OverflowMenuOnHover { get; set; }

    /// <summary>
    /// The table size.
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-cell")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttributeNotNull(6, "size", Size)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

