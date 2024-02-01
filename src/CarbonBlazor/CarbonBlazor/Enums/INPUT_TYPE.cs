using System.ComponentModel;

namespace CarbonBlazor;

public enum INPUT_TYPE
{
    [Description("email")]
    EMAIL,

    [Description("password")]
    PASSWORD,

    [Description("tel")]
    TEL,

    [Description("text")]
    TEXT,

    [Description("url")]
    URL,
}

