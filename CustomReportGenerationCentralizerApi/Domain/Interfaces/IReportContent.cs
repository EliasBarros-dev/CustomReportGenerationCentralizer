namespace CustomReportGenerationCentralizer.Domain.Interfaces;

public interface IReportContent
{
    string Title { get; }
    List<string> Headers { get; }
    List<List<string>> Rows { get; }
}