using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsPopover : BaseComponent
{
    /// <summary>
    /// Specify direction of alignment
    /// </summary>
    [Parameter]
    public string? Align { get; set; }

    /// <summary>
    /// Specify whether a caret should be rendered
    /// </summary>
    [Parameter]
    public bool Caret { get; set; } = true;

    /// <summary>
    /// Specify whether a dropShadow should be rendered
    /// </summary>
    [Parameter]
    public bool DropShadow { get; set; } = true;

    /// <summary>
    /// Render the component using the high-contrast variant
    /// </summary>
    [Parameter]
    public bool HighContrast { get; set; }

    /// <summary>
    /// Specify whether the component is currently open or closed
    /// </summary>
    [Parameter]
    public bool Open { get; set; }

    /// <summary>
    /// Render the component using the tab tip variant
    /// </summary>
    [Parameter]
    public bool TabTip { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-popover")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "align", Align)
            .SetAttribute(6, "caret", Caret)
            .SetAttribute(7, "dropShadow", DropShadow)
            .SetAttribute(8, "highContrast", HighContrast)
            .SetAttribute(9, "open", Open)
            .SetAttribute(10, "tabTip", TabTip)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

