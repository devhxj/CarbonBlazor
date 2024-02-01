using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableHeaderRow : BaseComponent
{
    /// <summary>
    /// `true` if this table should support batch expansion
    /// </summary>
    [Parameter]
    public bool BatchExpansion { get; set; }

    /// <summary>
    /// `true` if this table row should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if this table row should be filtered out.
    /// </summary>
    [Parameter]
    public bool Filtered { get; set; }

    /// <summary>
    /// Specify whether the checkbox should be present in the DOM,
    /// but invisible and uninteractable.
    /// </summary>
    [Parameter]
    public bool HideCheckbox { get; set; }

    /// <summary>
    /// `true` if the table row should be highlighted.
    /// </summary>
    [Parameter]
    public bool Highlighted { get; set; }

    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// </summary>
    [Parameter]
    public bool OverflowMenuOnHover { get; set; }

    /// <summary>
    /// `true` if this table row should be selected.
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the `&lt;label&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? SelectionLabel { get; set; }

    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// If present, this table row will be a selectable one.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? SelectionValue { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-header-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "batch-expansion", BatchExpansion)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "filtered", Filtered)
            .SetAttribute(8, "hide-checkbox", HideCheckbox)
            .SetAttribute(9, "highlighted", Highlighted)
            .SetAttribute(10, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttribute(11, "selected", Selected)
            .SetAttribute(12, "selection-label", SelectionLabel)
            .SetAttribute(13, "selection-name", SelectionName)
            .SetAttribute(14, "selection-value", SelectionValue)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetAttributes(16, AdditionalAttributes)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

