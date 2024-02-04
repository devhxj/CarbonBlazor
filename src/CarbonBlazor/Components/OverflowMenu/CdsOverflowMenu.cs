using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class OverflowMenuContext
{
    /// <summary>
    /// The icon for the trigger button.
    /// </summary>
    public string IconSlot = "icon";
}

public class CdsOverflowMenu : CdsComponentBase<OverflowMenuContext>
{
    /// <summary>
    /// `true` if this tooltip is in a data table row
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DataTable { get; set; }

    /// <summary>
    /// `true` if this overflow menu body should be flipped.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Flipped { get; set; }

    /// <summary>
    /// Index (starting at 1) of overflow menu item to focus on open.
    /// <para><b>DefaultValue : 1</b></para>
    /// </summary>
    [Parameter]
    public int? Index { get; set; }

    /// <summary>
    /// `true` if this menu is a toolbar action
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ToolbarAction { get; set; }

    /// <summary>
    /// `true` if the dropdown should be open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

    /// <summary>
    /// The position of the trigger button.
    /// </summary>
    [Parameter]
    public DOMRect TriggerPosition { get; set; }

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
    /// `true` if this overflow menu should be disabled.
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
    /// Overflow menu size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public OVERFLOW_MENU_SIZE Size { get; set; } = OVERFLOW_MENU_SIZE.MD;

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
            .OpenElementAnd(0, "cds-overflow-menu")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "data-table", DataTable)
            .SetAttributeNotNull(8, "flipped", Flipped)
            .SetAttributeNotNull(9, "index", Index)
            .SetAttributeNotNull(10, "toolbar-action", ToolbarAction)
            .SetAttributeNotNull(11, "open", Open)
            .SetAttributeNotNull(12, "triggerposition", TriggerPosition)
            .SetAttributeNotNull(13, "align", Align)
            .SetAttributeNotNull(14, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(15, "defaultOpen", DefaultOpen)
            .SetAttributeNotNull(16, "enter-delay-ms", EnterDelayMs)
            .SetAttributeNotNull(17, "leave-delay-ms", LeaveDelayMs)
            .SetAttributeNotNull(18, "autofocus", Autofocus)
            .SetAttributeNotNull(19, "batch-action", BatchAction)
            .SetAttributeNotNull(20, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(21, "danger-descriptor", DangerDescriptor)
            .SetAttributeNotNull(22, "disabled", Disabled)
            .SetAttributeNotNull(23, "download", Download)
            .SetAttributeNotNull(24, "has-main-content", HasMainContent)
            .SetAttributeNotNull(25, "href", Href)
            .SetAttributeNotNull(26, "hreflang", Hreflang)
            .SetAttributeNotNull(27, "isExpressive", IsExpressive)
            .SetAttributeNotNull(28, "isSelected", IsSelected)
            .SetAttribute(29, "kind", Kind)
            .SetAttributeNotNull(30, "link-role", LinkRole)
            .SetAttributeNotNull(31, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(32, "ping", Ping)
            .SetAttributeNotNull(33, "rel", Rel)
            .SetAttribute(34, "size", Size)
            .SetAttributeNotNull(35, "target", Target)
            .SetAttributeNotNull(36, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(37, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(38, "tooltip-text", TooltipText)
            .SetAttribute(39, "type", Type)
            .SetAttributeNotNull(40, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(41, "styles", Styles)
            .SetReferenceCapture(42, CaptureReference)
            .SetContent(43, ChildContent, new())
            .CloseElement();
    }
}

