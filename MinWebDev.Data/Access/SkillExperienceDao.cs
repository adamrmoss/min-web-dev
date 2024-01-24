namespace MinWebDev.Data;

public class SkillExperienceDao : BaseDao, ISkillExperienceDao
{
    public SkillExperienceDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.SkillExperience[] GetSkillExperiences()
    {
        return new[] {
            new MinWebDev.SkillExperience {
                Id = new Guid("e71babe1-262f-42b8-8daf-035e261ba03a"),
                Skill = "C++",
                Years = 4,
            },
            new MinWebDev.SkillExperience {
                Id = new Guid("2b041e3d-4762-449e-bfdf-55177e78f171"),
                Skill = "C♯ / .NET",
                Years = 2,
            },
            new MinWebDev.SkillExperience {
                Id = new Guid("dbc1d795-8193-4c78-847c-50b85ba6e308"),
                Skill = "SQL Server",
                Years = 2,
            },
            new MinWebDev.SkillExperience {
                Id = new Guid("fdf5bd66-cae1-4061-9628-4cfac3bf0563"),
                Skill = "Javascript / Typescript",
                Years = 2,
            },
            new MinWebDev.SkillExperience {
                Id = new Guid("8e97c4c3-91a3-47bb-847b-eb886cb82018"),
                Skill = "HTML",
                Years = 2,
            },
            new MinWebDev.SkillExperience {
                Id = new Guid("08a5a336-09e6-4e67-b764-874f5fb47880"),
                Skill = "React",
                Years = 1,
            },
        };
    }
}
