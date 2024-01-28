CREATE TABLE dbo.EmploymentTermBulletPoint
(
    Id UNIQUEIDENTIFIER NOT NULL,
    IdentityId BIGINT NOT NULL IDENTITY(1000, 1),
    EmploymentTermId UNIQUEIDENTIFIER NOT NULL,

    BulletPoint NVARCHAR(128) NOT NULL,

    CONSTRAINT PK_EmploymentTermBulletPoint PRIMARY KEY NONCLUSTERED (Id ASC),
    CONSTRAINT UX_EmploymentTermBulletPoint_IdentityId UNIQUE CLUSTERED (IdentityId ASC),
    CONSTRAINT FK_EmploymentTermBulletPoint_EmploymentTermId FOREIGN KEY (EmploymentTermId) REFERENCES Candidate (Id)
);
