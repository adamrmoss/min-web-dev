using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

[Table("CandidateEmploymentTermBulletPoint"), Keyless]
internal class CandidateEmploymentTermBulletPoint
{
    public required Guid CandidateId { get; set; }
    public required Guid EmploymentTermId { get; set; }
    public required Guid EmploymentTermBulletPointId { get; set; }
    public required string BulletPoint { get; set; }
}
