using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using shortid;
using System.Diagnostics.CodeAnalysis;

namespace CarbonBlazor;

public abstract class CdsInputBase<TValue> : InputBase<TValue>
{
    private ElementReference _ref;

    /// <summary>
    /// Gets or sets the associated web component. 
    /// May be <see langword="null"/> if accessed before the component is rendered.
    /// </summary>
    public ElementReference Element
    {
        get => _ref;
        protected set
        {
            _ref = value;
            ParentReference?.Set(value);
        }
    }

    /// <summary>
    /// A reference to the enclosing component.
    /// </summary>
    [Parameter]
    public virtual Reference? ParentReference { get; set; }

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

    public CdsInputBase()
    {
        Id = ShortId.Generate(RenderTreeBuilderExtensions.IdGenerator);
    }

    public void Refresh() => StateHasChanged();

    protected void CaptureReference(ElementReference reference) => Element = reference;
}
