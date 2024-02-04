using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsContentSwitcherItem : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "target", Target)
            .SetAttributeNotNull(9, "value", Value)
            .SetAttributeNotNull(10, "icon", Icon)
            .SetAttributeNotNull(11, "align", Align)
            .SetAttributeNotNull(12, "close-on-activation", CloseOnActivation)
            .SetAttributeNotNull(13, "enterdelayms", EnterDelayMs)
            .SetAttributeNotNull(14, "leavedelayms", LeaveDelayMs)
            .SetAttributeNotNull(15, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetReferenceCapture(17, CaptureReference)
            .SetContent(18, ChildContent)
            .CloseElement();
    }
}

