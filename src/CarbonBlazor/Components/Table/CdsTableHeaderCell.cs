using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableHeaderCell : BaseComponent
{
    /// <summary>
    /// `true` if this table has selectable rows
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsSelectable { get; set; }

    /// <summary>
    /// `true` if the table has expandable rows
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsExpandable { get; set; }

    /// <summary>
    /// `true` if this table header column should be sortable
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsSortable { get; set; }

    /// <summary>
    /// `true` if this table header cell is of a primary sorting column.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? SortActive { get; set; }

    /// <summary>
    /// The table sort cycle in use.
    /// </summary>
    [Parameter]
    public TABLE_SORT_CYCLE SortCycle { get; set; }

    /// <summary>
    /// The table sort direction.
    /// If present, this table header cell will have a sorting UI. Choose between `ascending` or `descending`.
    /// </summary>
    [Parameter]
    public TABLE_SORT_DIRECTION SortDirection { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// Mapping of table sort cycles to table sort states.
    /// <para><b>DefaultValue : {"bi-states-from-ascending":["ascending","descending"],"bi-states-from-descending":["descending","ascending"],"tri-states-from-ascending":["none","ascending","descending"],"tri-states-from-descending":["none","descending","ascending"]}</b></para>
    /// </summary>
    [Parameter]
    public TableSortCycles? TABLE_SORT_CYCLES { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-header-cell")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "isselectable", IsSelectable)
            .SetAttributeNotNull(7, "is-sortable", IsExpandable)
            .SetAttributeNotNull(8, "issortable", IsSortable)
            .SetAttributeNotNull(9, "sort-active", SortActive)
            .SetAttributeNotNull(10, "sort-cycle", SortCycle)
            .SetAttributeNotNull(11, "sort-direction", SortDirection)
            .SetAttributeNotNull(12, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributeNotNull(14, "TABLE_SORT_CYCLES", TABLE_SORT_CYCLES)
            .SetAttributes(15, AdditionalAttributes)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

