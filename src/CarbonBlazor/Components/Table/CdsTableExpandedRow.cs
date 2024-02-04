using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableExpandedRow : CdsComponentBase
{
    /// <summary>
    /// The colspan.
    /// <para><b>DefaultValue : 1</b></para>
    /// </summary>
    [Parameter]
    public int? ColSpan { get; set; }

    /// <summary>
    /// `true` if the table row should be expanded.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// `true` if the table row should be filtered.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Filtered { get; set; }

    /// <summary>
    /// `true` if the table row should be highlighted.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Highlighted { get; set; }

    /// <summary>
    /// `true` if the previous table row has been selected
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Selected { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-expanded-row")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "colspan", ColSpan)
            .SetAttributeNotNull(8, "expanded", Expanded)
            .SetAttributeNotNull(9, "filtered", Filtered)
            .SetAttributeNotNull(10, "highlighted", Highlighted)
            .SetAttributeNotNull(11, "selected", Selected)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetReferenceCapture(13, CaptureReference)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

