using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class FileUploaderContext
{
    public string LabelTitleSlot = "label-title";

    public string LebelDescriptionSlot = "lebel-description";
}

public class CdsFileUploader : BaseComponent<FileUploaderContext>
{
    /// <summary>
    /// `true` if the file uploader should disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The description text.
    /// </summary>
    [Parameter]
    public string? LabelDescription { get; set; }

    /// <summary>
    /// The label title.
    /// </summary>
    [Parameter]
    public string? LabelTitle { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-file-uploader")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "label-description", LabelDescription)
            .SetAttributeNotNull(8, "label-title", LabelTitle)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent, new())
            .CloseElement();
    }
}

