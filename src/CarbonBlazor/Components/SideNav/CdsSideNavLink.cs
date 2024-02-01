using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class SideNavLinkContext
{
    /// <summary>
    /// The link.
    /// </summary>
    public string LinkSlot = "link";

    /// <summary>
    /// The title.
    /// </summary>
    public string TitleSlot = "title";

    /// <summary>
    /// The title icon container.
    /// </summary>
    public string TitleIconSlot = "title-icon";
}

public class CdsSideNavLink : BaseComponent<SideNavLinkContext>
{
    /// <summary>
    /// `true` if the menu item should be active.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Active { get; set; }

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
    /// Specify if this is a large variation of the side nav link
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Large { get; set; }

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
            .OpenElementAnd(0, "cds-side-nav-link")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "active", Active)
            .SetAttributeNotNull(7, "href", Href)
            .SetAttributeNotNull(8, "rel", Rel)
            .SetAttributeNotNull(9, "target", Target)
            .SetAttributeNotNull(10, "large", Large)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent, new())
            .CloseElement();
    }
}

