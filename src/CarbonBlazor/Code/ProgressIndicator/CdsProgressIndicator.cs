using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressIndicator : BaseComponent
{
    /// <summary>
    /// Determines whether or not the progress indicator should be rendered
    /// vertically.
    /// </summary>
    [Parameter]
    public bool Vertical { get; set; }

    /// <summary>
    /// Specify whether the progress steps should be split equally in size in the
    /// div
    /// </summary>
    [Parameter]
    public bool SpaceEqually { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-progress-indicator")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "vertical", Vertical)
            .SetAttribute(6, "space-equally", SpaceEqually)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

