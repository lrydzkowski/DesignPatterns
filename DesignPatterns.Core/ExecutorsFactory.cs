using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DesignPatterns.Core;

public class ExecutorsFactory
{
    public ExecutorsFactory(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }

    public IServiceProvider ServiceProvider { get; }

    public IExecutor CreateExecutor(string patternName)
    {
        string namespaceToFind = $"{typeof(ExecutorsFactory).Namespace}.{patternName}";
        List<IExecutor> executors = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.GetInterfaces().Contains(typeof(IExecutor)))
            .Where(type => type.Namespace != null && type.Namespace.Contains(namespaceToFind))
            .Select(type => (IExecutor?)ActivatorUtilities.CreateInstance(ServiceProvider, type))
            .Where(executor => executor != null)
            .OfType<IExecutor>()
            .ToList();
        if (executors.Count == 0)
        {
            throw new InvalidOperationException(
                $"Executor for pattern with name = {patternName} doesn't exist."
            );
        }
        if (executors.Count > 1)
        {
            throw new InvalidOperationException(
                $"There are more than one executor for pattern with name = {patternName}."
            );
        }
        IExecutor executor = executors[0];
        return executor;
    }
}
