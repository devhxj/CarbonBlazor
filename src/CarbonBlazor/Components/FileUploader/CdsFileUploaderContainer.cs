using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsFileUploaderContainer : CdsComponentBase
{
    /// <summary>
    /// Button kind.
    /// <para><b>DefaultValue : "primary"</b></para>
    /// </summary>
    [Parameter]
    public BUTTON_KIND ButtonKind { get; set; } = BUTTON_KIND.PRIMARY;

    /// <summary>
    /// Button size.
    /// <para><b>DefaultValue : "md"</b></para>
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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if this drop container should accept more than one files at once.
    /// Note that even with `false` set here, user _can_ select multiple files one by one.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Multiple { get; set; }

    /// <summary>
    /// The name of the input.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// The shadow DOM slot to put this drop container in.
    /// <para><b>DefaultValue : "drop-container"</b></para>
    /// </summary>
    [Parameter]
    public string? Slot { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-file-uploader-container")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "button-kind", ButtonKind)
            .SetAttribute(8, "size", Size)
            .SetAttributeNotNull(9, "accept", Accept)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "multiple", Multiple)
            .SetAttributeNotNull(12, "name", Name)
            .SetAttributeNotNull(13, "slot", Slot)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetReferenceCapture(15, CaptureReference)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

