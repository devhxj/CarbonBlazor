using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTooltip : BaseComponent
{
    /// <summary>
    /// `true` if this tooltip is in a data table row
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DataTable { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be closed when clicked
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? CloseOnActivation { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DefaultOpen { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the tooltip
    /// <para><b>DefaultValue : 100</b></para>
    /// </summary>
    [Parameter]
    public int? EnterDelayMs { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// <para><b>DefaultValue : 300</b></para>
    /// </summary>
    [Parameter]
    public int? LeaveDelayMs { get; set; }

    /// <summary>
    /// Specify the size of the tooltip
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Size { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ToolbarAction { get; set; }

    /// <summary>
    /// Specify how the trigger should align with the tooltip
    /// <para><b>DefaultValue : "top"</b></para>
    /// </summary>
    [Parameter]
    public string? Align { get; set; }

    /// <summary>
    /// Specify whether a caret should be rendered
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? Caret { get; set; }

    /// <summary>
    /// Specify whether a dropShadow should be rendered
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? DropShadow { get; set; }

    /// <summary>
    /// Render the component using the high-contrast variant
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HighContrast { get; set; }

    /// <summary>
    /// Specify whether the component is currently open or closed
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

    /// <summary>
    /// Render the component using the tab tip variant
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? TabTip { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tooltip")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "data-table", DataTable)
            .SetAttributeNotNull(7, "closeOnActivation", CloseOnActivation)
            .SetAttributeNotNull(8, "defaultOpen", DefaultOpen)
            .SetAttributeNotNull(9, "enter-delay-ms", EnterDelayMs)
            .SetAttributeNotNull(10, "leave-delay-ms", LeaveDelayMs)
            .SetAttributeNotNull(11, "size", Size)
            .SetAttributeNotNull(12, "toolbar-action", ToolbarAction)
            .SetAttributeNotNull(13, "align", Align)
            .SetAttributeNotNull(14, "caret", Caret)
            .SetAttributeNotNull(15, "dropShadow", DropShadow)
            .SetAttributeNotNull(16, "highContrast", HighContrast)
            .SetAttributeNotNull(17, "open", Open)
            .SetAttributeNotNull(18, "tabTip", TabTip)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

