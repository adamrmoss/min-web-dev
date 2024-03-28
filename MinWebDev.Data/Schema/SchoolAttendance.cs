using System.ComponentModel.DataAnnotations.Schema;

namespace MinWebDev.Data;

[Table("SchoolAttendance")]
internal class SchoolAttendance
{
    public required Guid Id { get; set; }
    public required Guid CandidateId { get; set; }
    public required string School { get; set; }
    public required string Degree { get; set; }
    public required int GraduationYear { get; set; }
}
