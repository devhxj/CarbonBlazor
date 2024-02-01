using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsFileUploaderContainer : BaseComponent
{
    /// <summary>
    /// Button kind.
    /// </summary>
    [Parameter]
    public BUTTON_KIND ButtonKind { get; set; } = BUTTON_KIND.PRIMARY;

    /// <summary>
    /// Button size.
    /// </summary>
    [Parameter]
    public BUTTON_SIZE Size { get; set; } = BUTTON_SIZE.MD;

    /// <summary>
    /// The file types the file input should accept, separated by space.
    /// </summary>
    [Parameter]
    public string? Accept { get; set; }

    /// <summary>
    /// `true` if this drop container should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if this drop container should accept more than one files at once.
    /// Note that even with `false` set here, user _can_ select multiple files one by one.
    /// </summary>
    [Parameter]
    public bool Multiple { get; set; }

    /// <summary>
    /// The name of the input.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// The shadow DOM slot to put this drop container in.
    /// </summary>
    [Parameter]
    public string Slot { get; set; } = "drop-container";

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-file-uploader-container")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "button-kind", ButtonKind)
            .SetAttribute(6, "size", Size)
            .SetAttribute(7, "accept", Accept)
            .SetAttribute(8, "disabled", Disabled)
            .SetAttribute(9, "multiple", Multiple)
            .SetAttribute(10, "name", Name)
            .SetAttribute(11, "slot", Slot)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

