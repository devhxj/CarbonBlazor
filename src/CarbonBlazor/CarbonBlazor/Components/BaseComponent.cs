using Microsoft.AspNetCore.Components;

namespace CarbonBlazor;

public abstract class BaseComponent : IdComponent
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}

public abstract class BaseComponent<TContext> : IdComponent
{
    [Parameter]
    public RenderFragment<TContext>? ChildContent { get; set; }
}
