using DesignPatterns.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.CLI;

internal static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<Commands>();
        services.AddScoped<IMessage, ConsoleMessage>();
        services.AddCoreServices();
        return services;
    }
}
