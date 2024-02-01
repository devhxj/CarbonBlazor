using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsOverflowMenuBody : BaseComponent
{
    /// <summary>
    /// <para><b>Type : CDSOverflowMenuItem | null</b></para>
    /// </summary>
    [Parameter]
    public ElementRef? Selected { get; set; }

    /// <summary>
    /// The overflow menu size.
    /// </summary>
    [Parameter]
    public OVERFLOW_MENU_SIZE Size { get; set; } = OVERFLOW_MENU_SIZE.MD;

    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// The menu direction.
    /// </summary>
    [Parameter]
    public FLOATING_MENU_DIRECTION Direction { get; set; } = FLOATING_MENU_DIRECTION.BOTTOM;

    /// <summary>
    /// How the menu is aligned to the trigger button.
    /// </summary>
    [Parameter]
    public bool Flipped { get; set; }

    /// <summary>
    /// The DOM element to put this menu into.
    /// </summary>
    [Parameter]
    public string? Container { get; set; }

    /// <summary>
    /// The position of this floating menu.
    /// </summary>
    [Parameter]
    public FloatingMenuPosition? Position { get; set; }

    /// <summary>
    /// A constant indicating that this class is a floating menu.
    /// </summary>
    [Parameter]
    public bool FLOATING_MENU { get; set; } = true;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-overflow-menu-body")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "selected", Selected)
            .SetAttribute(6, "size", Size)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttribute(8, "direction", Direction)
            .SetAttribute(9, "flipped", Flipped)
            .SetAttributeNotNull(10, "container", Container)
            .SetAttributeNotNull(11, "position", Position)
            .SetAttribute(12, "", FLOATING_MENU)
            .SetAttributeNotNull(13, "shadowRootOptions", ShadowRootOptions)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

