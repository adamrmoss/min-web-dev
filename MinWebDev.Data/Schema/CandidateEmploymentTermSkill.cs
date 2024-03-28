using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

[Table("CandidateEmploymentTermSkill"), Keyless]
internal class CandidateEmploymentTermSkill
{
    public required Guid CandidateId { get; set; }
    public required Guid EmploymentTermId { get; set; }
    public required Guid EmploymentTermSkillId { get; set; }
    public required string Skill { get; set; }
}
