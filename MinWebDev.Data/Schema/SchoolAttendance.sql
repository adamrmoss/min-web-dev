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
