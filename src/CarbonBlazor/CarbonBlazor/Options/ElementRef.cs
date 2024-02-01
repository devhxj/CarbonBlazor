namespace CarbonBlazor;

/// <summary>
/// 
/// </summary>
/// <param name="Selecter">选择器</param>
public record ElementRef(string Selecter)
{
    public override string ToString() => $"javascript:document.querySelector('{Selecter}')";
}
