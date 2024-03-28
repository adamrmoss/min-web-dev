using System.ComponentModel.DataAnnotations.Schema;

namespace MinWebDev.Data;

[Table("Candidate")]
internal class Candidate
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Tagline { get; set; }
}
