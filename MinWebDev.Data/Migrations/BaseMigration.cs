using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinWebDev.Data.Migrations;

public abstract class BaseMigration : Migration
{
    protected sealed override void Up(MigrationBuilder migrationBuilder)
    {
        var type = this.GetType();
        var regex = new Regex($@"\d{{14}}_{Regex.Escape(type.Name)}_Up\.sql");

        var assembly = Assembly.GetExecutingAssembly();
        var sqlResult = GetResourceContents(assembly, regex);
        _ = migrationBuilder.Sql(sqlResult);
    }

    protected sealed override void Down(MigrationBuilder migrationBuilder)
    {
        var type = this.GetType();
        var regex = new Regex($@"\d{{14}}_{Regex.Escape(type.Name)}_Down\.sql");

        var assembly = Assembly.GetExecutingAssembly();
        var sqlResult = GetResourceContents(assembly, regex);
        _ = migrationBuilder.Sql(sqlResult);
    }

    private static string GetResourceContents(Assembly assembly, Regex regex)
    {
        var resourceName = (
            assembly.GetManifestResourceNames()
                .FirstOrDefault(regex.IsMatch)
        ) ?? throw new InvalidOperationException($"Unable to load resource matching pattern: {regex}");

        using var stream = assembly.GetManifestResourceStream(resourceName)!;
        using var reader = new StreamReader(stream);
        var resourceContents = reader.ReadToEnd();

        return resourceContents;
    }
}
