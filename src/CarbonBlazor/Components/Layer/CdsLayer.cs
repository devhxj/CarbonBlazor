using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class LayerContext
{
    /// <summary>
    /// The elements contained within the component.
    /// </summary>
    public string ChildrenSlot = "children";
}

public class CdsLayer : CdsComponentBase<LayerContext>
{
    /// <summary>
    /// Specify the layer level and override any existing levels based on hierarchy
    /// <para><b>DefaultValue : 0</b></para>
    /// </summary>
    [Parameter]
    public int? Level { get; set; }

    [Parameter]
    public string? Layers { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-layer")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "level", Level)
            .SetAttributeNotNull(8, "layers", Layers)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent, new())
            .CloseElement();
    }
}

