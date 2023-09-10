using CodeChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodeChallenge.Controllers;

[ApiController]
[Route("api/employee/{id}/reporting-structure")]
public class ReportingStructureController : ControllerBase
{
    private readonly ILogger<ReportingStructureController> _logger;
    private readonly IReportingStructureService _reportingStructureService;

    public ReportingStructureController(ILogger<ReportingStructureController> logger, IReportingStructureService reportingStructureService)
    {
        _logger = logger;
        _reportingStructureService = reportingStructureService;
    }

    [HttpGet]
    public IActionResult GetReportingStructure(string id)
    { 
        _logger.LogDebug($"Received employee reporting structure get request for '{id}'");

        var reportingStructure = _reportingStructureService.GetById(id);

        if (reportingStructure == null)
            return NotFound();

        return Ok(reportingStructure);
    }
}