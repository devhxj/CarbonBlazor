using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsInlineLoading : BaseComponent
{
    /// <summary>
    /// The assistive text for the spinner icon.
    /// <para><b>DefaultValue : "Loading"</b></para>
    /// </summary>
    [Parameter]
    public string? AssistiveText { get; set; }

    /// <summary>
    /// The loading status.
    /// <para><b>DefaultValue : "active"</b></para>
    /// </summary>
    [Parameter]
    public INLINE_LOADING_STATE Status { get; set; } = INLINE_LOADING_STATE.ACTIVE;

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-inline-loading")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "assistive-text", AssistiveText)
            .SetAttribute(7, "status", Status)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

