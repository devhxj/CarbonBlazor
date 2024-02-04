using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressBar : CdsComponentBase
{
    /// <summary>
    /// The current progress as a textual representation.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Whether the label should be visually hidden.
    /// </summary>
    [Parameter]
    public string? HideLabel { get; set; }

    /// <summary>
    /// A label describing the progress bar.
    /// </summary>
    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// The maximum value.
    /// <para><b>DefaultValue : 100</b></para>
    /// </summary>
    [Parameter]
    public int? Max { get; set; }

    /// <summary>
    /// Specify the size of the ProgressBar.
    /// <para><b>DefaultValue : "big"</b></para>
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_SIZE Size { get; set; } = PROGRESS_BAR_SIZE.BIG;

    /// <summary>
    /// Specify the status.
    /// <para><b>DefaultValue : "active"</b></para>
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_STATUS Status { get; set; } = PROGRESS_BAR_STATUS.ACTIVE;

    /// <summary>
    /// Defines the alignment variant of the progress bar.
    /// <para><b>DefaultValue : "default"</b></para>
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_TYPE Type { get; set; } = PROGRESS_BAR_TYPE.DEFAULT;

    /// <summary>
    /// The current value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-progress-bar")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "helper-text", HelperText)
            .SetAttributeNotNull(8, "hide-label", HideLabel)
            .SetAttributeNotNull(9, "label", Label)
            .SetAttributeNotNull(10, "max", Max)
            .SetAttribute(11, "size", Size)
            .SetAttribute(12, "status", Status)
            .SetAttribute(13, "type", Type)
            .SetAttributeNotNull(14, "value", Value)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetReferenceCapture(16, CaptureReference)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

