using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableSkeleton : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "compact", Compact)
            .SetAttributeNotNull(8, "column-count", ColumnCount)
            .SetAttributeNotNull(9, "row-count", RowCount)
            .SetAttributeNotNull(10, "show-header", ShowHeader)
            .SetAttributeNotNull(11, "show-toolbar", ShowToolbar)
            .SetAttributeNotNull(12, "zebra", Zebra)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

