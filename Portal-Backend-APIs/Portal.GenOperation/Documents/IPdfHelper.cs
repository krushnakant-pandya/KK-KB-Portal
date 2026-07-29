namespace Portal.GenOperation.Documents;

/// <summary>
/// <para>Placeholder for rendering KB pages / articles to PDF.</para>
/// <remarks>Not implemented — wire up QuestPDF when this is needed.</remarks>
/// </summary>
public interface IPdfHelper
{
    byte[] GeneratePdf(string title, string htmlContent);
}
