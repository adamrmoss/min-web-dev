namespace MinWebDev.Data;

public class MinWebDevDao : IMinWebDevDao
{
    public Candidate GetCandidate()
    {
        return new Candidate {
            Name = "Amir Lewis",
            Tagline = "Enthusiastic <b>Full-Stack Web Developer</b> with a passion for crafting elegant and efficient web solutions",
        };
    }

    public SchoolAttendance[] GetSchoolAttendances()
    {
        return new[] {
            new SchoolAttendance {
                School = "North Atlanta High School",
                Degree = "High School Diploma",
                GraduationYear = 2016
            },
            new SchoolAttendance {
                School = "Howard University",
                Degree = "B.S. Computer Engineering",
                GraduationYear = 2020
            },
        };
    }

    public SkillExperience[] GetSkillExperiences()
    {
        return new[] {
            new SkillExperience {
                Skill = "C++",
                Years = 4,
            },
            new SkillExperience {
                Skill = "C♯ / .NET",
                Years = 2,
            },
            new SkillExperience {
                Skill = "SQL Server",
                Years = 2,
            },
            new SkillExperience {
                Skill = "Javascript / Typescript",
                Years = 2,
            },
            new SkillExperience {
                Skill = "HTML",
                Years = 2,
            },
            new SkillExperience {
                Skill = "React",
                Years = 1,
            },
        };
    }

    public EmploymentTerm[] GetEmploymentTerms()
    {
        return new[] {
            new EmploymentTerm {
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
            new EmploymentTerm {
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
            new EmploymentTerm {
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
            new EmploymentTerm {
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
            new EmploymentTerm {
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
}
