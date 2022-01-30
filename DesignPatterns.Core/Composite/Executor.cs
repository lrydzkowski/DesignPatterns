namespace DesignPatterns.Core.Composite;

internal class Executor : IExecutor
{
    public Executor(IMessage message)
    {
        Message = message;
    }

    public IMessage Message { get; }

    public void Execute()
    {
        Node secondLvl1 = new("secondLvl1", Message);
        Node secondLvl2 = new("secondLvl2", Message);
        Node firstLvl1 = new("firstLvl1", Message);
        firstLvl1.Children.Add(secondLvl1);
        firstLvl1.Children.Add(secondLvl2);

        Node secondLvl3 = new("secondLvl3", Message);
        Node firstLvl2 = new("firstLvl2", Message);
        firstLvl2.Children.Add(secondLvl3);

        Node rootNode = new("rootNode", Message);
        rootNode.Children.Add(firstLvl1);
        rootNode.Children.Add(firstLvl2);

        rootNode.DisplayName();
    }
}
