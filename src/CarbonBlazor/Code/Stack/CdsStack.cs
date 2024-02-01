using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStack : BaseComponent
{
    /// <summary>
    /// Specify the orientation of them items in the Stack
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
    /// </summary>
    [Parameter]
    public bool UseCustomGapValue { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-stack")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "orientation", Orientation)
            .SetAttributeNotNull(6, "gap", Gap)
            .SetAttribute(7, "use-custom-gap-value", UseCustomGapValue)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

