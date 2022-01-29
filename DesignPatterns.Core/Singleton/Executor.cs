namespace DesignPatterns.Core.Singleton;

internal class Executor : IExecutor
{
    public Executor(IMessage message)
    {
        Message = message;
    }

    public IMessage Message { get; }

    public void Execute()
    {
        Cache.Message = Message;
        List<Task> tasks = new();
        for (int i = 0; i < 25; i++)
        {
            tasks.Add(Task.Run(() =>
            {
                Cache cache = Cache.Instance;
            }));
        }
        Task.WaitAll(tasks.ToArray());
    }
}
