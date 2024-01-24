namespace MinWebDev;

public interface IMinWebDevDao
{
    Candidate GetCandidate();
    SchoolAttendance[] GetSchoolAttendances();
    SkillExperience[] GetSkillExperiences();
    EmploymentTerm[] GetEmploymentTerms();
}
