using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSkeletonText : BaseComponent
{
    /// <summary>
    /// The type of skeleton text.
    /// </summary>
    [Parameter]
    public SKELETON_TEXT_TYPE? Type { get; set; }

    /// <summary>
    /// width (in px or %) of single line of text or max-width of paragraph lines
    /// </summary>
    [Parameter]
    public string Width { get; set; } = "100%";

    /// <summary>
    /// will generate multiple lines of text
    /// </summary>
    [Parameter]
    public bool Paragraph { get; set; }

    /// <summary>
    /// the number of lines in a paragraph
    /// </summary>
    [Parameter]
    public int LineCount { get; set; } = 3;

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-skeleton-text")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "type", Type)
            .SetAttribute(6, "width", Width)
            .SetAttribute(7, "paragraph", Paragraph)
            .SetAttribute(8, "lineCount", LineCount)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

