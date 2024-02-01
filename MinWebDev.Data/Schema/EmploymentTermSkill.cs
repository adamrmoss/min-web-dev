namespace MinWebDev.Data;

internal class EmploymentTermSkill
{
    public required Guid Id { get; set; }
    public required Guid EmploymentTermId { get; set; }
    public required string Skill { get; set; }
}
