namespace MinWebDev.Data;

internal class EmploymentTermBulletPoint
{
    public required Guid Id { get; set; }
    public required Guid EmploymentTermId { get; set; }
    public required string BulletPoint { get; set; }
}
