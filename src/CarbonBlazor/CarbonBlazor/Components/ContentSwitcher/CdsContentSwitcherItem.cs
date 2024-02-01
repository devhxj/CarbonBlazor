using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsContentSwitcherItem : BaseComponent
{
    /// <summary>
    /// `true` if this content switcher item should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Icon { get; set; }

    /// <summary>
    /// Specify how the trigger should align with the tooltip for icon-only
    /// switcher item
    /// <para><b>DefaultValue : "top"</b></para>
    /// </summary>
    [Parameter]
    public string? Align { get; set; }

    /// <summary>
    /// Determines whether the tooltip should close when inner content is
    /// activated (click, Enter or Space)
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? CloseOnActivation { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before displaying the
    /// tooltip for icon-only switcher item
    /// <para><b>DefaultValue : 100</b></para>
    /// </summary>
    [Parameter]
    public int? EnterDelayMs { get; set; }

    /// <summary>
    /// Specify the duration in milliseconds to delay before hiding the tooltip
    /// for icon-only switcher-item
    /// 
    /// TODO: match upstream value once #10471 is resolved
    /// <para><b>DefaultValue : 100</b></para>
    /// </summary>
    [Parameter]
    public int? LeaveDelayMs { get; set; }

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
            .OpenElementAnd(0, "cds-content-switcher-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "target", Target)
            .SetAttributeNotNull(8, "value", Value)
            .SetAttributeNotNull(9, "icon", Icon)
            .SetAttributeNotNull(10, "align", Align)
            .SetAttributeNotNull(11, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(12, "enterdelayms", EnterDelayMs)
            .SetAttributeNotNull(13, "leavedelayms", LeaveDelayMs)
            .SetAttributeNotNull(14, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetAttributes(16, AdditionalAttributes)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

