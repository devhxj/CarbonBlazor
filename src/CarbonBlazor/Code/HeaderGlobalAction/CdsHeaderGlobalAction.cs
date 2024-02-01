using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderGlobalAction : BaseComponent
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
    /// </summary>
    [Parameter]
    public bool Autofocus { get; set; }

    /// <summary>
    /// `true` if the button is being used within a data table batch action toolbar
    /// </summary>
    [Parameter]
    public bool BatchAction { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The default file name, used if this button is rendered as `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? Download { get; set; }

    /// <summary>
    /// `true` if there is a non-icon content.
    /// </summary>
    [Parameter]
    public bool HasMainContent { get; set; }

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
    /// </summary>
    [Parameter]
    public bool IsExpressive { get; set; }

    /// <summary>
    /// Specify whether the Button is currently selected.
    /// Only applies to the Ghost variant.
    /// </summary>
    [Parameter]
    public bool IsSelected { get; set; }

    /// <summary>
    /// Button kind.
    /// </summary>
    [Parameter]
    public BUTTON_KIND Kind { get; set; } = BUTTON_KIND.PRIMARY;

    /// <summary>
    /// The a11y role for `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string LinkRole { get; set; } = "button";

    /// <summary>
    /// Boolean to determine if tooltip is open.
    /// </summary>
    [Parameter]
    public bool OpenTooltip { get; set; }

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
    /// </summary>
    [Parameter]
    public string Size { get; set; } = "lg";

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
    public BUTTON_TOOLTIP_ALIGNMENT? TooltipAlignment { get; set; }

    /// <summary>
    /// Specify the direction of the tooltip for icon-only buttons.
    /// Can be either top, right, bottom, or left.
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
    /// </summary>
    [Parameter]
    public BUTTON_TYPE Type { get; set; } = BUTTON_TYPE.BUTTON;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-global-action")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "active", Active)
            .SetAttributeNotNull(6, "panel-id", PanelId)
            .SetAttributeNotNull(7, "button-label-active", ButtonLabelActive)
            .SetAttributeNotNull(8, "button-label-inactive", ButtonLabelInactive)
            .SetAttribute(9, "autofocus", Autofocus)
            .SetAttribute(10, "batch-action", BatchAction)
            .SetAttributeNotNull(11, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(12, "danger-descriptor", DangerDescriptor)
            .SetAttribute(13, "disabled", Disabled)
            .SetAttributeNotNull(14, "download", Download)
            .SetAttribute(15, "has-main-content", HasMainContent)
            .SetAttributeNotNull(16, "href", Href)
            .SetAttributeNotNull(17, "hreflang", Hreflang)
            .SetAttribute(18, "isExpressive", IsExpressive)
            .SetAttribute(19, "isSelected", IsSelected)
            .SetAttribute(20, "kind", Kind)
            .SetAttribute(21, "link-role", LinkRole)
            .SetAttribute(22, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(23, "ping", Ping)
            .SetAttributeNotNull(24, "rel", Rel)
            .SetAttribute(25, "size", Size)
            .SetAttributeNotNull(26, "target", Target)
            .SetAttribute(27, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(28, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(29, "tooltip-text", TooltipText)
            .SetAttribute(30, "type", Type)
            .SetAttributeNotNull(31, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(32, "styles", Styles)
            .SetAttributes(33, AdditionalAttributes)
            .SetContent(34, ChildContent)
            .CloseElement();
    }
}

