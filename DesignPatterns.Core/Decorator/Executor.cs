namespace DesignPatterns.Core.Decorator;

internal class Executor : IExecutor
{
    public Executor(IMessage message)
    {
        Message = message;
    }

    public IMessage Message { get; }

    public void Execute()
    {
        IOperation operation = new Operation(Message);
        operation.Execute();

        IOperation validatedOperation = new ValidatedOperation(Message, operation);
        validatedOperation.Execute();
    }
}
