using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTableToolbarSearch : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "persistent", Persistent)
            .SetAttributeNotNull(8, "autocomplete", AutoComplete)
            .SetAttributeNotNull(9, "close-button-label-text", CloseButtonLabelText)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "expandable", Expandable)
            .SetAttributeNotNull(12, "expanded", Expanded)
            .SetAttributeNotNull(13, "hasCustomIcon", HasCustomIcon)
            .SetAttributeNotNull(14, "label-text", LabelText)
            .SetAttributeNotNull(15, "name", Name)
            .SetAttributeNotNull(16, "placeholder", Placeholder)
            .SetAttribute(17, "size", Size)
            .SetAttributeNotNull(18, "type", Type)
            .SetAttributeNotNull(19, "value", Value)
            .SetAttributeNotNull(20, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(21, "styles", Styles)
            .SetReferenceCapture(22, CaptureReference)
            .SetContent(23, ChildContent)
            .CloseElement();
    }
}

