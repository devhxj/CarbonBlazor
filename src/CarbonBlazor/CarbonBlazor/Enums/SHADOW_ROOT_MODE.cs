using System.Text.Json.Serialization;

namespace CarbonBlazor;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SHADOW_ROOT_MODE
{
    OPEN,
    CLOSED
}
