using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsContentSwitcherItem : BaseComponent
{
    /// <summary>
    /// `true` if this content switcher item should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The element ID of target panel.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// The `value` attribute that is set to the parent `&lt;cds-content-switcher&gt;`
    /// when this content switcher item is selected.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// `true` if the content switcher button should be icon-only.
    /// </summary>
    [Parameter]
    public bool Icon { get; set; }

    /// <summary>
    /// Specify how the trigger should align with the tooltip for icon-only
    /// switcher item
    /// </summary>
    [Parameter]
    public string Align { get; set; } = "top";

    /// <summary>
    /// Determines whether the tooltip should close when inner content is
    /// activated (click, Enter or Space)
    /// </summary>
    [Parameter]
    public bool CloseOnActivation { get; set; } = true;

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the
    /// tooltip for icon-only switcher item
    /// </summary>
    [Parameter]
    public int EnterDelayMs { get; set; } = 100;

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// for icon-only switcher-item
    /// 
    /// TODO: match upstream value once #10471 is resolved
    /// </summary>
    [Parameter]
    public int LeaveDelayMs { get; set; } = 100;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-content-switcher-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttributeNotNull(6, "target", Target)
            .SetAttribute(7, "value", Value)
            .SetAttribute(8, "icon", Icon)
            .SetAttribute(9, "align", Align)
            .SetAttribute(10, "close-on-activation", CloseOnActivation)
            .SetAttribute(11, "", EnterDelayMs)
            .SetAttribute(12, "", LeaveDelayMs)
            .SetAttributeNotNull(13, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetAttributes(15, AdditionalAttributes)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

