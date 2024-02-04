using Microsoft.AspNetCore.Components;

namespace CarbonBlazor;

public abstract class CdsComponentBase : CdsIdComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}

public abstract class CdsComponentBase<TContext> : CdsIdComponentBase
{
    [Parameter]
    public RenderFragment<TContext>? ChildContent { get; set; }
}
