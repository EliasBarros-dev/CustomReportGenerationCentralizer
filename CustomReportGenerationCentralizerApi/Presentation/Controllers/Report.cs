using CustomReportGenerationCentralizer.Presentation.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace CustomReportGenerationCentralizer.Presentation.Controllers;

public class Report : Controller
{
    [HttpGet("export")]
    public IActionResult Index(ReportRequestDto requestDto)
    {
        return View();
    }
}