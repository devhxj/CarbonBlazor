using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSlugActionButton : BaseComponent
{
    /// <summary>
    /// The shadow slot this slug-action should be in.
    /// <para><b>DefaultValue : "actions"</b></para>
    /// </summary>
    [Parameter]
    public string? Slot { get; set; }

    /// <summary>
    /// `true` if the button should have input focus when the page loads.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Autofocus { get; set; }

    /// <summary>
    /// `true` if the button is being used within a data table batch action toolbar
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? BatchAction { get; set; }

    /// <summary>
    /// Specify an optional className to be added to your Button
    /// </summary>
    [Parameter]
    public string? ButtonClassName { get; set; }

    /// <summary>
    /// Specify the message read by screen readers for the danger button variant
    /// </summary>
    [Parameter]
    public string? DangerDescriptor { get; set; }

    /// <summary>
    /// `true` if the button should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The default file name, used if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Download { get; set; }

    /// <summary>
    /// `true` if there is a non-icon content.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasMainContent { get; set; }

    /// <summary>
    /// Link `href`. If present, this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The language of what `href` points to, if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Hreflang { get; set; }

    /// <summary>
    /// `true` if expressive theme enabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsExpressive { get; set; }

    /// <summary>
    /// Specify whether the Button is currently selected.
    /// Only applies to the Ghost variant.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsSelected { get; set; }

    /// <summary>
    /// Button kind.
    /// <para><b>DefaultValue : "primary"</b></para>
    /// </summary>
    [Parameter]
    public BUTTON_KIND Kind { get; set; } = BUTTON_KIND.PRIMARY;

    /// <summary>
    /// The a11y role for `&lt;a&gt;`.
    /// <para><b>DefaultValue : "button"</b></para>
    /// </summary>
    [Parameter]
    public string? LinkRole { get; set; }

    /// <summary>
    /// Boolean to determine if tooltip is open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? OpenTooltip { get; set; }

    /// <summary>
    /// URLs to ping, if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Ping { get; set; }

    /// <summary>
    /// The link type, if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Rel { get; set; }

    /// <summary>
    /// Button size.
    /// <para><b>DefaultValue : "lg"</b></para>
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    /// <summary>
    /// The link target, if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// Specify the alignment of the tooltip to the icon-only button.
    /// Can be one of: start, center, or end.
    /// </summary>
    [Parameter]
    public BUTTON_TOOLTIP_ALIGNMENT TooltipAlignment { get; set; }

    /// <summary>
    /// Specify the direction of the tooltip for icon-only buttons.
    /// Can be either top, right, bottom, or left.
    /// <para><b>DefaultValue : "top"</b></para>
    /// </summary>
    [Parameter]
    public BUTTON_TOOLTIP_POSITION TooltipPosition { get; set; } = BUTTON_TOOLTIP_POSITION.TOP;

    /// <summary>
    /// Specify the direction of the tooltip for icon-only buttons.
    /// Can be either top, right, bottom, or left.
    /// </summary>
    [Parameter]
    public string? TooltipText { get; set; }

    /// <summary>
    /// Button type.
    /// <para><b>DefaultValue : "button"</b></para>
    /// </summary>
    [Parameter]
    public BUTTON_TYPE Type { get; set; } = BUTTON_TYPE.BUTTON;

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
            .OpenElementAnd(0, "cds-slug-action-button")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "slot", Slot)
            .SetAttributeNotNull(7, "autofocus", Autofocus)
            .SetAttributeNotNull(8, "batch-action", BatchAction)
            .SetAttributeNotNull(9, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(10, "danger-descriptor", DangerDescriptor)
            .SetAttributeNotNull(11, "disabled", Disabled)
            .SetAttributeNotNull(12, "download", Download)
            .SetAttributeNotNull(13, "has-main-content", HasMainContent)
            .SetAttributeNotNull(14, "href", Href)
            .SetAttributeNotNull(15, "hreflang", Hreflang)
            .SetAttributeNotNull(16, "isExpressive", IsExpressive)
            .SetAttributeNotNull(17, "isSelected", IsSelected)
            .SetAttribute(18, "kind", Kind)
            .SetAttributeNotNull(19, "link-role", LinkRole)
            .SetAttributeNotNull(20, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(21, "ping", Ping)
            .SetAttributeNotNull(22, "rel", Rel)
            .SetAttributeNotNull(23, "size", Size)
            .SetAttributeNotNull(24, "target", Target)
            .SetAttributeNotNull(25, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(26, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(27, "tooltip-text", TooltipText)
            .SetAttribute(28, "type", Type)
            .SetAttributeNotNull(29, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(30, "styles", Styles)
            .SetAttributes(31, AdditionalAttributes)
            .SetContent(32, ChildContent)
            .CloseElement();
    }
}

