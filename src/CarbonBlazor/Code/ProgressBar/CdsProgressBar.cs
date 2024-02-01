using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressBar : BaseComponent
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
    /// </summary>
    [Parameter]
    public int Max { get; set; } = 100;

    /// <summary>
    /// Specify the size of the ProgressBar.
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_SIZE Size { get; set; } = PROGRESS_BAR_SIZE.BIG;

    /// <summary>
    /// Specify the status.
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_STATUS Status { get; set; } = PROGRESS_BAR_STATUS.ACTIVE;

    /// <summary>
    /// Defines the alignment variant of the progress bar.
    /// </summary>
    [Parameter]
    public PROGRESS_BAR_TYPE Type { get; set; } = PROGRESS_BAR_TYPE.DEFAULT;

    /// <summary>
    /// The current value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-progress-bar")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "helper-text", HelperText)
            .SetAttributeNotNull(6, "hide-label", HideLabel)
            .SetAttributeNotNull(7, "label", Label)
            .SetAttribute(8, "max", Max)
            .SetAttribute(9, "size", Size)
            .SetAttribute(10, "status", Status)
            .SetAttribute(11, "type", Type)
            .SetAttributeNotNull(12, "value", Value)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

