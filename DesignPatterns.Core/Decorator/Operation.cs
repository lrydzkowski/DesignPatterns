namespace DesignPatterns.Core.Decorator;

internal class Operation : IOperation
{
    public Operation(IMessage message)
    {
        Message = message;
    }

    public IMessage Message { get; }

    public bool Execute()
    {
        Message.Write("Execute Operation");
        return true;
    }
}
