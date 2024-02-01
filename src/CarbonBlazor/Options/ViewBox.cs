namespace CarbonBlazor;

/// <summary>
/// viewBox 属性允许指定一个给定的一组图形伸展以适应特定的容器元素。
/// viewBox 属性的值是一个包含 4 个参数的列表 min-x, min-y, width and height，以空格或者逗号分隔开，在用户空间中指定一个矩形区域映射到给定的元素，查看属性preserveAspectRatio。
/// 不允许宽度和高度为负值，0 则禁用元素的呈现。
/// </summary>
/// <param name="MinX"></param>
/// <param name="MinY"></param>
/// <param name="Width"></param>
/// <param name="Height"></param>
public record struct ViewBox(int MinX, int MinY, int Width, int Height)
{
    public static implicit operator ViewBox(int size) => new(0, 0, size, size);
    public override readonly string ToString() => $"{MinX},{MinY},{Math.Max(0, Width)},{Math.Max(0, Height)}";
}