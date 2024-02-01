using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSkipToContent : BaseComponent
{
    /// <summary>
    /// The assistive text for the link,
    /// <para><b>DefaultValue : "Skip to main content"</b></para>
    /// </summary>
    [Parameter]
    public string? LinkAssisstiveText { get; set; }

    /// <summary>
    /// The skip link href.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-skip-to-content")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "link-assistive-text", LinkAssisstiveText)
            .SetAttributeNotNull(7, "href", Href)
            .SetAttributeNotNull(8, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

