using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTooltip : BaseComponent
{
    /// <summary>
    /// `true` if this tooltip is in a data table row
    /// </summary>
    [Parameter]
    public bool DataTable { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be closed when clicked
    /// </summary>
    [Parameter]
    public bool CloseOnActivation { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// </summary>
    [Parameter]
    public bool DefaultOpen { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the tooltip
    /// </summary>
    [Parameter]
    public int EnterDelayMs { get; set; } = 100;

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// </summary>
    [Parameter]
    public int LeaveDelayMs { get; set; } = 300;

    /// <summary>
    /// Specify the size of the tooltip
    /// </summary>
    [Parameter]
    public bool Size { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// </summary>
    [Parameter]
    public bool ToolbarAction { get; set; }

    /// <summary>
    /// Specify how the trigger should align with the tooltip
    /// </summary>
    [Parameter]
    public string Align { get; set; } = "top";

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
            .OpenElementAnd(0, "cds-tooltip")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "data-table", DataTable)
            .SetAttribute(6, "closeOnActivation", CloseOnActivation)
            .SetAttribute(7, "defaultOpen", DefaultOpen)
            .SetAttribute(8, "enter-delay-ms", EnterDelayMs)
            .SetAttribute(9, "leave-delay-ms", LeaveDelayMs)
            .SetAttribute(10, "size", Size)
            .SetAttribute(11, "toolbar-action", ToolbarAction)
            .SetAttribute(12, "align", Align)
            .SetAttribute(13, "caret", Caret)
            .SetAttribute(14, "dropShadow", DropShadow)
            .SetAttribute(15, "highContrast", HighContrast)
            .SetAttribute(16, "open", Open)
            .SetAttribute(17, "tabTip", TabTip)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

