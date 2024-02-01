using System.Text.Json;
using System.Text.Json.Serialization;

namespace CarbonBlazor;

public record struct TableSortCycles(
    [property: JsonPropertyName("bi-states-from-ascending")] TABLE_SORT_DIRECTION[] BiStatesFromAscending,
    [property: JsonPropertyName("bi-states-from-descending")] TABLE_SORT_DIRECTION[] BiStatesFromDescending,
    [property: JsonPropertyName("tri-states-from-ascending")] TABLE_SORT_DIRECTION[] TriStatesFromAscending,
    [property: JsonPropertyName("tri-states-from-descending")] TABLE_SORT_DIRECTION[] TriStatesFromDescending)
{
    public TableSortCycles() : this(
        [TABLE_SORT_DIRECTION.ASCENDING, TABLE_SORT_DIRECTION.DESCENDING],
        [TABLE_SORT_DIRECTION.DESCENDING, TABLE_SORT_DIRECTION.ASCENDING],
        [TABLE_SORT_DIRECTION.NONE, TABLE_SORT_DIRECTION.ASCENDING, TABLE_SORT_DIRECTION.DESCENDING],
        [TABLE_SORT_DIRECTION.NONE, TABLE_SORT_DIRECTION.DESCENDING, TABLE_SORT_DIRECTION.ASCENDING])
    {
    }

    public override readonly string ToString() => JsonSerializer.Serialize(this);
}
