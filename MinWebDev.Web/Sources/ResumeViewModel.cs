namespace MinWebDev.Web;

public class ResumeViewModel
{
    public required string CandidateName { get; set; }
    public required string CandidateTagline { get; set; }

    public required SchoolAttendance[] SchoolAttendances { get; set; }
    public required SkillExperience[] SkillExperiences { get; set; }
    public required EmploymentTerm[] EmploymentTerms { get; set; }
}
