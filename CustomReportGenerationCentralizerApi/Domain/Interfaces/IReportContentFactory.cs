namespace CustomReportGenerationCentralizer.Domain.Interfaces;

public interface IReportContentFactory
{
    IReportContent CreateContent(Dictionary<string, string> parameters);
}