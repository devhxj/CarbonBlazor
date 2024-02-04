using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public sealed class CdsModules : CdsElementBase
{
    static readonly MarkupString _indicator = new(@"<div class='cds-preload-indicator'></div>");

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

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

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "template")
            .SetAttribute(1, "id", "cds-preload-template")
            .SetContent(2, BuildContent)
            .CloseElementAnd()
            .OpenElementAnd(3, "link")
            .SetAttribute(4, "rel", "stylesheet")
            .SetAttribute(5, "href", $"_content/CarbonBlazor/web-components.css")
            .CloseElementAnd()
            .OpenElementAnd(6, "script")
            .SetAttribute(7, "type", "text/javascript")
            .SetContent(8, new MarkupString(@"
let preloadTemp = document.getElementById('cds-preload-template');
if (preloadTemp) preloadTemp.before(preloadTemp.content.cloneNode(true));
import('./_content/CarbonBlazor/web-components.es.js')
    .then(() => {
        console.info('Carbon module loading completed.')
        let preload = document.getElementById('cds-preload')
        if (preload) preload.remove();
    })
    .catch(e => console.error(e))"))
            .CloseElementAnd();
    }
}
