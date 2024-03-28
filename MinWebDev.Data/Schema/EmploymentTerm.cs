using System.ComponentModel.DataAnnotations.Schema;

namespace MinWebDev.Data;

[Table("EmploymentTerm")]
internal class EmploymentTerm
{
    public required Guid Id { get; set; }
    public required Guid CandidateId { get; set; }
    public required string Employer { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime? EndDate { get; set; }
    public required string JobTitle { get; set; }
}
