using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderNavItem : BaseComponent
{
    /// <summary>
    /// Link `href`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The link type.
    /// </summary>
    [Parameter]
    public string? Rel { get; set; }

    /// <summary>
    /// The link target.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// Applies selected styles to the item if a user sets this to true and `aria-current !== 'page'`.
    /// </summary>
    [Parameter]
    public bool IsActive { get; set; }

    /// <summary>
    /// indicates that this element represents the current item
    /// </summary>
    [Parameter]
    public string? AriaCurrent { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-nav-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "href", Href)
            .SetAttributeNotNull(6, "rel", Rel)
            .SetAttributeNotNull(7, "target", Target)
            .SetAttribute(8, "is-active", IsActive)
            .SetAttributeNotNull(9, "aria-current", AriaCurrent)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

