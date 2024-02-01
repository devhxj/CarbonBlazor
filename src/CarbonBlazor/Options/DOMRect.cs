using System.Text.Json;
using System.Text.Json.Serialization;

namespace CarbonBlazor;

/// <summary>
/// DOM矩形
/// </summary>
/// <param name="X">x 坐标</param>
/// <param name="Y">y 坐标</param>
/// <param name="Width">宽度</param>
/// <param name="Height">高度</param>
/// <param name="Top">顶坐标值（与 y 具有相同的值，如果 height 为负值，则为 y + height 的值）。</param>
/// <param name="Right">右坐标值（与 x + width 具有相同的值，如果width 为负值，则为 x 的值）。</param>
/// <param name="Bottom">底坐标值（与 y + height 具有相同的值，如果 height 为负值，则为 y 的值）。</param>
/// <param name="Left">返回 DOMRect 的左坐标值（与 x 具有相同的值，如果 width 为负值，则为 x + width 的值）。</param>
public record struct DOMRect([property: JsonPropertyName("x")] int X,
                             [property: JsonPropertyName("y")] int Y,
                             [property: JsonPropertyName("width")] int Width,
                             [property: JsonPropertyName("height")] int Height,
                             [property: JsonPropertyName("top")] int Top,
                             [property: JsonPropertyName("right")] int Right,
                             [property: JsonPropertyName("bottom")] int Bottom,
                             [property: JsonPropertyName("left")] int Left)
{
    public override readonly string ToString() => JsonSerializer.Serialize(this);
}