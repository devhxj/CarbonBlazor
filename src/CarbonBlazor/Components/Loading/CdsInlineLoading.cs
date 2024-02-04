using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsInlineLoading : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "assistive-text", AssistiveText)
            .SetAttribute(8, "status", Status)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetReferenceCapture(10, CaptureReference)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

