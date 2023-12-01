using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AppMvcTiered522.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AppMvcTiered522DbContextFactory : IDesignTimeDbContextFactory<AppMvcTiered522DbContext>
{
    public AppMvcTiered522DbContext CreateDbContext(string[] args)
    {
        AppMvcTiered522EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AppMvcTiered522DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AppMvcTiered522DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AppMvcTiered522.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
