using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace CarbonBlazor;

public sealed class CdsModules : IComponent
{
    RenderHandle _renderHandle;
    static readonly MarkupString _indicator = new(@"<div class='cds-preload-indicator'></div>");

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    public void Attach(RenderHandle renderHandle)
    {
        if (_renderHandle.IsInitialized)
        {
            throw new InvalidOperationException("The render handle is already set. Cannot initialize a ComponentBase more than once.");
        }

        _renderHandle = renderHandle;
    }

    public Task SetParametersAsync(ParameterView parameters)
    {
        parameters.SetParameterProperties(this);
        _renderHandle.Render(BuildRenderTree);
        return Task.CompletedTask;
    }

    void BuildContent(RenderTreeBuilder builder)
    {
        var hasContent = ChildContent is null;
        builder
            .OpenElementAnd(3, "div")
            .SetAttribute(4, "id", "cds-preload");

        if (ChildContent is null)
            builder.AddContent(5, _indicator);
        else
            builder.AddContent(6, ChildContent);

        builder.CloseElement();
    }

    void BuildRenderTree(RenderTreeBuilder builder)
    {
        var v = string.Empty;
#if DEBUG
        v = $"?{DateTime.Now.Ticks}";
#endif
        var hasContent = ChildContent is null;
        builder
            .OpenElementAnd(0, "template")
            .SetAttribute(1, "id", "cds-preload-template")
            .SetContent(2, BuildContent)
            .CloseElementAnd()

            .OpenElementAnd(7, "link")
            .SetAttribute(8, "rel", "stylesheet")
            .SetAttribute(9, "href", $"_content/CarbonBlazor/css/grid.css{v}")
            .CloseElementAnd()

            .OpenElementAnd(10, "link")
            .SetAttribute(11, "rel", "stylesheet")
            .SetAttribute(12, "href", $"_content/CarbonBlazor/css/themes.css{v}")
            .CloseElementAnd()

            .OpenElementAnd(13, "link")
            .SetAttribute(14, "rel", "stylesheet")
            .SetAttribute(15, "href", $"_content/CarbonBlazor/css/app.css{v}")
            .CloseElementAnd()

            .OpenElementAnd(16, "script")
            .SetAttribute(17, "type", "text/javascript")
            .SetAttribute(18, "src", $"_content/CarbonBlazor/modules.js{v}")
            .CloseElementAnd();
    }
}
