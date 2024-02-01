using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCopy : BaseComponent
{
    /// <summary>
    /// Specify the string that is displayed when the button is clicked and the content is copi
    /// <para><b>DefaultValue : "Copied!"</b></para>
    /// </summary>
    [Parameter]
    public string? Feedback { get; set; }

    /// <summary>
    /// The number in milliseconds to determine how long the tooltip should remain.
    /// <para><b>DefaultValue : 2000</b></para>
    /// </summary>
    [Parameter]
    public int? FeedbackTimeout { get; set; }

    /// <summary>
    /// Specify how the trigger should align with the tooltip
    /// <para><b>DefaultValue : "top"</b></para>
    /// </summary>
    [Parameter]
    public string? Align { get; set; }

    /// <summary>
    /// Determines whether the tooltip should close when inner content is activated (click, Enter or Space)
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? CloseOnActivation { get; set; }

    /// <summary>
    /// Specify whether the tooltip should be open when it first renders
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DefaultOpen { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the tooltip
    /// <para><b>DefaultValue : 100</b></para>
    /// </summary>
    [Parameter]
    public int? EnterDelayMs { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// <para><b>DefaultValue : 300</b></para>
    /// </summary>
    [Parameter]
    public int? LeaveDelayMs { get; set; }

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
    /// Specify the size of the Button. Defaults to `md`.
    /// <para><b>DefaultValue : "md"</b></para>
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
            .OpenElementAnd(0, "cds-copy")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "feedback", Feedback)
            .SetAttributeNotNull(7, "feedback-timeout", FeedbackTimeout)
            .SetAttributeNotNull(8, "align", Align)
            .SetAttributeNotNull(9, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(10, "defaultOpen", DefaultOpen)
            .SetAttributeNotNull(11, "enter-delay-ms", EnterDelayMs)
            .SetAttributeNotNull(12, "leave-delay-ms", LeaveDelayMs)
            .SetAttributeNotNull(13, "autofocus", Autofocus)
            .SetAttributeNotNull(14, "batch-action", BatchAction)
            .SetAttributeNotNull(15, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(16, "danger-descriptor", DangerDescriptor)
            .SetAttributeNotNull(17, "disabled", Disabled)
            .SetAttributeNotNull(18, "download", Download)
            .SetAttributeNotNull(19, "has-main-content", HasMainContent)
            .SetAttributeNotNull(20, "href", Href)
            .SetAttributeNotNull(21, "hreflang", Hreflang)
            .SetAttributeNotNull(22, "isExpressive", IsExpressive)
            .SetAttributeNotNull(23, "isSelected", IsSelected)
            .SetAttribute(24, "kind", Kind)
            .SetAttributeNotNull(25, "link-role", LinkRole)
            .SetAttributeNotNull(26, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(27, "ping", Ping)
            .SetAttributeNotNull(28, "rel", Rel)
            .SetAttributeNotNull(29, "size", Size)
            .SetAttributeNotNull(30, "target", Target)
            .SetAttributeNotNull(31, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(32, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(33, "tooltip-text", TooltipText)
            .SetAttribute(34, "type", Type)
            .SetAttributeNotNull(35, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(36, "styles", Styles)
            .SetAttributes(37, AdditionalAttributes)
            .SetContent(38, ChildContent)
            .CloseElement();
    }
}

