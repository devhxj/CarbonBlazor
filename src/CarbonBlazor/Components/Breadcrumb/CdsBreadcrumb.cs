using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsBreadcrumb : CdsComponentBase
{
    /// <summary>
    /// Optional prop to omit the trailing slash for the breadcrumbs
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? NoTrailingSlash { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-breadcrumb")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "no-trailing-slash", NoTrailingSlash)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetReferenceCapture(9, CaptureReference)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

