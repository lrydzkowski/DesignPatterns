using DesignPatterns.Core.AbstractFactory.Factories;

namespace DesignPatterns.Core.AbstractFactory;

internal class Executor : IExecutor
{
    public Executor(IMessage message)
    {
        Message = message;
    }

    public IMessage Message { get; }

    public void Execute()
    {
        LightModeComponentsFactory lightModeComponentsFactory = new();
        Window lightWindow = new(lightModeComponentsFactory);
        Message.Write(lightWindow.Button.Background);

        DarkModeComponentsFactory darkModeComponentsFactory = new();
        Window darkWindow = new(darkModeComponentsFactory);
        Message.Write(darkWindow.Button.Background);
    }
}
