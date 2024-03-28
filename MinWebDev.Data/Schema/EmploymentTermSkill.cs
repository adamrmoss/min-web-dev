using System.ComponentModel.DataAnnotations.Schema;

namespace MinWebDev.Data;

[Table("EmploymentTermSkill")]
internal class EmploymentTermSkill
{
    public required Guid Id { get; set; }
    public required Guid EmploymentTermId { get; set; }
    public required string Skill { get; set; }
}
