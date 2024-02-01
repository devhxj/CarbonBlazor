using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableHeaderRow : BaseComponent
{
    /// <summary>
    /// `true` if this table should support batch expansion
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? BatchExpansion { get; set; }

    /// <summary>
    /// `true` if this table row should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if this table row should be filtered out.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Filtered { get; set; }

    /// <summary>
    /// Specify whether the checkbox should be present in the DOM,
    /// but invisible and uninteractable.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideCheckbox { get; set; }

    /// <summary>
    /// `true` if the table row should be highlighted.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Highlighted { get; set; }

    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? OverflowMenuOnHover { get; set; }

    /// <summary>
    /// `true` if this table row should be selected.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Selected { get; set; }

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

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-header-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "batch-expansion", BatchExpansion)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "filtered", Filtered)
            .SetAttributeNotNull(9, "hide-checkbox", HideCheckbox)
            .SetAttributeNotNull(10, "highlighted", Highlighted)
            .SetAttributeNotNull(11, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttributeNotNull(12, "selected", Selected)
            .SetAttributeNotNull(13, "selection-label", SelectionLabel)
            .SetAttributeNotNull(14, "selection-name", SelectionName)
            .SetAttributeNotNull(15, "selection-value", SelectionValue)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetAttributes(17, AdditionalAttributes)
            .SetContent(18, ChildContent)
            .CloseElement();
    }
}

