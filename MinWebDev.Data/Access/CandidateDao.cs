namespace MinWebDev.Data;

public class CandidateDao : BaseDao, ICandidateDao
{
    public CandidateDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.Candidate GetCandidate()
    {
        // var candidate = this.dbContext.Candidates.FirstOrDefault();
        
        return new MinWebDev.Candidate {
            Id = new Guid("4e1b3dde-5dcc-4816-9a51-f413b8506d33"),
            Name = "Amir Lewis",
            Tagline = "Enthusiastic <b>Full-Stack Web Developer</b> with a passion for crafting elegant and efficient web solutions",
        };
    }
}
