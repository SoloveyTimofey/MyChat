using Microsoft.Extensions.DependencyInjection;

namespace MyChat.DataAccess;

public static class DataAccessSericesRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        return services;
    }
}