CREATE TABLE dbo.EmploymentTermSkill
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    EmploymentTermId UNIQUEIDENTIFIER NOT NULL,

    Skill NVARCHAR(128) NOT NULL,

    CONSTRAINT PK_EmploymentTermSkill PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTermSkill_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTermSkill_EmploymentTermId FOREIGN KEY (EmploymentTermId) REFERENCES Candidate (Id)
);
