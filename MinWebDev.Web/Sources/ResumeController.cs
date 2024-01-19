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
        var schoolAttendances = this.dao.GetSchoolAttendances();
        var skillExperiences = this.dao.GetSkillExperiences();
        var employmentTerms = this.dao.GetEmploymentTerms();

        return new ResumeViewModel {
            CandidateName = candidate.Name,
            CandidateTagline = candidate.Tagline,
            SchoolAttendances = schoolAttendances,
            SkillExperiences = skillExperiences,
            EmploymentTerms = employmentTerms,
        };
    }
}
