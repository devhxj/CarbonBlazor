using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableCell : CdsComponentBase
{
    /// <summary>
    /// Specify whether the overflow menu (if it exists) should be shown always, or only on hover
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? OverflowMenuOnHover { get; set; }

    /// <summary>
    /// The table size.
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-cell")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "overflow-menu-on-hover", OverflowMenuOnHover)
            .SetAttributeNotNull(8, "size", Size)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

