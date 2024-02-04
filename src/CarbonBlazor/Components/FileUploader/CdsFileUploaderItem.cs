using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class FileUploaderItemContext
{
    /// <summary>
    /// message The validity message.
    /// </summary>
    public string ValiditySlot = "validity";

    /// <summary>
    /// supplement The supplemental validity message.
    /// </summary>
    public string ValidityMessageSlot = "validity-message";
}

public class CdsFileUploaderItem : CdsComponentBase<FileUploaderItemContext>
{
    /// <summary>
    /// The `aria-label` attribute for the icon to delete this file uploader item.
    /// <para><b>DefaultValue : "Delete this file"</b></para>
    /// </summary>
    [Parameter]
    public string? IconDescription { get; set; }

    /// <summary>
    /// Controls the invalid state and visibility of the `validityMessage`.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// The size of this file uploader item.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public FILE_UPLOADER_ITEM_SIZE Size { get; set; } = FILE_UPLOADER_ITEM_SIZE.MD;

    /// <summary>
    /// The state of this file uploader item.
    /// <para><b>DefaultValue : "uploading"</b></para>
    /// </summary>
    [Parameter]
    public FILE_UPLOADER_ITEM_STATE State { get; set; } = FILE_UPLOADER_ITEM_STATE.UPLOADING;

    /// <summary>
    /// The error subject text.
    /// </summary>
    [Parameter]
    public string? ErrorSubject { get; set; }

    /// <summary>
    /// The error body text
    /// </summary>
    [Parameter]
    public string? ErrorBody { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-file-uploader-item")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "icon-description", IconDescription)
            .SetAttributeNotNull(8, "invalid", Invalid)
            .SetAttribute(9, "size", Size)
            .SetAttribute(10, "state", State)
            .SetAttributeNotNull(11, "error-subject", ErrorSubject)
            .SetAttributeNotNull(12, "error-body", ErrorBody)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent, new())
            .CloseElement();
    }
}

