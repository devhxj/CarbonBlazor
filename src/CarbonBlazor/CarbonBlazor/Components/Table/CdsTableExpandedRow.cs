using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableExpandedRow : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "colspan", ColSpan)
            .SetAttributeNotNull(7, "expanded", Expanded)
            .SetAttributeNotNull(8, "filtered", Filtered)
            .SetAttributeNotNull(9, "highlighted", Highlighted)
            .SetAttributeNotNull(10, "selected", Selected)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

