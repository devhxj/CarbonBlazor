using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTable : BaseComponent
{
    /// <summary>
    /// `true` if this table should support batch expansion
    /// </summary>
    [Parameter]
    public bool BatchExpansion { get; set; }

    /// <summary>
    /// The g11n collator to use.
    /// </summary>
    [Parameter]
    public string? Collator { get; set; }

    /// <summary>
    /// Specify whether the rows should be able to be expandable
    /// </summary>
    [Parameter]
    public bool Expandable { get; set; }

    /// <summary>
    /// The method used when filtering the table with the search bar.
    /// Can be replaced with custom method.
    /// <para><b>Type : (rowText: string, searchString: string) => boolean</b></para>
    /// </summary>
    [Parameter]
    public string? FilterRows { get; set; } = "(rowText: string, searchString: string) =>\n    rowText.toLowerCase().indexOf(searchString) < 0";

    /// <summary>
    /// The total headers
    /// </summary>
    [Parameter]
    public int HeaderCount { get; set; } = 0;

    /// <summary>
    /// `true` if this table contains selectable rows
    /// </summary>
    [Parameter]
    public bool IsSelectable { get; set; }

    /// <summary>
    /// `true` if this table should support sorting.
    /// </summary>
    [Parameter]
    public bool IsSortable { get; set; }

    /// <summary>
    /// The table size.
    /// </summary>
    [Parameter]
    public string Locale { get; set; } = "en";

    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// </summary>
    [Parameter]
    public bool OverflowMenuOnHover { get; set; }

    /// <summary>
    /// Specify whether the control should be a radio button or inline checkbox
    /// </summary>
    [Parameter]
    public bool Radio { get; set; }

    /// <summary>
    /// The table size.
    /// </summary>
    [Parameter]
    public TABLE_SIZE Size { get; set; } = TABLE_SIZE.LG;

    /// <summary>
    /// TODO: Uncomment when Carbon fully implements sticky header
    /// Specify whether the header should be sticky.
    /// Still experimental: may not work with every combination of table props
    /// </summary>
    [Parameter]
    public bool UseStaticWidth { get; set; }

    /// <summary>
    /// true to add useZebraStyles striping.
    /// </summary>
    [Parameter]
    public bool UseZebraStyles { get; set; }

    [Parameter]
    public string? WithHeader { get; set; }

    /// <summary>
    /// true if slugs are added in the rows
    /// </summary>
    [Parameter]
    public bool WithRowSlugs { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "batch-expansion", BatchExpansion)
            .SetAttributeNotNull(6, "collator", Collator)
            .SetAttribute(7, "expandable", Expandable)
            .SetAttribute(8, "filterRows", FilterRows)
            .SetAttribute(9, "headerCount", HeaderCount)
            .SetAttribute(10, "is-selectable", IsSelectable)
            .SetAttribute(11, "is-sortable", IsSortable)
            .SetAttribute(12, "locale", Locale)
            .SetAttribute(13, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttribute(14, "radio", Radio)
            .SetAttribute(15, "size", Size)
            .SetAttribute(16, "use-static-width", UseStaticWidth)
            .SetAttribute(17, "use-zebra-styles", UseZebraStyles)
            .SetAttributeNotNull(18, "with-header", WithHeader)
            .SetAttribute(19, "with-row-slugs", WithRowSlugs)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetAttributes(21, AdditionalAttributes)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

