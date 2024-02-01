using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

/// <summary>
/// 静态 SSR 脚本
/// onLoad 将在脚本添加到页面时调用。
/// onUpdate 将在增强型更新后脚本仍存在于页面时调用。
/// onDispose 将在增强型更新后从页面删除脚本时调用。
/// </summary>
public sealed class CdsScript : IComponent
{
    RenderHandle _renderHandle;

    [Parameter]
    public string? Src { get; set; }

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
        if (ChildContent is null)
            return;

        builder
            .OpenElementAnd(3, "template")
            .SetContent(4, ChildContent)
            .CloseElement();
    }

    void BuildRenderTree(RenderTreeBuilder builder)
    {
        if (string.IsNullOrWhiteSpace(Src) && ChildContent is null)
            return;

        builder
            .OpenElementAnd(0, "cds-script")
            .SetAttributeNotNull(1, "src", Src)
            .SetContent(2, BuildContent)
            .CloseElement();
    }
}
