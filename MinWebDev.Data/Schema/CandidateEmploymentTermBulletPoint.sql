CREATE VIEW dbo.CandidateEmploymentTermBulletPoint WITH SCHEMABINDING
AS
SELECT et.CandidateId, ets.EmploymentTermId, ets.Id AS EmploymentTermBulletPointId, ets.BulletPoint
FROM dbo.[Candidate] AS c JOIN
         dbo.EmploymentTerm AS et ON c.Id = et.CandidateId JOIN
         dbo.EmploymentTermBulletPoint AS ets ON et.Id = ets.EmploymentTermId;

GO

CREATE UNIQUE CLUSTERED INDEX UX_CandidateEmploymentTermBulletPoint
    ON dbo.CandidateEmploymentTermBulletPoint (CandidateId, EmploymentTermId, EmploymentBulletPointId);

