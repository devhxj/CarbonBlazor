using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLoading : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "assistive-text", AssistiveText)
            .SetAttribute(7, "type", Type)
            .SetAttributeNotNull(8, "overlay", Overlay)
            .SetAttributeNotNull(9, "inactive", Inactive)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

