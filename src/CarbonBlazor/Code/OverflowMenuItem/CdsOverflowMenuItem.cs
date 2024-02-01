using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsOverflowMenuItem : BaseComponent
{
    /// <summary>
    /// `true` if the action is danger.
    /// </summary>
    [Parameter]
    public bool Danger { get; set; }

    /// <summary>
    /// `true` if the overflow menu item should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if the item has a divider
    /// </summary>
    [Parameter]
    public bool Divider { get; set; }

    /// <summary>
    /// The link href of the overflow menu item.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The size of the overflow menu item.
    /// </summary>
    [Parameter]
    public OVERFLOW_MENU_SIZE Size { get; set; } = OVERFLOW_MENU_SIZE.MD;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-overflow-menu-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "danger", Danger)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "divider", Divider)
            .SetAttribute(8, "href", Href)
            .SetAttribute(9, "size", Size)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

