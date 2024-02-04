using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsPopover : CdsComponentBase
{
    /// <summary>
    /// Specify direction of alignment
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
            .OpenElementAnd(0, "cds-popover")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "align", Align)
            .SetAttributeNotNull(8, "caret", Caret)
            .SetAttributeNotNull(9, "dropShadow", DropShadow)
            .SetAttributeNotNull(10, "highContrast", HighContrast)
            .SetAttributeNotNull(11, "open", Open)
            .SetAttributeNotNull(12, "tabTip", TabTip)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

