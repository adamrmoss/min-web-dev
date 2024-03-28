namespace MinWebDev;

public class EmploymentTerm
{
    public required string Employer { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime? EndDate { get; set; }
    public required string JobTitle { get; set; }
    public required string[] Skills { get; set; }
    public required string[] BulletPoints { get; set; }
}
