namespace Portal.GenOperation.Documents;

public sealed class PdfHelper : IPdfHelper
{
    public byte[] GeneratePdf(string title, string htmlContent) =>
        throw new NotImplementedException("PDF generation is not implemented. Add the QuestPDF package and implement this method when real PDF export is needed.");
}
