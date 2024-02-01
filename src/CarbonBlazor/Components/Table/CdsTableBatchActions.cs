using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableBatchActions : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "active", Active)
            .SetAttributeNotNull(7, "formatselecteditemscount", FormatSelectedItemsCount)
            .SetAttributeNotNull(8, "selected-rows-count", SelectedRowsCount)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

