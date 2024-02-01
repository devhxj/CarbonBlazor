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

public class CdsLayer : BaseComponent<LayerContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "level", Level)
            .SetAttributeNotNull(7, "layers", Layers)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent, new())
            .CloseElement();
    }
}

