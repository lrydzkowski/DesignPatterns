namespace DesignPatterns.Core.AbstractFactory.Factories;

internal class LightModeComponentsFactory : IComponentsFactory
{
    public Button CreateButton()
    {
        return new Button() { Background = "#FFFFFF" };
    }
}
