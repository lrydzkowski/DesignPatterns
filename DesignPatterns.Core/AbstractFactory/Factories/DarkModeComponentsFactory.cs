namespace DesignPatterns.Core.AbstractFactory.Factories;

internal class DarkModeComponentsFactory : IComponentsFactory
{
    public Button CreateButton()
    {
        return new Button() { Background = "#000000" };
    }
}
