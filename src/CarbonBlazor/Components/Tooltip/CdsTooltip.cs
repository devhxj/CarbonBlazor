using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTooltip : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "data-table", DataTable)
            .SetAttributeNotNull(8, "closeOnActivation", CloseOnActivation)
            .SetAttributeNotNull(9, "defaultOpen", DefaultOpen)
            .SetAttributeNotNull(10, "enter-delay-ms", EnterDelayMs)
            .SetAttributeNotNull(11, "leave-delay-ms", LeaveDelayMs)
            .SetAttributeNotNull(12, "size", Size)
            .SetAttributeNotNull(13, "toolbar-action", ToolbarAction)
            .SetAttributeNotNull(14, "align", Align)
            .SetAttributeNotNull(15, "caret", Caret)
            .SetAttributeNotNull(16, "dropShadow", DropShadow)
            .SetAttributeNotNull(17, "highContrast", HighContrast)
            .SetAttributeNotNull(18, "open", Open)
            .SetAttributeNotNull(19, "tabTip", TabTip)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetReferenceCapture(21, CaptureReference)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

