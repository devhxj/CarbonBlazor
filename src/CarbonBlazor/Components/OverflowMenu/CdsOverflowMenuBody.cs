using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsOverflowMenuBody : CdsComponentBase
{
    /// <summary>
    /// <para><b>Type : CDSOverflowMenuItem | null</b></para>
    /// </summary>
    [Parameter]
    public CdsOverflowMenuItem? Selected { get; set; }

    /// <summary>
    /// The overflow menu size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public OVERFLOW_MENU_SIZE Size { get; set; } = OVERFLOW_MENU_SIZE.MD;

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    /// <summary>
    /// The menu direction.
    /// <para><b>DefaultValue : "bottom"</b></para>
    /// </summary>
    [Parameter]
    public FLOATING_MENU_DIRECTION Direction { get; set; } = FLOATING_MENU_DIRECTION.BOTTOM;

    /// <summary>
    /// How the menu is aligned to the trigger button.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Flipped { get; set; }

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
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? FLOATING_MENU { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-overflow-menu-body")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "selected", Selected)
            .SetAttribute(8, "size", Size)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttribute(10, "direction", Direction)
            .SetAttributeNotNull(11, "flipped", Flipped)
            .SetAttributeNotNull(12, "container", Container)
            .SetAttributeNotNull(13, "position", Position)
            .SetAttributeNotNull(14, "floating_menu", FLOATING_MENU)
            .SetAttributeNotNull(15, "shadowRootOptions", ShadowRootOptions)
            .SetReferenceCapture(16, CaptureReference)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

