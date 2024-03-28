namespace MinWebDev.Data;

public class SkillExperienceDao : BaseDao, ISkillExperienceDao
{
    public SkillExperienceDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.SkillExperience[] GetSkillExperiences(Guid candidateId)
    {
        
        var skillExperiences = this.dbContext.SkillExperiences
            .Where(sa => sa.CandidateId == candidateId)
            .OrderByDescending(sa => sa.Years)
            .ToArray();

        return skillExperiences
            .Select((se => new MinWebDev.SkillExperience
            {
                Id = se.Id,
                Skill = se.Skill,
                Years = se.Years
            }))
            .ToArray();
    }
}
