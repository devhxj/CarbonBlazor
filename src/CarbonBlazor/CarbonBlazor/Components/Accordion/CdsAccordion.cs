using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsAccordion : BaseComponent
{
    /// <summary>
    /// Accordion size should be sm, md, lg.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public ACCORDION_SIZE Size { get; set; } = ACCORDION_SIZE.MD;

    /// <summary>
    /// Specify the alignment of the accordion heading title and chevron
    /// <para><b>DefaultValue : "END"</b></para>
    /// </summary>
    [Parameter]
    public ACCORDION_ALIGNMENT Alignment { get; set; } = ACCORDION_ALIGNMENT.END;

    /// <summary>
    /// Specify whether Accordion text should be flush, default is false, does not work with align="start"
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsFlush { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-accordion")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttribute(6, "size", Size)
            .SetAttribute(7, "alignment", Alignment)
            .SetAttributeNotNull(8, "isFlush", IsFlush)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

