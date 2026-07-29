namespace Portal.GenOperation.Documents;

public sealed class ExcelHelper : IExcelHelper
{
    public byte[] ExportToExcel<T>(IEnumerable<T> rows, string sheetName) =>
        throw new NotImplementedException("Excel export is not implemented. Add the ClosedXML package and implement this method when a real xlsx export is needed.");
}
