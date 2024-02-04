using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableBatchActions : CdsComponentBase
{
    /// <summary>
    /// `true` if this batch actions bar should be active.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Active { get; set; }

    /// <summary>
    /// The formatter for selected items. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// <para><b>DefaultValue : "({ count }) =>\n    `${count} item${count <= 1 ? '' : 's'} selected`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatSelectedItemsCount { get; set; }

    /// <summary>
    /// Numeric representation of the total number of items selected in a table.
    /// This number is used to derive the selection message.
    /// <para><b>DefaultValue : 0</b></para>
    /// </summary>
    [Parameter]
    public int? SelectedRowsCount { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-batch-actions")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "active", Active)
            .SetAttributeNotNull(8, "formatselecteditemscount", FormatSelectedItemsCount)
            .SetAttributeNotNull(9, "selected-rows-count", SelectedRowsCount)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetReferenceCapture(11, CaptureReference)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

