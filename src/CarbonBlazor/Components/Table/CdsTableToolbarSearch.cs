using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableToolbarSearch : BaseComponent
{
    /// <summary>
    /// `true` if the search box should be always be open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Persistent { get; set; }

    /// <summary>
    /// Specify an optional value for the autocomplete property on the underlying &lt;input&gt;,
    /// defaults to "off"
    /// <para><b>DefaultValue : "off"</b></para>
    /// </summary>
    [Parameter]
    public string? AutoComplete { get; set; }

    /// <summary>
    /// Specify a label to be read by screen readers on the "close" button
    /// </summary>
    [Parameter]
    public string? CloseButtonLabelText { get; set; }

    /// <summary>
    /// `true` if the search box should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if the search bar can be expandable
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expandable { get; set; }

    /// <summary>
    /// `true` if the search box should be expanded.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasCustomIcon { get; set; }

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
    /// <para><b>DefaultValue : "Search"</b></para>
    /// </summary>
    [Parameter]
    public string? Placeholder { get; set; }

    /// <summary>
    /// The search box size.
    /// <para><b>DefaultValue : "lg"</b></para>
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
            .OpenElementAnd(0, "cds-table-toolbar-search")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "persistent", Persistent)
            .SetAttributeNotNull(7, "autocomplete", AutoComplete)
            .SetAttributeNotNull(8, "close-button-label-text", CloseButtonLabelText)
            .SetAttributeNotNull(9, "disabled", Disabled)
            .SetAttributeNotNull(10, "expandable", Expandable)
            .SetAttributeNotNull(11, "expanded", Expanded)
            .SetAttributeNotNull(12, "hasCustomIcon", HasCustomIcon)
            .SetAttributeNotNull(13, "label-text", LabelText)
            .SetAttributeNotNull(14, "name", Name)
            .SetAttributeNotNull(15, "placeholder", Placeholder)
            .SetAttribute(16, "size", Size)
            .SetAttributeNotNull(17, "type", Type)
            .SetAttributeNotNull(18, "value", Value)
            .SetAttributeNotNull(19, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetAttributes(21, AdditionalAttributes)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

