using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsTileGroup : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "fieldset-class-name", FieldsetClassName)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttributeNotNull(9, "currentRadioSelection", CurrentRadioSelection)
            .SetAttributeNotNull(10, "currentSelections", CurrentSelections)
            .SetAttributeNotNull(11, "radioTiles", RadioTiles)
            .SetAttributeNotNull(12, "selectableTiles", SelectableTiles)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

