namespace DesignPatterns.Core.Decorator;

internal class ValidatedOperation : IOperation
{
    public ValidatedOperation(IMessage message, IOperation operation)
    {
        Message = message;
        Operation = operation;
    }

    public IMessage Message { get; }
    public IOperation Operation { get; }

    public bool Execute()
    {
        Message.Write("Validating...");
        return Operation.Execute();
    }
}
