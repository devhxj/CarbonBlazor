using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderPanel : CdsComponentBase
{
    /// <summary>
    /// Specify whether the panel is expanded
    /// </summary>
    [Parameter]
    public string? Expanded { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-panel")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "expanded", Expanded)
            .SetAttributeNotNull(8, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

