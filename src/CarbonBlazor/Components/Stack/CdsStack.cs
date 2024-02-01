using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStack : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttribute(6, "orientation", Orientation)
            .SetAttributeNotNull(7, "gap", Gap)
            .SetAttributeNotNull(8, "use-custom-gap-value", UseCustomGapValue)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

