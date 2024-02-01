using System.ComponentModel;

namespace CarbonBlazor;

public enum NUMBER_INPUT_VALIDATION_STATUS
{
    [Description("exceeded_maximum")]
    EXCEEDED_MAXIMUM,

    [Description("exceeded_minimum")]
    EXCEEDED_MINIMUM,
}

