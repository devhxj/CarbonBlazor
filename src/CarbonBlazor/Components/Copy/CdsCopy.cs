using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCopy : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "feedback", Feedback)
            .SetAttributeNotNull(8, "feedback-timeout", FeedbackTimeout)
            .SetAttributeNotNull(9, "align", Align)
            .SetAttributeNotNull(10, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(11, "defaultOpen", DefaultOpen)
            .SetAttributeNotNull(12, "enter-delay-ms", EnterDelayMs)
            .SetAttributeNotNull(13, "leave-delay-ms", LeaveDelayMs)
            .SetAttributeNotNull(14, "autofocus", Autofocus)
            .SetAttributeNotNull(15, "batch-action", BatchAction)
            .SetAttributeNotNull(16, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(17, "danger-descriptor", DangerDescriptor)
            .SetAttributeNotNull(18, "disabled", Disabled)
            .SetAttributeNotNull(19, "download", Download)
            .SetAttributeNotNull(20, "has-main-content", HasMainContent)
            .SetAttributeNotNull(21, "href", Href)
            .SetAttributeNotNull(22, "hreflang", Hreflang)
            .SetAttributeNotNull(23, "isExpressive", IsExpressive)
            .SetAttributeNotNull(24, "isSelected", IsSelected)
            .SetAttribute(25, "kind", Kind)
            .SetAttributeNotNull(26, "link-role", LinkRole)
            .SetAttributeNotNull(27, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(28, "ping", Ping)
            .SetAttributeNotNull(29, "rel", Rel)
            .SetAttributeNotNull(30, "size", Size)
            .SetAttributeNotNull(31, "target", Target)
            .SetAttributeNotNull(32, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(33, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(34, "tooltip-text", TooltipText)
            .SetAttribute(35, "type", Type)
            .SetAttributeNotNull(36, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(37, "styles", Styles)
            .SetReferenceCapture(38, CaptureReference)
            .SetContent(39, ChildContent)
            .CloseElement();
    }
}

