using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLoading : BaseComponent
{
    /// <summary>
    /// The assistive text for the spinner icon.
    /// </summary>
    [Parameter]
    public string AssistiveText { get; set; } = "Loading";

    /// <summary>
    /// Spinner type.
    /// </summary>
    [Parameter]
    public LOADING_TYPE Type { get; set; } = LOADING_TYPE.REGULAR;

    /// <summary>
    /// `true` if overlay should be applied.
    /// </summary>
    [Parameter]
    public bool Overlay { get; set; }

    /// <summary>
    /// `true` if spinner should stop.
    /// </summary>
    [Parameter]
    public bool Inactive { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-loading")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "assistive-text", AssistiveText)
            .SetAttribute(6, "type", Type)
            .SetAttribute(7, "overlay", Overlay)
            .SetAttribute(8, "inactive", Inactive)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

