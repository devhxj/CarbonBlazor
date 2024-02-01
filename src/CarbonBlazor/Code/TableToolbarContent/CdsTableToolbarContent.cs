using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableToolbarContent : BaseComponent
{
    /// <summary>
    /// `true` if this batch actions bar is active.
    /// </summary>
    [Parameter]
    public bool HasBatchActions { get; set; }

    /// <summary>
    /// Table toolbar contents size
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-toolbar-content")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "has-batch-actions", HasBatchActions)
            .SetAttributeNotNull(6, "size", Size)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

