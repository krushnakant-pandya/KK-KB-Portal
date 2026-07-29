namespace Portal.GenOperation.Documents;

/// <summary>
/// <para>Placeholder for exporting tabular data (e.g. article/user lists) to .xlsx.</para>
/// <remarks>Not implemented — wire up ClosedXML when this is needed.</remarks>
/// </summary>
public interface IExcelHelper
{
    byte[] ExportToExcel<T>(IEnumerable<T> rows, string sheetName);
}
