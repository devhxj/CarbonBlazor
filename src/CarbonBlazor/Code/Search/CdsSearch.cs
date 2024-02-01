using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSearch : BaseComponent
{
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
    /// `true` if the expandable search has been expanded
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
    public INPUT_SIZE Size { get; set; } = INPUT_SIZE.MD;

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
            .OpenElementAnd(0, "cds-search")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "autocomplete", AutoComplete)
            .SetAttribute(6, "close-button-label-text", CloseButtonLabelText)
            .SetAttribute(7, "disabled", Disabled)
            .SetAttribute(8, "expandable", Expandable)
            .SetAttribute(9, "expanded", Expanded)
            .SetAttribute(10, "hasCustomIcon", HasCustomIcon)
            .SetAttribute(11, "label-text", LabelText)
            .SetAttribute(12, "name", Name)
            .SetAttribute(13, "placeholder", Placeholder)
            .SetAttribute(14, "size", Size)
            .SetAttribute(15, "type", Type)
            .SetAttribute(16, "value", Value)
            .SetAttributeNotNull(17, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

