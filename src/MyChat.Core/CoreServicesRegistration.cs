using Microsoft.Extensions.DependencyInjection;

namespace MyChat.Core;

public static class CoreServicesRegistration
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(CoreServicesRegistration).Assembly);
        });

        return services;
    }
}