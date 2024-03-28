-- Candidate Amir Lewis
INSERT INTO dbo.[Candidate] (Id, [Name], Tagline)
VALUES ('4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Amir Lewis', 'Enthusiastic <b>Full-Stack Web Developer</b> with a passion for crafting elegant and efficient web solutions');

GO

-- School Attendances for Amir Lewis
INSERT INTO dbo.SchoolAttendance (Id, CandidateId, School, Degree, GraduationYear) 
VALUES ('391ca3c0-c07f-4572-a6db-e13dfe9ae163', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'North Atlanta High School', 'High School Diploma', 2016);

INSERT INTO dbo.SchoolAttendance (Id, CandidateId, School, Degree, GraduationYear)
VALUES ('6382c3bb-f502-42f5-9fa0-ec0572724750', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Howard University', 'B.S. Computer Engineering', 2020);

GO

-- Skill Experiences for Amir Lewis
INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('e71babe1-262f-42b8-8daf-035e261ba03a', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'C++', 4);

INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('2b041e3d-4762-449e-bfdf-55177e78f171', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'C♯ / .NET', 2);

INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('dbc1d795-8193-4c78-847c-50b85ba6e308', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'SQL Server', 2);

INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('fdf5bd66-cae1-4061-9628-4cfac3bf0563', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Javascript / Typescript', 2);

INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('8e97c4c3-91a3-47bb-847b-eb886cb82018', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'HTML', 2);

INSERT INTO dbo.SkillExperience (Id, CandidateId, Skill, Years)
VALUES ('08a5a336-09e6-4e67-b764-874f5fb47880', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'React', 1);

GO

-- Employment Term for Amir Lewis + Six Flags
INSERT INTO dbo.EmploymentTerm (Id, CandidateId, Employer, StartDate, EndDate, JobTitle)
VALUES ('168680ca-6ec3-47ab-989c-b9ec00fe357f', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Six Flags', '2014-05-01', '2017-08-01', 'Ride Operator');

-- Employment Term for Amir Lewis + Howard University
INSERT INTO dbo.EmploymentTerm (Id, CandidateId, Employer, StartDate, EndDate, JobTitle)
VALUES ('b6550495-918e-4dac-b8e6-0243a0f21f21', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Howard University"', '2017-09-01', '2019-12-01', 'Electrical Engineering Lab Assistant');

-- Employment Term for Amir Lewis + Atlanta PowerTech
INSERT INTO dbo.EmploymentTerm (Id, CandidateId, Employer, StartDate, EndDate, JobTitle)
VALUES ('53aa6c77-82cf-4def-91f2-e74609329152', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Atlanta PowerTech', '2020-01-01', '2020-05-01', 'Electrical Engineer Intern');

-- Employment Term for Amir Lewis + WebDev Co.
INSERT INTO dbo.EmploymentTerm (Id, CandidateId, Employer, StartDate, EndDate, JobTitle)
VALUES ('64425184-85e7-46ae-8352-4097fd9f1ea9', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'WebDev Co.', '2020-06-01', '2020-12-01', '');

-- Employment Term for Amir Lewis + Tech Solutioneering, Inc.
INSERT INTO dbo.EmploymentTerm (Id, CandidateId, Employer, StartDate, EndDate, JobTitle)
VALUES ('4aaaad36-37c2-43b6-9d53-af3784f7e3ac', '4e1b3dde-5dcc-4816-9a51-f413b8506d33', 'Tech Solutioneering, Inc.', '2021-01-01', NULL, 'Full-Stack Web Developer');

GO

-- Employment Skills for Amir Lewis + Howard University
INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('977ccdb7-1caa-4697-893e-097c9e8fb69a', 'b6550495-918e-4dac-b8e6-0243a0f21f21', 'C++');

-- Employment Skills for Amir Lewis + Atlanta PowerTech
INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('b3abbb68-3d55-415d-a11b-6878b6fafcb7', '53aa6c77-82cf-4def-91f2-e74609329152', 'C++');

-- Employment Skills for Amir Lewis + WebDev Co.
INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('ffd0c261-24e1-41f8-9fe1-801c79307ec3', '64425184-85e7-46ae-8352-4097fd9f1ea9', 'Javascript / Typescript');

INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('e1018eaa-6227-44a2-9085-810434d596be', '64425184-85e7-46ae-8352-4097fd9f1ea9', 'HTML');

-- Employment Skills for Amir Lewis + Tech Solutioneering, Inc.
INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('dd3dcc53-04b3-4471-9e3f-ef7ecc5803ec', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'Javascript / Typescript');

INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('2705ec3c-5501-4e23-8152-12980415305f', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'HTML');

INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('a7d60679-f0c0-4492-abf5-d7d916cafa93', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'C♯ / .NET');

INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('27eb196a-66da-42fa-a5b9-87ad4d49b1b2', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'SQL Server');

INSERT INTO dbo.EmploymentTermSkill (Id, EmploymentTermId, Skill)
VALUES ('062c369a-8102-4c54-8c72-2861f538363b', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'React');

GO

-- Employment Bullet Points for Amir Lewis + Six Flags
INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('8b6551ed-e505-4415-99e5-0afef76f6615', '168680ca-6ec3-47ab-989c-b9ec00fe357f', 'Operated amusement park rides, ensuring visitor safety and enjoyment');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('7fa8d9b5-a66c-4e04-be69-73586f65aad3', '168680ca-6ec3-47ab-989c-b9ec00fe357f', 'Developed strong communication and teamwork skills during high-demand periods');

-- Employment Bullet Points for Amir Lewis + Howard University
INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('8a98ae26-c60c-499f-affa-bf8b36d21448', 'b6550495-918e-4dac-b8e6-0243a0f21f21', 'Assisted students in the electrical engineering lab, providing guidance on experiments and equipment usage');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('757ae274-de26-4a63-9de0-d63e24c6dee0', 'b6550495-918e-4dac-b8e6-0243a0f21f21', 'Helped maintain lab equipment and ensured a safe and organized environment for students');

-- Employment Bullet Points for Amir Lewis + Atlanta PowerTech
INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('cbd100bc-afdf-4bfa-b600-e7d077166e36', '53aa6c77-82cf-4def-91f2-e74609329152', 'Assisted senior engineers in electrical design and testing of power distribution systems');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('ac4e1b18-d963-41a5-af9c-a4733b94632d', '53aa6c77-82cf-4def-91f2-e74609329152', 'Conducted research on energy efficiency and contributed to the development of sustainable energy solutions');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('4c5d9e38-c798-45bd-a607-efd7e3847f5f', '53aa6c77-82cf-4def-91f2-e74609329152', 'Gained hands-on experience in electrical engineering practices and safety standards');

-- Employment Bullet Points for Amir Lewis + Atlanta WebDev Co.
INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('247c9fab-8677-4db1-9bf9-197a7eb359b1', '64425184-85e7-46ae-8352-4097fd9f1ea9', 'Assisted in front-end and back-end development using React, Node.js, and MongoDB');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('2d187ebf-9564-4058-b87f-c8d864ed2357', '64425184-85e7-46ae-8352-4097fd9f1ea9', 'Engaged in Git-based version control, participated in code reviews, and used Jira for project management');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('484bc037-7103-4778-b95a-0f2217d2a625', '64425184-85e7-46ae-8352-4097fd9f1ea9', 'Contributed to the design and development of web applications, working closely with experienced developers');

-- Employment Bullet Points for Amir Lewis + Tech Solutioneering, Inc.
INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('576220a6-0e96-4833-8f8b-5a7169cf2eb8', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'Worked directly with clients to provide custom solution development');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('f9fe836c-eb2d-4de6-b7e7-de97e6377a52', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'Developed and maintained scalable web applications, using React on the front-end and ASP.NET MVC on the back-end');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('53f11f14-c4de-478f-a4be-f5951ba61860', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'Managed SQL Server databases and employed Sequelize for efficient data handling');

INSERT INTO dbo.EmploymentTermBulletPoint (Id, EmploymentTermId, BulletPoint)
VALUES ('9143d2e3-8a7b-45c9-923a-5c499a17552f', '4aaaad36-37c2-43b6-9d53-af3784f7e3ac', 'Collaborated with cross-functional teams and participated in Agile development methodologies using Jira');
