using System;
namespace DesignPatterns.Core.Composite;

internal class Node
{
    public Node(string name, IMessage message)
    {
        Name = name;
        Message = message;
    }

    public string Name { get; }
    public IMessage Message { get; }
    public List<Node> Children { get; private set; } = new();

    public void DisplayName(int indentation = 0)
    {
        Message.Write(new string(' ', indentation) + Name);
        foreach (Node child in Children)
        {
            child.DisplayName(indentation + 4);
        }
    }
}
