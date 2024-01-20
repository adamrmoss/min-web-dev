using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

public class MinWebDevDbContext : DbContext
{
    public MinWebDevDbContext(DbContextOptions options)
        : base(options)
    {
    }
}
