using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsInlineLoading : BaseComponent
{
    /// <summary>
    /// The assistive text for the spinner icon.
    /// </summary>
    [Parameter]
    public string AssistiveText { get; set; } = "Loading";

    /// <summary>
    /// The loading status.
    /// </summary>
    [Parameter]
    public INLINE_LOADING_STATE Status { get; set; } = INLINE_LOADING_STATE.ACTIVE;

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-inline-loading")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "assistive-text", AssistiveText)
            .SetAttribute(6, "status", Status)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

