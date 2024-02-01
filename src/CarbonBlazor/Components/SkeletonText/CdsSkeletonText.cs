using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSkeletonText : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "type", Type)
            .SetAttributeNotNull(7, "width", Width)
            .SetAttributeNotNull(8, "paragraph", Paragraph)
            .SetAttributeNotNull(9, "lineCount", LineCount)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

