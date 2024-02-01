using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTable : BaseComponent
{
    /// <summary>
    /// `true` if this table should support batch expansion
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? BatchExpansion { get; set; }

    /// <summary>
    /// The g11n collator to use.
    /// </summary>
    [Parameter]
    public string? Collator { get; set; }

    /// <summary>
    /// Specify whether the rows should be able to be expandable
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expandable { get; set; }

    /// <summary>
    /// The method used when filtering the table with the search bar.
    /// Can be replaced with custom method.
    /// <para><b>Type : (rowText: string, searchString: string) => boolean</b></para>
    /// <para><b>DefaultValue : "(rowText: string, searchString: string) =>\n    rowText.toLowerCase().indexOf(searchString) < 0"</b></para>
    /// </summary>
    [Parameter]
    public string? FilterRows { get; set; }

    /// <summary>
    /// The total headers
    /// <para><b>DefaultValue : 0</b></para>
    /// </summary>
    [Parameter]
    public int? HeaderCount { get; set; }

    /// <summary>
    /// `true` if this table contains selectable rows
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsSelectable { get; set; }

    /// <summary>
    /// `true` if this table should support sorting.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsSortable { get; set; }

    /// <summary>
    /// The table size.
    /// <para><b>DefaultValue : "en"</b></para>
    /// </summary>
    [Parameter]
    public string? Locale { get; set; }

    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? OverflowMenuOnHover { get; set; }

    /// <summary>
    /// Specify whether the control should be a radio button or inline checkbox
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Radio { get; set; }

    /// <summary>
    /// The table size.
    /// <para><b>DefaultValue : "lg"</b></para>
    /// </summary>
    [Parameter]
    public TABLE_SIZE Size { get; set; } = TABLE_SIZE.LG;

    /// <summary>
    /// TODO: Uncomment when Carbon fully implements sticky header
    /// Specify whether the header should be sticky.
    /// Still experimental: may not work with every combination of table props
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? UseStaticWidth { get; set; }

    /// <summary>
    /// true to add useZebraStyles striping.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? UseZebraStyles { get; set; }

    [Parameter]
    public string? WithHeader { get; set; }

    /// <summary>
    /// true if slugs are added in the rows
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? WithRowSlugs { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "batch-expansion", BatchExpansion)
            .SetAttributeNotNull(7, "collator", Collator)
            .SetAttributeNotNull(8, "expandable", Expandable)
            .SetAttributeNotNull(9, "filterRows", FilterRows)
            .SetAttributeNotNull(10, "headerCount", HeaderCount)
            .SetAttributeNotNull(11, "is-selectable", IsSelectable)
            .SetAttributeNotNull(12, "is-sortable", IsSortable)
            .SetAttributeNotNull(13, "locale", Locale)
            .SetAttributeNotNull(14, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttributeNotNull(15, "radio", Radio)
            .SetAttribute(16, "size", Size)
            .SetAttributeNotNull(17, "use-static-width", UseStaticWidth)
            .SetAttributeNotNull(18, "use-zebra-styles", UseZebraStyles)
            .SetAttributeNotNull(19, "with-header", WithHeader)
            .SetAttributeNotNull(20, "with-row-slugs", WithRowSlugs)
            .SetAttributeNotNull(21, "styles", Styles)
            .SetAttributes(22, AdditionalAttributes)
            .SetContent(23, ChildContent)
            .CloseElement();
    }
}

