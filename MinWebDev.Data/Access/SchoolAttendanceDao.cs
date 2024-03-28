namespace MinWebDev.Data;

public class SchoolAttendanceDao : BaseDao, ISchoolAttendanceDao
{
    public SchoolAttendanceDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.SchoolAttendance[] GetSchoolAttendances(Guid candidateId)
    {
        var schoolAttendances = this.dbContext.SchoolAttendances
            .Where(sa => sa.CandidateId == candidateId)
            .OrderBy(sa => sa.GraduationYear)
            .ToArray();

        return schoolAttendances
            .Select(sa => new MinWebDev.SchoolAttendance
            {
                Id = sa.Id,
                School = sa.School,
                Degree = sa.Degree,
                GraduationYear = sa.GraduationYear
            })
            .OrderByDescending(sa => sa.GraduationYear)
            .ToArray();
    }
}
