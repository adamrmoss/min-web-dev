namespace MinWebDev.Data;

public interface ISkillExperienceDao
{
    MinWebDev.SkillExperience[] GetSkillExperiences(Guid candidateId);
}
