namespace MinWebDev.Data;

public class SchoolAttendance
{
    public required Guid Id { get; set; }
    public required string School { get; set; }
    public required string Degree { get; set; }
    public required int GraduationYear { get; set; }
}
