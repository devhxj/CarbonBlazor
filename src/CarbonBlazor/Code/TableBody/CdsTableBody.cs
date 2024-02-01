using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableBody : BaseComponent
{
    /// <summary>
    /// TODO: Uncomment when Carbon fully implements sticky header
    /// Specify whether the header should be sticky.
    /// Still experimental: may not work with every combination of table props
    /// </summary>
    [Parameter]
    public bool UseZebraStyles { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-body")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "use-zebra-styles", UseZebraStyles)
            .SetAttributeNotNull(6, "styles", Styles)
            .SetAttributes(7, AdditionalAttributes)
            .SetContent(8, ChildContent)
            .CloseElement();
    }
}

