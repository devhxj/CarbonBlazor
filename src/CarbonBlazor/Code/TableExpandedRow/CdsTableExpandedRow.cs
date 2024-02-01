using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableExpandedRow : BaseComponent
{
    /// <summary>
    /// The colspan.
    /// </summary>
    [Parameter]
    public int ColSpan { get; set; } = 1;

    /// <summary>
    /// `true` if the table row should be expanded.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    /// <summary>
    /// `true` if the table row should be filtered.
    /// </summary>
    [Parameter]
    public bool Filtered { get; set; }

    /// <summary>
    /// `true` if the table row should be highlighted.
    /// </summary>
    [Parameter]
    public bool Highlighted { get; set; }

    /// <summary>
    /// `true` if the previous table row has been selected
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-expanded-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "colspan", ColSpan)
            .SetAttribute(6, "expanded", Expanded)
            .SetAttribute(7, "filtered", Filtered)
            .SetAttribute(8, "highlighted", Highlighted)
            .SetAttribute(9, "selected", Selected)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

