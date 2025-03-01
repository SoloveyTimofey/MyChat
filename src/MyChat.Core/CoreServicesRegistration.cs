using Microsoft.Extensions.DependencyInjection;

namespace MyChat.Core;

public static class CoreServicesRegistration
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        return services;
    }
}