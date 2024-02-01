namespace CarbonBlazor.Generator;
public class CarbonTag
{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public string? Description { get; set; }
    public CarbonProp[] Attributes { get; set; } = [];
    public CarbonProp[] Properties { get; set; } = [];
    public CarbonItem[] Events { get; set; } = [];
    public CarbonItem[] CssParts { get; set; } = [];
    public CarbonItem[] Slots { get; set; } = [];
}
