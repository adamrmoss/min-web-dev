namespace MinWebDev.Data;

public class EmploymentTermDao : BaseDao, IEmploymentTermDao
{
    public EmploymentTermDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }

    public MinWebDev.EmploymentTerm[] GetEmploymentTerms(Guid candidateId)
    {
        var employmentTerms = this.dbContext.EmploymentTerms
            .Where(et => et.CandidateId == candidateId)
            .ToArray();
        
        var candidateEmploymentTermSkills = this.dbContext.CandidateEmploymentTermSkills
            .Where(cets => cets.CandidateId == candidateId)
            .ToArray();
        
        var candidateEmploymentTermBulletPoints = this.dbContext.CandidateEmploymentTermBulletPoints
            .Where(cetbp => cetbp.CandidateId == candidateId)
            .ToArray();
        
        return employmentTerms
            .Select(et => new MinWebDev.EmploymentTerm
            {
                Id = et.Id,
                Employer = et.Employer,
                StartDate = et.StartDate,
                EndDate = et.EndDate,
                JobTitle = et.JobTitle,
                Skills = candidateEmploymentTermSkills
                    .Where(cets => cets.EmploymentTermId == et.Id)
                    .Select(cets => cets.Skill)
                    .ToArray(),
                BulletPoints = candidateEmploymentTermBulletPoints
                    .Where(cetbp => cetbp.EmploymentTermId == et.Id)
                    .Select(cetbp => cetbp.BulletPoint)
                    .ToArray(),
            })
            .ToArray();
    }
}
