using DesignPatterns.Core;

namespace DesignPatterns.CLI;

internal class ConsoleMessage : IMessage
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}
