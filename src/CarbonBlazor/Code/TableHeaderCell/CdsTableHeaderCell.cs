using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableHeaderCell : BaseComponent
{
    /// <summary>
    /// `true` if this table has selectable rows
    /// </summary>
    [Parameter]
    public bool IsSelectable { get; set; }

    /// <summary>
    /// `true` if the table has expandable rows
    /// </summary>
    [Parameter]
    public bool IsExpandable { get; set; }

    /// <summary>
    /// `true` if this table header column should be sortable
    /// </summary>
    [Parameter]
    public bool IsSortable { get; set; }

    /// <summary>
    /// `true` if this table header cell is of a primary sorting column.
    /// </summary>
    [Parameter]
    public bool SortActive { get; set; }

    /// <summary>
    /// The table sort cycle in use.
    /// </summary>
    [Parameter]
    public TABLE_SORT_CYCLE? SortCycle { get; set; }

    /// <summary>
    /// The table sort direction.
    /// If present, this table header cell will have a sorting UI. Choose between `ascending` or `descending`.
    /// </summary>
    [Parameter]
    public TABLE_SORT_DIRECTION? SortDirection { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// Mapping of table sort cycles to table sort states.
    /// </summary>
    [Parameter]
    public { "bi-states-from-ascending": TABLE_SORT_DIRECTION[]; "bi-states-from-descending": TABLE_SORT_DIRECTION[]; "tri-states-from-ascending": TABLE_SORT_DIRECTION[]; "tri-states-from-descending": TABLE_SORT_DIRECTION[]; } TABLE_SORT_CYCLES { get; set; } = {"bi-states-from-ascending":["ascending","descending"],"bi-states-from-descending":["descending","ascending"],"tri-states-from-ascending":["none","ascending","descending"],"tri-states-from-descending":["none","descending","ascending"]};

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-header-cell")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "", IsSelectable)
            .SetAttribute(6, "is-sortable", IsExpandable)
            .SetAttribute(7, "", IsSortable)
            .SetAttribute(8, "sort-active", SortActive)
            .SetAttributeNotNull(9, "sort-cycle", SortCycle)
            .SetAttributeNotNull(10, "sort-direction", SortDirection)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttribute(13, "", TABLE_SORT_CYCLES)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

