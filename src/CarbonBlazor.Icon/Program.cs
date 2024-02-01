// See https://aka.ms/new-console-template for more information
using CarbonBlazor.Icon;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");

const string ManifestJsonPath = @".\metadata.json";
const string RootDir = @"D:\repository\own\enjouauth\CarbonBlazor\";

var icons = Path.Combine(RootDir, @"Options");

var json = File.ReadAllText(ManifestJsonPath);
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};
var cds = JsonSerializer.Deserialize<CdsIconMetaData>(json, options);

var builder = new StringBuilder();
var metaData = new List<string>();
if (!Directory.Exists(icons))
    Directory.CreateDirectory(icons);

builder.AppendLine(@$"
namespace CarbonBlazor;

public static class CdsIcon
{{");


foreach (var item in cds!.Icons.OrderBy(x=>x.Category).ThenBy(x=>x.Subcategory))
{
    var c = item.NamespaceValue.Length > 0 ? item.NamespaceValue[0] : "Cds";
    var className = FormatName(item.NamespaceValue.Length > 0 ? (item.NamespaceValue[0] + "-" + item.Name) : item.Name)?.Replace('?', '_');
    if (className?.StartsWith("4") == true)
        className = "S" + className;

    foreach (var ss in item.ModuleInfo!.sizes)
    {
        if (ss.size.ToString() == "glyph")
            continue;

        var sn = className + "_" + ss.size;
        var b = new StringBuilder();
        foreach (var ast in ss.ast.children)
        {
            b.Append($"<{ast.tagName}");
            if (!string.IsNullOrWhiteSpace(ast.attributes.d)) b.Append($" d=\'{ast.attributes.d}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.cx)) b.Append($" cx=\'{ast.attributes.cx}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.cy)) b.Append($" cy=\'{ast.attributes.cy}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.r)) b.Append($" r=\'{ast.attributes.r}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.fill)) b.Append($" fill=\'{ast.attributes.fill}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.dataiconpath)) b.Append($" dataiconpath=\'{ast.attributes.dataiconpath}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.strokewidth)) b.Append($" strokewidth=\'{ast.attributes.strokewidth}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.fillrule)) b.Append($" fillrule=\'{ast.attributes.fillrule}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.transform)) b.Append($" transform=\'{ast.attributes.transform}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.width)) b.Append($" width=\'{ast.attributes.width}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.height)) b.Append($" height=\'{ast.attributes.height}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.x)) b.Append($" x=\'{ast.attributes.x}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.y)) b.Append($" y=\'{ast.attributes.y}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.rx)) b.Append($" rx=\'{ast.attributes.rx}\'");
            if (!string.IsNullOrWhiteSpace(ast.attributes.opacity)) b.Append($" opacity=\'{ast.attributes.opacity}\'");
            if (ast.children.Length > 0)
            {
                b.Append($">");
                foreach (var ast1 in ast.children)
                {
                    b.Append($"<{ast1.tagName}");
                    if (ast1.children.Length > 0)
                    {
                        b.Append($">");
                        foreach (var ast2 in ast1.children)
                        {
                            b.Append($"<{ast2.tagName}");
                            if (!string.IsNullOrWhiteSpace(ast2.attributes.d)) b.Append($" d=\'{ast2.attributes.d}\'");
                            if (!string.IsNullOrWhiteSpace(ast2.attributes.cx)) b.Append($" cx=\'{ast2.attributes.cx}\'");
                            if (!string.IsNullOrWhiteSpace(ast2.attributes.cy)) b.Append($" cy=\'{ast2.attributes.cy}\'");
                            if (!string.IsNullOrWhiteSpace(ast2.attributes.r)) b.Append($" r=\'{ast2.attributes.r}\'");
                            if (!string.IsNullOrWhiteSpace(ast2.attributes.transform)) b.Append($" transform=\'{ast2.attributes.transform}\'");
                            if (ast2.children.Length > 0)
                            {
                                b.Append($">");
                                b.Append("hxj");
                                b.Append($"</{ast2.tagName}>");
                            }
                            else b.Append($"/>");
                        }
                        b.Append($"</{ast1.tagName}>");
                    }
                    else b.Append($"/>");
                }
                b.Append($"</{ast.tagName}>");
            }
            else
                b.Append($"/>");
        }

        builder.AppendLine($"    public const string {sn} = @\"{b.ToString()}\";");
        metaData.Add($"(\"{item.Category}\", \"{item.Subcategory}\", {ss.size}, {sn})");
    }
}

builder.AppendLine("    public static (string Category, string SubCategory, int Size, string Content)[] MetaData() => [");
metaData.ForEach(x => builder.AppendLine($"        {x},"));
builder.AppendLine("    ];");

builder.AppendLine($@"}}");

File.WriteAllText(Path.Combine(icons, "CdsIcon.cs"), builder.ToString());

Console.WriteLine("completed");
Console.ReadLine();


static string? FormatName(string? s)
{
    if (string.IsNullOrWhiteSpace(s))
        return null;

    return string.Join("", s.Split('-').SelectMany(x =>
    {
        if (x.Length > 1)
            return char.ToUpper(x[0]).ToString() + x[1..];
        else if (x.Length == 1)
            return char.ToUpper(x[0]).ToString();
        else
            return "?";
    }));
}