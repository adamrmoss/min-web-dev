namespace MinWebDev.Data;

public class EmploymentTerm
{
    public required Guid Id { get; set; }
    public required string Employer { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime? EndDate { get; set; }
    public required string JobTitle { get; set; }
}
