using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsFileUploaderItem : BaseComponent
{
    /// <summary>
    /// The `aria-label` attribute for the icon to delete this file uploader item.
    /// </summary>
    [Parameter]
    public string IconDescription { get; set; } = "Delete this file";

    /// <summary>
    /// Controls the invalid state and visibility of the `validityMessage`.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// The size of this file uploader item.
    /// </summary>
    [Parameter]
    public FILE_UPLOADER_ITEM_SIZE Size { get; set; } = FILE_UPLOADER_ITEM_SIZE.MD;

    /// <summary>
    /// The state of this file uploader item.
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

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-file-uploader-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "icon-description", IconDescription)
            .SetAttribute(6, "invalid", Invalid)
            .SetAttribute(7, "size", Size)
            .SetAttribute(8, "state", State)
            .SetAttribute(9, "error-subject", ErrorSubject)
            .SetAttribute(10, "error-body", ErrorBody)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

