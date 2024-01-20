using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MinWebDev.Data;

public class MinWebDevDbContextFactory : IDesignTimeDbContextFactory<MinWebDevDbContext>
{
    public MinWebDevDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("database.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");

        var options = new DbContextOptionsBuilder()
            .UseSqlServer(connectionString)
            .Options;

        return new MinWebDevDbContext(options);
    }
}
