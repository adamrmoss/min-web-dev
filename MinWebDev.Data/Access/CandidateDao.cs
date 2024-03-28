namespace MinWebDev.Data;

public class CandidateDao : BaseDao, ICandidateDao
{
    public CandidateDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.Candidate GetCandidate()
    {
        // For now, we're assuming there will be a single candidate
        var candidate = this.dbContext.Candidates.FirstOrDefault();

        if (candidate == null)
        {
            throw new InvalidOperationException("No candidate found.");
        }

        return new MinWebDev.Candidate {
            Id = candidate.Id,
            Name = candidate.Name,
            Tagline = candidate.Tagline,
        };
    }
}
