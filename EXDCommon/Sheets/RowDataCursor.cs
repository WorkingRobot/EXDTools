using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace EXDCommon.Sheets;

// From Lumina

/// <summary>
/// A 'cursor' that points to the current row offset and which file the row is in
/// </summary>
public record struct RowDataCursor
{
    public ExcelDataFile SheetPage;
    public ExcelDataOffset RowOffset;
}