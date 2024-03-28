CREATE VIEW dbo.CandidateEmploymentTermSkill WITH SCHEMABINDING
AS
SELECT et.CandidateId, ets.EmploymentTermId, ets.Id AS EmploymentTermSkillId, ets.Skill
FROM dbo.[Candidate] AS c JOIN
         dbo.EmploymentTerm AS et ON c.Id = et.CandidateId JOIN
         dbo.EmploymentTermSkill AS ets ON et.Id = ets.EmploymentTermId;

GO

CREATE UNIQUE CLUSTERED INDEX UX_CandidateEmploymentTermSkill
    ON dbo.CandidateEmploymentTermSkill (CandidateId, EmploymentTermId, EmploymentTermSkillId);

GO

CREATE VIEW dbo.CandidateEmploymentTermBulletPoint WITH SCHEMABINDING
AS
SELECT et.CandidateId, ets.EmploymentTermId, ets.Id AS EmploymentTermBulletPointId, ets.BulletPoint
FROM dbo.[Candidate] AS c JOIN
         dbo.EmploymentTerm AS et ON c.Id = et.CandidateId JOIN
         dbo.EmploymentTermBulletPoint AS ets ON et.Id = ets.EmploymentTermId;

GO

CREATE UNIQUE CLUSTERED INDEX UX_CandidateEmploymentTermBulletPoint
    ON dbo.CandidateEmploymentTermBulletPoint (CandidateId, EmploymentTermId, EmploymentTermBulletPointId);
