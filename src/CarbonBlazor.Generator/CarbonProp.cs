using System.Text.Json.Serialization;

namespace CarbonBlazor.Generator;

public class CarbonProp: CarbonItem
{
    public string? Type { get; set; }

    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    [JsonPropertyName("default")]
    public string? DefaultValue { get; set; }
}
