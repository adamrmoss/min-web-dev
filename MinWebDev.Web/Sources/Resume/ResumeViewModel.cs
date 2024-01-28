namespace MinWebDev.Web;

public class ResumeViewModel
{
    public required Candidate Candidate { get; set; }
    public required SchoolAttendance[] SchoolAttendances { get; set; }
    public required SkillExperience[] SkillExperiencesPart1 { get; set; }
    public required SkillExperience[] SkillExperiencesPart2 { get; set; }
    public required EmploymentTerm[] EmploymentTerms { get; set; }
}
