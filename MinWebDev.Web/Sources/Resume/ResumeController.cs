using Microsoft.AspNetCore.Mvc;

using MinWebDev.Data;

namespace MinWebDev.Web;

public class ResumeController : Controller
{
    private readonly ICandidateDao candidateDao;
    private readonly ISchoolAttendanceDao schoolAttendanceDao;
    private readonly ISkillExperienceDao skillExperienceDao;
    private readonly IEmploymentTermDao employmentTermDao;

    public ResumeController(
        ICandidateDao candidateDao,
        ISchoolAttendanceDao schoolAttendanceDao,
        ISkillExperienceDao skillExperienceDao,
        IEmploymentTermDao employmentTermDao
    ) {
        this.candidateDao = candidateDao;
        this.schoolAttendanceDao = schoolAttendanceDao;
        this.skillExperienceDao = skillExperienceDao;
        this.employmentTermDao = employmentTermDao;
    }

    [Route("")]
    [HttpGet]
    public IActionResult Index()
    {
        var model = this.BuildViewModel();

        return this.View("~/Sources/Resume/Resume.cshtml", model);
    }

    private ResumeViewModel BuildViewModel()
    {
        var candidate = this.candidateDao.GetCandidate();

        var schoolAttendances = this.schoolAttendanceDao.GetSchoolAttendances()
            .OrderByDescending(sa => sa.GraduationYear)
            .ToArray();

        var skillExperiences = this.skillExperienceDao.GetSkillExperiences()
            .OrderByDescending(se => se.Years)
            .ToArray();

        var skillExperiencesPart1 = skillExperiences
            .Take((int) Math.Ceiling(skillExperiences.Length / 2.0))
            .ToArray();

        var skillExperiencesPart2 = skillExperiences
            .Skip(skillExperiencesPart1.Length)
            .ToArray();

        var employmentTerms = this.employmentTermDao.GetEmploymentTerms()
            .OrderByDescending(et => et.StartDate)
            .ToArray();

        return new ResumeViewModel {
            CandidateName = candidate.Name,
            CandidateTagline = candidate.Tagline,
            SchoolAttendances = schoolAttendances,
            SkillExperiencesPart1 = skillExperiencesPart1,
            SkillExperiencesPart2 = skillExperiencesPart2,
            EmploymentTerms = employmentTerms,
        };
    }
}
