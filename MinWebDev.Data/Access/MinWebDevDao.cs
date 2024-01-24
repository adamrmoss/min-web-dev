using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

public class MinWebDevDao : IMinWebDevDao
{
    private readonly MinWebDevDbContext dbContext;

    public MinWebDevDao(MinWebDevDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
    public MinWebDev.Candidate GetCandidate()
    {
        return new MinWebDev.Candidate {
            Id = new Guid("4e1b3dde-5dcc-4816-9a51-f413b8506d33"),
            Name = "Amir Lewis",
            Tagline = "Enthusiastic <b>Full-Stack Web Developer</b> with a passion for crafting elegant and efficient web solutions",
        };
    }

    public MinWebDev.SchoolAttendance[] GetSchoolAttendances()
    {
        return new[] {
            new MinWebDev.SchoolAttendance {
                Id = new Guid("391ca3c0-c07f-4572-a6db-e13dfe9ae163"),
                School = "North Atlanta High School",
                Degree = "High School Diploma",
                GraduationYear = 2016
            },
            new MinWebDev.SchoolAttendance {
                Id = new Guid("6382c3bb-f502-42f5-9fa0-ec0572724750"),
                School = "Howard University",
                Degree = "B.S. Computer Engineering",
                GraduationYear = 2020
            },
        };
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

    public MinWebDev.EmploymentTerm[] GetEmploymentTerms()
    {
        return new[] {
            new MinWebDev.EmploymentTerm {
                Id = new Guid("168680ca-6ec3-47ab-989c-b9ec00fe357f"),
                Employer = "Six Flags",
                StartDate = new DateTime(2014, 5, 1),
                EndDate = new DateTime(2017, 8, 1),
                JobTitle = "Ride Operator",
                Skills = Array.Empty<string>(),
                BulletPoints = new[] {
                    "Operated amusement park rides, ensuring visitor safety and enjoyment",
                    "Developed strong communication and teamwork skills during high-demand periods"
                },
            },
            new MinWebDev.EmploymentTerm {
                Id = new Guid("b6550495-918e-4dac-b8e6-0243a0f21f21"),
                Employer = "Howard University",
                StartDate = new DateTime(2017, 9, 1),
                EndDate = new DateTime(2019, 12, 1),
                JobTitle = "Electrical Engineering Lab Assistant",
                Skills = new[] {
                    "C++",
                },
                BulletPoints = new[] {
                    "Assisted students in the electrical engineering lab, providing guidance on experiments and equipment usage",
                    "Helped maintain lab equipment and ensured a safe and organized environment for students",
                },
            },
            new MinWebDev.EmploymentTerm {
                Id = new Guid("53aa6c77-82cf-4def-91f2-e74609329152"),
                Employer = "Atlanta PowerTech",
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2020, 5, 1),
                JobTitle = "Electrical Engineer Intern",
                Skills = new[] {
                    "C++",
                },
                BulletPoints = new[] {
                    "Assisted senior engineers in electrical design and testing of power distribution systems",
                    "Conducted research on energy efficiency and contributed to the development of sustainable energy solutions",
                    "Gained hands-on experience in electrical engineering practices and safety standards",
                },
            },
            new MinWebDev.EmploymentTerm {
                Id = new Guid("64425184-85e7-46ae-8352-4097fd9f1ea9"),
                Employer = "WebDev Co.",
                StartDate = new DateTime(2020, 6, 1),
                EndDate = new DateTime(2020, 12, 1),
                JobTitle = "Junior Developer",
                Skills = new[] {
                    "Javascript / Typescript",
                    "HTML",
                },
                BulletPoints = new[] {
                    "Assisted senior engineers in electrical design and testing of power distribution systems",
                    "Conducted research on energy efficiency and contributed to the development of sustainable energy solutions",
                    "Gained hands-on experience in electrical engineering practices and safety standards",
                },
            },
            new MinWebDev.EmploymentTerm {
                Id = new Guid("4aaaad36-37c2-43b6-9d53-af3784f7e3ac"),
                Employer = "Tech Solutioneering, Inc.",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = null,
                JobTitle = "Full-Stack Web Developer",
                Skills = new[] {
                    "Javascript / Typescript",
                    "HTML",
                    "C♯ / .NET",
                    "SQL Server",
                    "React",
                },
                BulletPoints = new[] {
                    "Worked directly with clients to provide custom solution development",
                    "Developed and maintained scalable web applications, using React on the front-end and ASP.NET MVC on the back-end",
                    "Managed SQL Server databases and employed Sequelize for efficient data handling",
                    "Collaborated with cross-functional teams and participated in Agile development methodologies using Jira",
                },
            },
        };
    }

    protected int Sql(string sql, params object[] queryParameters)
    {
        var rowsAffectedCount = this.dbContext.Database
            .ExecuteSqlRaw(sql, queryParameters);

        return rowsAffectedCount;
    }

    protected TEntity[] SqlQuery<TEntity>(string sql, params object[] queryParameters)
        where TEntity : class
    {
        return this.dbContext.Set<TEntity>()
            .FromSqlRaw(sql, queryParameters)
            .AsNoTracking()
            .ToArray();
    }
}
