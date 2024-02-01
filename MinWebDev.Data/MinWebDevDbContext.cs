using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

public class MinWebDevDbContext : DbContext
{
    public MinWebDevDbContext(DbContextOptions options)
        : base(options)
    {
    }

    internal DbSet<Candidate> Candidates { get; set; }
    internal DbSet<SchoolAttendance> SchoolAttendances { get; set; }
    internal DbSet<SkillExperience> SkillExperiences { get; set; }
    internal DbSet<EmploymentTerm> EmploymentTerms { get; set; }
    internal DbSet<EmploymentTermSkill> EmploymentTermSkills { get; set; }
    internal DbSet<EmploymentTermBulletPoint> EmploymentTermBulletPoints { get; set; }
}
