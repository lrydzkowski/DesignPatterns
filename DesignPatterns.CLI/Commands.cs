using CommandDotNet;
using DesignPatterns.Core;

namespace DesignPatterns.CLI;

internal class Commands
{
    public Commands(ExecutorsFactory executorsFactory)
    {
        ExecutorsFactory = executorsFactory;
    }

    public ExecutorsFactory ExecutorsFactory { get; }

    [Command("run")]
    public void Run(string patternName) => ExecutorsFactory.CreateExecutor(patternName).Execute();
}
