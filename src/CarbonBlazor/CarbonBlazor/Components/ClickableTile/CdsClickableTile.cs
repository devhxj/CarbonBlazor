using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsClickableTile : BaseComponent
{
    /// <summary>
    /// The color scheme.
    /// </summary>
    [Parameter]
    public FORM_ELEMENT_COLOR_SCHEME ColorScheme { get; set; }

    /// <summary>
    /// Specify if the `ClickableTile` component should be rendered with rounded corners.
    /// Only valid when `slug` prop is present
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasRoundedCorners { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Slug { get; set; }

    /// <summary>
    /// `true` if the link should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The default file name.
    /// </summary>
    [Parameter]
    public string? Download { get; set; }

    /// <summary>
    /// Link `href`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The language of what `href` points to.
    /// </summary>
    [Parameter]
    public string? Hreflang { get; set; }

    /// <summary>
    /// `true` if the link should be inline.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inline { get; set; }

    /// <summary>
    /// The a11y role for `&lt;a&gt;`.
    /// <para><b>DefaultValue : "button"</b></para>
    /// </summary>
    [Parameter]
    public string? LinkRole { get; set; }

    /// <summary>
    /// URLs to ping.
    /// </summary>
    [Parameter]
    public string? Ping { get; set; }

    /// <summary>
    /// The link type.
    /// </summary>
    [Parameter]
    public string? Rel { get; set; }

    /// <summary>
    /// Link size.
    /// <para><b>DefaultValue : "REGULAR"</b></para>
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    /// <summary>
    /// The link target.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// MIME type of the `target`.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// `true` if the link has been visited.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Visited { get; set; }

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
            .OpenElementAnd(0, "cds-clickable-tile")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "color-scheme", ColorScheme)
            .SetAttributeNotNull(7, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(8, "slug", Slug)
            .SetAttributeNotNull(9, "disabled", Disabled)
            .SetAttributeNotNull(10, "download", Download)
            .SetAttributeNotNull(11, "href", Href)
            .SetAttributeNotNull(12, "hreflang", Hreflang)
            .SetAttributeNotNull(13, "inline", Inline)
            .SetAttributeNotNull(14, "link-role", LinkRole)
            .SetAttributeNotNull(15, "ping", Ping)
            .SetAttributeNotNull(16, "rel", Rel)
            .SetAttributeNotNull(17, "size", Size)
            .SetAttributeNotNull(18, "target", Target)
            .SetAttributeNotNull(19, "type", Type)
            .SetAttributeNotNull(20, "visited", Visited)
            .SetAttributeNotNull(21, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(22, "styles", Styles)
            .SetAttributes(23, AdditionalAttributes)
            .SetContent(24, ChildContent)
            .CloseElement();
    }
}

