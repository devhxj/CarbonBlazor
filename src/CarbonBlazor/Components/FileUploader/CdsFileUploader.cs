using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class FileUploaderContext
{
    public string LabelTitleSlot = "label-title";

    public string LebelDescriptionSlot = "lebel-description";
}

public class CdsFileUploader : CdsComponentBase<FileUploaderContext>
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "label-description", LabelDescription)
            .SetAttributeNotNull(9, "label-title", LabelTitle)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetReferenceCapture(11, CaptureReference)
            .SetContent(12, ChildContent, new())
            .CloseElement();
    }
}

