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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "helper-text", HelperText)
            .SetAttributeNotNull(7, "hide-label", HideLabel)
            .SetAttributeNotNull(8, "label", Label)
            .SetAttributeNotNull(9, "max", Max)
            .SetAttribute(10, "size", Size)
            .SetAttribute(11, "status", Status)
            .SetAttribute(12, "type", Type)
            .SetAttributeNotNull(13, "value", Value)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetAttributes(15, AdditionalAttributes)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

