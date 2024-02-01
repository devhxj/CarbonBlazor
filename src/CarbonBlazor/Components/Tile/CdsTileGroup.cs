using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTileGroup : BaseComponent
{
    /// <summary>
    /// Provide an optional className to be applied to the component
    /// </summary>
    [Parameter]
    public string? FieldsetClassName { get; set; }

    /// <summary>
    /// Specify whether the group is disabled
    /// </summary>
    [Parameter]
    public string? Disabled { get; set; }

    [Parameter]
    public string? CurrentRadioSelection { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : []</b></para>
    /// </summary>
    [Parameter]
    public string[]? CurrentSelections { get; set; }

    [Parameter]
    public string? RadioTiles { get; set; }

    [Parameter]
    public string? SelectableTiles { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tile-group")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "fieldset-class-name", FieldsetClassName)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "currentRadioSelection", CurrentRadioSelection)
            .SetAttributeNotNull(9, "currentSelections", CurrentSelections)
            .SetAttributeNotNull(10, "radioTiles", RadioTiles)
            .SetAttributeNotNull(11, "selectableTiles", SelectableTiles)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

