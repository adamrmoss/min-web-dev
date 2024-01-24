namespace MinWebDev.Data;

public class SchoolAttendanceDao : BaseDao, ISchoolAttendanceDao
{
    public SchoolAttendanceDao(MinWebDevDbContext dbContext)
        : base(dbContext)
    {
    }
    
    public MinWebDev.SchoolAttendance[] GetSchoolAttendances()
    {
        return new[] {
            new MinWebDev.SchoolAttendance {
                Id = new Guid("391ca3c0-c07f-4572-a6db-e13dfe9ae163"),
                School = "North Atlanta High School",
                Degree = "High School Diploma",
                GraduationYear = 2016
            },
            new MinWebDev.SchoolAttendance {
                Id = new Guid("6382c3bb-f502-42f5-9fa0-ec0572724750"),
                School = "Howard University",
                Degree = "B.S. Computer Engineering",
                GraduationYear = 2020
            },
        };
    }
}
