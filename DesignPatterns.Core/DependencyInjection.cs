using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Core;

public static class DependencyInjection
{
    public static void AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<ExecutorsFactory>();
    }
}
