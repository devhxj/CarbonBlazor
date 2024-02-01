using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableToolbarSearch : BaseComponent
{
    /// <summary>
    /// `true` if the search box should be always be open.
    /// </summary>
    [Parameter]
    public bool Persistent { get; set; }

    /// <summary>
    /// Specify an optional value for the autocomplete property on the underlying &lt;input&gt;,
    /// defaults to "off"
    /// </summary>
    [Parameter]
    public string AutoComplete { get; set; } = "off";

    /// <summary>
    /// Specify a label to be read by screen readers on the "close" button
    /// </summary>
    [Parameter]
    public string? CloseButtonLabelText { get; set; }

    /// <summary>
    /// `true` if the search box should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if the search bar can be expandable
    /// </summary>
    [Parameter]
    public bool Expandable { get; set; }

    /// <summary>
    /// `true` if the search box should be expanded.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    [Parameter]
    public bool HasCustomIcon { get; set; }

    /// <summary>
    /// The label text.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// The form name in `FormData`.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// The placeholder text.
    /// </summary>
    [Parameter]
    public string Placeholder { get; set; } = "Search";

    /// <summary>
    /// The search box size.
    /// </summary>
    [Parameter]
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.LG;

    /// <summary>
    /// The `&lt;input&gt;` name.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-table-toolbar-search")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "persistent", Persistent)
            .SetAttribute(6, "autocomplete", AutoComplete)
            .SetAttribute(7, "close-button-label-text", CloseButtonLabelText)
            .SetAttribute(8, "disabled", Disabled)
            .SetAttribute(9, "expandable", Expandable)
            .SetAttribute(10, "expanded", Expanded)
            .SetAttribute(11, "hasCustomIcon", HasCustomIcon)
            .SetAttribute(12, "label-text", LabelText)
            .SetAttribute(13, "name", Name)
            .SetAttribute(14, "placeholder", Placeholder)
            .SetAttribute(15, "size", Size)
            .SetAttribute(16, "type", Type)
            .SetAttribute(17, "value", Value)
            .SetAttributeNotNull(18, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

