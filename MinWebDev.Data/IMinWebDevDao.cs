namespace MinWebDev.Data;

public interface IMinWebDevDao
{
    Candidate GetCandidate();
    SchoolAttendance[] GetSchoolAttendances();
    SkillExperience[] GetSkillExperiences();
    EmploymentTerm[] GetEmploymentTerms();
}
