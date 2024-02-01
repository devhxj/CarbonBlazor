using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSkipToContent : BaseComponent
{
    /// <summary>
    /// The assistive text for the link,
    /// </summary>
    [Parameter]
    public string LinkAssisstiveText { get; set; } = "Skip to main content";

    /// <summary>
    /// The skip link href.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-skip-to-content")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "link-assistive-text", LinkAssisstiveText)
            .SetAttributeNotNull(6, "href", Href)
            .SetAttributeNotNull(7, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

