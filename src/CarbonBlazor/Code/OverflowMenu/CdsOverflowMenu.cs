using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsOverflowMenu : BaseComponent
{
    /// <summary>
    /// `true` if this tooltip is in a data table row
    /// </summary>
    [Parameter]
    public bool DataTable { get; set; }

    /// <summary>
    /// `true` if this overflow menu body should be flipped.
    /// </summary>
    [Parameter]
    public bool Flipped { get; set; }

    /// <summary>
    /// Index (starting at 1) of overflow menu item to focus on open.
    /// </summary>
    [Parameter]
    public int Index { get; set; } = 1;

    /// <summary>
    /// `true` if this menu is a toolbar action
    /// </summary>
    [Parameter]
    public bool ToolbarAction { get; set; }

    /// <summary>
    /// `true` if the dropdown should be open.
    /// </summary>
    [Parameter]
    public bool Open { get; set; }

    /// <summary>
    /// The position of the trigger button.
    /// </summary>
    [Parameter]
    public DOMRect? TriggerPosition { get; set; }

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
    /// `true` if this overflow menu should be disabled.
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
    /// Overflow menu size.
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
            .OpenElementAnd(0, "cds-overflow-menu")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "data-table", DataTable)
            .SetAttribute(6, "flipped", Flipped)
            .SetAttribute(7, "index", Index)
            .SetAttribute(8, "toolbar-action", ToolbarAction)
            .SetAttribute(9, "open", Open)
            .SetAttributeNotNull(10, "triggerposition", TriggerPosition)
            .SetAttribute(11, "align", Align)
            .SetAttribute(12, "close-on-activation", CloseOnActivation)
            .SetAttribute(13, "defaultOpen", DefaultOpen)
            .SetAttribute(14, "enter-delay-ms", EnterDelayMs)
            .SetAttribute(15, "leave-delay-ms", LeaveDelayMs)
            .SetAttribute(16, "autofocus", Autofocus)
            .SetAttribute(17, "batch-action", BatchAction)
            .SetAttributeNotNull(18, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(19, "danger-descriptor", DangerDescriptor)
            .SetAttribute(20, "disabled", Disabled)
            .SetAttributeNotNull(21, "download", Download)
            .SetAttribute(22, "has-main-content", HasMainContent)
            .SetAttributeNotNull(23, "href", Href)
            .SetAttributeNotNull(24, "hreflang", Hreflang)
            .SetAttribute(25, "isExpressive", IsExpressive)
            .SetAttribute(26, "isSelected", IsSelected)
            .SetAttribute(27, "kind", Kind)
            .SetAttribute(28, "link-role", LinkRole)
            .SetAttribute(29, "openTooltip", OpenTooltip)
            .SetAttributeNotNull(30, "ping", Ping)
            .SetAttributeNotNull(31, "rel", Rel)
            .SetAttribute(32, "size", Size)
            .SetAttributeNotNull(33, "target", Target)
            .SetAttribute(34, "tooltip-alignment", TooltipAlignment)
            .SetAttribute(35, "tooltip-position", TooltipPosition)
            .SetAttributeNotNull(36, "tooltip-text", TooltipText)
            .SetAttribute(37, "type", Type)
            .SetAttributeNotNull(38, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(39, "styles", Styles)
            .SetAttributes(40, AdditionalAttributes)
            .SetContent(41, ChildContent)
            .CloseElement();
    }
}

