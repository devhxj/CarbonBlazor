using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSkeletonText : CdsComponentBase
{
    /// <summary>
    /// The type of skeleton text.
    /// </summary>
    [Parameter]
    public SKELETON_TEXT_TYPE Type { get; set; }

    /// <summary>
    /// width (in px or %) of single line of text or max-width of paragraph lines
    /// <para><b>DefaultValue : "100%"</b></para>
    /// </summary>
    [Parameter]
    public string? Width { get; set; }

    /// <summary>
    /// will generate multiple lines of text
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Paragraph { get; set; }

    /// <summary>
    /// the number of lines in a paragraph
    /// <para><b>DefaultValue : 3</b></para>
    /// </summary>
    [Parameter]
    public int? LineCount { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-skeleton-text")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "type", Type)
            .SetAttributeNotNull(8, "width", Width)
            .SetAttributeNotNull(9, "paragraph", Paragraph)
            .SetAttributeNotNull(10, "lineCount", LineCount)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetReferenceCapture(12, CaptureReference)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

