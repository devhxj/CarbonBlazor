using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTab : BaseComponent
{
    /// <summary>
    /// Tab type.
    /// </summary>
    [Parameter]
    public TABS_TYPE? Type { get; set; }

    /// <summary>
    /// The tab text content.
    /// </summary>
    [Parameter]
    public string? TabTitle { get; set; }

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
            .OpenElementAnd(0, "cds-tab")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "type", Type)
            .SetAttributeNotNull(6, "tabTitle", TabTitle)
            .SetAttribute(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "target", Target)
            .SetAttribute(9, "value", Value)
            .SetAttribute(10, "icon", Icon)
            .SetAttribute(11, "align", Align)
            .SetAttribute(12, "close-on-activation", CloseOnActivation)
            .SetAttribute(13, "", EnterDelayMs)
            .SetAttribute(14, "", LeaveDelayMs)
            .SetAttributeNotNull(15, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetAttributes(17, AdditionalAttributes)
            .SetContent(18, ChildContent)
            .CloseElement();
    }
}

