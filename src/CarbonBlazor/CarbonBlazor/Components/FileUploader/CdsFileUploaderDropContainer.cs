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
            .OpenElementAnd(0, "cds-file-uploader-drop-container")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "accept", Accept)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "multiple", Multiple)
            .SetAttributeNotNull(9, "name", Name)
            .SetAttributeNotNull(10, "slot", Slot)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

