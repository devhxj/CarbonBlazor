using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

/// <summary>
/// 静态 SSR 脚本
/// onLoad 将在脚本添加到页面时调用。
/// onUpdate 将在增强型更新后脚本仍存在于页面时调用。
/// onDispose 将在增强型更新后从页面删除脚本时调用。
/// </summary>
public sealed class CdsScript : CdsElementBase
{
    [Parameter]
    public string? Src { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    void BuildContent(RenderTreeBuilder builder)
    {
        if (ChildContent is null)
            return;

        builder
            .OpenElementAnd(3, "template")
            .SetContent(4, ChildContent)
            .CloseElement();
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
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
