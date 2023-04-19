using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DDDTemplateSolution.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DDDTemplateSolutionDbContextFactory : IDesignTimeDbContextFactory<DDDTemplateSolutionDbContext>
{
    public DDDTemplateSolutionDbContext CreateDbContext(string[] args)
    {
        DDDTemplateSolutionEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DDDTemplateSolutionDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new DDDTemplateSolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DDDTemplateSolution.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
