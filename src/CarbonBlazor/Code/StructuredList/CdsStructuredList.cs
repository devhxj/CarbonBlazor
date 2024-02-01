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
    /// </summary>
    [Parameter]
    public bool Condensed { get; set; }

    /// <summary>
    /// Specify if structured list is flush, default is false
    /// </summary>
    [Parameter]
    public bool Flush { get; set; }

    /// <summary>
    /// The CSS selector to find the rows, including header rows.
    /// </summary>
    [Parameter]
    public string SelectorRowsWithHeader { get; set; } = "`${prefix}-structured-list-row,${prefix}-structured-list-header-row`";

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-structured-list")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "selection-name", SelectionName)
            .SetAttribute(6, "condensed", Condensed)
            .SetAttribute(7, "flush", Flush)
            .SetAttribute(8, "", SelectorRowsWithHeader)
            .SetAttributeNotNull(9, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

