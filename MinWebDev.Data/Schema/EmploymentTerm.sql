CREATE TABLE dbo.EmploymentTerm
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    Employer NVARCHAR(128) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    JobTitle NVARCHAR(128) NOT NULL,

    CandidateId UNIQUEIDENTIFIER NOT NULL,

    CONSTRAINT PK_EmploymentTerm PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTerm_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTerm_CandidateId FOREIGN KEY (CandidateId) REFERENCES Candidate (Id)
);
