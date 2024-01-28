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
