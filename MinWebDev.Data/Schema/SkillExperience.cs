namespace MinWebDev.Data;

internal class SkillExperience
{
    public required Guid Id { get; set; }
    public required Guid CandidateId { get; set; }
    public required string Skill { get; set; }
    public required int Years { get; set; }
}
