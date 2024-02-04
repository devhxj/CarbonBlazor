using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderGlobalAction : CdsComponentBase
{
    /// <summary>
    /// Specify whether the action is currently active
    /// </summary>
    [Parameter]
    public string? Active { get; set; }

    /// <summary>
    /// Specify which header panel the button is associated with.
    /// </summary>
    [Parameter]
    public string? PanelId { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the button in its active state.
    /// </summary>
    [Parameter]
    public string? ButtonLabelActive { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the button in its inactive state.
    /// </summary>
    [Parameter]
    public string? ButtonLabelInactive { get; set; }

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
            .OpenElementAnd(0, "cds-header-global-action")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "active", Active)
            .SetAttributeNotNull(8, "panel-id", PanelId)
            .SetAttributeNotNull(9, "button-label-active", ButtonLabelActive)
            .SetAttributeNotNull(10, "button-label-inactive", ButtonLabelInactive)
            .SetAttributeNotNull(11, "autofocus", Autofocus)
            .SetAttributeNotNull(12, "batch-action", BatchAction)
            .SetAttributeNotNull(13, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(14, "danger-descriptor", DangerDescriptor)
            .SetAttributeNotNull(15, "disabled", Disabled)
            .SetAttributeNotNull(16, "download", Download)
            .SetAttributeNotNull(17, "has-main-content", HasMainContent)
            .SetAttributeNotNull(18, "href", Href)
            .SetAttributeNotNull(19, "hreflang", Hreflang)
            .SetAttributeNotNull(20, "isExpressive", IsExpressive)
            .SetAttributeNotNull(21, "isSelected", IsSelected)
            .SetAttribute(22, "kind", Kind)
            .SetAttributeNotNull(23, "link-role", LinkRole)
            .SetAttributeNotNull(24, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(25, "ping", Ping)
            .SetAttributeNotNull(26, "rel", Rel)
            .SetAttributeNotNull(27, "size", Size)
            .SetAttributeNotNull(28, "target", Target)
            .SetAttributeNotNull(29, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(30, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(31, "tooltip-text", TooltipText)
            .SetAttribute(32, "type", Type)
            .SetAttributeNotNull(33, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(34, "styles", Styles)
            .SetReferenceCapture(35, CaptureReference)
            .SetContent(36, ChildContent)
            .CloseElement();
    }
}

