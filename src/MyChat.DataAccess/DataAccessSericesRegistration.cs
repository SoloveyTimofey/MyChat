using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyChat.DataAccess.Context;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace MyChat.DataAccess;

public static class DataAccessSericesRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MyChatDbContext>(dbContextOptionsBuilder =>
        {
            DatabaseOptions options = GetDatabaseOptions(configuration);

            dbContextOptionsBuilder.UseSqlServer(options.ConnectionString, sqlServerAction =>
            {
                sqlServerAction.EnableRetryOnFailure(options.MaxRetryCount);
                sqlServerAction.CommandTimeout(options.CommandTimeout);
            });

            dbContextOptionsBuilder.EnableSensitiveDataLogging(options.EnableSensitiveDataLogging);
            dbContextOptionsBuilder.EnableDetailedErrors(options.EnableDetailedError);
        });

        return services;
    }

    private static DatabaseOptions GetDatabaseOptions(IConfiguration configuration)
    {
        var dbOptionsSection = configuration.GetRequiredSection("DatabaseOptions");

        string connectionString = configuration.GetConnectionString("MyChatConnection")!;
        int maxRetryCount = int.Parse(dbOptionsSection.GetRequiredSection("MaxRetryCount").Value!);
        int commandTimeout = int.Parse(dbOptionsSection.GetRequiredSection("CommandTimeout").Value!);
        bool enableDetailedError = bool.Parse(dbOptionsSection.GetRequiredSection("EnableDetailedError").Value!);
        var enableSensitieDataLogging = bool.Parse(dbOptionsSection.GetRequiredSection("EnableSensitieDataLogging").Value!);

        return new DatabaseOptions(connectionString, maxRetryCount, commandTimeout, enableDetailedError, enableSensitieDataLogging);
    }

    private record DatabaseOptions(string ConnectionString, int MaxRetryCount, int CommandTimeout, bool EnableDetailedError, bool EnableSensitiveDataLogging);
}