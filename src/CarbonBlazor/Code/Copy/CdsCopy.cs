using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCopy : BaseComponent
{
    /// <summary>
    /// Specify the string that is displayed when the button is clicked and the content is copi
    /// </summary>
    [Parameter]
    public string Feedback { get; set; } = "Copied!";

    /// <summary>
    /// The number in milliseconds to determine how long the tooltip should remain.
    /// </summary>
    [Parameter]
    public int FeedbackTimeout { get; set; } = 2000;

    /// <summary>
    /// Specify how the trigger should align with the tooltip
    /// </summary>
    [Parameter]
    public string Align { get; set; } = "top";

    /// <summary>
    /// Determines whether the tooltip should close when inner content is activated (click, Enter or Space)
    /// </summary>
    [Parameter]
    public bool CloseOnActivation { get; set; } = true;

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// </summary>
    [Parameter]
    public bool DefaultOpen { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the tooltip
    /// </summary>
    [Parameter]
    public int EnterDelayMs { get; set; } = 100;

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// </summary>
    [Parameter]
    public int LeaveDelayMs { get; set; } = 300;

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
    /// Specify the size of the Button. Defaults to `md`.
    /// </summary>
    [Parameter]
    public string Size { get; set; } = "md";

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
            .OpenElementAnd(0, "cds-copy")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "feedback", Feedback)
            .SetAttribute(6, "feedback-timeout", FeedbackTimeout)
            .SetAttribute(7, "align", Align)
            .SetAttribute(8, "close-on-activation", CloseOnActivation)
            .SetAttribute(9, "defaultOpen", DefaultOpen)
            .SetAttribute(10, "enter-delay-ms", EnterDelayMs)
            .SetAttribute(11, "leave-delay-ms", LeaveDelayMs)
            .SetAttribute(12, "autofocus", Autofocus)
            .SetAttribute(13, "batch-action", BatchAction)
            .SetAttributeNotNull(14, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(15, "danger-descriptor", DangerDescriptor)
            .SetAttribute(16, "disabled", Disabled)
            .SetAttributeNotNull(17, "download", Download)
            .SetAttribute(18, "has-main-content", HasMainContent)
            .SetAttributeNotNull(19, "href", Href)
            .SetAttributeNotNull(20, "hreflang", Hreflang)
            .SetAttribute(21, "isExpressive", IsExpressive)
            .SetAttribute(22, "isSelected", IsSelected)
            .SetAttribute(23, "kind", Kind)
            .SetAttribute(24, "link-role", LinkRole)
            .SetAttribute(25, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(26, "ping", Ping)
            .SetAttributeNotNull(27, "rel", Rel)
            .SetAttribute(28, "size", Size)
            .SetAttributeNotNull(29, "target", Target)
            .SetAttribute(30, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(31, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(32, "tooltip-text", TooltipText)
            .SetAttribute(33, "type", Type)
            .SetAttributeNotNull(34, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(35, "styles", Styles)
            .SetAttributes(36, AdditionalAttributes)
            .SetContent(37, ChildContent)
            .CloseElement();
    }
}
