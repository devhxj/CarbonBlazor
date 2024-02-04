using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStack : CdsComponentBase
{
    /// <summary>
    /// Specify the orientation of them items in the Stack
    /// <para><b>DefaultValue : "vertical"</b></para>
    /// </summary>
    [Parameter]
    public STACK_ORIENTATION Orientation { get; set; } = STACK_ORIENTATION.VERTICAL;

    /// <summary>
    /// Provide either a custom value or a step from the spacing scale to be used
    /// as the gap in the layout
    /// </summary>
    [Parameter]
    public string? Gap { get; set; }

    /// <summary>
    /// Turn on when passing in custom value to 'gap' attribute (ie. gap="2rem")
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? UseCustomGapValue { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-stack")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "orientation", Orientation)
            .SetAttributeNotNull(8, "gap", Gap)
            .SetAttributeNotNull(9, "use-custom-gap-value", UseCustomGapValue)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetReferenceCapture(11, CaptureReference)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

