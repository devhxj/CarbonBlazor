using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsFileUploaderDropContainer : BaseComponent
{
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
            .OpenElementAnd(0, "cds-file-uploader-drop-container")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "accept", Accept)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "multiple", Multiple)
            .SetAttribute(8, "name", Name)
            .SetAttribute(9, "slot", Slot)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

