using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableSkeleton : BaseComponent
{
    /// <summary>
    /// Optionally specify whether you want the Skeleton to be rendered as a compact DataTable
    /// </summary>
    [Parameter]
    public bool Compact { get; set; }

    /// <summary>
    /// Specify the number of columns that you want to render in the skeleton state
    /// </summary>
    [Parameter]
    public int ColumnCount { get; set; } = 5;

    /// <summary>
    /// Specify the number of rows that you want to render in the skeleton state
    /// </summary>
    [Parameter]
    public int RowCount { get; set; } = 5;

    /// <summary>
    /// Specify if the table header should be rendered as part of the skeleton.
    /// </summary>
    [Parameter]
    public bool ShowHeader { get; set; } = true;

    /// <summary>
    /// Specify if the table toolbar should be rendered as part of the skeleton.
    /// </summary>
    [Parameter]
    public bool ShowToolbar { get; set; } = true;

    /// <summary>
    /// true to add useZebraStyles striping.
    /// </summary>
    [Parameter]
    public bool Zebra { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-skeleton")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "compact", Compact)
            .SetAttribute(6, "column-count", ColumnCount)
            .SetAttribute(7, "row-count", RowCount)
            .SetAttribute(8, "show-header", ShowHeader)
            .SetAttribute(9, "show-toolbar", ShowToolbar)
            .SetAttribute(10, "zebra", Zebra)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

