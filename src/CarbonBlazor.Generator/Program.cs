﻿// See https://aka.ms/new-console-template for more information
using CarbonBlazor.Generator;
using System.Collections.Generic;
using System;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");

const string ManifestJsonPath = @".\custom-elements.json";
const string RootDir = @"D:\repository\own\enjouauth\CarbonBlazor\";

var components = Path.Combine(RootDir, "Components");

var json = File.ReadAllText(ManifestJsonPath);
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};
var cds = JsonSerializer.Deserialize<CarbonJson>(json, options);
var builder = new StringBuilder();

if (!Directory.Exists(components)) 
    Directory.CreateDirectory(components);

var dic = new Dictionary<string, string>();
foreach (var d in new DirectoryInfo(components).GetDirectories())
{
    foreach (var f in d.GetFiles())
    {
        dic.Add(f.Name.Replace(".cs", string.Empty), d.Name);
    }
}

if (cds?.Tags.Length > 0)
{
    foreach (var tag in cds.Tags)
    {
        var className = FormatName(tag.Name);
        if (string.IsNullOrWhiteSpace(className))
            continue;

        var fileName = className.Replace("Cds", "");
        var outdir = Path.Combine(RootDir, "Components", fileName);

        if (dic.TryGetValue(className, out var floder))
            outdir = Path.Combine(RootDir, "Components", floder);
        
        if (!Directory.Exists(outdir))
            Directory.CreateDirectory(outdir);

        builder.Clear();
        if (tag.Slots.Length > 0)
        {
            builder.AppendLine();
            builder.AppendLine($"public class {fileName}Context");
            builder.Append("{");
            foreach (var slot in tag.Slots)
            {
                builder.AppendLine();
                if (!string.IsNullOrWhiteSpace(slot.Description))
                {
                    builder.AppendLine("    /// <summary>");
                    builder.AppendLine($@"    /// {slot.Description.Replace("\n", "\n    /// ").Replace("<", "&lt;").Replace(">", "&gt;")}");
                    builder.AppendLine("    /// </summary>");
                }

                var slotName = FormatName(slot.Name?.Replace(".", ""));
                builder.AppendLine($"    public string {slotName}Slot = \"{slot.Name?.Replace(".", "")}\";");
            }
            builder.AppendLine("}").AppendLine();
            builder.AppendLine($"public class {className} : BaseComponent<{fileName}Context>");
        }
        else
            builder.AppendLine($"public class {className} : BaseComponent");

        builder.AppendLine("{");

        var cultureInfo = false;
        var tdic = new Dictionary<string, (string T,string V)>();

        foreach (var prop in tag.Properties)
        {
            var n = FormatName(prop.Name);

            if (string.IsNullOrWhiteSpace(n) || n == "Title" || n == "Role" || n == "AriaLabel" || n == "TabIndex" || n == "Id")
                continue;

            var t = prop.Type?.Replace(" | undefined", "");
            var v = string.Empty;

            if (prop.Type == "boolean")
                t = "bool?";
            else if (prop.Type == "number" || prop.Type == "number | null")
                t = "int?";
            else if (prop.Type?.Contains("Locale") == true)
                t = "CultureInfo?";
            else if (prop.Type == "string | undefined")
                t = "string?";
            else if (prop.Type == "array" || prop.DefaultValue == "[]")
                t = "string[]?";
            if (string.IsNullOrWhiteSpace(t) || t == "string")
                t = "string?";



            var ttt = prop.Type?.Replace(" | undefined", "");
            if (!string.IsNullOrWhiteSpace(ttt) && char.IsUpper(ttt[^1]))
            {
                var vv = prop.DefaultValue?.Trim('"');

                if (prop.DefaultValue == "\"\"")
                    vv = "DEFAULT";

                if (!string.IsNullOrWhiteSpace(prop.DefaultValue?.Replace("\"", "")))
                    v = $" = {ttt}.{vv?.Replace('-','_').ToUpperInvariant()};";
            }
            var isFunc = prop.Type?.Contains(" => ") == true;
            var isEl = prop.Type == "HTMLInputElement" ||
                prop.Type?.Contains("Instance") == true ||
                prop.Type == "CDSOverflowMenuItem | null";

            var hasV = !string.IsNullOrWhiteSpace(prop.DefaultValue?.Replace("\"", ""));

            if (!string.IsNullOrWhiteSpace(prop.Description))
            {
                builder.AppendLine("    /// <summary>");
                builder.AppendLine($@"    /// {prop.Description.Replace("\n", "\n    /// ").Replace("<", "&lt;").Replace(">", "&gt;")}");
                if (isFunc || isEl)
                    builder.AppendLine($@"    /// <para><b>Type : {prop.Type}</b></para>");
                if (hasV)
                    builder.AppendLine($@"    /// <para><b>DefaultValue : {prop.DefaultValue}</b></para>");
                builder.AppendLine("    /// </summary>");
            }
            else if (isFunc || isEl || hasV)
            {
                builder.AppendLine("    /// <summary>");
                if (isFunc || isEl)
                    builder.AppendLine($@"    /// <para><b>Type : {prop.Type}</b></para>");
                if (hasV)
                    builder.AppendLine($@"    /// <para><b>DefaultValue : {prop.DefaultValue}</b></para>");
                builder.AppendLine("    /// </summary>");
            }

            if (prop.Name == "shadowRootOptions")
                t = "ShadowRootOptions?";

            if (prop.Type?.Contains("floatingMenuPosition", StringComparison.InvariantCultureIgnoreCase) == true)
                t = "FloatingMenuPosition?";

            if (prop.Name == "TABLE_SORT_CYCLES")
                t = "TableSortCycles?";

            if (isFunc)
            {
                t = "string?";
            }
            else if (prop.Type == "CDSOverflowMenuItem | null")
                t = "CdsOverflowMenuItem?";
            else if (isEl)
            {
                t = "ElementRef?";
            }

            if (prop.Type?.Contains("Set<") == true)
            {
                var tt = prop.Type.Replace("Set<", "").Replace(">", "").Trim();
                t = $"{tt}[]";
                if (!string.IsNullOrWhiteSpace(prop.DefaultValue?.Replace("\"", "")))
                    v = $" = {prop.DefaultValue?.Replace("\"", "").Replace("new Set([", "[").Replace("])", "]").Replace("'","\"")};";
            }

            if (prop.Type?.Contains("Locale") == true && prop.DefaultValue?.Replace("\"", "") == "default")
            {
                v = " = CultureInfo.CurrentCulture;";
                cultureInfo = true;
            }

            tdic.Add(n, (t, v));
            builder.AppendLine($"    [Parameter]").AppendLine($"    public {t} {n} {{ get; set; }}{v}").AppendLine();
        }

        if (className == "CdsModalFooterButton")
            builder.AppendLine("    [Parameter]").AppendLine("    public bool Closeable { get; set; }").AppendLine();

        var i = 0;
        builder.AppendLine(@$"    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {{
        builder
            .OpenElementAnd({i++}, ""{tag.Name}"")
            .SetAttribute({i++}, ""id"", Id)
            .SetAttributeNotNull({i++}, ""title"", Title)
            .SetAttributeNotNull({i++}, ""tabindex"", TabIndex)
            .SetAttributeNotNull({i++}, ""role"", Role)
            .SetAttributeNotNull({i++}, ""aria-label"", AriaLabel)");

        if (className == "CdsModalFooterButton")
            builder.AppendLine($"            .SetAttributeIf({i++}, \"data-modal-close\", Closeable)");

        if (className == "CdsModal")
            builder.AppendLine($"            .SetAttribute({i++}, \"hidden\")");

        foreach (var prop in tag.Properties)
        {
            var n = FormatName(prop.Name);
            if (n == "Title" || n == "Role" || n == "AriaLabel" || n == "TabIndex" || n == "Id")
                continue;

            if (string.IsNullOrWhiteSpace(prop.DefaultValue)
                || (n == "Styles")
                || (n == "ShadowRootOptions")
                || (n == "TABLE_SORT_CYCLES")
                || (n == "TRIGGER_KEYS")
                || (tdic.AsEnumerable().Any(x => x.Key == n && string.IsNullOrWhiteSpace(x.Value.V))))
            {

                var v = prop.Attribute ?? prop.Name?.ToLower();
                if (n == "ShadowRootOptions")
                    v = "shadowRootOptions";
                if (n == "TABLE_SORT_CYCLES")
                    v = "TABLE_SORT_CYCLES";

                builder.AppendLine($"            .SetAttributeNotNull({i}, \"{v}\", {FormatName(prop.Name)})");
            }
            else
                builder.AppendLine($"            .SetAttribute({i}, \"{prop.Attribute}\", {FormatName(prop.Name)})");
            i++;
        }
        builder.AppendLine(@$"            .SetAttributes({i++}, AdditionalAttributes)
            .SetContent({i++}, ChildContent{(tag.Slots.Length>0?$", new()":"")})
            .CloseElement();
    }}").AppendLine("}").AppendLine();

        builder.Insert(0, @"using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
");

        if (cultureInfo) builder.Insert(0, @"using System.Globalization;
");

        File.WriteAllText(Path.Combine(outdir, $"{className}.cs"), builder.ToString());
    }
}

Console.WriteLine("complete");
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