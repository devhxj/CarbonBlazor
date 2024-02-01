using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableSkeleton : BaseComponent
{
    /// <summary>
    /// Optionally specify whether you want the Skeleton to be rendered as a compact DataTable
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Compact { get; set; }

    /// <summary>
    /// Specify the number of columns that you want to render in the skeleton state
    /// <para><b>DefaultValue : 5</b></para>
    /// </summary>
    [Parameter]
    public int? ColumnCount { get; set; }

    /// <summary>
    /// Specify the number of rows that you want to render in the skeleton state
    /// <para><b>DefaultValue : 5</b></para>
    /// </summary>
    [Parameter]
    public int? RowCount { get; set; }

    /// <summary>
    /// Specify if the table header should be rendered as part of the skeleton.
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? ShowHeader { get; set; }

    /// <summary>
    /// Specify if the table toolbar should be rendered as part of the skeleton.
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? ShowToolbar { get; set; }

    /// <summary>
    /// true to add useZebraStyles striping.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Zebra { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-skeleton")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "compact", Compact)
            .SetAttributeNotNull(7, "column-count", ColumnCount)
            .SetAttributeNotNull(8, "row-count", RowCount)
            .SetAttributeNotNull(9, "show-header", ShowHeader)
            .SetAttributeNotNull(10, "show-toolbar", ShowToolbar)
            .SetAttributeNotNull(11, "zebra", Zebra)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

