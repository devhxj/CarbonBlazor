using System.Text.Json;
using System.Text.Json.Serialization;

namespace CarbonBlazor;

public record struct ShadowRootOptions([property: JsonPropertyName("delegatesFocus")] bool DelegatesFocus,
                                       [property: JsonPropertyName("mode")] SHADOW_ROOT_MODE Mode)
{
    public override readonly string ToString() => JsonSerializer.Serialize(this);
}
