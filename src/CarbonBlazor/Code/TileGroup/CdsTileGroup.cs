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

    [Parameter]
    public string CurrentSelections { get; set; } = [];

    [Parameter]
    public string? RadioTiles { get; set; }

    [Parameter]
    public string? SelectableTiles { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-tile-group")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "fieldset-class-name", FieldsetClassName)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "currentRadioSelection", CurrentRadioSelection)
            .SetAttribute(8, "currentSelections", CurrentSelections)
            .SetAttributeNotNull(9, "radioTiles", RadioTiles)
            .SetAttributeNotNull(10, "selectableTiles", SelectableTiles)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

