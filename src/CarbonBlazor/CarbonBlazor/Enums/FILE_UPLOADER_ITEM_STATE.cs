using System.ComponentModel;

namespace CarbonBlazor;

public enum FILE_UPLOADER_ITEM_STATE
{
    [Description("uploading")]
    UPLOADING,

    [Description("complete")]
    COMPLETE,

    [Description("edit")]
    EDIT,
}

