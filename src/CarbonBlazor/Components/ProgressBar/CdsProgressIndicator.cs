using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressIndicator : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "vertical", Vertical)
            .SetAttributeNotNull(8, "space-equally", SpaceEqually)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

