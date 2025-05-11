using CustomReportGenerationCentralizer.Application.Enum;

namespace CustomReportGenerationCentralizer.Presentation.DTOs.Request;

public class ReportRequestDto
{
    public ReportType ReportType { get; set; } = ReportType.Invalid;
    public List<string> Parameters { get; set; } = [];
}