using Microsoft.AspNetCore.Components;
using shortid;
using System.Diagnostics.CodeAnalysis;

namespace CarbonBlazor;

public abstract class IdComponent : ComponentBase
{
    [Parameter]
    [NotNull]
    public string Id { get; init; }

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public int? TabIndex { get; set; }

    [Parameter]
    public string? Role { get; set; }

    [Parameter]
    public string? AriaLabel { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    public IdComponent()
    {
        Id = ShortId.Generate(RenderTreeBuilderExtensions.IdGenerator);
    }

    /// <summary>
    /// Refreshes the state of the component. When applicable, this will cause the component to be re-rendered.
    /// </summary>
    public void Refresh() => StateHasChanged();
}
