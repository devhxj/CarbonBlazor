using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderMenuItem : BaseComponent
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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsActive { get; set; }

    /// <summary>
    /// indicates that this element represents the current item
    /// </summary>
    [Parameter]
    public string? AriaCurrent { get; set; }

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
            .OpenElementAnd(0, "cds-header-menu-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "href", Href)
            .SetAttributeNotNull(7, "rel", Rel)
            .SetAttributeNotNull(8, "target", Target)
            .SetAttributeNotNull(9, "is-active", IsActive)
            .SetAttributeNotNull(10, "aria-current", AriaCurrent)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

