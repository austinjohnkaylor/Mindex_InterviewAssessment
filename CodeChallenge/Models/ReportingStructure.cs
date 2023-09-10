namespace CodeChallenge.Models;

/// <summary>
/// Model used to define an employees direct and indirect reports
/// </summary>
public class ReportingStructure
{
    public Employee Employee { get; set; }
    public int NumberOfReports => Employee.DirectReports.Count;
}