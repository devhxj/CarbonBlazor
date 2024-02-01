using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredList : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "selection-name", SelectionName)
            .SetAttributeNotNull(7, "condensed", Condensed)
            .SetAttributeNotNull(8, "flush", Flush)
            .SetAttributeNotNull(9, "selectorrowswithheader", SelectorRowsWithHeader)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

