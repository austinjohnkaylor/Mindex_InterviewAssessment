using CodeChallenge.Models;
using CodeChallenge.Repositories;

namespace CodeChallenge.Services;

/// <inheritdoc/>
public class ReportingStructureService : IReportingStructureService
{
    private readonly IEmployeeRepository _employeeRepository;

    public ReportingStructureService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    public ReportingStructure GetById(string id)
    {
        if (string.IsNullOrEmpty(id))
            return null;
        
        var employee = _employeeRepository.GetById(id);
        return new ReportingStructure
        {
            Employee = employee
        };
    }
}