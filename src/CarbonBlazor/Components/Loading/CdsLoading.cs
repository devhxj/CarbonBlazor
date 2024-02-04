using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLoading : CdsComponentBase
{
    /// <summary>
    /// The assistive text for the spinner icon.
    /// <para><b>DefaultValue : "Loading"</b></para>
    /// </summary>
    [Parameter]
    public string? AssistiveText { get; set; }

    /// <summary>
    /// Spinner type.
    /// <para><b>DefaultValue : "regular"</b></para>
    /// </summary>
    [Parameter]
    public LOADING_TYPE Type { get; set; } = LOADING_TYPE.REGULAR;

    /// <summary>
    /// `true` if overlay should be applied.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Overlay { get; set; }

    /// <summary>
    /// `true` if spinner should stop.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inactive { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-loading")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "assistive-text", AssistiveText)
            .SetAttribute(8, "type", Type)
            .SetAttributeNotNull(9, "overlay", Overlay)
            .SetAttributeNotNull(10, "inactive", Inactive)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetReferenceCapture(12, CaptureReference)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

