CREATE TABLE dbo.[Candidate]
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),

    [Name] NVARCHAR(128) NOT NULL,
    Tagline NVARCHAR(256) NOT NULL,

    CONSTRAINT PK_Candidate PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_Candidate_IdentityId UNIQUE CLUSTERED (IdentityId ASC)
);

GO

CREATE TABLE dbo.SchoolAttendance
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    CandidateId UNIQUEIDENTIFIER NOT NULL,

    School NVARCHAR(128) NOT NULL,
    Degree NVARCHAR(128) NOT NULL,
    GraduationYear INT NOT NULL,

    CONSTRAINT PK_SchoolAttendance PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_SchoolAttendance_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_SchoolAttendance_CandidateId FOREIGN KEY (CandidateId) REFERENCES Candidate (Id)
);

GO

CREATE TABLE dbo.SkillExperience
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    CandidateId UNIQUEIDENTIFIER NOT NULL,

    Skill NVARCHAR(128) NOT NULL,
    Years INT NOT NULL,

    CONSTRAINT PK_SkillExperience PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_SkillExperience_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_SkillExperience_CandidateId FOREIGN KEY (CandidateId) REFERENCES Candidate (Id)
);

GO

CREATE TABLE dbo.EmploymentTerm
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    CandidateId UNIQUEIDENTIFIER NOT NULL,

    Employer NVARCHAR(128) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    JobTitle NVARCHAR(128) NOT NULL,

    CONSTRAINT PK_EmploymentTerm PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTerm_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTerm_CandidateId FOREIGN KEY (CandidateId) REFERENCES Candidate (Id)
);

GO

CREATE TABLE dbo.EmploymentTermSkill
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    EmploymentTermId UNIQUEIDENTIFIER NOT NULL,

    Skill NVARCHAR(128) NOT NULL,

    CONSTRAINT PK_EmploymentTermSkill PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTermSkill_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTermSkill_EmploymentTermId FOREIGN KEY (EmploymentTermId) REFERENCES EmploymentTerm (Id)
);

GO

CREATE TABLE dbo.EmploymentTermBulletPoint
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    EmploymentTermId UNIQUEIDENTIFIER NOT NULL,

    BulletPoint NVARCHAR(512) NOT NULL,

    CONSTRAINT PK_EmploymentTermBulletPoint PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTermBulletPoint_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTermBulletPoint_EmploymentTermId FOREIGN KEY (EmploymentTermId) REFERENCES EmploymentTerm (Id)
);
