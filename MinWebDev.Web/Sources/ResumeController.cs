using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using MinWebDev.Data;

namespace MinWebDev.Web;

public class ResumeController : Controller
{
    private readonly IMinWebDevDao dao;

    public ResumeController(IMinWebDevDao dao)
    {
        this.dao = dao;
    }

    [Route("")]
    [HttpGet]
    public IActionResult Index()
    {
        var model = this.BuildViewModel();

        return this.View("~/Sources/Resume.cshtml", model);
    }

    private ResumeViewModel BuildViewModel()
    {
        var candidate = this.dao.GetCandidate();

        var schoolAttendances = this.dao.GetSchoolAttendances()
            .OrderByDescending(sa => sa.GraduationYear)
            .ToArray();

        var skillExperiences = this.dao.GetSkillExperiences()
            .OrderByDescending(se => se.Years)
            .ToArray();

        var skillExperiencesPart1 = skillExperiences
            .Take((int) Math.Ceiling(skillExperiences.Length / 2.0))
            .ToArray();

        var skillExperiencesPart2 = skillExperiences
            .Skip(skillExperiencesPart1.Length)
            .ToArray();

        var employmentTerms = this.dao.GetEmploymentTerms()
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
