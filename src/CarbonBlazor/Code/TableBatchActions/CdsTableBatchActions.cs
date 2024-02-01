using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableBatchActions : BaseComponent
{
    /// <summary>
    /// `true` if this batch actions bar should be active.
    /// </summary>
    [Parameter]
    public bool Active { get; set; }

    /// <summary>
    /// The formatter for selected items. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatSelectedItemsCount { get; set; } = "({ count }) =>\n    `${count} item${count <= 1 ? '' : 's'} selected`";

    /// <summary>
    /// Numeric representation of the total number of items selected in a table.
    /// This number is used to derive the selection message.
    /// </summary>
    [Parameter]
    public int SelectedRowsCount { get; set; } = 0;

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-batch-actions")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "active", Active)
            .SetAttribute(6, "", FormatSelectedItemsCount)
            .SetAttribute(7, "selected-rows-count", SelectedRowsCount)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

