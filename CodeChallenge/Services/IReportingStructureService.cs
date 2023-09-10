using CodeChallenge.Models;

namespace CodeChallenge.Services;

public interface IReportingStructureService
{
    /// <summary>
    /// Get the reporting structure for a given <see cref="Employee"/> by their GUID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    ReportingStructure GetById(string id);
}