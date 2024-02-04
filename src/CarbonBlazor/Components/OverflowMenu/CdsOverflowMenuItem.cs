using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsOverflowMenuItem : CdsComponentBase
{
    /// <summary>
    /// `true` if the action is danger.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Danger { get; set; }

    /// <summary>
    /// `true` if the overflow menu item should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if the item has a divider
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Divider { get; set; }

    /// <summary>
    /// The link href of the overflow menu item.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The size of the overflow menu item.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public OVERFLOW_MENU_SIZE Size { get; set; } = OVERFLOW_MENU_SIZE.MD;

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
            .OpenElementAnd(0, "cds-overflow-menu-item")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "danger", Danger)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttributeNotNull(9, "divider", Divider)
            .SetAttributeNotNull(10, "href", Href)
            .SetAttribute(11, "size", Size)
            .SetAttributeNotNull(12, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

