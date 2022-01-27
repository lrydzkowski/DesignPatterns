using DesignPatterns.Core.AbstractFactory.Factories;

namespace DesignPatterns.Core.AbstractFactory;

internal class Window
{
    public Window(IComponentsFactory componentsFactory)
    {
        Button = componentsFactory.CreateButton();
    }

    public Button Button { get; set; }
}
