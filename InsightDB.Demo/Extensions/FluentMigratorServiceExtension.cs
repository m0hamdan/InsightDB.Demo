using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;

namespace InsightDB.Demo.Extensions
{
    public static class FluentMigratorServiceExtension
    {
        public static IServiceCollection AddFluentMigrator(this IServiceCollection services, IConfiguration config)
        {
            var connectionStringBuilder = new DbConnectionStringBuilder();
            connectionStringBuilder.ConnectionString = config.GetConnectionString("Migrator");

            var executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();

            services.AddFluentMigratorCore()
                .ConfigureRunner(
                    builder => builder
                        // Add SQL Server support to FluentMigrator
                        .AddSqlServer()
                        // Set the connection string
                        .WithGlobalConnectionString(connectionStringBuilder.ToString())
                        // Define the assembly containing the migrations
                        .ScanIn(executingAssembly).For.Migrations()
                        .ScanIn(executingAssembly).For.EmbeddedResources())
                // Enable logging to console
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .Configure<FluentMigratorLoggerOptions>(options =>
                {
                    options.ShowSql = true;
                    options.ShowElapsedTime = true;
                });
            return services;
        }
    }
}
