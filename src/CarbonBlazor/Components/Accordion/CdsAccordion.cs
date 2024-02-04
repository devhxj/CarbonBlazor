using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsAccordion : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "size", Size)
            .SetAttribute(8, "alignment", Alignment)
            .SetAttributeNotNull(9, "isFlush", IsFlush)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetReferenceCapture(11, CaptureReference)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

