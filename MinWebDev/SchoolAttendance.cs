namespace MinWebDev;

public class SchoolAttendance
{
    private Guid Id { get; set; }
    public required string School { get; set; }
    public required string Degree { get; set; }
    public required int GraduationYear { get; set; }
}
