using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsClickableTile : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "color-scheme", ColorScheme)
            .SetAttributeNotNull(8, "has-rounded-corners", HasRoundedCorners)
            .SetAttributeNotNull(9, "slug", Slug)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "download", Download)
            .SetAttributeNotNull(12, "href", Href)
            .SetAttributeNotNull(13, "hreflang", Hreflang)
            .SetAttributeNotNull(14, "inline", Inline)
            .SetAttributeNotNull(15, "link-role", LinkRole)
            .SetAttributeNotNull(16, "ping", Ping)
            .SetAttributeNotNull(17, "rel", Rel)
            .SetAttributeNotNull(18, "size", Size)
            .SetAttributeNotNull(19, "target", Target)
            .SetAttributeNotNull(20, "type", Type)
            .SetAttributeNotNull(21, "visited", Visited)
            .SetAttributeNotNull(22, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(23, "styles", Styles)
            .SetReferenceCapture(24, CaptureReference)
            .SetContent(25, ChildContent)
            .CloseElement();
    }
}

