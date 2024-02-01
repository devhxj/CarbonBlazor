using System.Text.Json.Serialization;

namespace CarbonBlazor.Generator;


public class CdsIconMetaData
{
    public CdsIcon[] Icons { get; set; } = [];

    public CdsIconCategory[] Categories { get; set; } = [];
}


public class CdsIcon
{
    public string? Name { get; set; }
    public string? FriendlyName { get; set; }
    public string[] Aliases { get; set; } = [];
    public object[] Sizes { get; set; } = [];

    [JsonPropertyName("namespace")]
    public string[] NamespaceValue { get; set; } = [];
    public CdsIconAsset[] Assets { get; set; } = [];
    public CdsIconOutput[] Output { get; set; } = [];
    public string? Category { get; set; }
    public string? Subcategory { get; set; }
    public CdsIconModuleinfo? ModuleInfo { get; set; }
    public bool Deprecated { get; set; }
    public string? Reason { get; set; }
}

public class CdsIconModuleinfo
{
    public string local { get; set; }
    public string global { get; set; }
    public string filepath { get; set; }
    public CdsIconSize[] sizes { get; set; }
}

public class CdsIconSize
{
    public object size { get; set; }
    public CdsIconAst ast { get; set; }
}

public class CdsIconAst
{
    public string type { get; set; }
    public string tagName { get; set; }
    public Attributes attributes { get; set; }
    public Child[] children { get; set; }
}



public class Attributes
{
    public string xmlns { get; set; }
    public string viewBox { get; set; }
    public string fill { get; set; }
}

public class Child
{
    public string type { get; set; }
    public string tagName { get; set; }
    public Attributes1 attributes { get; set; }
    public Child1[] children { get; set; }
}

public class Attributes1
{
    public string d { get; set; }
    public string cx { get; set; }
    public string cy { get; set; }
    public string r { get; set; }
    public string fill { get; set; }
    public string dataiconpath { get; set; }
    public string strokewidth { get; set; }
    public string fillrule { get; set; }
    public string transform { get; set; }
    public string width { get; set; }
    public string height { get; set; }
    public string x { get; set; }
    public string y { get; set; }
    public string rx { get; set; }
    public string opacity { get; set; }
}

public class Child1
{
    public string type { get; set; }
    public string tagName { get; set; }
    public Attributes2 attributes { get; set; }
    public Child2[] children { get; set; }
}

public class Attributes2
{
}

public class Child2
{
    public string type { get; set; }
    public string tagName { get; set; }
    public Attributes3 attributes { get; set; }
    public object[] children { get; set; }
}

public class Attributes3
{
    public string d { get; set; }
    public string transform { get; set; }
    public string cx { get; set; }
    public string cy { get; set; }
    public string r { get; set; }
}




public class CdsIconAsset
{
    public object size { get; set; }
    public string filepath { get; set; }
    public string source { get; set; }
    public CdsIconOptimized optimized { get; set; }
}

public class CdsIconOptimized
{
    public string data { get; set; }
    public CdsIconInfo info { get; set; }
    public string path { get; set; }
}

public class CdsIconInfo
{
}

public class CdsIconOutput
{
    public string moduleName { get; set; }
    public string filepath { get; set; }
    public CdsIconDescriptor descriptor { get; set; }
    public object size { get; set; }
}

public class CdsIconDescriptor
{
    public string elem { get; set; }
    public Attrs attrs { get; set; }
    public Content[] content { get; set; }
    public string name { get; set; }
    public object size { get; set; }
}



public class Attrs
{
    public string xmlns { get; set; }
    public string viewBox { get; set; }
    public string fill { get; set; }
    public object width { get; set; }
    public object height { get; set; }
}

public class Content
{
    public string elem { get; set; }
    public Attrs1 attrs { get; set; }
    public Content1[] content { get; set; }
}

public class Attrs1
{
    public string d { get; set; }
    public string cx { get; set; }
    public string cy { get; set; }
    public string r { get; set; }
    public string fill { get; set; }
    public string dataiconpath { get; set; }
    public string strokewidth { get; set; }
    public string fillrule { get; set; }
    public string transform { get; set; }
    public string width { get; set; }
    public string height { get; set; }
    public string x { get; set; }
    public string y { get; set; }
    public string rx { get; set; }
    public string opacity { get; set; }
}

public class Content1
{
    public string elem { get; set; }
    public Attrs2 attrs { get; set; }
    public Content2[] content { get; set; }
}

public class Attrs2
{
}

public class Content2
{
    public string elem { get; set; }
    public Attrs3 attrs { get; set; }
}

public class Attrs3
{
    public string d { get; set; }
    public string transform { get; set; }
    public string cx { get; set; }
    public string cy { get; set; }
    public string r { get; set; }
}



public class CdsIconCategory
{
    public string name { get; set; }
    public CdsIconSubcategory[] subcategories { get; set; }
}

public class CdsIconSubcategory
{
    public string? Name { get; set; }

    public string[]? Members { get; set; }
}
