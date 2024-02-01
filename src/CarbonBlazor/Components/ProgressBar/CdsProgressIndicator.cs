using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressIndicator : BaseComponent
{
    /// <summary>
    /// Determines whether or not the progress indicator should be rendered
    /// vertically.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Vertical { get; set; }

    /// <summary>
    /// Specify whether the progress steps should be split equally in size in the
    /// div
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? SpaceEqually { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-progress-indicator")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "vertical", Vertical)
            .SetAttributeNotNull(7, "space-equally", SpaceEqually)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

