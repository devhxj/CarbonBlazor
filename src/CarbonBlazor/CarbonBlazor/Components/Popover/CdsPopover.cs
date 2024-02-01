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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "align", Align)
            .SetAttributeNotNull(7, "caret", Caret)
            .SetAttributeNotNull(8, "dropShadow", DropShadow)
            .SetAttributeNotNull(9, "highContrast", HighContrast)
            .SetAttributeNotNull(10, "open", Open)
            .SetAttributeNotNull(11, "tabTip", TabTip)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

