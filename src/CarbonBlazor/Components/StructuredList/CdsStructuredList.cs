using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredList : CdsComponentBase
{
    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// If present, this structured list will be a selectable one.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// Specify if structured list is condensed, default is false
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Condensed { get; set; }

    /// <summary>
    /// Specify if structured list is flush, default is false
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Flush { get; set; }

    /// <summary>
    /// The CSS selector to find the rows, including header rows.
    /// <para><b>DefaultValue : "`${prefix}-structured-list-row,${prefix}-structured-list-header-row`"</b></para>
    /// </summary>
    [Parameter]
    public string? SelectorRowsWithHeader { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-structured-list")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "selection-name", SelectionName)
            .SetAttributeNotNull(8, "condensed", Condensed)
            .SetAttributeNotNull(9, "flush", Flush)
            .SetAttributeNotNull(10, "selectorrowswithheader", SelectorRowsWithHeader)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetReferenceCapture(13, CaptureReference)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

