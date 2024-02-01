using System.ComponentModel;

namespace CarbonBlazor;

/// <summary>
/// Notification types.
/// </summary>
public enum NOTIFICATION_TYPE
{
    [Description("inline")]
    INLINE,

    [Description("toast")]
    TOAST,

    [Description("actionable")]
    ACTIONABLE,
}

