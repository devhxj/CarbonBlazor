using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTab : BaseComponent
{
    /// <summary>
    /// Tab type.
    /// </summary>
    [Parameter]
    public TABS_TYPE Type { get; set; }

    /// <summary>
    /// The tab text content.
    /// </summary>
    [Parameter]
    public string? TabTitle { get; set; }

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
            .OpenElementAnd(0, "cds-tab")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "type", Type)
            .SetAttributeNotNull(7, "tabTitle", TabTitle)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttributeNotNull(9, "target", Target)
            .SetAttributeNotNull(10, "value", Value)
            .SetAttributeNotNull(11, "icon", Icon)
            .SetAttributeNotNull(12, "align", Align)
            .SetAttributeNotNull(13, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(14, "enterdelayms", EnterDelayMs)
            .SetAttributeNotNull(15, "leavedelayms", LeaveDelayMs)
            .SetAttributeNotNull(16, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(17, "styles", Styles)
            .SetAttributes(18, AdditionalAttributes)
            .SetContent(19, ChildContent)
            .CloseElement();
    }
}

