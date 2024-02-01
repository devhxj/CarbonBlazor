using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CarbonBlazor;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TABLE_SORT_DIRECTION
{
    [Description("none")]
    NONE,

    [Description("ascending")]
    ASCENDING,

    [Description("descending")]
    DESCENDING,
}